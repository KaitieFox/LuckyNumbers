using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lucky_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string userConsent = "";
            do
            {
                //Part one
                Console.WriteLine("Please enter lowest number.");
                int lowest = int.Parse(Console.ReadLine());

                Console.WriteLine("And a higher number.");
                int highest = int.Parse(Console.ReadLine());

                //prevents inconsistensies
                while (lowest >= highest)
                {
                    Console.WriteLine("Enter a number greater than your first number");
                    highest = int.Parse(Console.ReadLine());
                }

                Console.WriteLine("Excellent! Now, pick 6 numbers between " + lowest + " and " + highest + ".");

                //the user array
                int[] userLuckyNumbers = new int[6];

                //while (int.Parse(Console.ReadLine()) > highest || int.Parse(Console.ReadLine()) < lowest) 
                //{
                //    Console.WriteLine("Please enter a valid number");
                //}          

                for (int i = 0; i < 6; i++)
                {
                    int userGuess = int.Parse(Console.ReadLine());
                    while (userGuess > highest || userGuess < lowest)
                    {
                        Console.WriteLine("Please enter a valid number");
                        userGuess = int.Parse(Console.ReadLine());
                    }
                    userLuckyNumbers[i] = userGuess;

                }

                //my check to make sure it saved those numbers into the array
                Console.WriteLine("You chose ");

                foreach (int n in userLuckyNumbers)
                {
                    Console.Write(n + " ");
                }

                //part two
                //Random generator. Create array

                int[] randoms = new int[6];

                Random rando = new Random();
                for (int i = 0; i < 6; i++)
                {
                    int randomNumber = rando.Next(lowest, highest) + 1;
                    randoms[i] = randomNumber;
                }

                Console.WriteLine("\nI chose ");
                //check
                foreach (int n in randoms)
                {
                    Console.WriteLine("Lucky Number: " + n);
                }

                //part three
                decimal jackpot = 13;
                Console.WriteLine("Total possible jackpot for your guesses is $" + jackpot);
                int userWin = 0;
                decimal userMoney;

                for (int i = 0; i < 6; i++)
                {
                    if (randoms.Contains(userLuckyNumbers[i]))
                    {
                        userWin++;
                    }
                    else
                    {
                        userWin = userWin + 0;
                    }
                }

                Console.WriteLine("You won " + userWin + " times!");
                userMoney = Decimal.Round((jackpot / 6 * userWin) * 1.00m, 2, MidpointRounding.AwayFromZero);


                Console.WriteLine("You won $" + userMoney + "!");

                Console.WriteLine("Want to play again?");
                userConsent = Console.ReadLine().Trim().ToLower();

            }
            while (userConsent == "yes");









        }
    }
}
