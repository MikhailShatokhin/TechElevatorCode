using Assessment.Models;
using System;


namespace Assessment
{
    public class Program
    {
        static void Main(string[] args)
        {
            // create an object and call methods on it
            WorkOrder test = new WorkOrder("Fred", 10, 10);

            // (manual testing) from this class.
            Console.WriteLine(test.ActualTotal(true,true));

            

        }
        //Constructor
        //public Program(string name, int length, int width) : base("Fred", 10, 10)
        //{
            
        //}

        ////Properties
        

        ////Methods
        //public override string ToString()
        //{
        //    return $"WORK ORDER - {Name} - ${EstimatedTotal}";
        //}
    }
}


