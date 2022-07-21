using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lottery
{
    internal class LottoSystem : IObserver<Player>
    {
        private readonly Random random = new();
        private IDisposable cancellation;
        public virtual void Subscribe(LottoDrawer provider)
        {
            cancellation = provider.Subscribe(this);
        }
        public virtual void Unsubscribe()
        {
            cancellation.Dispose();
        }
        public virtual void OnCompleted()
        {
        }
        public virtual void OnError(Exception e)
        {
            //No implementation
        }

        public virtual void OnNext(Player info)
        {
            int count = 0;
            int balance = info.PlayerBudget;

            if (info != null)
            {
                count++;
                Console.WriteLine("Welcome to a new week of Lotto.");
                for (int i = 0; info.PlayerName.Length > 0; i++)
                {
                    Console.WriteLine(info.PlayerName[i]);
                }
                balance =- info.Numbers.Length * count;
                int Result = random.Next(1, 50);
                Console.WriteLine($"This week's winning number is:...{Result}!");
            }
        }
    }
}
