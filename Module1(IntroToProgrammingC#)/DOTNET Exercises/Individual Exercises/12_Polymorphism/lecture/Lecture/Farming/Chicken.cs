using System;

namespace Lecture.Farming
{
    public class Chicken : FarmAnimal, ISingable, ISellable
    {
        //Constructors
        public Chicken() : base("Chicken", "cluck")
        {
        }

        //Properties
        public decimal Price { get; } = 5.00M;

        //Methods
        public void LayEgg()
        {
            Console.WriteLine("Chicken laid an egg!");
        }
    }
}
