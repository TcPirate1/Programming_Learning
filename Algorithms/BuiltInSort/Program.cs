using System;
using System.Diagnostics;

namespace BuiltInSort
{
    class BuiltInSort
    {
        void PrintArray(CatalogueItem[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n; ++i)
                Console.WriteLine(
                        "Id: " + arr[i].Id + ", "
                        + "Name: " + arr[i].ItemName + ", "
                        + "Category: " + arr[i].Category);
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            BuiltInSort ob = new BuiltInSort();

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
            Console.WriteLine("The Unsorted array is\r\n");
            ob.PrintArray(arr);

            //apply sort
            Stopwatch time = new Stopwatch();
            Console.WriteLine("The array sorted by category using C# built in sort is:\r\n");
            time.Start();
            Array.Sort(arr, new CatalogueItem());
            time.Stop();
            ob.PrintArray(arr);
            Console.WriteLine($"It took {time.Elapsed}");
            Console.Read();
        }
    }
}
