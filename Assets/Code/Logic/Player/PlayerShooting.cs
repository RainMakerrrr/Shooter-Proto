using Code.Infrastructure.Services.Input;
using Code.Logic.Player.Pickup;
using UnityEngine;
using Zenject;

namespace Code.Logic.Player
{
    public class PlayerShooting : MonoBehaviour
    {
        [SerializeField] private WeaponSlot _leftSlot;
        [SerializeField] private WeaponSlot _rightSlot;
        [SerializeField] private float _shootRate;
        
        private IInputService _inputService;
        
        private float _nextLeftHandShootTime;
        private float _nextRightHandShootTime;
        
        [Inject]
        private void Construct(IInputService inputService)
        {
            _inputService = inputService;
        }

        private void OnEnable()
        {
            _inputService.ShootLeftClicked += OnShootLeft;
            _inputService.ShootRightClicked += OnShootRight;
        }

        private void OnDisable()
        {
            _inputService.ShootLeftClicked -= OnShootLeft;
            _inputService.ShootRightClicked -= OnShootRight;
        }

        private void OnShootLeft()
        {
            if (!(Time.time > _nextLeftHandShootTime)) return;

            _nextLeftHandShootTime = Time.time + 1 / _shootRate;
            
            TryShoot(_leftSlot);
        }

        private void OnShootRight()
        {
            if (!(Time.time > _nextRightHandShootTime)) return;
            
            _nextRightHandShootTime = Time.time + 1 / _shootRate;

            TryShoot(_rightSlot);
        }

        private void TryShoot(WeaponSlot slot)
        {
            if (slot.HasWeapon == false) return;
            
            slot.Weapon.Shoot();

            if (slot.Weapon.IsOutOfAmmo)
            {
                slot.DetachWeapon();
            }
        }
    }
}