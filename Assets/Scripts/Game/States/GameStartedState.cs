using Game.Factories;

namespace Game.States
{
    public class GameStartedState : IGameState

    {
        private readonly UIFactory _uiFactory;

        public GameStartedState(UIFactory uiFactory)
        {
            _uiFactory = uiFactory;
        }

        public void Enter()
        {
            _uiFactory.CreateInGameUI();
        }

        public void Exit() { }
    }
}