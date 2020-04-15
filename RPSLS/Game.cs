using System;
using System.Collections.Generic;
using System.Text;

namespace RPSLS
{
    class Game
    {
        //member variables (HAS A)       
        public int pointsNeededToWin;
        public Player player1;
        public Player player2;
        
       public Game()
       {
            pointsNeededToWin = 3;
            player1 = new Human();
       }
        
        public void RunGame()
        {
            DisplayRules();
            ChooseGameMode();

        }

       public void DisplayRules()
       {       
            List<string> rules = new List<string>();
            rules.Add("- Rock crushes Scissors");
            rules.Add("- Scissors cuts Paper");
            rules.Add("- Paper covers Rock");
            rules.Add("- Rock crushes Lizard");
            rules.Add("- Lizard poisons Spock");
            rules.Add("- Spock smashes Scissors");
            rules.Add("- Scissors decapitates Lizard");
            rules.Add("- Lizard eats Paper ");
            rules.Add("- Paper disproves Spock");
            rules.Add("- Spock vaporizes Rock");

            Console.WriteLine("THESE ARE THE RULES!");
            Console.WriteLine("*************************");
            foreach (string i in rules)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("*************************");
            Console.WriteLine("");


        }

       public void ChooseGameMode()
       {
            Console.WriteLine("Please enter 1 for HvC, or 2 for HvH:");
            
            string userInput = Console.ReadLine();

            if (userInput == "1")
            {
                // HvC game
                player2 = new Computer();
            }
            else if (userInput == "2")
            {
                // HvH game
                player2 = new Human();
            }
            else
            {
                Console.WriteLine("Invalid user input. Please Try again.");
            }

       }
        public void DisplayGestures()
        {            
            List<string> gesture = new List<string>();
            gesture.Add("Rock");
            gesture.Add("Paper");
            gesture.Add("Sissors");
            gesture.Add("Lizard");
            gesture.Add("Spock");
                       
            foreach (string g in gesture)
            {
                Console.WriteLine(g);
            }
            Console.ReadLine();
        }

    }
}
