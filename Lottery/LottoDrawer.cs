using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lottery
{
    internal class LottoDrawer : IObservable<Player>
    {
        private readonly List<IObserver<Player>> observers;
        private readonly List<Player> players;
        public LottoDrawer()
        {
            observers = new List<IObserver<Player>>();
            players = new List<Player>();
        }
        public IDisposable Subscribe(IObserver<Player> observer)
        {
            if (!observers.Contains(observer))
            {
                observers.Add(observer);
                foreach(var item in players)
                    observer.OnNext(item);
            }
            return new Unsubscriber<Player>(observers, observer);
        }
        public void PlayerInfo(string name, int[]lottoNumbers, int budget)
        {
            var info = new Player(name, lottoNumbers, budget);

            if (budget > 0 && !players.Contains(info))
            {
                players.Add(info);
                foreach (var observer in observers)
                    observer.OnNext(info);
            }
            else if (budget <= 0)
            {
                var removePlayers = new List<Player>();
                foreach (var player in players)
                {
                    if (info.PlayerBudget == player.PlayerBudget)
                    {
                        players.Remove(player);
                        foreach (var observer in observers)
                            observer.OnNext(info);
                    }
                }
                foreach (var remove in removePlayers)
                    players.Remove(remove);
                removePlayers.Clear();
            }
        }
        public void NoMorePlayers()
        {
            foreach (var observer in observers)
                observer.OnCompleted();
            observers.Clear();
        }
    }
}
