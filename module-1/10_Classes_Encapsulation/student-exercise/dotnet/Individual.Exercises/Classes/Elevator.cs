using System;
using System.Collections.Generic;
using System.Text;

namespace Individual.Exercises.Classes
{
    public class Elevator
    {

        public Elevator(int numberOfLevels)
        {
            this.NumberOfLevels = numberOfLevels;
            this.CurrentLevel = 1;
        }
        /// <summary>
        /// Gets the current floor that the elevator is on
        /// </summary>
        public int CurrentLevel { get; private set; }

        /// <summary>
        /// Gets the number of levels available to the elevator.
        /// </summary>
        public int NumberOfLevels { get; }

        /// <summary>
        /// Gets if the elevator door is open or not
        /// </summary>
        public bool DoorIsOpen { get; private set; }

        public void OpenDoor()
        {
            DoorIsOpen = true;
        }

        public void CloseDoor()
        {
            DoorIsOpen = false;
        }

        public void GoUp(int desiredFloor)
        {
            if (!DoorIsOpen && CurrentLevel < NumberOfLevels)
            {
               CurrentLevel = desiredFloor;
            }

        }

        public void GoDown(int desiredFloor)
        {
            if (!DoorIsOpen && CurrentLevel > 1)
            {
                CurrentLevel = desiredFloor;
            }
        }
    }

}
