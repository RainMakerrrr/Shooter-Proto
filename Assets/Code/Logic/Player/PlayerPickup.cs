using Code.Infrastructure.Services.Input;
using Code.Logic.Player.Pickup;
using Code.Logic.Weapons;
using UnityEngine;
using Zenject;

namespace Code.Logic.Player
{
    public class PlayerPickup : MonoBehaviour
    {
        [SerializeField] private WeaponSlot _leftSlot;
        [SerializeField] private WeaponSlot _rightSlot;
        [SerializeField] private float _pickupDistance = 10f;

        private IInputService _inputService;
        private Camera _camera;

        private readonly Vector3 _screenMiddle = new Vector3(0.5f, 0.5f, 0f);

        [Inject]
        private void Construct(IInputService inputService)
        {
            _inputService = inputService;
        }

        private void OnEnable()
        {
            _camera = Camera.main;

            _inputService.EquipLeftClicked += OnEquipLeftHand;
            _inputService.EquipRightClicked += OnEquipRightHand;
        }

        private void OnEquipLeftHand()
        {
            AttachWeapon(_leftSlot);
        }

        private void OnEquipRightHand()
        {
            AttachWeapon(_rightSlot);
        }

        private void AttachWeapon(WeaponSlot slot)
        {
            if (slot.HasWeapon)
            {
                slot.DetachWeapon();
                return;
            }
            
            Ray ray = _camera.ViewportPointToRay(_screenMiddle);

            if (Physics.Raycast(ray, out RaycastHit hit, _pickupDistance))
            {
                var weapon = hit.collider.GetComponent<BaseWeapon>();
                if (weapon != null)
                {
                    slot.AttachWeapon(weapon);
                }
            }
        }

        private void OnDisable()
        {
            _inputService.EquipLeftClicked -= OnEquipLeftHand;
            _inputService.EquipRightClicked -= OnEquipRightHand;
        }
    }
}