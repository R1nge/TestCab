using Game.States;

namespace Game
{
    public class GameStateFactory
    {
        private GameStateFactory() { }

        public IGameState CreateGameInitState(GameStateMachine gameStateMachine)
        {
            return new GameInitState();
        }

        public IGameState CreateGameStartedState(GameStateMachine gameStateMachine)
        {
            return new GameStartedState();
        }

        public IGameState CreateGameEndedState(GameStateMachine gameStateMachine)
        {
            return new GameEndedState();
        }
    }
}