namespace Game.UIs
{
    public class MainMenuUIPresenter
    {
        private readonly GameStateMachine _gameStateMachine;

        public MainMenuUIPresenter(GameStateMachine gameStateMachine) => _gameStateMachine = gameStateMachine;

        public void StartTheGame() => _gameStateMachine.SwitchState(GameStateMachine.GameStates.Start);
    }
}