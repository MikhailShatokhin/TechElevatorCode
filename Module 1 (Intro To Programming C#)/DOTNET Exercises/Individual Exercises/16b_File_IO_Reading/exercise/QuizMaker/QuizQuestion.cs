using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace QuizMaker
{
    public class QuizQuestion
    {
        public static void Main()
        {
            //Ask User for file path
            Console.WriteLine("Enter the fully qualified name of the file to read in for quiz questions");
            //string fullPath = Console.ReadLine();
            string directory = @"C:\Users\Student\source\repos\individual\mikhail-shatokhin-student-code\module-1\16b_File_IO_Reading\exercise";
            string filename = "sample-quiz-file.txt";
            string fullPath = Path.Combine(directory, filename);

            List<string> quizQuestions = new List<string>();

            using (StreamReader sr = new StreamReader(fullPath))
            {

                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    string[] questions = line.Split('|');
                    for (int i = 0; i < questions.Length; i++)
                    {
                        questions[i] = questions[i].Replace("*", string.Empty);
                    }
                    quizQuestions.AddRange(questions);
                }
            }
            for (int i = 0; i < quizQuestions.Count; i += 5)
            {
                Console.WriteLine(quizQuestions[0 + i]);
                Console.WriteLine("1. " + quizQuestions[1 + i]);
                Console.WriteLine("2. " + quizQuestions[2 + i]);
                Console.WriteLine("3. " + quizQuestions[3 + i]);
                Console.WriteLine("4. " + quizQuestions[4 + i]);
                Console.WriteLine();

                int count = 0;
                if (i == 0)
                {
                    Console.Write("Your answer: ");
                    string answer = Console.ReadLine();
                    if (answer == "2")
                    {
                        Console.WriteLine("RIGHT!");
                        count++;
                    }
                    else
                    {
                        Console.WriteLine("WRONG!");
                    }
                    Console.WriteLine();
                }
                else
                {
                    Console.Write("Your answer: ");
                    string answer2 = Console.ReadLine();
                    if (answer2 == "1")
                    {
                        Console.WriteLine("RIGHT!");
                        count++;
                        if(count==0)
                        {
                            Console.WriteLine();
                            Console.WriteLine("You got 0 anser(s) correct out of the 2 questions asked.");
                        }
                        else if(count==1)
                        {
                            Console.WriteLine();
                            Console.WriteLine("You got 1 anser(s) correct out of the 2 questions asked.");
                        }
                        else
                        {
                            Console.WriteLine();
                            Console.WriteLine("You got 2 anser(s) correct out of the 2 questions asked.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("WRONG!");
                        
                    }
                }
                
            }
            
        }
    }
} 

