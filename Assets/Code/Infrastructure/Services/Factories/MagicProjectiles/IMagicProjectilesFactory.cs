using Code.Logic.Projectiles;
using Code.Logic.Weapons;

namespace Code.Infrastructure.Services.Factories.MagicProjectiles
{
    public interface IMagicProjectilesFactory
    {
        void Load();
        BaseMagicProjectile CreateProjectile(MagicType magicType);
    }
}