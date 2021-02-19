using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectHigherLower
{
    // Vervang de class Card met de Card van card-assignment opdracht zodra die af is.
    class Card
    {
        // Attributes
        private string suit;
        private string colour;
        private string value;
        private int points;
        private static string[] allowedValues = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };

        /*
         * Constructor
         */
        public Card(string value, string suit, int points)
        {
            this.SetValue(value);
            this.SetSuit(suit);
            this.points = points;
        }
        /**
         * This mehtod prints the card e.g. 2♡ or J♤
         */
        public void PrintCard()
        {
            Console.Write(this.value + " " + this.suit);
        }

        /**
         * Checks wether the value is in the allowedValues list.
         * If it is this method returns true.
         */
        public bool CheckValue(string value)
        {
            bool isAllowed = false;
            for (int i = 0; i < allowedValues.Length; i++)
            {
                if (value == allowedValues[i])
                {
                    isAllowed = true;
                }
            }
            return isAllowed;
        }

        /**
         * This method returns the points of this card. 
         */
        public int GetPoints()
        {
            return points;
        }

        public string[] GetValue()
        {
            return allowedValues;
        }

        public void SetSuit(string suit)
        {
            if (suit == "♡" || suit == "♢" || suit == "♧" || suit == "♤")
            {
                this.suit = suit;
                this.colour = GetColour(suit);
            }
            else
            {
                throw new Exception("Could not find the specified suit.");
            }
        }

        /**
        * This method checks the value and if the value is allowed it sets the value.
        * This method method uses the CheckValue method to check if the value is correct.
        */
        public void SetValue(string value)
        {
            if (CheckValue(value))
            {
                this.value = value;
            }
            else
            {
                new Exception("This value of a card is not allowed");
            }
        }


        /**
        * This method returns the color. 
        * You can use this method with and suit argument to translate a suit to colour 
        */
        public string GetColour()
        {
            return this.colour;
        }

        /**
        * This method translate a suit to the corresponsing color.
        * Use this method to get the colour of a suit
        */
        public string GetColour(string suit)
        {
            if (suit == "♡" || suit == "♢")
            {
                return "red";
            }
            else if (suit == "♧" || suit == "♤")
            {
                return "black";
            }
            else
            {
                throw new Exception("Could not find the specified suit.");
            }
        }

        /**
         * Returns all the allowed Card Values
         */
        public static string[] GetAllowedCardValues()
        {
            return allowedValues;
        }
    }
}
