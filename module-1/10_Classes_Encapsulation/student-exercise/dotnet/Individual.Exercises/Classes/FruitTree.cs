using System;
using System.Collections.Generic;
using System.Text;

namespace Individual.Exercises.Classes
{
    public class FruitTree
    {
        public FruitTree (string typeOfFruit, int startingPiecesOfFruit)
        {
            this.TypeOfFruit = typeOfFruit;
            this.PiecesOfFruitLeft = startingPiecesOfFruit;
        }
        
        /// <summary>
        /// Gets the type of fruit on the tree.
        /// </summary>
        public string TypeOfFruit { get; }

        /// <summary>
        /// Gets the number of remaining fruit pieces on the tree.
        /// </summary>
        public int PiecesOfFruitLeft { get; private set; }

        public bool PickFruit(int numberOfPiecesToRemove)
        {
            if (PiecesOfFruitLeft - numberOfPiecesToRemove >= 0)
            {
                PiecesOfFruitLeft = PiecesOfFruitLeft - numberOfPiecesToRemove;
                    return true;
            }
            else
            {
                return false;
            }
        }

    }
}
