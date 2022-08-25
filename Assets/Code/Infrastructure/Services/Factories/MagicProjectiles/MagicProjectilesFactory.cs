using System;
using Code.Infrastructure.Services.Assets;
using Code.Logic.Projectiles;
using Code.Logic.Weapons;
using Object = UnityEngine.Object;

namespace Code.Infrastructure.Services.Factories.MagicProjectiles
{
    public class MagicProjectilesFactory : IMagicProjectilesFactory
    {
        private readonly IAssetProvider _assetProvider;
        private BaseMagicProjectile _waterProjectilePrefab;
        private BaseMagicProjectile _fireProjectilePrefab;

        public MagicProjectilesFactory(IAssetProvider assetProvider)
        {
            _assetProvider = assetProvider;
        }

        public void Load()
        {
            _waterProjectilePrefab = _assetProvider.Load<BaseMagicProjectile>(AssetPath.WaterProjectile);
            _fireProjectilePrefab = _assetProvider.Load<BaseMagicProjectile>(AssetPath.FireProjectile);
        }
        
        public BaseMagicProjectile CreateProjectile(MagicType magicType)
        {
            switch (magicType)
            {
                case MagicType.Fire:
                    return Object.Instantiate(_fireProjectilePrefab);
                case MagicType.Water:
                    return Object.Instantiate(_waterProjectilePrefab);
                default:
                    throw new ArgumentOutOfRangeException(nameof(magicType), magicType, null);
            }
        }
    }
}