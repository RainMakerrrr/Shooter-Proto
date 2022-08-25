using System.Threading;
using System.Threading.Tasks;

namespace Code.Logic.Debuffs
{
    public class BurningDebuff
    {
        private const float Ticks = 5f;
        private const int Damage = 5;
        
        private readonly IHealth _health;

        private CancellationTokenSource _tokenSource;

        public BurningDebuff(IHealth health)
        {
            _health = health;

            _tokenSource = new CancellationTokenSource();
        }

        public void Reset()
        {
            _tokenSource.Cancel();
            _tokenSource = new CancellationTokenSource();
        }

        public async void ApplyDebuff()
        {
            CancellationTokenSource currentToken = _tokenSource;
            
            _health.TakeDamage(1f);

            for (int i = 0; i < Ticks; i++)
            {
                if (currentToken.IsCancellationRequested == false)
                {
                    _health.TakeDamage(Damage);
                    await Task.Delay(1000);
                }
            }
        }
    }
}