using System;
using System.Collections.Generic;
using System.Text;

namespace Lecture.Farming
{
    class Pig : FarmAnimal,ISingable, ISellable
    {
        public Pig():base("Pig", "oink")
        {
        }

        //Properties
        public decimal Price { get; } = 5.00M;
    }
}
