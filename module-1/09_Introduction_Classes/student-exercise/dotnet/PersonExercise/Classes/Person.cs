using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechElevator.Classes
{
    public class Person
    {
        /// <summary>
        /// The first name of the person.
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// The last name of the person.
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// The age of the person.
        /// </summary>
        public int Age { get; set; }

        /// <summary>
        /// Returns the first and last name of the person separated by a space.
        /// </summary>
        /// <returns></returns>
        public string GetFullName()
        {
            return FirstName + " " + LastName;
        }

        public bool IsAdult()
        {
            if (Age >= 18)
            {
                return true;
            }
            return false;
        }
    }
}
