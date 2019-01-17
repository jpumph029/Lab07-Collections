using System;
using System.Collections.Generic;
using Lab07_Collections.Classes;

namespace Lab07_Collections
{
    class Program : Card
    {
        public static void Main(string[] args)
        {
         
            Deck<Card> dealer = PopulateDeckWithCards();
            Print(dealer);
            Deal(dealer);

        }
        public static void Deal(Deck<Card> deck)
        {
            Deck<Card> playerOne = new Deck<Card>();
            Deck<Card> playerTwo = new Deck<Card>();
            Deck<Card> dealer = deck;
            
            if (dealer.CurrentCardCounter % 2 == 0)
            {
                Console.Write("I dont have enough cards to deal\n");
            }
            else
            {
                int playerCards = dealer.CurrentCardCounter / 2;
                for (int i = 0; i < playerCards; i++)
                {
                    playerOne.Add(dealer.cards[i]);
                    
                }
                Console.WriteLine("");
                Print(playerOne);
           
                for (int i = 0; i < playerCards; i++)
                {
                    playerTwo.Add(dealer.cards[i]);
                }
                Console.WriteLine("");
                Print(playerTwo);
                Console.Write("dealer");
                Console.Write($"Total {CardCounter(dealer)}");
            }

        }

        public static int CardCounter(Deck<Card> deck)
        {
            return deck.CurrentCardCounter;
        }

        public static void Print(Deck<Card> deck)
        {
           
            for (int i = 0; i < deck.currentIndex; i++)
            {
                Console.Write($"{deck.cards[i].value}Of{deck.cards[i].suit}\n");

            }
   
        }

        /// <summary>
        /// Instantiates Club card for each value
        /// </summary>
        /// <returns></returns>
        public static Deck<Card> PopulateDeckWithCards()
        {
            Deck<Card> dealer = new Deck<Card>();

            //Card AceOfClubs = new Card();
            //AceOfClubs.suit = Suit.Clubs;
            //AceOfClubs.value = Value.Ace;
            //dealer.Add(AceOfClubs);

            Card TwoOfClubs = new Card();
            TwoOfClubs.suit = Suit.Clubs;
            TwoOfClubs.value = Value.Two;
            dealer.Add(TwoOfClubs);

            Card ThreeOfClubs = new Card();
            ThreeOfClubs.suit = Suit.Clubs;
            ThreeOfClubs.value = Value.Three;
            dealer.Add(ThreeOfClubs);

            Card FourOfClubs = new Card();
            FourOfClubs.suit = Suit.Clubs;
            FourOfClubs.value = Value.Four;
            dealer.Add(FourOfClubs);

            Card FiveOfClubs = new Card();
            FiveOfClubs.suit = Suit.Clubs;
            FiveOfClubs.value = Value.Five;
            dealer.Add(FiveOfClubs);

            Card SixOfClubs = new Card();
            SixOfClubs.suit = Suit.Clubs;
            SixOfClubs.value = Value.Six;
            dealer.Add(SixOfClubs);

            Card SevenOfClubs = new Card();
            SevenOfClubs.suit = Suit.Clubs;
            SevenOfClubs.value = Value.Seven;
            dealer.Add(SevenOfClubs);

            Card EightOfClubs = new Card();
            EightOfClubs.suit = Suit.Clubs;
            EightOfClubs.value = Value.Eight;
            dealer.Add(EightOfClubs);

            Card NineOfClubs = new Card();
            NineOfClubs.suit = Suit.Clubs;
            NineOfClubs.value = Value.Nine;
            dealer.Add(NineOfClubs);

            Card TenOfClubs = new Card();
            TenOfClubs.suit = Suit.Clubs;
            TenOfClubs.value = Value.Ten;
            dealer.Add(TenOfClubs);

            Card JackOfClubs = new Card();
            JackOfClubs.suit = Suit.Clubs;
            JackOfClubs.value = Value.Jack;
            dealer.Add(JackOfClubs);

            Card QueenOfClubs = new Card();
            QueenOfClubs.suit = Suit.Clubs;
            QueenOfClubs.value = Value.Queen;
            dealer.Add(QueenOfClubs);

            Card KingOfClubs = new Card();
            KingOfClubs.suit = Suit.Clubs;
            KingOfClubs.value = Value.King;
            dealer.Add(KingOfClubs);

            return dealer;
        }


    }
}
