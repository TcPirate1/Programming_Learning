using System;

namespace Searching_Algorithms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Select a data size from the list:\n20 , 100, 1k, 10k, 400k");
            Console.WriteLine("(Type in the number only, so 1 = 1k, 10 = 10k, 400 = 400k)");
            int dataSize = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Would you like Linear or Binary? (L = Linear, B = Binary)");
            char choice = Convert.ToChar(Console.ReadLine().ToUpper());

            Menu(dataSize, choice);
        }

        static void Menu(int dSize, char choice)
        {
            if (dSize == 20 && choice == 'L')
            {
                Movies20.MoviesLinear20();
            }
            else if (dSize == 20 && choice == 'B')
            {
                Movies20.MoviesBinary20();
            }
            else if (dSize == 100 && choice == 'L')
            {
                Movies100.MoviesLinear100();
            }
            else if (dSize == 100 && choice == 'B')
            {
                Movies100.MoviesBinary100();
            }
            else if (dSize == 1 && choice == 'L')
            {
                Movies1k.MoviesLinear1k();
            }
            else if (dSize == 1 && choice == 'B')
            {
                Movies1k.MoviesBinary1k();
            }
            else if (dSize == 10 && choice == 'L')
            {
                Movies10k.MoviesLinear10k();
            }
            else if (dSize == 10 && choice == 'B')
            {
                Movies10k.MoviesBinary10k();
            }
            else if (dSize == 400 && choice == 'L')
            {
                Movies400k.MoviesLinear400k();
            }
            else if (dSize == 400 && choice == 'B')
            {
                Movies400k.MoviesBinary400k();
            }
        }
    }
}
