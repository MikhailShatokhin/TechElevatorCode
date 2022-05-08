using System;
using System.Collections.Generic;

namespace Exercises
{
    public partial class Exercises
    {
        /*
         * Given the name of an animal, return the name of a group of that animal
         * (e.g. "Elephant" -> "Herd", "Rhino" - "Crash").
         *
         * The animal name should be case insensitive so "elephant", "Elephant", and
         * "ELEPHANT" should all return "herd".
         *
         * If the name of the animal is not found, null, or empty, return "unknown".
         *
         * Rhino -> Crash
         * Giraffe -> Tower
         * Elephant -> Herd
         * Lion -> Pride
         * Crow -> Murder
         * Pigeon -> Kit
         * Flamingo -> Pat
         * Deer -> Herd
         * Dog -> Pack
         * Crocodile -> Float
         *
         * AnimalGroupName("giraffe") → "Tower"
         * AnimalGroupName("") -> "unknown"
         * AnimalGroupName("walrus") -> "unknown"
         * AnimalGroupName("Rhino") -> "Crash"
         * AnimalGroupName("rhino") -> "Crash"
         * AnimalGroupName("elephants") -> "unknown"
         *
         */
        public string AnimalGroupName(string animalName)
        {
            if (animalName == null)
            {
                return "unknown";
            }
            else
            {
                string animal = animalName.ToLower();

                Dictionary<string, string> groupName = new Dictionary<string, string>();

                //groupName["rhino"]= "Crash";
                //groupName["giraffe"] = "Tower";
                //groupName["elephant"] = "Herd";
                //groupName["lion"] = "Pride";
                //groupName["crow"] = "Murder";
                //groupName["pigeon"] = "Kit";
                //groupName["flamingo"] = "Pat";
                //groupName["deer"] = "Herd";
                //groupName["dog"] = "Pack";
                //groupName["crocodile"] = "Float";

                groupName.Add("rhino", "Crash");
                groupName.Add("giraffe", "Tower");
                groupName.Add("elephant", "Herd");
                groupName.Add("lion", "Pride");
                groupName.Add("crow", "Murder");
                groupName.Add("pigeon", "Kit");
                groupName.Add("flamingo", "Pat");
                groupName.Add("deer", "Herd");
                groupName.Add("dog", "Pack");
                groupName.Add("crocodile", "Float");


                if (!groupName.ContainsKey(animal))
                {
                    return "unknown";
                }
                else
                {
                    return groupName[animal];
                }
            }
            

            
        }
    }
}
