using System;
using System.IO;

namespace WordSearch
{
    public class Program
    {
        public static void Main(string[] args)
        {
            
            //1. Ask the user for the file path
            Console.WriteLine("What is the fully qualified name of the file that should be searched?");
            string fullPath = Console.ReadLine();

            //string directory = @"C:\Users\Student\source\repos\individual\mikhail-shatokhin-student-code\module-1\16b_File_IO_Reading\exercise\WordSearch.Tests";
            //string filename = "dr_jekyll_mr_hyde.txt";
            //string fullPath = Path.Combine(directory, filename);

            //2. Ask the user for the search string
            Console.WriteLine("What is the search word you are looking for?");
            string search = Console.ReadLine();

            // Ask user if the search is case sensitive
            Console.WriteLine(@"Should the search be case sensitive? (Y\N)");
            string yesNo = Console.ReadLine();

            //3. Open the file
            //4. Loop through each line in the file
            //5. If the line contains the search string, print it out along with its line number
            try
            {
                using (StreamReader sr = new StreamReader(fullPath))
                {
                    if(yesNo == "y" || yesNo == "Y")
                    {
                        int count = 0;
                        while (!sr.EndOfStream)
                        {
                            count++;
                            string line = sr.ReadLine();
                            if (line.Contains(search))
                            {
                                
                                Console.WriteLine($"{count}) {line}");
                            }
                        }
                    }
                    else
                    {
                        int count = 0;
                        while (!sr.EndOfStream)
                        {
                            count++;
                            string line = sr.ReadLine();
                            if (line.IndexOf(search, StringComparison.InvariantCultureIgnoreCase) != -1)
                            {
                                Console.WriteLine($"{count}) {line}");
                            }
                        }
                    }
                    
                }
            }
            
            catch(IOException)
            {
                Console.WriteLine("Error reading the file");
            }
        }
    }
}
