using System;
using System.Collections.Generic;
using System.Text;

namespace PetInfo
{
    public class UserInterface
    {
        public void Run()
        {
            Console.WriteLine("Welcome to Pet Info.");

            Pet dog = new Pet();
            dog.petName = "Bella";
            dog.PetType = "dog";
            dog.PetAge = 5;
            //dog.PetColor = "black"; not allowed since set is private
            dog.PetEyeColor = "Brown";  
            
            Pet dog2 = new Pet();
            dog2.petName = "Yoshi";
            dog2.SetColor("Black");

            Pet dog3 = new Pet();


            //Console.WriteLine(dog.petName + " " + dog.PetType + " " + dog.PetAge + " " + dog.PetColor);
            //Console.WriteLine(dog2.petName + " " + dog2.PetType + " " + dog2.PetAge + " " + dog2.PetColor);
            //Console.WriteLine(dog3.petName);

            Console.WriteLine(dog.DisplayInfo());
            Console.WriteLine(dog2.DisplayInfo());
            Console.WriteLine(dog3.DisplayInfo());

            Console.ReadLine();

            return;
        }
        
    }
}
