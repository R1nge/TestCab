namespace Game.UIs.MainMenu
{
    public class MainMenuUIPresenter
    {
        private readonly GameStateMachine _gameStateMachine;

        public MainMenuUIPresenter(GameStateMachine gameStateMachine) => _gameStateMachine = gameStateMachine;

        public void StartTheGame() => _gameStateMachine.SwitchState(GameStateMachine.GameStates.Start);
    }
}