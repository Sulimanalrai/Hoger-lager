using System;
using System.Threading;
using System.Collections.Generic;

namespace CardGame
{
    public class Program
    {
        public static void Main(string[] args)
        {
            /*
             * Opdracht beschrijving
             * 
             * Je gaat een simpele kaartenspel maken.
             * De class Card is al aangemaakt voor je. Echter zit er nog wel een foutje in kan jij die verbeteren?
             * Daarnaast is het de bedoeling dat je een volledige kaartenspel gaat genereren met for-loops.
             */

            // TODO #1 There seems to be a problem in the Card class can you fix this: System.Exception: This value of a card is not allowed
            // Creating 4 cards for the intro text;
            Card aceOfHearts = new Card("A", "♡", 14);
            Card aceOfDiamonds = new Card("A", "♢", 14);
            Card aceOfClubs = new Card("A", "♧", 14);
            Card aceOfSpades = new Card("A", "♤", 14);

            aceOfHearts.PrintCard();
            aceOfDiamonds.PrintCard();
            aceOfClubs.PrintCard();
            aceOfSpades.PrintCard();

            Program.WriteLineSlow(" - Welkom bij de Guess the Card Game.");
            Program.WriteLineSlow("De regels zijn simpel. De computer heeft een gegenereerd deck met kaarten.");
            Program.WriteLineSlow("De computer kiest zelf een willekeurige kaart uit het deck.");
            Program.WriteLineSlow("en jij moet die raden.");
            Program.WriteLineSlow("Je begint met het raden van de kleur.");
            Program.WriteLineSlow("Zodra je die goed hebt mag je het symbol (harten, klaveren, schoppen, ruiten) raden.");
            Program.WriteLineSlow("Als laatste mag je het getal of soort raden(J, Q, K, A) raden.");
            Program.WriteLineSlow("Veel plezier!");
            Program.WriteLineSlow("Computer is generating the deck of cards...");

            List<Card> deck = new List<Card>();
            // TODO #3 Generate a deck of cards using two for-loops. Use for example deck.Add(new Card("A", "♡", 14)). To add a card. 
            string[] cardValue = Card.GetAllowedCardValues(); // Array with: 2 - 10, J, Q, K, A
            for(int i = 0; i < cardValue.Length; i++) {
                string useValue = cardValue[i];
                for(int j = 1; j <= 4; j++) {
                    // Zorg ervoor dat je de waarde i en j vertaalt naar waarde(2 - 10, J, Q, K, A), naar (♡, ♢, ♧, ♤) en naar punten 1 - 14
                    string useSuit = "♤";
                    if (j == 1)
                    {
                        useSuit = "♡";
                    }
                    else if (j == 2)
                    {
                        useSuit = "♡";
                    }
                    else if (j == 3)
                    {
                        useSuit = "♧";
                    }
                    
                    int usePoints = i + 2 ;
                    Card newCard = new Card(useValue, useSuit, usePoints);
                    deck.Add(newCard);
                    Console.WriteLine("The card is: "+ useValue + " The Suit is " + useSuit + " The i number = " + i);

                }
            }
            Console.WriteLine("Total cards in deck " + deck.Count);
            Console.ReadLine();
            Program.WriteLineSlow("Computer is choosing a card...");
            // TODO #4 Generate a random number withing your generated list/array. use deck.Count to get the maximum number of elements in the deck
            

            Random rnd = new Random();

            int cardIndex = rnd.Next(52);
            
            Card computersCard = deck[cardIndex]; // Fill computers card with a random card from the deck

            computersCard.PrintCard();
            Console.ReadLine();
            Program.WriteLineSlow("Computer has chosen, take your first guess, red or black?");
            bool colourCorrect = false;
            while(colourCorrect == false) {
                string colour = Console.ReadLine();
                // TODO #5 This if-statement should end the loop if guessed correctly.
                if(true) {
                    Console.WriteLine("Very well!");
                    goto done;
                }
                else {
                    Console.WriteLine("Oops that is not correct! You should know the answer by now!?");
                }
                done:;
            }
            
            // TODO #bonus should be nice if you can help the user. Because we know the colour and the colour only has two options
            // If it's black it could only be Clubs or Spades, and if it's red its only Diamonds or Hearts.
            Program.WriteLineSlow("Take your second guess on the suit?");
            // TODO #6 Create the loop for the suit guessing
            //for (int k = 1; k < 4; k++) ;
            //if{

            //}
            Program.WriteLineSlow("We are close now. Take your last guess. What's the value of the card?");
            // TODO #7 Create the loop for the value guessing

            Program.WriteLineSlow("Congratulations you have Won this game!");
            Program.WriteLineSlow("You probably want to know how many guesses you have made?");
            Program.WriteLineSlow("The answer is...");
            // TODO #8 Print the total amount of guesses.

            Program.WriteLineSlow("Thank you for playing the game.");
            
            // Rolling the Credits
            Program.Credits();
        }

        /**
         * A Simple wrapper method to make a Console.WriteLine and a Thread.Sleep(2000) which pauses
         * the console for 2000 milliseconds == 2 seconds.
         */
        public static void WriteLineSlow(string message) {
            Console.WriteLine(message);
            Thread.Sleep(2000);
        }

        public static void Credits() {
            Console.WriteLine("\n\n\n\n");
            Program.WriteLineSlow("Credits");
            Console.WriteLine("\n");
            Program.WriteLineSlow("Creative Director - Roy Springer");
            Console.WriteLine("\n");
            Program.WriteLineSlow("Art Director - Roy Springer");
            Console.WriteLine("\n");
            Program.WriteLineSlow("Game Analist - Roy Springer");
            Console.WriteLine("\n");
            Program.WriteLineSlow("Game Director - Roy Springer");
            Console.WriteLine("\n");
            Program.WriteLineSlow("Game Design - Roy Springer");
            Console.WriteLine("\n");
            Program.WriteLineSlow("Game Developer - Roy Springer");
            Console.WriteLine("\n");
            Program.WriteLineSlow("Lead Developer - Roy Springer");
            Console.WriteLine("\n");
            Program.WriteLineSlow("Senior Developer - Roy Springer");
            Console.WriteLine("\n");
            Program.WriteLineSlow("Junior Developer - Roy Springer");
            Console.WriteLine("\n");
            Program.WriteLineSlow("Developer - Roy Springer");
            Console.WriteLine("\n");
            Program.WriteLineSlow("Catering staff - Roy Springer");
            Console.WriteLine("\n");
            Program.WriteLineSlow("Copywritings - Roy Springer");
            Console.WriteLine("\n");
            Program.WriteLineSlow("Writer - Roy Springer");
            Console.WriteLine("\n");
        }
    }
}
