using Game.Configs;
using UnityEngine;
using Zenject;

/// <summary>
/// Decided not to create a state machine for the UI, as it would be overkill for a such small project
/// </summary>


namespace Game.Factories
{
    public class UIFactory
    {
        private DiContainer _diContainer;
        private readonly ConfigProvider _configProvider;
        private GameObject _previousScreen;

        private UIFactory(DiContainer diContainer, ConfigProvider configProvider)
        {
            _diContainer = diContainer;
            _configProvider = configProvider;
        }
        
        public void CreateMainMenuUI()
        {
            _previousScreen = _diContainer.InstantiatePrefab(_configProvider.UIConfig.MainMenuUI);
        }

        public void CreateInGameUI()
        {
            Object.Destroy(_previousScreen);
            
            _previousScreen = _diContainer.InstantiatePrefab(_configProvider.UIConfig.InGameUI);
        }

        public void CreateGameOverUI()
        {
            Object.Destroy(_previousScreen);
            
            _previousScreen = _diContainer.InstantiatePrefab(_configProvider.UIConfig.GameOverUI);
        }
    }
}