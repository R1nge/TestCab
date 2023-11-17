using Game;
using Game.Factories;
using Zenject;

namespace Installers
{
    public class GameInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            Container.Bind<UIFactory>().AsSingle();
            
            Container.Bind<GameStateFactory>().AsSingle();
            Container.Bind<GameStateMachine>().AsSingle();
        }
    }
}