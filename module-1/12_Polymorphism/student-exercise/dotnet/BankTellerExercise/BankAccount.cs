﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BankTellerExercise
{
    public class BankAccount : IAccountable
    {

        public string AccountHolderName { get; private set; }
        public string AccountNumber { get; private set; }
        public int Balance { get; private set; }

        public BankAccount(string accountHolder, string accountNumber)
        {
            AccountHolderName = accountHolder;
            AccountNumber = accountNumber;
            Balance = 0;
        }

        public BankAccount(string accountHolder, string accountNumber, int balance)
        {
            AccountHolderName = accountHolder;
            AccountNumber = accountNumber;
            Balance = balance;
        }

        public int Deposit(int amountToDeposit)
        {
            Balance += amountToDeposit;
            return Balance;
        }

        public virtual int Withdraw(int amountToWithdraw)
        {
            Balance -= amountToWithdraw;
            return Balance;
        }
        public int TransferTo(BankAccount destinationAccount, int transferAmount)
        {
            
            this.Withdraw(transferAmount);
            destinationAccount.Deposit(transferAmount);
            //return destinationAccount.Balance += transferAmount;

            return Balance;
            //return destinationAccount.Balance += transferAmount;
            
        }
    }
}
