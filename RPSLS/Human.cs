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
            Console.Clear();
        }
public void ChosenGesture()
        {

            string userInput;
            
            Console.WriteLine(name + " choose your gesture");
                       

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
            else if (userInput == "2")
            {
                chosenGesture = "Paper";
            }
            else if(userInput == "3")
            {
                chosenGesture = "Sissors";
            }
            else if (userInput == "4")
            {
                chosenGesture = "Lizard";
            }
            else if (userInput == "5")
            {
                chosenGesture = "Spock";
            }
            else
            {
                Console.WriteLine("Invalid Entry! Please Try Again.");
                ChosenGesture();
            }
            Console.WriteLine(name + ", you have chosen " + chosenGesture);
            
            

        }
        
    }
}
