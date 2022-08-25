using System;
using Code.Infrastructure.Services.Input;
using Code.Logic.Enemies;
using UnityEngine;
using Zenject;

namespace Code.Logic
{
    public class EnemyStateReset : MonoBehaviour
    {
        [SerializeField] private EnemyStateMachine _enemyStateMachine;

        private IInputService _inputService;

        [Inject]
        private void Construct(IInputService inputService)
        {
            _inputService = inputService;
        }

        private void OnEnable()
        {
            _inputService.ResetClicked += OnReset;
        }

        private void OnDisable()
        {
            _inputService.ResetClicked -= OnReset;
        }

        private void OnReset()
        {
            _enemyStateMachine.ResetState();
            _enemyStateMachine.GetComponent<IHealth>().Reset();
            _enemyStateMachine.GetComponent<IWetness>().Reset();
        }
        
    }
}