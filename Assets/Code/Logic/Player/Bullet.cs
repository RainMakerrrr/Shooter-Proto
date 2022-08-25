using Code.Logic.Enemies;
using UnityEngine;

namespace Code.Logic.Player
{
    public class Bullet : MonoBehaviour
    {
        [SerializeField] private Rigidbody _rigidbody;
        [SerializeField] private float _force;
        [SerializeField] private float _damage;
        
        public void AddForce(Vector3 direction) => _rigidbody.AddForce(direction * _force, ForceMode.Impulse);

        private void OnCollisionEnter(Collision collision)
        {
            var enemy = collision.collider.GetComponent<EnemyStateMachine>();
            if (enemy == null) return;
            
            enemy.TakeDamage(_damage);
            Destroy(gameObject);
        }
    }
}