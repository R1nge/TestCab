using Game.Configs;
using UnityEngine;
using Zenject;

namespace Game.Factories
{
    public class PlayerFactory
    {
        private readonly DiContainer _diContainer;
        private readonly ConfigProvider _configProvider;

        private PlayerFactory(DiContainer diContainer, ConfigProvider configProvider)
        {
            _diContainer = diContainer;
            _configProvider = configProvider;
        }

        public GameObject CreatePlayer(Vector3 position, Quaternion rotation, Transform parent)
        {
            return _diContainer.InstantiatePrefab(_configProvider.PlayerConfig.PlayerPrefab, position, rotation, parent);
        }
    }
}