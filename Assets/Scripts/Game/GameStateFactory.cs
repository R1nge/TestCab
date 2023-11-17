using Game.Factories;
using Game.Services;
using Game.States;

namespace Game
{
    public class GameStateFactory
    {
        private readonly PlayerDataService _playerDataService;
        private readonly CameraService _cameraService;
        private readonly PlayerSpawner _playerSpawner;
        private readonly UIFactory _uiFactory;
        
        private GameStateFactory(PlayerDataService playerDataService, CameraService cameraService,  PlayerSpawner playerSpawner, UIFactory uiFactory)
        {
            _playerDataService = playerDataService;
            _cameraService = cameraService;
            _playerSpawner = playerSpawner;
            _uiFactory = uiFactory;
        }

        public IGameState CreateGameInitState(GameStateMachine gameStateMachine)
        {
            return new GameInitState(_uiFactory);
        }

        public IGameState CreateGameStartedState(GameStateMachine gameStateMachine)
        {
            return new GameStartedState(_playerDataService, _cameraService, _playerSpawner, _uiFactory);
        }

        public IGameState CreateGameEndedState(GameStateMachine gameStateMachine)
        {
            return new GameEndedState(_uiFactory);
        }
    }
}