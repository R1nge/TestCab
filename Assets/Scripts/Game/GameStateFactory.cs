using Game.Factories;
using Game.Services;
using Game.States;

namespace Game
{
    public class GameStateFactory
    {
        private readonly PlayerDataService _playerDataService;
        private readonly UIFactory _uiFactory;
        
        private GameStateFactory(PlayerDataService playerDataService, UIFactory uiFactory)
        {
            _playerDataService = playerDataService;
            _uiFactory = uiFactory;
        }

        public IGameState CreateGameInitState(GameStateMachine gameStateMachine)
        {
            return new GameInitState(_uiFactory);
        }

        public IGameState CreateGameStartedState(GameStateMachine gameStateMachine)
        {
            return new GameStartedState(_playerDataService, _uiFactory);
        }

        public IGameState CreateGameEndedState(GameStateMachine gameStateMachine)
        {
            return new GameEndedState(_uiFactory);
        }
    }
}