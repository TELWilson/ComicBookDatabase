﻿using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;

namespace BankTellerExercise.Classes
{
    public class SavingsAccount : BankAccount
    {
        public SavingsAccount(string accountHolderName, string accountNumber) : base(accountHolderName, accountNumber)
        {

        }

        public SavingsAccount(string accountHolderName, string accountNumber, decimal balance) : base(accountHolderName, accountNumber, balance)
        {

        }
        public override decimal Withdraw(decimal amountToWithdraw)
        {
            if (Balance - amountToWithdraw < 150 && Balance - amountToWithdraw > 0)
            {
                base.Withdraw(amountToWithdraw + 2);
                    return Balance;
            }
            else if (amountToWithdraw >= Balance)
            {
                return Balance;
            }
            else
            {
                base.Withdraw(amountToWithdraw);
                return Balance;
            }
            
        }
    }
}
