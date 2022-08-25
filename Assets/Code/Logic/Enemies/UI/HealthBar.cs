using UnityEngine;
using UnityEngine.UI;

namespace Code.Logic.Enemies.UI
{
    public class HealthBar : MonoBehaviour
    {
        [SerializeField] private Image _healthBar;

        private IHealth _health;

        private void OnEnable()
        {
            _health = GetComponentInParent<IHealth>();
            _health.HealthChanged += OnHealthChanged;
        }

        private void OnDisable() => _health.HealthChanged -= OnHealthChanged;

        private void OnHealthChanged() => _healthBar.fillAmount = _health.Current / _health.Max;
    }
}