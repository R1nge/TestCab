using System;

namespace Game.Services
{
    [Serializable]
    public class PlayerDataModel
    {
        private int _health;
        private int _score;
        public event Action<int> OnHealthChanged;
        public event Action<int> OnScoreChanged;

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

        public PlayerDataModel(int health, int score)
        {
            Health = health;
            Score = score;
        }
    }
}