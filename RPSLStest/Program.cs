using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class RPSLS
    {
        
        static void Main(string[] args)
        {      //Game object
            
            RPSLS rpsls = new RPSLS();
            string name;
            string playerInput;


            Console.WriteLine("Welcome to Rock, Paper, Scissors, Lizard, Spock!!");

            Console.WriteLine("Please enter your name to start playing: ");
            name = Console.ReadLine();
            Console.WriteLine("Hi, " + name + "!" + " Let's Play!"); 
            Console.WriteLine();
            playerInput = Console.ReadLine();

            if (playerInput == name)
            {
                //method to start game
                RPSLS.StartGame();

                RPSLS.GetWinner();
            }
            else
            {
                Console.WriteLine("Please enter a valid name.");
                playerInput = Console.ReadLine();
            }
           

        }
    }
}
