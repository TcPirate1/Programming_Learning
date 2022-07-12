using System;
using System.IO;
using System.Diagnostics;

namespace Searching_Algorithms
{
    internal class Movies100
    {
        public static void MoviesLinear100()
        {
            Console.WriteLine("Enter movie that you would like to find:");
            string input = Console.ReadLine();
            string FilePath = Path.Combine(Environment.CurrentDirectory, "movieTitles100.txt");

            string[] movies = File.ReadAllLines(FilePath);
            Array.Sort(movies);
            //Linear
            Stopwatch timerLinear = Stopwatch.StartNew();
            for (int i = 0; i < movies.Length; i++)
            {
                if (movies[i] == input)
                {
                    Console.WriteLine($"{movies[i]} is at index {i}");
                }
            }
            timerLinear.Stop();
            Console.WriteLine($"The time it took for the Linear Algorithm to find is {timerLinear.Elapsed}");
            timerLinear.Reset();
        }
        public static void MoviesBinary100()
        {
            Console.WriteLine("Enter movie that you would like to find:");
            string input = Console.ReadLine();
            string FilePath = Path.Combine(Environment.CurrentDirectory, "movieTitles100.txt");

            string[] movies = File.ReadAllLines(FilePath);
            Array.Sort(movies); //Text file needs to be in alphebetical order for CompareTo method to function properly.

            Stopwatch timerBinary = Stopwatch.StartNew();
            int result = BinarySearch(movies, input);

            if (result == -1)
            {
                Console.WriteLine($"Could not find {input}");
            }
            else if (result != -1)
            {
                Console.WriteLine($"{input} is at index {result}");
            }
            timerBinary.Stop();
            Console.WriteLine($"Time it took for the Binary Algorithm to find is {timerBinary.Elapsed}");
            timerBinary.Reset();
        }
        static int BinarySearch(string[] movieList, string input)
        {
            int low = 0;
            int high = movieList.Length - 1;

            while (low <= high)
            {
                int mid = low + (high - low) / 2;
                int result = input.CompareTo(movieList[mid]);

                if (result == 0)
                {
                    return mid;
                }
                else if (result > 0)
                {
                    low = mid + 1;
                }
                else if (result < 0)
                {
                    high = mid - 1;
                }
            }
            return -1;
        }
    }
}