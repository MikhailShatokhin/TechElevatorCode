using System;

namespace TempConvert
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter the temperature: ");
            string temp = Console.ReadLine();
            
            Console.Write("Is the temperature in (C)elsius, or (F)ahrenheit? ");
            string tempType = Console.ReadLine();

            int tempCToF = int.Parse(temp);
            int tempFToC = int.Parse(temp);
            if (tempType=="C")
            {
                tempCToF = (int)(tempCToF * (1.8 + 32));
                Console.WriteLine(temp + tempType + " is " + tempCToF + "F.");
            }
            else if (tempType=="F")
            {
                tempFToC = (int)((tempFToC-32)/1.8);
                Console.WriteLine(temp + tempType + " is " + tempFToC + "C.");
            }
            

            //Console.Write(temp + tempType + " is " + tempConv)
        }
    }
}
