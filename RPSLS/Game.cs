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
        
        public void RunGame() // Master method
        {
            DisplayRules();
            ChooseGameMode();     
            while(player1.score < pointsNeededToWin && player2.score < pointsNeededToWin)
            {
                player1.ChoseGesture();
                player2.ChoseGesture();
                CompareGestures();
                DisplayRoundWinner();
            }
            DisplayGameWinner();

            // 1) Display rules (also include how many rounds!)  [GAME] ✓
            // 2) What are we playing? (HvH or HvC?)             [GAME]  ✓

            //// One round of game ////
            // 3) Display gesture options to the players         [PLAYER]  ✓
            // 4) Player 1 chooses gesture                       [PLAYER]  ✓
            // 5) Player 2 chooses gesture                       [PLAYER]   ✓
            // 6) Compare gestures (assign a point to ROUND winner/check for tie!)      [GAME]
            // 7) Display current score                          [GAME]
            // 8) Check for GAME winner (best of 3/5)            [GAME]

            // if no
            // 9a) Repeat steps 3-8
            // if yes
            // 9b) Display final results                     [GAME]

            // 10) Ask to play again?                            [GAME]
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
            rules.Add("- First player to win 3 rounds wins the Game");

            Console.WriteLine("THESE ARE THE RULES!");
            Console.WriteLine("*************************");
            foreach (string i in rules)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("*************************");
            Console.WriteLine("");
            Console.WriteLine("Press Enter To Continue"); 
            Console.ReadLine();
            Console.Clear();


        }

       
        public void ChooseGameMode()
       {
            Console.WriteLine("Please Enter 1 For HvC, Or 2 For HvH:");            
            Console.WriteLine("");
            

            string userInput = Console.ReadLine();
            bool validInput;

            if (userInput == "1")
            {
                // HvC game
                player2 = new Computer();
                validInput = true;
                Console.WriteLine("");
                Console.WriteLine("You Have Chosen Human vs CPU");
                Console.WriteLine("");
            }
            else if (userInput == "2")
            {
                // HvH game
                player2 = new Human();
                validInput = true;
                Console.WriteLine("");
                Console.WriteLine("You Have Chosen Human vs Human");
                Console.WriteLine("");
            }
            else
            {
                Console.WriteLine("");
                Console.WriteLine("Invalid user input. Please Try again.");
                Console.WriteLine("");
                validInput = false;
            }
            if (validInput == false)
            {
                ChooseGameMode();
            }
            Console.WriteLine("");
            
            Console.WriteLine("Press Enter ");
            
        }        
        public void CompareGestures()
        {
            
            string player2Input;
            string player1Input;
            player2Input = player2.chosenGesture;
            player1Input = player1.chosenGesture;
            player1.roundScore = 0;
            player2.roundScore = 0;

           
            switch (player2.chosenGesture)
            {
                case "Rock":
                    player2Input = "Rock";
                    Console.WriteLine(player2.name + " chose Rock!");
                    if (player1Input == "Rock")
                    {
                        Console.WriteLine("It's a draw!"); 
                    }
                    else if (player1Input == "Spock")
                    {
                        Console.WriteLine("Spock vaporizes Rock");
                        player1.roundScore++;
                    }
                    else if (player1Input == "Paper")
                    {
                        Console.WriteLine("Paper covers Rock");
                        player1.roundScore++;
                    }
                    else if (player1Input == "Sissors")
                    {
                        Console.WriteLine("Rock crushes Sissors");
                        player2.roundScore++;
                    }
                    else if (player1Input == "Lizard")
                    {
                        Console.WriteLine("Rock crushes Lizard");
                        player2.roundScore++;
                    }                    
                    break;
                case "Paper":
                    player2Input = "Paper";
                    Console.WriteLine(player2.name + " chose Paper!");
                    if (player1Input == "Paper")
                    {
                        Console.WriteLine("It's a draw!");
                    }
                    else if (player1Input == "Spock")
                    {
                        Console.WriteLine("Paper disproves Spock");
                        player2.roundScore++;
                    }
                    else if (player1Input == "Rock")
                    {
                        Console.WriteLine("Paper covers Rock");
                        player2.roundScore++;
                    }
                    else if (player1Input == "Sissors")
                    {
                        Console.WriteLine("Scissors cuts Paper");
                        player1.roundScore++;
                    }
                    else if (player1Input == "Lizard")
                    {
                        Console.WriteLine("Lizard eats Paper");
                        player1.roundScore++;
                    }
                    break;
                case "Sissors":
                    player2Input = "Sissors";
                    Console.WriteLine(player2.name + " chose Sissors!");
                    if (player1Input == "Sissors")
                    {
                        Console.WriteLine("It's a draw!");
                    }
                    else if (player1Input == "Spock")
                    {
                        Console.WriteLine("Spock smashes Scissors");
                        player1.roundScore++;
                    }
                    else if (player1Input == "Rock")
                    {
                        Console.WriteLine("Rock crushes Scissors");
                        player1.roundScore++;
                    }
                    else if (player1Input == "Paper")
                    {
                        Console.WriteLine("Scissors cuts Paper");
                        player2.roundScore++;
                    }
                    else if (player1Input == "Lizard")
                    {
                        Console.WriteLine("Scissors decapitates Lizard");
                        player2.roundScore++;
                    }
                    break;
                case "Lizard":
                    player2Input = "Lizard";
                    Console.WriteLine(player2.name + " chose Lizard!");
                    if (player1Input == "Lizard")
                    {
                        Console.WriteLine("It's a draw!");
                    }
                    else if (player1Input == "Spock")
                    {
                        Console.WriteLine("Lizard poisons Spock");
                        player2.roundScore++;
                    }
                    else if (player1Input == "Rock")
                    {
                        Console.WriteLine("Rock crushes Lizard");
                        player1.roundScore++;
                    }
                    else if (player1Input == "Paper")
                    {
                        Console.WriteLine("Lizard eats Paper");
                        player2.roundScore++;
                    }
                    else if (player1Input == "Sissors")
                    {
                        Console.WriteLine("Scissors decapitates Lizard");
                        player1.roundScore++;
                    }
                    break;
                case "Spock":
                    player2Input = "Spock";
                    Console.WriteLine(player2.name + " chose Spock!");
                    if (player1Input == "Spock")
                    {
                        Console.WriteLine("It's a draw!");
                    }
                    else if (player1Input == "Lizard")
                    {
                        Console.WriteLine("Lizard poisons Spock");
                        player1.roundScore++;
                    }
                    else if (player1Input == "Rock")
                    {
                        Console.WriteLine("Spock vaporizes Rock");
                        player2.roundScore++;
                    }
                    else if (player1Input == "Paper")
                    {
                        Console.WriteLine("Paper disproves Spock");
                        player1.roundScore++;
                    }
                    else if (player1Input == "Sissors")
                    {
                        Console.WriteLine("Spock smashes Scissors");                        
                        player2.roundScore++;
                    }                    
                    break;                    
            }
             
                    

        }
        public void DisplayRoundWinner()
        {
            if (player1.roundScore > player2.roundScore)
            {
                player1.score++;
                Console.WriteLine(player1.name + " Won this round!");
                Console.WriteLine("");
                Console.WriteLine(player1.name + ", your current score is " + player1.score);
                Console.WriteLine(player2.name + ", your current score is " + player2.score);
                Console.WriteLine("");
                
            }
            else if (player2.roundScore > player1.roundScore)
            {
                player2.score++;
                Console.WriteLine(player2.name + " Won this round!");
                Console.WriteLine("");
                Console.WriteLine(player1.name + ", your current score is " + player1.score);
                Console.WriteLine(player2.name + ", your current score is " + player2.score);
                Console.WriteLine("");
            }
            else if (player2.roundScore == player1.roundScore)
            {
                Console.WriteLine("");
                Console.WriteLine(player1.name + ", your current score is " + player1.score);
                Console.WriteLine(player2.name + ", your current score is " + player2.score);
                Console.WriteLine("");
            }

        }
       
        public void DisplayGameWinner()
        {
            //pointsNeededToWin = 3;
                
            if (player1.score == pointsNeededToWin)
            {
                Console.WriteLine(player1.name + " has won the game!");
            }
            else if (player2.score == pointsNeededToWin)
            {
                Console.WriteLine(player2.name + " has won the game!");
            }
            //else
            //{
            //    player1.ChoseGesture();
            //    player2.ChoseGesture();
            //    CompareGestures();
            //    DisplayRoundWinner();
            //    IsGameOver();
            //}
                            
            

        }

        
    }
}
