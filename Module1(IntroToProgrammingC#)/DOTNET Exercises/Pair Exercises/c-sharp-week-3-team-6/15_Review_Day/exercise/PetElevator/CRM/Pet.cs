using System;
using System.Collections.Generic;
using System.Text;

namespace PetElevator.CRM
{
    public class Pet
    {
        //Constructors
        public Pet(string petName, string species)
        {
            PetName = petName;
            Species = species;
        }

        //Properties
        public string PetName { get; set; }
        public string Species { get; set; }
        public List<string> Vaccinations { get; set; } = new List<string>();

        //Methods
        public string ListVaccinations()
        {
            string petVacs = string.Join(", ", Vaccinations.ToArray());

            return petVacs;
        }

    }
}
