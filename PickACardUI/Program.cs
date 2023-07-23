using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PickACardUI
{
    internal class Program
    {
        static void Main(string[] args) {
            double odds = .75;
            Random random = new Random();
            Guy player = new Guy() { 
            Cash = 100,
            Name = "the player"
            };
            Console.WriteLine("Welcome to the casino.The odds are " + odds);
            while (player.Cash > 0)
            {
                player.WriteMyInfo();
                Console.WriteLine("How much do you want to bet: ");
                string howMuch = Console.ReadLine();
                if (int.TryParse(howMuch, out int amount){
                    int pot = player.GiveCash(amount) * 2;
                    if (pot > 0)
                    {
                        if (random.NextDouble() > odds)
                        {
                            int winnings = pot;
                            Console.WriteLine("You win " + winnings);
                            player.ReceiveCash(winnings);
                        }
                        else {
                            Console.WriteLine("Bad luck, you lose");

                        }
                    }

          

                } else {

                    Console.WriteLine("Please enter a valid number.");
                }


            }
            Console.WriteLine("The house always wins.");

            Guy joe = new Guy() { Cash = 50, Name = "Joe" };
            Guy bob = new Guy() { Cash = 100, Name = "Bob" };

            while (true)
            {
                joe.WriteMyInfo();
                bob.WriteMyInfo();
                Console.WriteLine("Enter an amount:");
                string howMuch = Console.ReadLine();
                if (howMuch == "")
                {
                    return;
                }
                if (int.TryParse(howMuch, out int amount))
                {
                    Console.WriteLine("who should give the cash: ");
                    string whichGuy = Console.ReadLine();
                    if (whichGuy == "Joe")
                    {
                        int cashGiven = joe.GiveCash(amount);
                        bob.ReceiveCash(cashGiven);
                    }
                    else if (whichGuy == "Bob")
                    {
                        int cashGiven = bob.GiveCash(amount);
                        joe.ReceiveCash(cashGiven);
                    }
                    else
                    {
                        Console.WriteLine("please enter 'Joe' or 'Bob' ");
                    }
                }
                else {
                    Console.WriteLine("please enter an amount (Or a blankline to exit ).");
                }
            }
        }
    }

    class Pizzazz
    {
        public int Zippo;
        public void Bamboo(int eek) {
            Zippo += eek;
        }
    }
    class Abracadabra {

        public int Vavavoom;

        public bool Lala(int floq)
        {
            if (floq < Vavavoom) 
            {
                Vavavoom += floq;
                return true;
            }
            return false;
        }
    
    }
}
