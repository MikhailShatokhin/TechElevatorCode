namespace BankTellerExercise.Classes
{
    public class CheckingAccount : BankAccount
    {
        //Constructors
        public CheckingAccount(string accountHolderName, string accountNumber, decimal balance) : base(accountHolderName, accountNumber, balance)
        {
            
        }

        //Properties

        //Methods
        public override decimal Withdraw(decimal amountToWithdraw)
        {
            if (Balance - amountToWithdraw <= -100)
            {
                return Balance;
            }
            else if (Balance < 0 && Balance >= -100)
            {
                base.Withdraw(amountToWithdraw+10);
                return Balance;
            }
            else
            {
                base.Withdraw(amountToWithdraw);
            }
            return Balance;
        }
    }
}
