using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Lab07_Collections.Classes
{
    public class Deck<T> : IEnumerable<T>
    {
        public T[] cards = new T[10];
        public int currentIndex = 0;
        public int CurrentCardCounter = 0;


        /// <summary>
        /// Doubles the length of Cards
        /// </summary>
        /// <param name="cards"></param>
        public void Add(T Card)
        {
            if (currentIndex > cards.Length - 1)
            {
                Array.Resize(ref cards, cards.Length * 2);
            }
            cards[currentIndex] = Card;
            currentIndex++;
            CurrentCardCounter++;
        }
 
     

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < cards.Length; i++)
            {
                yield return cards[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
