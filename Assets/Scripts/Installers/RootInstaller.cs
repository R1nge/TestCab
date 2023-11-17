using Game.Configs;
using Game.Services;
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

            Container.BindInterfacesTo<PlayerDataProviderJson>().AsSingle();

            Container.Bind<PlayerDataService>().AsSingle();
        }
    }
}