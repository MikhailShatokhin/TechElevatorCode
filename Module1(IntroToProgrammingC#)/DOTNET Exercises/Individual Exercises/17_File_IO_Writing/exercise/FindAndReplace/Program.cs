using System;
using System.IO;
namespace FindAndReplace
{
    public class Program
    {
		public static void Main(string[] args)
		{

            //1. Ask the user for the search string
            Console.WriteLine("What is the search word?");
            string search = Console.ReadLine();

            //2. Ask the user for the replace word string
            Console.WriteLine("What is the replacement word?");
            string replace = Console.ReadLine();

            //3. Ask the user for the file Original location
            Console.WriteLine("What is the source file?");
            string fullPathOrig = Console.ReadLine();

            //4. Ask the user for the file destination location
            Console.WriteLine("What is the source file?");
            string fullPathDest = Console.ReadLine();

            //5. Open the file
            //6. Loop through each line in the file
            //7. If the line contains the search string, print it out and then replace it in the destination file
            try
            {
                using (StreamReader sr = new StreamReader(fullPathOrig))
                {
                    using (StreamWriter sw = new StreamWriter(fullPathDest))
                    {
                        while (!sr.EndOfStream)
                        {
                            string line = sr.ReadLine();
                            if (line.Contains(search))
                            {
                                line = line.Replace(search, replace);
                            }

                            sw.WriteLine(line);
                        }
                    }
                }
            }
            catch (IOException)
            {
                Console.WriteLine("Error reading the file");
            }
        }
    }
  }

