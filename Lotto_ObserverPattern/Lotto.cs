using System;
using System.Collections.Generic;
using System.Text;

namespace Lotto_ObserverPattern
{
    internal class Lotto
    {
        private List<Player> ListOfPlayers = new List<Player>();

        private int WinningNumber { get; set; }
        private int Result { get; set; }
        private bool check = true;

        public void Subscribe(Player player)
        {
            ListOfPlayers.Add(player);
        }

        public void Unsubscribe(Player player)
        {
            ListOfPlayers.Remove(player);
        }

        private void Notify()
        {
            if (WinningNumber != Result)
            {
                Console.WriteLine("There are no winners this week. Come back next week!");
            }
            if (ListOfPlayers.Count <= 0)
            {
                check = false;
                Console.WriteLine("\nNo players are playing Lotto.");
            }
        }
        private void RandomNumberGenerator()
        {
            Random random = new Random();
            WinningNumber = random.Next(1, 50);
            Console.WriteLine($"\nThe winning number for this week is...{WinningNumber}!");
        }
        public void LottoStart()
        {
            int count = 0;
            int playerBalance = 0;
            do
            {
                Console.WriteLine("\nWelcome to a new week of Lotto.");
                Console.WriteLine("Press any button to start the game!");
                Console.ReadLine();

                count++;
                Console.WriteLine("Players next to be drawn are below:\n");
                for (int i = 0; i < ListOfPlayers.Count; i++)
                {
                    playerBalance = ListOfPlayers[i].Budget;
                    playerBalance -= (ListOfPlayers[i].Numbers.Length * count);

                    if (playerBalance >= 0)
                    {
                        Console.WriteLine($"{ListOfPlayers[i].name} with ${playerBalance} left to buy lotto numbers");
                    }
                }

                RandomNumberGenerator();

                for (int i = 0; i < ListOfPlayers.Count; i++)
                {
                    playerBalance = ListOfPlayers[i].Budget;
                    playerBalance -= (ListOfPlayers[i].Numbers.Length * count);

                    if (playerBalance >= ListOfPlayers[i].Numbers.Length)
                    {
                        foreach (var item in ListOfPlayers[i].Numbers)
                        {
                            if (WinningNumber == item)
                            {
                                Console.WriteLine($"Congratulations {ListOfPlayers[i].name}! You are this week's winner! Thanks for playing!");
                                Result = item;
                                check = false;
                            }
                        }
                    }
                    if (playerBalance < ListOfPlayers[i].Numbers.Length && WinningNumber != Result)
                    {
                        Console.WriteLine($"{ListOfPlayers[i].name} has run out of money and cannot continue next week.\n");
                        Unsubscribe(ListOfPlayers[i]);
                    }
                }
                Notify();
            }
            while (check == true);
        }
    }
}
