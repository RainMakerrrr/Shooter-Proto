using System;

namespace Code.Logic
{
    public class Health
    {
        public event Action Died;
        public event Action TakenDamage;

        public bool IsDead => CurrentHealth <= 0;

        public float CurrentHealth { get; private set; }
        public float MaxHealth { get; }

        public Health(float maxHealth)
        {
            MaxHealth = maxHealth;
            CurrentHealth = MaxHealth;
        }

        public void TakeDamage(float damage)
        {
            CurrentHealth -= damage;

            TakenDamage?.Invoke();
            
            if (IsDead)
                Died?.Invoke();
        }
    }
}