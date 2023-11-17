using Game.Factories;
using Game.Services;
using UnityEngine;

namespace Game.States
{
    public class GameStartedState : IGameState
    {
        private readonly PlayerDataService _playerDataService;
        private readonly UIFactory _uiFactory;

        public GameStartedState(PlayerDataService playerDataService,UIFactory uiFactory)
        {
            _playerDataService = playerDataService;
            _uiFactory = uiFactory;
        }

        public void Enter()
        {
            _playerDataService.Load();
            Debug.Log($"PLAYER DATA: {_playerDataService.Model.Health} {_playerDataService.Model.Score}");
            //TODO: spawn the player
            _uiFactory.CreateInGameUI();
        }

        public void Exit() { }
    }
}