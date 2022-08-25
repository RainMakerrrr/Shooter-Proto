using System;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Code.Infrastructure.Services.Input
{
    public class InputService : IInputService
    {
        public event Action ShootLeftClicked;
        public event Action ShootRightClicked;
        public event Action EquipLeftClicked;
        public event Action EquipRightClicked;
        public event Action ResetClicked;

        public Vector2 MovementInput => _playerControls.Player.Movement.ReadValue<Vector2>();

        public Vector2 CameraRotationInput => _playerControls.Player.CameraRotation.ReadValue<Vector2>();

        private readonly PlayerControls _playerControls;

        public InputService()
        {
            _playerControls = new PlayerControls();
            _playerControls.Enable();

            _playerControls.Player.ShootLeft.started += OnShootLeft;
            _playerControls.Player.ShootRight.started += OnShootRight;
            _playerControls.Player.EquipLeft.started += OnEquipLeft;
            _playerControls.Player.EquipRight.started += OnEquipRight;
            _playerControls.Scarecrow.Reset.started += OnReset;
        }

        private void OnShootLeft(InputAction.CallbackContext context) => ShootLeftClicked?.Invoke();

        private void OnShootRight(InputAction.CallbackContext context) => ShootRightClicked?.Invoke();

        private void OnEquipLeft(InputAction.CallbackContext context) => EquipLeftClicked?.Invoke();

        private void OnEquipRight(InputAction.CallbackContext context) => EquipRightClicked?.Invoke();

        private void OnReset(InputAction.CallbackContext context) => ResetClicked?.Invoke();

        ~InputService()
        {
            _playerControls.Player.ShootLeft.started -= OnShootLeft;
            _playerControls.Player.ShootRight.started -= OnShootRight;
            _playerControls.Player.EquipLeft.started -= OnEquipLeft;
            _playerControls.Player.EquipRight.started -= OnEquipRight;
            _playerControls.Scarecrow.Reset.started -= OnReset;
            
            _playerControls.Disable();
            _playerControls.Dispose();
        }
    }
}