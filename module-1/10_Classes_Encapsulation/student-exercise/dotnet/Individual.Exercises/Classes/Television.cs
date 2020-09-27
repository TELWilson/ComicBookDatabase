using System;
using System.Collections.Generic;
using System.Text;

namespace Individual.Exercises.Classes
{
    public class Television
    {
        /// <summary>
        /// Gets whether or not the TV is turned on
        /// </summary>
        public bool IsOn { get; private set; } = false;


        /// <summary>
        /// Gets the value for the current channel.  Channel levels go between 3 and 18.
        /// </summary>
        public int CurrentChannel { get; private set; } = 3;

        /// <summary>
        /// Gets the current volume level.
        /// </summary>
        public int CurrentVolume { get; private set; } = 2;

        public void TurnOff()
        {
            IsOn = false;
        }

        public void TurnOn()
        {
            IsOn = true;
            CurrentChannel = 3;
            CurrentVolume = 2;
        }

        public void ChangeChannel(int newChannel)
        {
            if (IsOn)
            {
                if (CurrentChannel >= 3 && CurrentChannel <= 18)
                {
                    CurrentChannel = newChannel;
                }
            }
        }

        public void ChannelUp()
        {
            if (IsOn)
            {
                if (CurrentChannel == 18)
                {
                    CurrentChannel = 3;
                }
                else
                {
                    CurrentChannel += 1;
                }
            }

        }

        public void ChannelDown()
        {
            if (IsOn)
            {
                if (CurrentChannel == 3)
                {
                    CurrentChannel = 18;
                }
                else
                {
                    CurrentChannel -= 1;
                }
            }

        }



        public void RaiseVolume()
        {
            if (IsOn)
            {
                if (CurrentVolume < 10)
                {
                    CurrentVolume += 1;
                }
            }

        }

        public void LowerVolume()
        {
            if (IsOn)
            {
                if (CurrentVolume > 0)
                {
                    CurrentVolume -= 1;
                }
            }

        }
    }
}
