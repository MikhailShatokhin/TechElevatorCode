using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises
{
    public abstract class Wall
    {
        //Constructors
        public Wall(string name, string color)
        {
            Name = name;
            Color = color;
        }
        

        //Properties
        public string Name { get; }
        public string Color { get; }
        

        //Methods
        public abstract int GetArea();
        
        

    }
}
