using Game.Services;
using Player.Movement;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.EventSystems;
using Zenject;

public class PlayerMovementView : MonoBehaviour
{
    [SerializeField] private LayerMask ignore;
    [SerializeField] private NavMeshAgent navMeshAgent;
    private PlayerMovementController _playerMovementController;
    private CameraService _cameraService;

    [Inject]
    private void Inject(CameraService cameraService)
    {
        _cameraService = cameraService;
    }

    private void Awake()
    {
        _playerMovementController = new PlayerMovementController(navMeshAgent);
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (!EventSystem.current.IsPointerOverGameObject())
            {
                _cameraService.RaycastScreenToRay(Input.mousePosition, out RaycastHit hit, Mathf.Infinity, layerMask: ~ignore);
                
                _playerMovementController.MoveTo(hit.point);
            }
        }

        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            if (!EventSystem.current.IsPointerOverGameObject(Input.GetTouch(0).fingerId))
            {
                if (touch.phase == TouchPhase.Began)
                {
                    _cameraService.RaycastScreenToRay(Input.GetTouch(0).position, out RaycastHit hit, Mathf.Infinity, layerMask: ~ignore);
                    
                    _playerMovementController.MoveTo(hit.point);
                }
            }
        }
    }
}