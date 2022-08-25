using Code.Infrastructure.Services.Assets;
using Code.Logic.Player;
using UnityEngine;

namespace Code.Infrastructure.Services.Factories.Bullets
{
    public class BulletsFactory : IBulletsFactory
    {
        private readonly IAssetProvider _assetProvider;
        private Bullet _bulletPrefab;

        public BulletsFactory(IAssetProvider assetProvider)
        {
            _assetProvider = assetProvider;
        }

        public void Load() => _bulletPrefab = _assetProvider.Load<Bullet>(AssetPath.BulletPrefab);

        public Bullet Create() => Object.Instantiate(_bulletPrefab);
    }
}