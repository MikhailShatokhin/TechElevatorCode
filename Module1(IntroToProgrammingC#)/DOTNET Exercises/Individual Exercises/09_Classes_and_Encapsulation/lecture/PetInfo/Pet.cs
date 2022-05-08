using System;
using System.Collections.Generic;
using System.Text;

namespace PetInfo
{
    public class Pet
    {
        public Pet()
        {
            Console.WriteLine("Reached constructor.");
        }

        

        public Pet(string petName)
        {
            this.petName = petName;
        }

        public string petName = "Need to assign Dog Name in UserInterface";

        /**
         * This is the intellisense block
         * that shows up
         * */

        public string PetType { get; set; }
        public int PetAge {get; set;}

        public string PetColor { get; private set; } = "Brown";

        public void SetColor (string newColor)
        {
            PetColor = newColor;
            return;
        }

        private string petEyeColor = "";
        public string PetEyeColor
        {
            get
            {
                return petEyeColor;
            }
            set
            {
                if(value=="Black" || value=="Brown")
                {
                    petEyeColor = value;
                }
            }
        }
        public string DisplayInfo()
        {
            return $"{petName} - {PetType} - {PetAge} - {PetColor} - {PetEyeColor}";
        }
    }
}
