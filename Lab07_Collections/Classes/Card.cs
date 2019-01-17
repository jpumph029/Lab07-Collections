using System;
using System.Collections.Generic;
using System.Text;

namespace Lab07_Collections.Classes
{
    public class Card
    {
        public Suit suit { get; set; }
        public Value value { get; set; }

        public enum Suit { Clubs, Diamonds, Heats, Spades}
        public enum Value { Ace, Two, Three, Four, Five, Six, Seven, Eight, Nine, Ten, Jack, Queen, King }


    }
}
