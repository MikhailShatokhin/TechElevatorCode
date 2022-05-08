namespace BankTellerExercise.Classes
{
    public class SavingsAccount : BankAccount
    {
        //Constructors
        public SavingsAccount(string accountHolderName, string accountNumber, decimal balance) : base(accountHolderName, accountNumber, balance)
        {

        }

        //Properties

        //Methods
        public override decimal Withdraw(decimal amountToWithdraw)
        {
            if (amountToWithdraw > Balance)
            {
                return Balance;
            }
            else if (amountToWithdraw+2>Balance)
            {
                return Balance;
            }
            else if (Balance - amountToWithdraw < 150)
            {
                base.Withdraw(amountToWithdraw + 2);
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
