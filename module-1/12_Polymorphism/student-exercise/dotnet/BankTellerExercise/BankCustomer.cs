using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BankTellerExercise
{
    public class BankCustomer
    {

        /// <summary>
        /// Returns the name of the bank customer
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Returns the address of the bank customer
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// Returns the phone number of the bank customer
        /// </summary>
        public string PhoneNumber { get; set; }

        private List<IAccountable> listOfAccounts = new List<IAccountable>();

        /// <summary>
        /// Calculates the balance of all accounts, returns true if at least $25000; otherwise it is false.
        /// </summary>
        public bool IsVip
        {
            //
            //needs a loop to check balances of all accounts
            get
            {
                int allBalances = 0;
                foreach (IAccountable account in listOfAccounts)
                {
                    allBalances += account.Balance;
                }
                if (allBalances >= 25000)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

        }


        /// <summary>
        /// Adds newAccount to the customer's list of accounts
        /// </summary>
        /// <param name="newAccount"></param>
        public void AddAccount(IAccountable newAccount)
        {
            listOfAccounts.Add(newAccount);

        }


        /// <summary>
        /// Returns array of the accounts belonging to the customer.
        /// </summary>
        /// <returns></returns>
        public IAccountable[] GetAccounts()
        {
            return listOfAccounts.ToArray();
            //Instructions are asking for a list.
        }
    }

}

