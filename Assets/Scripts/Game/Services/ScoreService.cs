using UnityEngine;

namespace Game.Services
{
    public class ScoreService
    {
        private readonly PlayerDataService _playerDataService;
        
        private ScoreService(PlayerDataService playerDataService) => _playerDataService = playerDataService;

        public void AddScore(int amount)
        {
            if (amount <= 0)
            {
                Debug.LogWarning($"Trying to add {amount} points. Points must be greater than 0.");
                return;
            }
            
            _playerDataService.Model.Score += amount;

            if (_playerDataService.Model.Score > _playerDataService.Model.HighScore)
            {
                _playerDataService.Model.HighScore = _playerDataService.Model.Score;
            }
        }
    }
}