using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lottery
{
    internal class Player
    {
        private readonly string Pname;
        private readonly int[] LottoNumbers;
        private readonly int Budget;

        internal Player(string pname, int[] lottoNumbers, int budget)
        {
            this.Pname = pname;
            this.LottoNumbers = lottoNumbers;
            this.Budget = budget;
        }

        public string PlayerName
        {
            get { return this.Pname; }
        }
        public int[] Numbers
        {
            get { return this.LottoNumbers; }
        }
        public int PlayerBudget
        {
            get { return this.Budget; }
        }
    }
}
