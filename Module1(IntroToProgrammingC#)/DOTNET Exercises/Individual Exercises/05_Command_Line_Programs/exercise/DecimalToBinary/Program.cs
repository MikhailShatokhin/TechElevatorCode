using System;

namespace DecimalToBinary
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter in a series of decimal values (seperated by spaces): ");
            string input = Console.ReadLine();

            string[] decValues = input.Split(" ");

            int from = 10;
            int to = 2;

            for (int i=0; i<decValues.Length; i++)
            {
                string binary = Convert.ToString(Convert.ToInt32(decValues[i], from), to);
                Console.WriteLine(decValues[i] + " in binary is " + binary);
            }

        }
    }
}
