using System;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a number: ");
            string input = Console.ReadLine();
            int fibNums = int.Parse(input);

            if(fibNums<=0)
            {
                Console.WriteLine("0, 1");
            }
            else if(fibNums==1)
            {
                Console.WriteLine("0, 1, 1");
            }
            else
            {
                Console.Write("0, 1, 1");
                int fib = 1;
                int fib2 = 1;

                for(int i=1; i+fib<fibNums; i++)
                {
                    fib2 = i + fib;
                    i = fib;
                    fib = fib2;

                    Console.Write(", "+(fib2 + 1));
                }

                
                }
            }
        }
    }

