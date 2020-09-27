using System;
using System.Collections.Generic;
using System.Text;

namespace Individual.Exercises.Classes
{
    public class HomeworkAssignment
    {
        //private string submitterName;
        //private string letterGrade;
        //private int possibleMarks;    
        //private int earnedMarks;
        public HomeworkAssignment(int possibleMarks, string submitterName)
        {
            //this.LetterGrade = letterGrade;
            //this.EarnedMarks = earnedMarks;
            this.PossibleMarks = possibleMarks;
            this.SubmitterName = submitterName;

        }
        /// <summary>
        /// Gets or sets the total number of correct marks submitter received on the assignment.
        /// </summary>
        public int EarnedMarks { get; set; }

        /// <summary>
        /// /\Gets the number of possible marks on the assignment.
        /// </summary>
        public int PossibleMarks { get; }
        
        

        /// <summary>
        /// Gets or sets the submitter's name for the assignment
        /// </summary>
        public string SubmitterName { get; }
       
        /// <summary>
        /// Gets the letter grade for the assignment.
        /// </summary>
        public string LetterGrade //{ get; }
        {
            get
            {
                    if (((EarnedMarks / (double)PossibleMarks) * 100) > 90)
                    {
                        return  "A";

                    }
                    else if (((EarnedMarks / (double)PossibleMarks) * 100) >= 80)
                    {
                        return "B";

                    }
                    else if (((EarnedMarks / (double)PossibleMarks) * 100) >= 70)
                    {
                        return "C";
                    }
                    else if (((EarnedMarks / (double)PossibleMarks) * 100) >= 60 )
                    {
                        return "D";
                    }
                    else
                    {
                        return "F";
                    }
                 
            }

                



            }
    }
}
