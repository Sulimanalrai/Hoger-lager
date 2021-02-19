using System;
using System.Collections.Generic;

namespace ProjectHigherLower
{
    class Program
    {
        static void Main(string[] args)
        {
                Console.WriteLine("Project Higher Lower - The card guessing game.");
                Program.WriteLineSlow("Welkom bij Hoger Lager!");
                Program.WriteLineSlow("Wat is uw naam?");
                string name = Console.ReadLine();
                Program.WriteLineSlow("Welkom " + name + "!");
                Program.WriteLineSlow("De regels zijn als volgt: ");
                Program.WriteLineSlow("U krijgt een eerste kaart.");
                Program.WriteLineSlow("U moet dan raden of de volgende kaart hoger is of lager dan vorige.");
                Program.WriteLineSlow("Als u gelijk heeft win je deze ronde.");
                Program.WriteLineSlow("Als je het verkeerd heeft verliest u deze ronde.");
                Program.WriteLineSlow("Bij een gelijke kaart verliest u ook de ronde.");
                Program.WriteLineSlow("Veel plezier " + name + "!");
                Program.WriteLineSlow("Deck word genererd...");

                // Loop dat ervoor zorgt dat het spel opnieuw gespeeld kan worden
              bool replay = false;
              while (replay)
              {

                List<Card> deck = new List<Card>();
                int coins = 10;
                int guessCounter = 0;

                string[] cardValue = Card.GetAllowedCardValues();
                string useSuit = "♤";
                for (int i = 0; i < cardValue.Length; i++)
                {
                    string useValue = cardValue[i];
                    Console.WriteLine(cardValue[i]);
                    for (int j = 1; j <= 4; j++)
                    {
                        // Zorg ervoor dat je de waarde i en j vertaalt naar waarde(2 - 10, J, Q, K, A), naar (♡, ♢, ♧, ♤) en naar punten 1 - 14
                        useSuit = "♤";
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
                    }
                    int usePoints = i + 2;
                    Card testCard = new Card(useValue, useSuit, usePoints);
                    deck.Add(testCard);
                }

                // Eerste en tweede kaart worden gemaakt
                Console.WriteLine(deck.Count);
                Program.WriteLineSlow("Computer is choosing a card...");
                Random rnd = new Random();
                int cardIndex = rnd.Next(51);
                Card computersCard = deck[cardIndex];
                string first = Convert.ToString(computersCard.GetValue());
                int firstNumber = Convert.ToInt32(computersCard.GetPoints());
                Random rn = new Random();
                int secondIndex = rn.Next(51);
                Card guessCard = deck[secondIndex];
                string secondCard = Convert.ToString(guessCard.GetValue());
                int secondNumber = Convert.ToInt32(guessCard.GetPoints());
                string firstCard = Convert.ToString(first);

                computersCard.PrintCard();

                Console.WriteLine("Er zijn " + deck.Count + " kaarten in de deck.");


                Console.WriteLine(firstCard);
                Console.WriteLine("Is de volgende kaart hoger of lager?");
                string guess = Console.ReadLine();
                guessCounter++;

                // Tweede kaart raden
                if (guess == "hoger")
                {
                    if (secondNumber > firstNumber)
                    {
                        Console.WriteLine("U wint!");
                        coins = coins + 5;
                    }
                }
                else if (guess == "lager")
                {
                    if (secondNumber < firstNumber)
                    {
                        Console.WriteLine("U wint!");
                        coins = coins + 5;
                    }
                }
                else
                {
                    Console.WriteLine("U verliest! De kaart was " + secondCard + "!");
                    coins = coins - 15;
                }

                Console.WriteLine("U heeft " + guessCounter + " keer geraden.");

                // Vragen of je opnieuw wilt spelen
                Console.WriteLine("Wilt u opnieuw spelen, ja of nee?");
                string wantToReplay = Console.ReadLine();
                if (wantToReplay == "nee")
                {
                    replay = false;
                    Console.WriteLine("Dank u wel voor het spelen!");
                }
                else
                {
                    replay = true;
                }
                Console.WriteLine("U hebt " + coins + " munten");
              }
                  
        }

        // Zorgt voor tragere berichten
        public static void WriteLineSlow(string message)
        {
            Console.WriteLine(message);
            System.Threading.Thread.Sleep(1600);
        }
    }
}
