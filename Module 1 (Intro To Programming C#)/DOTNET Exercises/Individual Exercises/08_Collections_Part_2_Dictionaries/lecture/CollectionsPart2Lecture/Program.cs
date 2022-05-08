using System;
using System.Collections.Generic;

namespace CollectionsPart2Lecture
{
    public class CollectionsPart2Lecture
	{
        static void Main(string[] args)
        {
			Console.WriteLine("####################");
			Console.WriteLine("       DICTIONARIES");
			Console.WriteLine("####################");
			Console.WriteLine();

			//create dictionary

			Dictionary<string, string> pets = new Dictionary<string, string>();

			pets.Add("Bella", "dog");
			pets["Primrose"] = "cat";
			pets["Gabriel"] = "cat";
			pets["Penny"] = "cat";
			pets["fish1"] = "fish";
			pets["fish2"] = "fish";

			Console.WriteLine(pets["Gabriel"]);

			foreach(string name in pets.Keys)
            {
				Console.WriteLine(name);
            }

			//contains

			if(pets.ContainsKey("fish1"))
            {
				Console.WriteLine("fish1 exists.");
				Console.WriteLine("and is of type " + pets["fish1"]);
            }
			else
            {
				pets["fish1"] = "fish";
				Console.WriteLine("fish1 has been created.");
            }

			bool result = pets.Remove("fish1");
			if(result)
            {
				Console.WriteLine("Removed fish1");
            }
			else
            {
				Console.WriteLine("Did not remove fish1.");
            }
			foreach(string name in pets.Keys)
            {
				Console.WriteLine(name);
            }
			foreach(KeyValuePair<string, string> item in pets)
            {
				Console.WriteLine($"The pet {item.Key} is a {item.Value}.");
            }

			HashSet<string> students = new HashSet<string>();
			students.Add("student1");
			students.Add("student2");
			students.Add("student3");
			students.Add("student1");

			foreach (string student in students)
            {
				Console.WriteLine(student);
            }

			string[] temp = new string[students.Count];
			students.CopyTo(temp);

			List<string> myList = new List<string>();
			myList.AddRange(temp);

			foreach(string student in myList)
            {
				Console.WriteLine(student);
            }
		}
	}
}
