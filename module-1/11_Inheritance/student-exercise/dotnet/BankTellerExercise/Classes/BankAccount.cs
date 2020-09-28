using System;
using System.Collections.Generic;
using System.Text;

namespace BankTellerExercise.Classes
{
    public class BankAccount
    {
        
        public BankAccount(string accountHolderName, string accountNumber)
        {
            this.Balance = 0;
            this.AccountHolderName = accountHolderName;
            this.AccountNumber = accountNumber;
        }

        public BankAccount(string accountHolderName, string accountNumber, decimal balance)
        {
            this.AccountNumber = accountNumber;
            this.AccountHolderName = accountHolderName;
            this.Balance = balance;
        }
            
        /// <summary>
        /// Returns the account holder name that the account belongs to.
        /// </summary>
        public string AccountHolderName { get; private set; }

        /// <summary>
        /// Returns the account number that the account belongs to
        /// </summary>
        public string AccountNumber { get; set; }

        /// <summary>
        /// Returns the balance value of the bank account in USD
        /// </summary>
        public decimal Balance { get; private set; }

       

        

        /// <summary>
        /// Adds amountToDeposit to the current balance, and returns the new balance of the bank account.
        /// </summary>
        /// <param name="amountToDeposit"></param>
        /// <returns></returns>
        public virtual decimal Deposit (decimal amountToDeposit)
        {
            Balance = Balance + amountToDeposit;
            return Balance;
        }

        /// <summary>
        /// Subtracts amountToWithdraw from the current balance, and returns the new balance of the bank account.
        /// </summary>
        /// <param name="amountToWithdraw"></param>
        /// <returns></returns>
        public virtual decimal Withdraw(decimal amountToWithdraw)
        {
            Balance = Balance - amountToWithdraw;
            return Balance;
        }

    }
}
