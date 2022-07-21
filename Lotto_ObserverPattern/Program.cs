using System;

namespace Lotto_ObserverPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Simple Lotto Game. \nLotto tickets cost $1 per number.\nYou may only choose numbers between 1 and 49.");

            //Players
            Player player1 = new Player("Tama", new int[] { 3, 33, 17, 46, 47, 27}, 50);
            Player player2 = new Player("Bob", new int[] { 7, 19, 22, 23}, 8);
            Player player3 = new Player("Caesar", new int[] { 33, 13}, 35);

            //Lotto
            Lotto lotto = new Lotto();

            lotto.Subscribe(player1);
            lotto.Subscribe(player2);
            lotto.Subscribe(player3);
            lotto.LottoStart();
        }
    }
}
