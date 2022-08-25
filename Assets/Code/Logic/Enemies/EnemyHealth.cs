using System;
using UnityEngine;

namespace Code.Logic.Enemies
{
    public class EnemyHealth : MonoBehaviour, IHealth
    {
        [SerializeField] private float _startHealth;
        
        public event Action HealthChanged;
        
        public float Current { get; private set; }
        public float Max { get; private set; }

        public bool IsDead => Current <= 0;
        
        private void OnEnable()
        {
            Max = _startHealth;
            Current = _startHealth;
            
            HealthChanged?.Invoke();
        }

        public void TakeDamage(float damage)
        {
            Current -= damage;
            
            HealthChanged?.Invoke();

            if (Current <= 0)
                Die();
        }

        public void Reset()
        {
            Current = Max;
            HealthChanged?.Invoke();
        }

        private void Die() => Destroy(gameObject);
    }
}