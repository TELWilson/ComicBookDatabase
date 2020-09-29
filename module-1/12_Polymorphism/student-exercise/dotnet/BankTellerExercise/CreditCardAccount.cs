using System;
using System.Collections.Generic;
using System.Text;

namespace BankTellerExercise
{
    public class CreditCardAccount : IAccountable
    {
        public int Balance { get; set; }
        public CreditCardAccount(string accountHolderName, string accountNumber)
        {
            this.AccountHolderName = accountHolderName;
            this.AccountNumber = accountNumber;
            
        }

        /// <summary>
        /// Returns the account holder name that the account belongs to.
        /// </summary>
        public string AccountHolderName { get; }

        /// <summary>
        /// Returns the account number that the account belongs to.
        /// </summary>
        public string AccountNumber { get; }

        /// <summary>
        /// Returns the amount the customer owes.
        /// </summary>
        public int Debt
        {
            get
            {
                return Balance * -1;
            }
        }

        /// <summary>
        /// Removes amountToPay from the amount owed and returns the new total amount owed.
        /// </summary>
        /// <param name="amountToPay"></param>
        /// <returns></returns>
        public int Pay (int amountToPay)
        {
            
            return Balance += amountToPay;
        }

        /// <summary>
        /// Adds amountToCharge to the amount owed and returns the new total amount owed.
        /// </summary>
        /// <param name="amountToCharge"></param>
        /// <returns></returns>
        public int Charge (int amountToCharge)
        {
            
            return  Balance -= amountToCharge;
        }

    }
}
