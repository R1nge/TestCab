using Game.Factories;

namespace Game.States
{
    public class GameEndedState : IGameState
    {
        private readonly UIFactory _uiFactory;

        public GameEndedState(UIFactory uiFactory)
        {
            _uiFactory = uiFactory;
        }

        public void Enter()
        {
            _uiFactory.CreateGameOverUI();
        }

        public void Exit() { }
    }
}