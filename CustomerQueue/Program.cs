using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace TicketingSystem
{
    class Program
    {
        static void Main(string[] args)
        {   //Net 5.0

            /* Was this data structure suitable for the task? Yes
             *The queue was suitable because we are removing items from the beginning of the collection of elements and
             *can simulate a Queue.
             *Is there another data structures that could be used?
             *A Generic List could have of also been used as you could just remove the element at the start of the List
             *to mimick a Queue.
             *A Stack could also be used but the order of customers would be reversed from what would happen in a Queue.
             *This could result in confusion and data may be incorrectly inputted in or removed.
             */

            Queue<int> Customer = new();

            Timer tmrTimersTimer = new Timer();
            tmrTimersTimer.Interval = 5000; //set the interval to 5 seconds
            tmrTimersTimer.Elapsed += new ElapsedEventHandler(TmrTimersTimer_Elapsed); //run the code in the tmrTimersTimer_Elapsed every 5 seconds until keypress
            tmrTimersTimer.Start();

            Timer newTimer = new Timer();
            newTimer.Interval = 3000; //New Customer every 3 secs
            newTimer.Elapsed += delegate { NewCustomer(Customer); };
            newTimer.Start();
            Console.Read();
        }
        private static void TmrTimersTimer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            Console.WriteLine("\nStore open! Sales Assistant is ready to see the next customer.");
            //the rest of the code to disply the next customer in line, what number ticket is next and list all customers in a queue
        }
        private static Queue<int> NewCustomer(Queue<int> Customer)
        {
            while (Customer.Count == 0)
            {
                Console.WriteLine("There are no customers to see");
                Customer.Enqueue(1); //Needs to be in here otherwise an infinite loop is created
            }
            if (Customer.Count < 4)
            {
                Console.WriteLine("\nCustomer with ticket 1 is added to the queue");
                Customer.Enqueue(2);
                Console.WriteLine("\nCustomer with ticket 2 is added to the queue");
                Customer.Enqueue(3);
                Console.WriteLine("\nCustomer with ticket 3 is added to the queue");
                Customer.Enqueue(4);
            }
            Console.WriteLine("\nCustomer 1 has been seen by the Sales Assistant");
            Customer.Dequeue();
            ShowQueue(Customer); //Shows the queue

            Console.WriteLine("\nCustomer 2 has been seen by the Sales Assistant");
            Customer.Dequeue();
            ShowQueue(Customer);

            Console.WriteLine("\nCustomer 3 has been seen by the Sales Assistant");
            Customer.Dequeue();
            ShowQueue(Customer);

            Console.WriteLine("\nCustomer 4 has been seen by the Sales Assistant");
            Customer.Dequeue();
            ShowQueue(Customer);

            if (Customer.Count == 0)
            {
                Console.WriteLine("\nThere are no customers in the queue.");
            }
            return Customer;
        }
        private static Queue<int> ShowQueue(Queue<int>Customer)
        {
            foreach (int item in Customer)
            {
                Console.WriteLine($"Customer ticket number in the queue: [{item}]");
            }
            return Customer;
        }
    }
}