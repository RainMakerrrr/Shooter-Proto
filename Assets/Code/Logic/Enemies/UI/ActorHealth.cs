using System.Globalization;
using TMPro;
using UnityEngine;

namespace Code.Logic.Enemies.UI
{
    public class ActorHealth : MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI _text;
        
        private IHealth _health;

        private void OnEnable()
        {
            _health = GetComponentInParent<IHealth>();
            _health.HealthChanged += OnHealthChanged;
        }

        private void OnDisable()
        {
            _health.HealthChanged += OnHealthChanged;
        }

        private void OnHealthChanged()
        {
            _text.text = _health.Current.ToString(CultureInfo.InvariantCulture);
        }
    }
}