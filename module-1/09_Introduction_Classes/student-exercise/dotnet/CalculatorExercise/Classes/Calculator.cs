using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechElevator.Classes
{
    /// <summary>
    /// Represents a "simple" calculator
    /// </summary>
    public class Calculator
    {
        /// <summary>
        /// The current calculated value.
        /// </summary>
        public int Result { get; private set; }

        /// <summary>
        /// Adds addend to Result and returns the current value of Result.
        /// </summary>
        /// <param name="addend"></param>
        /// <returns></returns>
        public int Add(int addend)
        {
            Result = Result + addend;
                return Result;
        }

        /// <summary>
        /// Multiplies current result by multiplier and returns the current value of Result.
        /// </summary>
        /// <param name="multiplier"></param>
        /// <returns></returns>
        public int Multiply(int multiplier)
        {
            Result = Result * multiplier;
            return Result;
        }

        /// <summary>
        /// Raises Result to power of exponent.  Negative exponents should use the absolute value.  Returns the current value of Result.
        /// </summary>
        /// <param name="exponent"></param>
        /// <returns></returns>
        public int Power(int exponent)
        {
            Result = Result * Result; 
            return Result;
        }

        /// <summary>
        /// Resets result to 0.
        /// </summary>
        public void Reset()
        {
            Result = 0;
            
        }

        /// <summary>
        /// Subtracts subtrahend from the current value of Result and returns the current value of Result.
        /// </summary>
        /// <param name="subtrahend"></param>
        /// <returns></returns>
        public int Subtract(int subtrahend)
        {
            Result = Result - subtrahend;
            return Result;

        }
    }
}
