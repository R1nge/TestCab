using UnityEngine;
using UnityEngine.AI;
using UnityEngine.EventSystems;

namespace Player.Movement
{
    public class PlayerMovementView : MonoBehaviour
    {
        [SerializeField] private LayerMask ignore;
        [SerializeField] private NavMeshAgent navMeshAgent;
        [SerializeField] private Camera playerCamera;
        private PlayerMovementController _playerMovementController;

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
                    Ray screenPointToRay = playerCamera.ScreenPointToRay(Input.mousePosition);
                
                    if (Physics.Raycast(screenPointToRay, out RaycastHit hit, Mathf.Infinity, layerMask: ~ignore))
                    {
                        _playerMovementController.MoveTo(hit.point);
                    }
                }
            }

            if (Input.touchCount > 0)
            {
                Touch touch = Input.GetTouch(0);

                if (!EventSystem.current.IsPointerOverGameObject(Input.GetTouch(0).fingerId))
                {
                    if (touch.phase == TouchPhase.Began)
                    {
                        Ray ray = new Ray(playerCamera.transform.position, playerCamera.transform.forward);

                        if (Physics.Raycast(ray, out RaycastHit hit, Mathf.Infinity, layerMask: ~ignore))
                        {
                            _playerMovementController.MoveTo(hit.point);
                        }
                    }
                }
            }
        }
    }
}