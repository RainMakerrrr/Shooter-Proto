using Code.Logic.Enemies;
using Code.Logic.Enemies.States;
using UnityEngine;

namespace Code.Logic.Projectiles
{
    public class WaterProjectile : BaseMagicProjectile
    {
        [SerializeField] private float _wetness;

        protected override void TrySwitchEnemyState(IStateSwitcher switcher) => switcher.SwitchState<WetState>();

        protected override bool ChangeEnemyWetting(IWetness wetness)
        {
            wetness.IncreaseWetness(_wetness);
            return true;
        }
    }
}