using System;
using Unity.Properties;

namespace Game.Services
{
    [Serializable]
    public class PlayerDataModel
    {
        private int _health;
        private int _score, _highScore;
        public event Action<int> OnHealthChanged;
        public event Action<int> OnScoreChanged, OnHighScoreChanged;

        public int Health
        {
            get => _health;
            set
            {
                _health = value;
                OnHealthChanged?.Invoke(_health);
            }
        }

        public int Score
        {
            get => _score;
            set
            {
                _score = value;
                OnScoreChanged?.Invoke(_score);
            }
        }

        [CreateProperty]
        public int HighScore
        {
            get => _highScore;
            set
            {
                _highScore = value;
                OnHighScoreChanged?.Invoke(_highScore);
            }
        }

        public PlayerDataModel(int health, int score, int highScore)
        {
            Health = health;
            Score = score;
            HighScore = highScore;
        }

        public PlayerDataModel() { }
    }
}