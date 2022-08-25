using System;
using UnityEngine;

namespace Code.Logic.Enemies
{
    public class EnemyWetness : MonoBehaviour, IWetness
    {
        public event Action WetnessChanged;
        
        [SerializeField] private Renderer[] _renderers;
        [SerializeField] private float _maxWetness = 100f;
        
        public float Current { get; private set; }
        public float Max { get; private set; }
        
        private void OnEnable()
        {
            Max = _maxWetness;
            Current = 0f;
            
            WetnessChanged?.Invoke();
        }

        public void IncreaseWetness(float wetness)
        {
            if (wetness < 0) return;
            
            Current += wetness;
            
            ClampWetness();
            WetnessChanged?.Invoke();
            ChangeColor(Color.blue);
        }

        public void Burn(float burn)
        {
            if (burn < 0) return;

            Current -= burn;
            
            ClampWetness();
            WetnessChanged?.Invoke();
            
            if (Current == 0)
            {
                ChangeColor(Color.red);
            }
        }

        public void Reset()
        {
            Current = 0;
            ChangeColor(Color.white);
            
            WetnessChanged?.Invoke();
        }
        
        private void ClampWetness() => Current = Mathf.Clamp(Current, 0, Max);
        
        private void ChangeColor(Color color)
        {
            foreach (Renderer enemyRenderer in _renderers)
            {
                enemyRenderer.material.color = color;
            }
        }
    }
}