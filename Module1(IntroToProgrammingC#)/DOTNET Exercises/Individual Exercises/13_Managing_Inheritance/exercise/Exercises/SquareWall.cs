﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises
{
        public class SquareWall : RectangleWall
    {
        //Constructors
        public SquareWall(string name, string color, int sideLength) : base(name,color,sideLength,sideLength)
        {
            SideLength = sideLength;
        }
       

        //Properties
        public int SideLength { get; }


        //Methods
        public override int GetArea()
        {
            return SideLength * SideLength;
        }
        public override string ToString()
        {
            return $"{Name} ({SideLength}x{SideLength}) square";
        }
    }
}
