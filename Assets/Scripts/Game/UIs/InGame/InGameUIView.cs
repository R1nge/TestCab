using Game.Services;
using TMPro;
using UnityEngine;
using Zenject;

namespace Game.UIs.InGame
{
    public class InGameUIView : MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI healthText, scoreText;
        private InGameUIPresenter _inGameUIPresenter;
        private PlayerDataService _playerDataService;

        [Inject]
        private void Inject(PlayerDataService playerDataService) => _playerDataService = playerDataService;

        private void Awake()
        {
            _inGameUIPresenter = new InGameUIPresenter(scoreText, healthText);
            _playerDataService.Model.OnScoreChanged += UpdateScore;
            _playerDataService.Model.OnHealthChanged += UpdateHealth;
            UpdateHealth(_playerDataService.Model.Health);
            UpdateScore(_playerDataService.Model.Score);
        }

        private void UpdateHealth(int health) => _inGameUIPresenter.UpdateHealth(health);

        private void UpdateScore(int score) => _inGameUIPresenter.UpdateScore(score);

        private void OnDestroy()
        {
            _playerDataService.Model.OnScoreChanged -= UpdateScore;
            _playerDataService.Model.OnHealthChanged -= UpdateHealth;
        }
    }
}