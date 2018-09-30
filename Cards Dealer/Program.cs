using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cards_Dealer
{
    class Program
    {
        static void Main(string[] args)
        {
            DealCards();
        }

        public static void DealCards()
        {
            List<string> MyCards = new List<string>(){"Jack of Clubs", "Queen of Clubs", "King of Clubs", "Ace of Clubs",
                "Two of Clubs", "Three of Clubs", "Four of Clubs", "Five of Clubs", "Six of Clubs", "Seven of Clubs",
                "Eight of Clubs", "Nine of Clubs", "Ten of Clubs", "Jack of Hearts", "Queen of Hearts", "King of Hearts",
                "Ace of Hearts", "Two of Hearts", "Three of Hearts", "Four of Hearts", "Five of Hearts", "Six of Hearts",
                "Seven of Hearts", "Eight of Hearts", "Nine of Hearts", "Ten of Hearts", "Jack of Spades", "Queen of Spades",
                "King of Spades", "Ace of Spades", "Two of Spades", "Three of Spades", "Four of Spades", "Five of Spades",
                "Six of Spades", "Seven of Spades", "Eight of Spades", "Nine of Spades", "Ten of Spades", "Jack of Diamonds",
                "Queen of Diamonds", "King of Diamonds", "Ace of Diamonds", "Two of Diamonds", "Three of Diamonds",
                "Four of Diamonds", "Five of Diamonds", "Six of Diamonds", "Seven of Diamonds", "Eight of Diamonds",
                "Nine of Diamonds", "Ten of Diamonds"

            };

            int[] myHand = new int [10];

            Console.WriteLine("Generating ten random cards");

            for (int i = 0; i < 10; i++)
            {
                Random random = new Random();
                int cardIndex = random.Next(0, MyCards.Count);

                foreach (var j in myHand)
                {
                    if (j != cardIndex)
                    {
                        myHand[i] = cardIndex;
                    }
                }
                System.Threading.Thread.Sleep(250);
            }
            foreach (var i in myHand)
            {
                Console.WriteLine(MyCards[i]);
            }

        }
    }
}
