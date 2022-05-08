using System;
using System.IO;

namespace FileSplitter
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Where is the input file (please include the path to the file)? [path-to-file]/input.txt
            //Console.WriteLine("Where is the input file (please include the path to the file)? ");
            string fullPathOrig = Console.ReadLine();
            //string fullPathOrig = @"C:\Users\Student\source\repos\individual\mikhail-shatokhin-student-code\module-1\17_File_IO_Writing\exercise\FileSplitter\input.txt";

            //2. How many lines of text (max) should there be in the split files? 3
            Console.WriteLine("How many lines of text (max) should there be in the split files? ");
            double maxLines = int.Parse(Console.ReadLine());

            //3. The input file has "maxLines" lines of text
            double fileLineCount = 50;
            Console.WriteLine($"The input file has {fileLineCount} lines of text.");
            Console.WriteLine();

            //4. File count calc
            double fileCount = Math.Ceiling(fileLineCount/maxLines);

            //5.Each file that is created must have a sequential number assigned to it.
            Console.WriteLine("Each file that is created must have a sequential number assigned to it.");
            Console.WriteLine();

            //6. For a 50 line input file "input.txt", this produces 17 output files.
            Console.WriteLine(@$"For a {fileLineCount} line input file input.txt, this produces {fileCount} output files.");
            Console.WriteLine();

            //7. **GENERATING OUTPUT**
            Console.WriteLine("**GENERATING OUTPUT**");
            Console.WriteLine();

            //8. Output Directory Location
            string fullPathDest = @"C:\Users\Student\source\repos\individual\mikhail-shatokhin-student-code\module-1\17_File_IO_Writing\exercise\FileSplitter";

            try
            {
                using (StreamReader sr = new StreamReader(fullPathOrig))
                {
                    
                    for (int x = 1; x <= (fileCount); x++)
                        {
                        
                        using (StreamWriter sw = new StreamWriter(@$"{fullPathDest}\input-{x}.txt"))
                            {
                            
                            for (int i = 1; i <= maxLines; i++)
                                {
                                string line = sr.ReadLine();
                                sw.WriteLine(line);
                                }
                            }
                            Console.WriteLine(@$"Generating input-{x}.txt");
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
