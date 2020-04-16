using System;
using System.Collections.Generic;
using System.Text;

namespace RPSLS
{
    class Human : Player
    {
        public Human()
        {

        }
        public override void ChoseGesture()
        {
            ChosenGesture();


        }
        public override void SetName()
        {
            Console.WriteLine("Please enter your name:");
            name = Console.ReadLine();
        }
public void ChosenGesture()
        {

            string userInput;

            Console.WriteLine(name + " choose your gesture");
            // Mike choose your gesture


            for (int i = 0; i < gestures.Count; i++)
            {

                Console.WriteLine((i + 1) + ". " + gestures[i]);
                // 1. Rock
            }
            userInput = Console.ReadLine();
            if (userInput == "1") 
            {
                chosenGesture = "Rock";
            }
            if (userInput == "2")
            {
                chosenGesture = "Paper";
            }
            if (userInput == "3")
            {
                chosenGesture = "Sissors";
            }
            if (userInput == "4")
            {
                chosenGesture = "Lizard";
            }
            if (userInput == "5")
            {
                chosenGesture = "Spock";
            }
            Console.WriteLine(name + ", you have chosen " + chosenGesture);

        }
        
    }
}
