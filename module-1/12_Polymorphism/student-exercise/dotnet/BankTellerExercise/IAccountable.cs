using System;
using System.Collections.Generic;
using System.Text;

namespace BankTellerExercise
{
    public interface IAccountable
    {
        /// <summary>
        /// Returns the balance value of the account in dollars.
        /// </summary>
        /// <returns></returns>
        int Balance { get; }
    }
}
