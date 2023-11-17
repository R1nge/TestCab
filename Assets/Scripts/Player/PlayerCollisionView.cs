using System;
using Game.Items;
using UnityEngine;

namespace Player
{
    public class PlayerCollisionView : MonoBehaviour
    {
        private void OnTriggerEnter(Collider other)
        {
            if (other.TryGetComponent(out ICollectable collectable))
            {
                collectable.Collect();
            }
        }
    }
}