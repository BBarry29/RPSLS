using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLStest
{
    class StartGame

   

}
Random random = new Random();
int randomInt;
int cpuInput;
int humanInput;


        switch (randomInt)
                
                    case 1:
                        cpuInput = "1";
                        Console.WriteLine("Computer chose Rock!");

                        if (humanInput == cpuInput)
                        {
                            Console.WriteLine("Human Player and Computer tie!");
                        }
                        else if (humanInput == "2")
                        {
                            Console.WriteLine("Paper covers Rock! Human player wins!");
                            humanWins++;
                        }
                        else if (humanInput == "3")
                        {
                            Console.WriteLine("Rock smashes scissors! Computer wins!");
                            cpuWins++;
                        }
                        else if (humanInput == "4")
                        {
                            Console.WriteLine("Rock crushes Lizard! Computer wins!");
                            cpuWins++;
                        }
                        else if (humanInput == "5")
                        {
                            Console.WriteLine("Spock vaporizes Rock! Human Player wins!");
                            humanWins++;
                        }
                        break;
                       
    

                    case 2:
                        cpuInput = "2";
                        Console.WriteLine("Computer chose Paper!");

                        if (humanInput == "1")
                        {
                            Console.WriteLine("Paper covers Rock! Computer wins!");
                            cpuWins++;
                        }
                        else if (humanInput == cpuInput)
                        {
                            Console.WriteLine("Human Player and Computer tie!");
                        }
                        else if (humanInput == "3")
                        {
                            Console.WriteLine("Scissors cuts paper! Human Player wins!");
                            humanWins++;
                        }
                        else if (humanInput == "4")
                        {
                            Console.WriteLine("Lizard eats Paper! Human Player wins!");
                            humanWins++;
                        }
                        else if (humanInput == "5")
                        {
                            Console.WriteLine("Paper disproves Spock! Computer wins!");
                            cpuWins++;
                        }
                        break;
                        

                    case 3:
                        cpuInput = "3";
                        Console.WriteLine("Computer chose Scissors!");

                        if (humanInput == "1")
                        {
                            Console.WriteLine("Rock smashes Scissors! Human Player wins!");
                            humanWins++;
                        }
                        else if (humanInput == "2")
                        {
                            Console.WriteLine("Paper covers Rock! Human Player wins!");
                            humanWins++;
                        }
                        else if (humanInput == cpuInput)
                        {
                            Console.WriteLine("Human Play and Computer tie!");
                        }
                        else if (humanInput == "4")
                        {
                            Console.WriteLine("Scissors decapitates lizard! Computer wins!");
                            cpuWins++;
                        }
                        else if (humanInput == "5")
                        {
                            Console.WriteLine("Spock smashes scissors! Human Player wins!");
                            humanWins++;
                        }
                        break;
                        

                    case 4:
                        cpuInput = "4";
                        Console.WriteLine("Computer chose Lizard!");

                        if (humanInput == "1")
                        {
                            Console.WriteLine("Rock crushes Lizard! Human Player wins!");
                            humanWins++;
                        }
                        else if (humanInput == "2")
                        {
                            Console.WriteLine("Lizard eats Paper! Computer wins!");
                            cpuWins++;
                        }
                        else if (humanInput == "3")
                        {
                            Console.WriteLine("Scissors decapitates Lizard! Human Player wins!");
                            humanWins++;
                        }
                        else if (humanInput == cpuInput)
                        {
                            Console.WriteLine("Human Player and Computer tie!");
                        }
                        else if (humanInput == "5")
                        {
                            Console.WriteLine("Lizard poisons Spock! Computer wins!");
                            cpuWins++;
                        }
                        break;
                        

                    case 5:
                        cpuInput = "5";
                        Console.WriteLine("Computer chose Spock!");

                        if (humanInput == "1")
                        {
                            Console.WriteLine("Spock vaporizes Rock! Computer wins!");
                            cpuWins++;
                        }
                        else if (humanInput == "2")
                        {
                            Console.WriteLine("Paper disproves Spock! Human Player wins!");
                            humanWins++;
                        }
                        else if (humanInput == "3")
                        {
                            Console.WriteLine("Spock smashes Scissors! Computer wins!");
                            cpuWins++;
                        }
                        else if (humanInput == "4")
                        {
                            Console.WriteLine("Lizard poisons Spock! Human Player wins!");
                            humanWins++;
                        }
                        else if (humanInput == cpuInput)
                        {
                            Console.WriteLine("Human Player and Computer tie!");
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid selection!");
                        break;
                                 
   
    }
}
