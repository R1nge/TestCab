using Game.Configs;
using UnityEngine;
using Zenject;

namespace Installers
{
    public class RootInstaller : MonoInstaller
    {
        [SerializeField] private ConfigProvider configProvider;

        public override void InstallBindings()
        {
            Container.BindInstance(configProvider);
        }
    }
}