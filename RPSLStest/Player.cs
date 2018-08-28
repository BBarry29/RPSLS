using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class Player


    {
        RPSLS rpsls = new RPSLS();

        string name;

        Console.WriteLine("Please enter your name to start playing: ");
            name = Console.ReadLine();

            Console.WriteLine("Hi, " + name + "!" + " Let's Play!");
            Console.WriteLine();
            string playerInput = Console.ReadLine();
    }
}
