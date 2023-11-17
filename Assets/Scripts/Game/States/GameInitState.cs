using Game.Factories;

namespace Game.States
{
    public class GameInitState : IGameState
    {
        private readonly UIFactory _uiFactory;
        
        public GameInitState(UIFactory uiFactory)
        {
            _uiFactory = uiFactory;
        }
        
        public void Enter()
        {
            _uiFactory.CreateMainMenuUI();
        }

        public void Exit()
        {
        }
    }
}