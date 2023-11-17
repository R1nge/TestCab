using Game.Services;
using TMPro;

namespace Game.UIs.InGame
{
    public class InGameUIPresenter
    {
        private TextMeshProUGUI _scoreText;
        private TextMeshProUGUI _healthText;

        public InGameUIPresenter(TextMeshProUGUI scoreText, TextMeshProUGUI healthText)
        {
            _scoreText = scoreText;
            _healthText = healthText;
        }

        public void UpdateScore(int score) => _scoreText.text = $"Score: {score}";
        
        public void UpdateHealth(int health) => _healthText.text = $"Health: {health}";
    }
}