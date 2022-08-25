using UnityEngine;

namespace Code.Logic.Weapons
{
    public abstract class BaseWeapon : MonoBehaviour
    {
        [SerializeField] protected Transform _projectileSpawnPoint;
        [SerializeField] protected int _ammunition;
        [SerializeField] private Collider _collider;
        
        private readonly Vector3 _middleScreenPosition = new Vector3(0.5f, 0.5f, 0f);

        private Transform _startParent;
        private Camera _camera;
        private Vector3 _startPosition;
        
        public bool IsOutOfAmmo => _ammunition <= 0;

        private void Start()
        {
            _camera = Camera.main;
            _startParent = transform.parent;
            _startPosition = transform.position;
        }

        public void SetPosition(Transform parent, Vector3 position)
        {
            transform.SetParent(parent);
            transform.position = position;
            transform.localRotation = Quaternion.identity;
        }

        public void DisableCollider() => _collider.enabled = false;
        public void EnableCollider() => _collider.enabled = true;

        public void ReturnStartPosition()
        {
            transform.SetParent(_startParent);
            transform.position = _startPosition;
        }

        protected Vector3 GetProjectileDirection()
        {
            Ray ray = _camera.ViewportPointToRay(_middleScreenPosition);

            Vector3 targetPoint = Physics.Raycast(ray, out RaycastHit hit, Mathf.Infinity)
                ? hit.point
                : ray.GetPoint(10);
            return (targetPoint - _projectileSpawnPoint.position).normalized;
        }


        public abstract void Shoot();
    }
}