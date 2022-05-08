using System;
using System.Collections.Generic;
using System.Text;


namespace Assessment.Models
{
    public class WorkOrder
    {
        //Constructors
        public WorkOrder(string name, int length, int width)
        {
            Name = name;
            Length = length;
            Width = width;
        }

        //Properties
        public string Name { get; private set; }
        public int Length { get; }
        public int Width { get; }
        public double EstimatedTotal 
        { 
            get
            {
                return (Length*Width)*cost;
            }
        }

        //Variables
        double cost = 4.99/100;
        double rushFee = 16.98;
        double icyFee = 24.75;
        double dubRushFee = 16.98 * 2;

        //Methods
        public virtual double ActualTotal(bool icy,bool rush)
        {
            if(rush && icy)
            {
                return EstimatedTotal+dubRushFee;
            }
            else if(rush)
            {
                return EstimatedTotal + rushFee;
            }
            else if(icy)
            {
                return EstimatedTotal + icyFee;
            }
            return EstimatedTotal;
        }
        public override string ToString()
        {
            return $"WORK ORDER - {Name} - ${EstimatedTotal}";
        }





    }
}
