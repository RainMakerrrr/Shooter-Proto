using Code.Infrastructure.Services.Input;
using UnityEngine;
using Zenject;

namespace Code.Logic.Player
{
    public class PlayerMovement : MonoBehaviour
    {
        [SerializeField] private Rigidbody _rigidbody;
        [SerializeField] private float _moveSpeed;

        private IInputService _inputService;

        [Inject]
        private void Construct(IInputService inputService)
        {
            _inputService = inputService;
        }

        private void FixedUpdate() => Move();

        private void Move()
        {
            Vector3 movementInput = new Vector3(_inputService.MovementInput.x, 0f, _inputService.MovementInput.y) *
                                    _moveSpeed;
            
            _rigidbody.velocity = transform.TransformDirection(movementInput);
        }
    }
}