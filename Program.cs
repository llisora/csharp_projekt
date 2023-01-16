using System;

namespace Rock_Paper_Scissors
{
    class Program
    {
        static void Main(string[] args)
        {
            //Initialize random number for enemy to pick
            Random random = new Random();

            //Create two integer for player score and enemy score
            int playerScore = 0;
            int enemyScore = 0;

            //Text to welcome you to the game
            Console.WriteLine("Welcome to rock, paper, scissors!");

            //While-loop where the game continues as long as neither of the players has reached a score of 3
            while (playerScore != 3 && enemyScore != 3)
            {
                //Write out the scores
                Console.WriteLine("Player score - " + playerScore + ". Enemy score - " + enemyScore);
                //Write out instructions
                Console.WriteLine("Please enter 'r' for rock, 'p' for paper or anything else for scissors!");

                //Retrieve players answer
                string playerChoice = Console.ReadLine();

                //Integer for enemy choice - if 0 is generated - enemy chose rock, if 1 is generated - enemy chose paper,
                //if 2 is generated - enemy chose scissors
                int enemyChoice = random.Next(0, 3);

                //A series of if-statements to print out what the enemy choice was and what happened because of it
                if (enemyChoice == 0)
                {
                    Console.WriteLine("Enemy chooses rock.");

                    switch (playerChoice)
                    {
                        case "r":
                            Console.WriteLine("Tie");
                            break;
                        case "p":
                            Console.WriteLine("Player wins this round!");
                            playerScore++;
                            break;
                        default:
                            Console.WriteLine("Enemy wins this round!");
                            enemyScore++;
                            break;
                    }
                }
                else if (enemyChoice == 1)
                {
                    Console.WriteLine("Enemy chooses paper.");

                    switch (playerChoice)
                    {
                        case "r":
                            Console.WriteLine("Enemy wins this round!");
                            enemyScore++;
                            break;
                        case "p":
                            Console.WriteLine("Tie");
                            break;
                        default:
                            Console.WriteLine("Player wins this round!");
                            playerScore++;
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Enemy chooses scissors.");

                    switch (playerChoice)
                    {
                        case "r":
                            Console.WriteLine("Player has won this round!");
                            playerScore++;
                            break;
                        case "p":
                            Console.WriteLine("Enemy won this round!");
                            enemyScore++;
                            break;
                        default:
                            Console.WriteLine("Tie");
                            break;
                    }
                }
            }
            //If players score = 3 - the player won. If not - they lose!
            if(playerScore == 3)
            {
                Console.WriteLine("YOU WON!");
            }
            else 
            {
                Console.WriteLine("You lose...");
            }
        }
    }
}