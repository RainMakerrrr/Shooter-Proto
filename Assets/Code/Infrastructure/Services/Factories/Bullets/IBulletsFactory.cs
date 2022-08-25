using Code.Logic.Player;

namespace Code.Infrastructure.Services.Factories.Bullets
{
    public interface IBulletsFactory
    {
        void Load();
        Bullet Create();
    }
}