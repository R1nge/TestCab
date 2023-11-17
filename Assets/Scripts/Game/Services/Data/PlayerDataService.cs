using System;

namespace Game.Services
{
    public class PlayerDataService
    {
        private readonly IPlayerDataProvider _playerDataProvider;
        private PlayerDataModel _model;

        public PlayerDataService(IPlayerDataProvider playerDataProvider) => _playerDataProvider = playerDataProvider;
        public PlayerDataModel Model => _model;
        
        public void Save() => _playerDataProvider.Save(_model);
        public void Load() => _model = _playerDataProvider.Load();
    }
}