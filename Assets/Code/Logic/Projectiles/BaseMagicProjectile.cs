using System.Collections.Generic;
using Code.Logic.Enemies;
using UnityEngine;

namespace Code.Logic.Projectiles
{
    public abstract class BaseMagicProjectile : MonoBehaviour
    {
        [SerializeField] private ParticleSystem _particle;
        [SerializeField] private Rigidbody _rigidbody;
        [SerializeField] private float _force;
        
        private readonly List<ParticleCollisionEvent> _collisionEvents = new List<ParticleCollisionEvent>();

        public void Play() => _particle.Play();

        public void AddForce(Vector3 direction) => _rigidbody.AddForce(direction * _force, ForceMode.Impulse);

        private void OnParticleCollision(GameObject other)
        {
            int collisionEventsCount = _particle.GetCollisionEvents(other, _collisionEvents);

            for (int i = 0; i < collisionEventsCount; i++)
            {
                var wetness = other.GetComponent<IWetness>();
                if(wetness == null) continue;

                if (ChangeEnemyWetting(wetness))
                {
                    TrySwitchEnemyState(other.GetComponent<IStateSwitcher>());
                }

                Destroy(gameObject);
                break;
            }
        }

        protected abstract void TrySwitchEnemyState(IStateSwitcher switcher);

        protected abstract bool ChangeEnemyWetting(IWetness wetness);
    }
}