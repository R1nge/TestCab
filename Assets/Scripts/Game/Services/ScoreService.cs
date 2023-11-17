namespace Game.Services
{
    public class ScoreService
    {
        private readonly PlayerDataService _playerDataService;
        
        private ScoreService(PlayerDataService playerDataService) => _playerDataService = playerDataService;

        public void AddScore(int amount) => _playerDataService.Model.Score += amount;
    }
}