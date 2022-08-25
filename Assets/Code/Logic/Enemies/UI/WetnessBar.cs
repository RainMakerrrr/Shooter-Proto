using UnityEngine;
using UnityEngine.UI;

namespace Code.Logic.Enemies.UI
{
    public class WetnessBar : MonoBehaviour
    {
        [SerializeField] private Image _healthBar;

        private IWetness _wetness;

        private void OnEnable()
        {
            _wetness = GetComponentInParent<IWetness>();
            _wetness.WetnessChanged += OnWetnessChanged;
        }

        private void OnDisable() => _wetness.WetnessChanged -= OnWetnessChanged;

        private void OnWetnessChanged() => _healthBar.fillAmount = _wetness.Current / _wetness.Max;
    }
}