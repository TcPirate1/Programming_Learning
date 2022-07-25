using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lottery
{
    internal class LottoSystem : IObserver<Player>
    {
        private readonly string name;
        private readonly Random random = new();
        private IDisposable cancellation;
        public LottoSystem(string name)
        {
            if (string.IsNullOrEmpty(name))
                throw new ArgumentNullException("Enter name for observer");
            this.name = name;
        }
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
            int balance = info.PlayerBudget;

            int Result = random.Next(1, 50);
            if (info != null)
            {
                Console.WriteLine($"\nWelcome to a new week of Lotto {info.PlayerName}");
                Console.WriteLine($"This week's winning number is:...{Result}!\n");
            }
            else
            {
                throw new ArgumentNullException("OnNext(Player info) is null.");
            }

            foreach (int Number in info.Numbers)
            {
                balance -= 1;
                if (Result == Number)
                {
                    Console.WriteLine($"Congradulations {info.PlayerName}, {Number} is a winning number!");
                }
                else
                {
                    Console.WriteLine($"Sorry, {Number} is not a winning number.");
                }
            }
            Console.WriteLine($"\n{info.PlayerName}'s balance after playing is ${balance}");
        }
    }
}
