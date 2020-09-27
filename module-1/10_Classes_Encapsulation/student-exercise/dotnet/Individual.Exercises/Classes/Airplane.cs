using System;
using System.Collections.Generic;
using System.Text;

namespace Individual.Exercises.Classes
{
    //private int totalFirstClassSeats;
    //private int privateFirstClassSeats;
    public class Airplane
    {
        public Airplane(string planeNumber, int totalFirstClassSeats, int totalCoachSeats)
        {
            this.PlaneNumber = planeNumber;
            this.TotalFirstClassSeats = totalFirstClassSeats;
            this.TotalCoachSeats = totalCoachSeats;
        }

        /// <summary>
        /// Gets the six character plane number
        /// </summary>
        public string PlaneNumber { get; }
        


        /// <summary>
        /// Gets the number of total first class seats
        /// </summary>
        public int TotalFirstClassSeats { get; }

        /// <summary>
        /// Gets the number of already booked first class seats
        /// </summary>
        public int BookedFirstClassSeats { get; private set; }

        /// <summary>
        /// Gets the number of available first class seats
        /// </summary>
        public int AvailableFirstClassSeats 
        {
            get
            {
                return this.TotalFirstClassSeats - this.BookedFirstClassSeats;
            }
        }

        /// <summary>
        /// Gets the number of total coach seats
        /// </summary>
        public int TotalCoachSeats { get; }
        

        /// <summary>
        /// Gets the number of already booked coach seats
        /// </summary>
        public int BookedCoachSeats { get; private set; }

        /// <summary>
        /// Gets the number of available coach seats.
        /// </summary>
        public int AvailableCoachSeats
        {
            get
            {
                return this.TotalCoachSeats - this.BookedCoachSeats;
            }
        }

        public bool ReserveSeats (bool forFirstClass, int totalNumberOfSeats)
        {
            
            if (forFirstClass)
            {
                if (AvailableFirstClassSeats >= totalNumberOfSeats)
                {
                    BookedFirstClassSeats += totalNumberOfSeats;
                    return true;
                }
                return false;
            }
            else
            {
                if (AvailableCoachSeats >= totalNumberOfSeats)
                {
                    BookedCoachSeats += totalNumberOfSeats;
                    return true;
                }return false;
            }
        }
    }
}
