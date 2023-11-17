using Game.Factories;
using Game.Services;
using UnityEngine;

namespace Game.States
{
    public class GameStartedState : IGameState
    {
        private readonly PlayerDataService _playerDataService;
        private readonly CameraService _cameraService;
        private readonly PlayerSpawner _playerSpawner;
        private readonly UIFactory _uiFactory;

        public GameStartedState(PlayerDataService playerDataService, CameraService cameraService, PlayerSpawner playerSpawner, UIFactory uiFactory)
        {
            _playerDataService = playerDataService;
            _cameraService = cameraService;
            _playerSpawner = playerSpawner;
            _uiFactory = uiFactory;
        }

        public void Enter()
        {
            _playerDataService.Load();
            Debug.Log(_playerSpawner);
            GameObject player = _playerSpawner.Spawn();
            _cameraService.Select(player.transform);
            _uiFactory.CreateInGameUI();
        }

        public void Exit() { }
    }
}