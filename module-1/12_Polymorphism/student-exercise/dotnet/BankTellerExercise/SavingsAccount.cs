using System;
using System.Collections.Generic;
using System.Text;

namespace BankTellerExercise
{
    public class SavingsAccount : BankAccount
    {
        public SavingsAccount(string accountHolder, string accountNumber) : base(accountHolder, accountNumber)
        {

        }

        public SavingsAccount(string accountHolder, string accountNumber, int balance) : base(accountHolder, accountNumber, balance)
        {

        }

        public override int Withdraw(int amountToWithdraw)
        {
            // only perform transaction of positive $ and room for fee
            if (Balance - amountToWithdraw >= 2)
            {
                base.Withdraw(amountToWithdraw);
                // Assess $2 fee if it goes below $150
                if (Balance < 150)
                {
                    base.Withdraw(2);
                }
            }
            return Balance;
        }

        //public override int TransferTo (BankAccount destinationAccount, int transferAmount)
        //{
        //     base.Deposit(Balance + transferAmount);
        //    return Balance;
        //}
    }
}
