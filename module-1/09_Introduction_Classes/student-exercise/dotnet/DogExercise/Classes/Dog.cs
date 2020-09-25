using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechElevator.Classes
{
    
    /**
    * This class represents a dog that can sleep, wake, and make a sound, so it's pretty much like most dogs,
    * with a few essential methods missing. Thankfully.
    */
    public class Dog
    {
       //public Dog(bool IsSleeping)
       // {
       //     this.IsSleeping = false;
       // }

        /// <summary>
        /// true if the dog is asleep, false if not
        /// </summary>
        public bool IsSleeping { get; private set; }

        /// <summary>
        /// Returns "Zzzzz..." if the dog is asleep.  Returns "Woof!" if the dog is awake.
        /// </summary>
        /// <returns></returns>
        public string MakeSound()
        {
            if (IsSleeping)
            {
                return "Zzzzz...";
            }
            return "Woof!";
        }

        /// <summary>
        /// Sets IsSleeping to true
        /// </summary>
        public void Sleep()
        {
            IsSleeping = true;
        }

        public void WakeUp()
        {
            IsSleeping = false;
        }
        



    }
}
