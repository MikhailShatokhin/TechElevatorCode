using System;
using System.IO;

namespace FizzWriter
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //1. Ask the user for the file destination location
            Console.WriteLine("Where is the destination file? ");
            string fullPathDest = Console.ReadLine();

            ////2. Ask the user for a number between 1-300
            //Console.WriteLine("Select a number between (1-300): ");
            //int fizzBuzz = int.Parse(Console.ReadLine());

            try
            {
                using (StreamWriter sw = new StreamWriter(fullPathDest))
                {
                    for (int fizzBuzz=1; fizzBuzz<=300; fizzBuzz++)
                    {
                        if(fizzBuzz%3==0 && fizzBuzz%5==0)
                        {
                            sw.WriteLine("FizzBuzz");
                        }
                        else if(fizzBuzz%3==0)
                        {
                            sw.WriteLine("Fizz");
                        }
                        else if(fizzBuzz%5==0)
                        {
                            sw.WriteLine("Buzz");
                        }
                        else
                        {
                            sw.WriteLine(fizzBuzz.ToString());
                        }
                    }
                }
                //for (int fizzBuzz=1; fizzBuzz<=300; fizzBuzz++)
                //{
                //    using (StreamWriter sw = new StreamWriter(fullPathDest, fizzBuzz % 3 == 0 && fizzBuzz % 5 == 0))
                //    {
                //        sw.WriteLine("FizzBuzz");
                //    }
                //    using (StreamWriter sw = new StreamWriter(fullPathDest, fizzBuzz % 3 == 0))
                //    {
                //        sw.WriteLine("Fizz");
                //    }
                //    using (StreamWriter sw = new StreamWriter(fullPathDest, fizzBuzz % 5 == 0))
                //    {
                //        sw.WriteLine("Buzz");
                //    }
                //    using (StreamWriter sw = new StreamWriter(fullPathDest,true))
                //    {
                //        sw.WriteLine(fizzBuzz);
                //    }
                //}
            }
            catch (IOException ex)
            {
                Console.WriteLine("An Exception occured: " + ex.Message);
            }
        }
    }
}

            


