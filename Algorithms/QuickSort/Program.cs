using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Threading;

namespace QuickSort
{
    class QuickSort
    {
        private CatalogueItem[] items;
        private int number;

        public void Sort(CatalogueItem[] values)
        {
            // check for empty or null array
            if (values == null || values.Length == 0)
            {
                return;
            }
            items = values;
            number = values.Length;
            Quicksort(0, number - 1);
        }

        private void Quicksort(int low, int high)
        {
            int i = low, j = high;
            // Get the pivot element from the middle of the list
            int pivot = items[low + (high - low) / 2].Id;

            // Divide into two lists
            while (i <= j)
            {
                // If the current value from the left list is smaller than the pivot
                // element then get the next element from the left list
                while (items[i].Id < pivot)
                {
                    i++;
                }
                // If the current value from the right list is larger than the pivot
                // element then get the next element from the right list
                while (items[j].Id > pivot)
                {
                    j--;
                }

                // If we have found a value in the left list which is larger than
                // the pivot element and if we have found a value in the right list
                // which is smaller than the pivot element then we exchange the
                // values.
                // As we are done we can increase i and j
                if (i <= j)
                {
                    Exchange(i, j);
                    i++;
                    j--;
                }
            }
            // Recursion
            if (low < j)
                Quicksort(low, j);
            if (i < high)
                Quicksort(i, high);
        }

        private void Exchange(int i, int j)
        {
            CatalogueItem temp = items[i];
            items[i] = items[j];
            items[j] = temp;
        }


        /* Prints the array */
        void PrintArray(CatalogueItem[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n; ++i)
                Console.WriteLine(
                        "id: " + arr[i].Id + " "
                        + "name: " + arr[i].ItemName + " "
                        + "category: " + arr[i].Category + "\n");
            Console.WriteLine();

        }

        static void Main(string[] args)
        {
            QuickSort ob = new QuickSort();

            CatalogueItem[] arr = {
            new CatalogueItem( 3, "Life of Pi","Books"),
            new CatalogueItem( 7, "Deelongie 4 way toaster","Home and Kitchen"),
            new CatalogueItem( 2, "Glorbarl knife set","Home and Kitchen"),
            new CatalogueItem( 4, "Diesorn vacuum cleaner","Appliances"),
            new CatalogueItem( 5, "Jennie Olivier sauce pan","Home and Kitchen"),
            new CatalogueItem( 6, "This book will save your life","Books"),
            new CatalogueItem( 9, "Kemwould hand mixer","Appliances"),
            new CatalogueItem( 1, "Java for Dummies","Books"),
        };
            Console.WriteLine("The Unsorted array is: \r\n");
            ob.PrintArray(arr);

            Stopwatch timer = new Stopwatch(); // new timer

            //apply sort
            timer.Start();
            ob.Sort(arr);
            timer.Stop();
            Console.WriteLine("The Quick Sorted array is: \r\n");
            ob.PrintArray(arr);
            Console.WriteLine($"The Quick sort algorithm took {timer.Elapsed} when it was not sorted."); //Was faster without Thread.sleep on my laptop
            timer.Reset();
            

            Console.WriteLine("\nThe Quick Sorted of the already sorted array is:\n");
            timer.Start();
            ob.Sort(arr);
            timer.Stop();
            ob.PrintArray(arr);
            Console.WriteLine($"The algorithm took {timer.Elapsed} when it was already sorted.");
            timer.Reset();
            Console.Read();
            /*The algorithm was run 10 times and the average times for the algorithm to sort the array was 0.000337 milliseconds (ms)
             and it takes 0.00000341 ms when the array is already sorted.
            The first run is average case for the algorithm as some of middles and numbers in the partitions need to be rearranged as some
            will be lower than the pivots while some will be higher than the pivots.
            This is much faster and is expected to be as this is the best case scenario for the algorithm
            as the middles of the array are already in their correct positions and are all lower than the pivots
            so it only has to check the positions and seperate the array into partitions but never actually has to make any changes.
            This algorithm has a time complexity of O(Log)n on average and best case with O(N) squared as the worst case scenario.*/
        }
    }
}