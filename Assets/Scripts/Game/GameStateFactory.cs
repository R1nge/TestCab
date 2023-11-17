using Game.Factories;
using Game.States;

namespace Game
{
    public class GameStateFactory
    {
        private readonly UIFactory _uiFactory;
        
        private GameStateFactory(UIFactory uiFactory)
        {
            _uiFactory = uiFactory;
        }

        public IGameState CreateGameInitState(GameStateMachine gameStateMachine)
        {
            return new GameInitState();
        }

        public IGameState CreateGameStartedState(GameStateMachine gameStateMachine)
        {
            return new GameStartedState(_uiFactory);
        }

        public IGameState CreateGameEndedState(GameStateMachine gameStateMachine)
        {
            return new GameEndedState(_uiFactory);
        }
    }
}