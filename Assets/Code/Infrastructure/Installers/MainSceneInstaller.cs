using Code.Infrastructure.Services.Assets;
using Code.Infrastructure.Services.Factories.Bullets;
using Code.Infrastructure.Services.Factories.MagicProjectiles;
using Code.Infrastructure.Services.Input;
using Zenject;

namespace Code.Infrastructure.Installers
{
    public class MainSceneInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            BindInputService();
            BindAssetProvider();
            BindBulletFactory();
            BindMagicProjectilesFactory();
        }
        
        private void BindInputService() => Container.Bind<IInputService>().To<InputService>().AsSingle();
        private void BindAssetProvider() => Container.Bind<IAssetProvider>().To<AssetProvider>().AsSingle();
        private void BindBulletFactory() => Container.Bind<IBulletsFactory>().To<BulletsFactory>().AsSingle();

        private void BindMagicProjectilesFactory() =>
            Container.Bind<IMagicProjectilesFactory>().To<MagicProjectilesFactory>().AsSingle();
    }
}