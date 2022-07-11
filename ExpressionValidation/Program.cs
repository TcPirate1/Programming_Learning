using System;
using System.Collections.Generic;

namespace ExpressionValidation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Net 5.0

            /*Analysis of the data structure: Was it suitable? Yes
             *It is suitable because the expression can be added to the Stack and evaluated against its index.
             *Is there another data structures that can be used?
             *A Generic List could of also been used to complete this task as they can also be indexed
             *so the expression's index could of been used as well.
             *A Queue however cannot be indexed. It would be able to do the other functions of the task but without
             *the ability to be indexed it is difficult to use a Queue to evaluate whether there is an equal amount of brackets
             *in the expression.
             */

            Console.WriteLine("Welcome to the expression validating program.\n\nEnter your expression:");
            string expression = Console.ReadLine();

            Stack<int> expressionvalidation = new ();

            Console.WriteLine("Enter the opening character to validate:");
            char bracket = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("Enter closing character to validate:");
            char closingbracket = Convert.ToChar(Console.ReadLine());

            int checker = 0;
            for (int i = 0; i < expression.Length; i++)
            {
                if (expression[i] == bracket)
                {
                    expressionvalidation.Push(i);
                    checker++;
                }
                if (expression[i] == closingbracket)
                {
                    if (expressionvalidation.Count < 0)
                    {
                        expressionvalidation.Pop();
                        checker--;
                    }
                }
            }
            if (checker == 0)
            {
                Console.WriteLine("Result: Correct");
            }
            else if (checker != 0)
            {
                Console.WriteLine("Result: Incorrect");
            }
            Console.WriteLine("The expression is validated");
        }
    }
}