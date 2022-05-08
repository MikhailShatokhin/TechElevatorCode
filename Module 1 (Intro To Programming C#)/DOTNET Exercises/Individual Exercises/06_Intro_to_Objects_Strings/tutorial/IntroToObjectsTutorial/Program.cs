using System;

namespace IntroToObjectsTutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            // ***********  Step 1: Use the *new* operator to create strings on the Heap  *************
            char[] helloChars = new char[] { 'h', 'e', 'l', 'l', 'o', '!' };
            string greeting = new string(helloChars);
            Console.WriteLine("Greeting: " + greeting);

            // ***********  Step 2: Try out some string methods  *************

            string salutation = new string("Welcome my friend");
            Console.WriteLine("Salutation: " + salutation);

            string toast = "May the compiler rise up to meet you.";
            Console.WriteLine("Toast: " + toast);

            Console.Write("Please type a sentence: ");
            string sentence = Console.ReadLine();

            Console.WriteLine(sentence);

            // Print the sentence in all upper-case
            string uppercaseSentence = sentence.ToUpper();
            Console.WriteLine(uppercaseSentence);

            // Print the sentence in all lower-case
            Console.WriteLine(sentence.ToLower());

            // Find the first space character
            int firstSpace = sentence.IndexOf(" ");
            // Report the length of the first word
            if (firstSpace == -1)
            {
                // IndexOf returns -1 when the string is not found.
                // If there is no space, assume the whole sentence is one word.
                Console.WriteLine("The first word is " + sentence.Length + " characters long.");
            }
            else
            {
                // Report the length of the first word
                Console.WriteLine("The first word is " + firstSpace + " characters long.");
            }
            // Replace the word "the" with "the one and only"
            Console.WriteLine(sentence.Replace("the", "the one and only"));

            // list the words (split)
            string[] words = sentence.Split(" ");
            Console.WriteLine("The words in this sentence:");
            foreach (string word in words)
            {
                Console.WriteLine(word);
            }

            // Re-assemble the sentence with a new delimiter
            string dashSentence = String.Join("-->", words);
            Console.WriteLine(dashSentence);

            // Print the initial sentence. Notice it has not changed.
            Console.WriteLine(sentence);
        }
    }
}
