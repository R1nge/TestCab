using Game.Factories;
using Game.Services;

namespace Game.States
{
    public class GameEndedState : IGameState
    {
        private readonly PlayerDataService _playerDataService;
        private readonly UIFactory _uiFactory;

        public GameEndedState(PlayerDataService playerDataService, UIFactory uiFactory)
        {
            _playerDataService = playerDataService;
            _uiFactory = uiFactory;
        }

        public void Enter()
        {
            _uiFactory.CreateGameOverUI();
            _playerDataService.Save();
        }

        public void Exit() { }
    }
}