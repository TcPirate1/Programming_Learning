using System;
using System.Collections.Generic;
using System.Text;

namespace IT6033_Practical2_Dongxu_Terence_Chen_
{
    internal class Customer
    {
        private string name;
        private int rating;
        private string address;

        public string GetName()
        {
            return name;
        }
        public int GetRating()
        {
            return rating;
        }
        public string GetAddress()
        {
            return address;
        }

        public Customer(string N, int R, string A)
        {
            name = N;
            rating = R;
            address = A;
        }
    }
}
