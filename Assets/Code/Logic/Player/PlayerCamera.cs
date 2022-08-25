using Code.Infrastructure.Services.Input;
using UnityEngine;
using Zenject;

namespace Code.Logic.Player
{
    public class PlayerCamera : MonoBehaviour
    {
        private const float RotationClampValue = 90f;

        [SerializeField] private float _sensitivity;

        private IInputService _inputService;
        private Transform _parent;

        private float _rotation;

        [Inject]
        private void Construct(IInputService inputService)
        {
            _inputService = inputService;
        }

        private void OnEnable()
        {
#if UNITY_EDITOR
            _sensitivity = 70f;
#endif

            _parent = transform.parent;
            HideCursor();
        }

        private void Update() => Rotate();

        private void Rotate()
        {
            Vector2 rotationInput = _inputService.CameraRotationInput * (_sensitivity * Time.deltaTime);

            _rotation -= rotationInput.y;
            _rotation = Mathf.Clamp(_rotation, -RotationClampValue, RotationClampValue);

            transform.localRotation = Quaternion.Euler(_rotation, 0f, 0f);
            _parent.Rotate(Vector3.up * rotationInput.x);
        }

        private void HideCursor()
        {
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
        }
    }
}