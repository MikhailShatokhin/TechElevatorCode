using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises
{
        public class RectangleWall : Wall
    {
        //Constructors
        public RectangleWall(string name, string color, int length, int height) : base(name, color)
        {
            Length = length;
            Height = height;
        }
        //public RectangleWall(string name, string color) : base(name, color)
        //{
           
        //}


        //Properties
        public virtual int Length { get; }
        public virtual int Height { get; }

        //Methods
        public override int GetArea()
        {
            return Length * Height;
        }
        public override string ToString()
        {
            return $"{Name} ({Length}x{Height}) rectangle";
        }
    }
}
