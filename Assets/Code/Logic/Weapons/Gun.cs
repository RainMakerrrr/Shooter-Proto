using Code.Infrastructure.Services.Factories.Bullets;
using Code.Logic.Player;
using UnityEngine;
using Zenject;

namespace Code.Logic.Weapons
{
    public class Gun : BaseWeapon
    {
        private IBulletsFactory _bulletsFactory;

        [Inject]
        private void Construct(IBulletsFactory bulletsFactory)
        {
            _bulletsFactory = bulletsFactory;
        }

        private void OnEnable()
        {
            _bulletsFactory.Load();
        }

        public override void Shoot()
        {
            Vector3 projectileDirection = GetProjectileDirection();
            
            Bullet bullet = SpawnBullet(projectileDirection);
            bullet.AddForce(projectileDirection);

            _ammunition--;
        }

        private Bullet SpawnBullet(Vector3 projectileDirection)
        {
            Bullet bullet = _bulletsFactory.Create();
            bullet.transform.position = _projectileSpawnPoint.position;
            bullet.transform.rotation = Quaternion.LookRotation(projectileDirection);
            return bullet;
        }
    }
}