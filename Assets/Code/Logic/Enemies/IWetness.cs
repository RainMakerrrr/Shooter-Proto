using System;

namespace Code.Logic.Enemies
{
    public interface IWetness
    {
        event Action WetnessChanged;
        float Current { get; }
        float Max { get; }
        void IncreaseWetness(float wetness);
        void Burn(float burn);

        void Reset();
    }
}