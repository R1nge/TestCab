using Cinemachine;
using UnityEngine;

namespace Game.Services
{
    public class CameraService : MonoBehaviour
    {
        [SerializeField] private CinemachineVirtualCamera menuCamera;
        [SerializeField] private CinemachineVirtualCamera playerCamera;
        [SerializeField] private new Camera camera;

        public void Select(Transform transform)
        {
            menuCamera.Priority = 0;
            playerCamera.Priority = 1;
            playerCamera.Follow = transform;
            playerCamera.LookAt = transform;
        }

        public void RaycastScreenToRay(Vector3 position, out RaycastHit hit, float distance, LayerMask layerMask)
        {
            Ray screenPointToRay = camera.ScreenPointToRay(position);
            
            if (!Physics.Raycast(screenPointToRay, out hit, distance, layerMask))
            {
                Debug.LogWarning("The ray hit nothing");
            }
        }
    }
}