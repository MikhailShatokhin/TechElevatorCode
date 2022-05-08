using System;

namespace LinearConvert
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter the length: ");
            string length = Console.ReadLine();

            Console.Write("Is the measurement in (m)eter, or (f)eet? ");
            string lengthType = Console.ReadLine();

            double mToF = double.Parse(length);
            double fToM = double.Parse(length);

            if (lengthType == "m")
            {
                mToF = (int)(mToF * 3.2808399);
                Console.WriteLine(length + lengthType + " is " + mToF + "f.");
            }
            else if (lengthType == "f")
            {
                fToM = (int)(fToM * 0.3048);
                Console.WriteLine(length + lengthType + " is " + fToM + "m.");
            }
            
        }
    }
}
