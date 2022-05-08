using System;
using System.Collections.Generic;
using System.Text;

namespace BankTellerExercise
{
    class BankCustomer : IAccountable
    {
        //Constructors

        //Properties
        public string Name { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public bool IsVip
        {
            get
            {
                decimal total = 0.00M;
                //if(accounts.Count==3 && Balance < 25000.00M)
                //{
                //    return false;
                //}
                //else if(accounts.Count==2 && Balance < 25000.00M)
                //{
                //    return false;
                //}
                //else if(accounts.Count==1 && Balance < 25000.00M)
                //{
                //    return false;
                //}
                //else if (accounts.Count == 0 && Balance < 25000.00M)
                //{
                //    return false;
                //}
                //else
                //{
                //    return true;
                //}

                //{
                //    return true;
                //}
                
                foreach (IAccountable item in accounts)
                {
                    if (item.Balance < 25000.00M)
                    {
                        total += item.Balance;
                    }
                }
                foreach (IAccountable item in accounts)
                {
                    if (item.Balance >= 25000.00M)
                    {
                        return true;
                    }
                }
                if (total >= 25000.00M)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

        }
        public decimal Balance { get; }

        //Variables
        private List<IAccountable> accounts = new List<IAccountable>();
        
        

        //Methods
        public void AddAccount(IAccountable newAccount)
        {
                accounts.Add(newAccount);
        }
        public IAccountable[] GetAccounts()
        {
            return accounts.ToArray();
        }
    }
}
