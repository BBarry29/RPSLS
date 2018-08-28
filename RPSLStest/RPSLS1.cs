using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    public class RPSLSGame
    {
        string playerInput;
        string name;

        public void PlayGame()
        {


            if (playerInput == name)
            {
                StartGame();
                GetWinner();

            }
        }

        public void GetWinner()
        {

            if (cpuInput == playerInput)

            {
                Console.WriteLine("Draw!");
                Console.WriteLine("You scored: {0} point(s) this round.");
                Console.WriteLine("The Computer scored {0} point(s) this round.");
            }

            else if (cpuInput == "Rock" && playerInput == "Scissors" || )
                }
    }
        public void StartGame()
        {
            string cpuInput;


            Random RandomNumber = new Random();
            int i = RandomNumber.Next(0, 5);
            if (i == 0)
            { cpuInput = "Rock"; }
            else if (i == 1)
            { cpuInput = "Paper"; }
            else if (i == 2)
            { cpuInput = "Scissors"; }
            else if (i == 3)
            { cpuInput = "Lizard"; }
            else if (i == 4)
            { cpuInput = "Spock"; }

            Console.WriteLine("Please choose Rock, Paper, Scissors, Lizard, or Spock: ");
            playerInput = Console.ReadLine();
        }
    }

}
    



