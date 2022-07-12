using System;
using System.Collections.Generic;

namespace IT6033_Practical2_Dongxu_Terence_Chen_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome!");
            Program list = new Program();
            Customer [] people = {new Customer("Tama", 2, "Auckland"), new Customer("Amelia", 5, "Taranaki"), new Customer("Kaos", 3, "Hamilton"),
                new Customer("Karl", 4, "Papatoetoe"), new Customer("Carlos", 5,"Glenfield"),
                new Customer("Alicia", 2, "Whangarei"), new Customer("Zion", 2, "Wellington"),
                new Customer("Sara", 3, "Auckland"), new Customer("Bob", 4, "Papakura"), new Customer("Wiremu", 5, "Auckland")};

            Console.WriteLine("This is the unsorted collection:");
            list.PrintCollection(people);
            Console.WriteLine();
            Console.WriteLine("This is the sorted collection:");
            list.BubbleSort(people);
            list.PrintCollection(people);
        }
        private void PrintCollection(Customer[] people)
        {
            for (int i = 0; i < people.Length; i++)
            {
                Console.Write($"{people[i].GetName()}, customer rating {people[i].GetRating()}, address {people[i].GetAddress()}");
                Console.WriteLine();
            }
        }
        private void BubbleSort(Customer[] people)
        {
            for (int i = 0; i < people.Length - 1; i++)
            {
                for (int j = 0; j < people.Length - i - 1; j++)
                {
                    if (people[j].GetRating() > people[j+1].GetRating())
                    {
                        if (people[j].GetName().CompareTo(people[j + 1].GetName()) < 0)
                        {
                            Customer temp = people[j];
                            people[j] = people[j + 1];
                            people[j + 1] = temp;
                        }
                    }
                }
            }
        }
    }
}