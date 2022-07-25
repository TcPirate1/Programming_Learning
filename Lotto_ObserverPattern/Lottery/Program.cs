using System;

namespace Lottery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to this Simple Lotto Game, using the Observer Pattern.\nEach number costs $1 and only numbers between 1 and 49 are valid.\n");
            //Players
            //Player player1 = new Player("Tama", new int[] { 3, 33, 17, 46, 47, 27 }, 50);
            //Player player2 = new Player("Bob", new int[]{7, 19, 22, 23 }, 8);
            //Player player3 = new Player("Caesar", new int[] { 33, 13 }, 35);
            LottoSystem observer = new("Tama");
            LottoSystem observer1 = new("Bob");
            LottoSystem observer2 = new("Caesar");

            LottoDrawer lotto = new();

            lotto.PlayerInfo("Tama", new int[] { 3, 33, 17, 46, 47, 27 }, 50);
            observer.Subscribe(lotto);
            lotto.PlayerInfo("Bob", new int[] { 7, 19, 22, 23 }, 8);
            observer1.Subscribe(lotto);
            lotto.PlayerInfo("Caesar", new int[] { 33, 13 }, 35);
            observer2.Subscribe(lotto);
        }
    }
}
