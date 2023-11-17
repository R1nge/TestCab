using Game;
using Game.Factories;
using Game.Services;
using UnityEngine;
using Zenject;

namespace Installers
{
    public class GameInstaller : MonoInstaller
    {
        [SerializeField] private PlayerSpawner playerSpawner;
        [SerializeField] private CameraService cameraService;
        public override void InstallBindings()
        {
            Container.Bind<PlayerFactory>().AsSingle();
            Container.BindInstance(playerSpawner);
            
            Container.BindInstance(cameraService);
            
            Container.Bind<UIFactory>().AsSingle();
            
            Container.Bind<GameStateFactory>().AsSingle();
            Container.Bind<GameStateMachine>().AsSingle();
        }
    }
}