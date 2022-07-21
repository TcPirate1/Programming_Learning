using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lottery
{
    internal class Unsubscriber<Player> : IDisposable
    {
        private readonly List<IObserver<Player>> _observers;
        private readonly IObserver<Player> _observer;
        internal Unsubscriber(List<IObserver<Player>> observers, IObserver<Player> observer)
        {
            this._observers = observers;
            this._observer = observer;
        }

        public void Dispose()
        {
            if (_observers.Contains(_observer))
                _observers.Remove(_observer);
        }
    }
}
