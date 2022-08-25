using Code.Logic.Enemies;
using Code.Logic.Enemies.States;
using UnityEngine;

namespace Code.Logic.Projectiles
{
    public class FireProjectile : BaseMagicProjectile
    {
        [SerializeField] private float _fireValue;

        protected override void TrySwitchEnemyState(IStateSwitcher switcher)
        {
            switcher.SwitchState<BurningState>();
        }

        protected override bool ChangeEnemyWetting(IWetness wetness)
        {
            wetness.Burn(_fireValue);
            
            return wetness.Current == 0;
        }
    }
}