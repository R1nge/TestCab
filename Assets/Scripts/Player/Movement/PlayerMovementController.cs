using UnityEngine;
using UnityEngine.AI;

namespace Player.Movement
{
    public class PlayerMovementController
    {
        private readonly NavMeshAgent _player;

        public PlayerMovementController(NavMeshAgent player)
        {
            _player = player;
        }

        public void MoveTo(Vector3 position)
        {
            _player.SetDestination(position);
        }
    }
}