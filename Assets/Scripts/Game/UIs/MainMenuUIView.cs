using UnityEngine;
using UnityEngine.UI;
using Zenject;

namespace Game.UIs
{
    public class MainMenuUIView : MonoBehaviour
    {
        [SerializeField] private Button startButton;
        private MainMenuUIPresenter _mainMenuUIPresenter;
        private GameStateMachine _gameStateMachine;

        [Inject]
        private void Inject(GameStateMachine gameStateMachine) => _gameStateMachine = gameStateMachine;

        private void Awake()
        {
            _mainMenuUIPresenter = new MainMenuUIPresenter(_gameStateMachine);
            startButton.onClick.AddListener(StartTheGame);
        }

        private void StartTheGame() => _mainMenuUIPresenter.StartTheGame();

        private void OnDestroy() => startButton.onClick.RemoveAllListeners();
    }
}