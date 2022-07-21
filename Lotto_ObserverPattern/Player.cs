using System;
using System.Collections.Generic;
using System.Text;

namespace Lotto_ObserverPattern
{
    internal class Player
    {
        public string name { get; set; }
        public int[] Numbers { get; set; }
        public int Budget { get; set; }

        public Player(string name, int[] numbers, int budget)
        {
            this.name = name;
            this.Numbers = numbers;
            this.Budget = budget;
        }
    }
}
