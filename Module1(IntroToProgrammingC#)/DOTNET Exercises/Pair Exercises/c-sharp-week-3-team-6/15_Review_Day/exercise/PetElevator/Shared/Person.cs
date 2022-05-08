using System.Collections.Generic;
namespace PetElevator.Shared
{
    public class Person : IBillable
    {
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string Email { get; set; }

        public virtual string FullName
        {
            get
            {
                return $"{FirstName} {LastName}";
            }
        }

        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public virtual double GetBalanceDue(Dictionary<string, double> servicesRendered)
        {
            double balanceDue = 0;
            foreach (KeyValuePair<string,double> item in servicesRendered)
            {
                if(item.Key=="Walking")
                {
                    balanceDue += item.Value / 2;
                }
                
            }
            return balanceDue;
        }
    }
}
