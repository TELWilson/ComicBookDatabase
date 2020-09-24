using System;
using System.Collections.Generic;
using System.Text;

namespace DeckOfCards.PlayingCards
{
    /// <summary>
    /// This represents a playing card in a deck
    /// </summary>
    
    public class Card
    {
        /// <summary>
        /// Gets or sets the numerical value of the card
        /// </summary>


        public int Value { get; set; }

        /// <summary>
        /// Gets or sets the suit the card has (Hearts, Spades, Diamonds, Clubs)
        /// </summary>
        public string Suit { get; set; }


        /// <summary>
        /// Gets or sets whether or not the card is face up
        /// </summary>
        public bool IsFaceUp { get; set; }

        /// <summary>
        /// Gets a user-readable message for the card
        /// </summary>
        public string DisplayText
        {
            get
            {
                return this.Value + " of " + this.Suit;
            }
        }

    }
}
