using System;
using System.Text;

namespace Cards
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8; // Set console output to UTF-8
            string[] faces = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };
            string[] suits = { "S", "H", "D", "C" };
            string[] input = Console.ReadLine().Split(", ");
            List<Cards> cardsList = new List<Cards>();
            foreach (string inputCard in input)
            {
                CreateCard(inputCard, faces, suits, cardsList);
            }


            foreach (var cards in cardsList)
            {
                Console.Write(cards.ToString() + " ");
            }
        }

        private static void CreateCard(string inputCard, string[] faces, string[] suits, List<Cards> cardsList)
        {
            string[] inputCardSplited = inputCard.Split();
            string cardFace = inputCardSplited[0].ToString();
            string cardSuit = inputCardSplited[1].ToString();
            try
            {
                if (faces.Contains(cardFace) && suits.Contains(cardSuit))
                {

                    Cards card = new Cards(cardFace, cardSuit);
                    cardsList.Add(card);

                }
                else
                {
                    throw new ArgumentException("Invalid card!");
                }
            }
            catch (ArgumentException ex)
            {

                Console.WriteLine(ex.Message);
            }
     
            
        }
    }

    public class Cards
    {
        public Cards(string face, string suit)
        {
            Face = face;
            Suit = suit;
            switch (Suit)
            {
                case "S":
                    Suit = "\u2660";
                    break;

                case "H":
                    Suit = "\u2665";
                    break;

                case "D":
                    Suit = "\u2666";
                    break;

                case "C":
                    Suit = "\u2663";
                    break;
            }
        }

        public string Face { get; set; }
        public string Suit { get; set; }

        public override string ToString()
        {
            return $"[{Face}{Suit}]";
        }
    }
}
