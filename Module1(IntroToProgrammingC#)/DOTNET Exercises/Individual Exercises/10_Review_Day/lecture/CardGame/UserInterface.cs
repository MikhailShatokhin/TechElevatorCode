using System;
using System.Collections.Generic;
using System.Text;

namespace CardGame
{
    public class UserInterface
    {
        private Deck deck = new Deck();
        public void Run()
        {
            bool done = false;

            while (!done)
            {
                DisplayMenu();

                int selection = int.Parse(Console.ReadLine());

                switch (selection)
                {
                    case (1):
                        DisplayDeck();
                        break;
                    case (2):
                        DealACard();
                        break;
                    case (0):
                        done = true;
                        break;
                    default:
                        Console.WriteLine("Please Enter a Valid Value.");
                        break;
                }
            }
        }

        //todo Create Menu
        private void DisplayMenu()
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Menu");
            Console.WriteLine("----");
            Console.WriteLine("1 - Display Deck");
            Console.WriteLine("2 - Deal a Card");
            Console.WriteLine();
            Console.WriteLine("0 - End Program");
            Console.WriteLine();
            Console.Write("Please Enter a Number: ");
        }

        //todo Examine Desk
        private void DisplayDeck()
        {
            Console.WriteLine("Here is your Deck: ");

            Card[] cards = deck.GetDeck();
            foreach(Card card in cards)
            {
                Console.WriteLine(card.Suit + " - " + card.Value);
            }
            Console.WriteLine("Reached DisplayDeck");
        }

        //todo Deal a Card
        private void DealACard()
        {
            Console.WriteLine("Reached DealACard");
        }
    }
}
