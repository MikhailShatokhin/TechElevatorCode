using System;
using System.Collections.Generic;
using System.Text;
using PetElevator.Shared;

namespace PetElevator.CRM
{
    public class Customer : Person
    {
        // Constructors

        public Customer(string firstName, string lastName, string phoneNumber) : base(firstName, lastName)
        {
            PhoneNumber = phoneNumber;
        }

        public Customer(string firstName, string lastName) : base(firstName, lastName)
        {

        }


        // Properties

        public string PhoneNumber { get; set; }
        public List<Pet> Pets { get; set; } = new List<Pet>();

        public override double GetBalanceDue(Dictionary<string, double> servicesRendered)
        {
            double balanceDue = 0;
            foreach (KeyValuePair<string, double> item in servicesRendered)
            {
                balanceDue += item.Value;
            }
            return balanceDue;

        }
    }
}
