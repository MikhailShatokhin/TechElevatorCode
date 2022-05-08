using System;
using System.Collections.Generic;
using System.Text;

namespace Lecture.Farming
{
    internal class Cat : FarmAnimal
    {
        public Cat() : base("Cat", "meow")
        {
        }
        public override string Eat()
        {
            return "Eating cat food...";
        }

        public sealed override string Sound
        {
            get
            {
                return "Meow";
            }
        }
    }
}
