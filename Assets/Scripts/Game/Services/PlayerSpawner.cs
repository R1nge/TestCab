using System;
using Game.Factories;
using UnityEngine;
using Zenject;

namespace Game.Services
{
    public class PlayerSpawner : MonoBehaviour
    {
        [SerializeField] private Transform spawnPoint;
        private PlayerFactory _playerFactory;

        [Inject]
        private void Inject(PlayerFactory playerFactory) => _playerFactory = playerFactory;

        public GameObject Spawn() => _playerFactory.CreatePlayer(spawnPoint.position, Quaternion.identity, null);
    }
}