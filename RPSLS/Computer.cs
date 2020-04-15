using System;
using System.Collections.Generic;
using System.Text;

namespace RPSLS
{
    class Computer : Player
    {
        public Computer()
        {

        }
         public int RandomNumber(Random random)
        {
            int numberGenerated = random.Next(1, 6);
            return numberGenerated;
        }
        public override void ChoseGesture()
        {
            Random rnd = new Random();

            // generate a random number 
            // user this number as an index for our gestures list
            int i = RandomNumber(rnd);

            chosenGesture = gestures[i];

            if (chosenGesture == "1")
            {
                chosenGesture = "Rock";
            }
            if (chosenGesture == "2")
            {
                chosenGesture = "Paper";
            }
            if (chosenGesture == "3")
            {
                chosenGesture = "Sissors";
            }
            if (chosenGesture == "4")
            {
                chosenGesture = "Lizard";
            }
            if (chosenGesture == "5")
            {
                chosenGesture = "Spock";
            }
            Console.WriteLine("Computer has chosen " + chosenGesture);



            
        }

        public override void SetName()
        {
            name = "Computer";
        }
    }
}
