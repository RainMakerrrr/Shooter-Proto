using Code.Infrastructure.Services.Factories.MagicProjectiles;
using Code.Logic.Projectiles;
using UnityEngine;
using Zenject;

namespace Code.Logic.Weapons
{
    public class MagicWeapon : BaseWeapon
    {
        [SerializeField] private MagicType _magicType;
        
        private IMagicProjectilesFactory _projectilesFactory;

        [Inject]
        private void Construct(IMagicProjectilesFactory projectilesFactory)
        {
            _projectilesFactory = projectilesFactory;
        }

        private void OnEnable() => _projectilesFactory.Load();
        
        public override void Shoot()
        {
            SpawnMagicProjectile();

            _ammunition--;
        }

        private void SpawnMagicProjectile()
        {
            BaseMagicProjectile magicProjectile = _projectilesFactory.CreateProjectile(_magicType);
            magicProjectile.transform.position = transform.position;
            magicProjectile.Play();
            magicProjectile.AddForce(GetProjectileDirection());
        }
    }
}