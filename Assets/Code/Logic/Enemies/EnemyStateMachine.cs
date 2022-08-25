using System.Collections.Generic;
using System.Linq;
using Code.Logic.Debuffs;
using Code.Logic.Enemies.States;
using UnityEngine;

namespace Code.Logic.Enemies
{
    public class EnemyStateMachine : MonoBehaviour, IStateSwitcher
    {
        [SerializeField] private EnemyHealth _enemyHealth;
        
        private List<IEnemyState> _states;
        private IEnemyState _currentState;
        
        private void OnEnable()
        {
            _states = new List<IEnemyState>
            {
                new NormalState(_enemyHealth),
                new BurningState(_enemyHealth, new BurningDebuff(_enemyHealth)),
                new WetState(_enemyHealth)
            };

            _currentState = _states[0];
        }

        public void TakeDamage(float damage)
        {
            _currentState.TakeDamage(damage);
            
            if (_enemyHealth.IsDead)
                Die();
        }

        public void ResetState()
        {
            _currentState?.Exit();
            _currentState = _states[0];
        }
        
        public void SwitchState<T>() where T : IEnemyState
        {
            IEnemyState state = _states.FirstOrDefault(state => state is T);
            if (state == null) return;
            
            _currentState.Exit();
            _currentState = state;
            _currentState.Enter();
        }
        
        private void Die()
        {
            _currentState.Exit();
            Destroy(gameObject);
        }
    }
}