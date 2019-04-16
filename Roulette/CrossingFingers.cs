using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roulette
{
    class CrossingFingers
    {
        public void doWork()
        {
            Random rnd = new Random();
            Console.WriteLine("Welcome to the Roulette table!");

            Console.WriteLine("Press any key to spin the wheel!");
            Console.ReadLine();
            Console.Clear();
            int[] chance = new int[38] { 3, 6, 9, 12, 15, 18, 21, 24, 27, 30, 33, 36,
            2, 5, 8, 11, 14, 17, 20, 23, 26, 29, 32, 35, 1, 4, 7, 10, 13, 16, 19, 22, 25, 28, 31, 34, 0, 00};

            int r = rnd.Next(0, 37);
            int x = (chance[r]);
            //Console.WriteLine(r);
            //Console.WriteLine(x);
            //Console.ReadLine();
            Console.WriteLine($"The winning number is {x}!");

            evenOrOdd(x);
            redOrBlack(x);
            highLow(x);
            dozens(x);
            columnWinner(x);
            streetRowSwitch(x);
            splitAndCorners(chance, r, x);
        }

        public void splitAndCorners(int[] chance, int r, int x)
        {
            if (r == 0)
            {
                Console.WriteLine($"Winning split bets are {chance[1]} and {chance[12]}" +
                    $"\nWinning corner bets are {chance[1]}, {chance[12]} and {chance[13]}"); 
            }
            else if (r > 0 & r < 11)
            {
                Console.WriteLine($"winning split bets are {chance[r - 1]}, {chance[r + 1]} and {chance[r + 12]}" +
                    $"\nWinning corner bets are {chance[r - 1]}, {chance[r + 1]}, {chance[r + 11]}, {chance[r + 12]} and {chance[r + 13]}");
            }
            else if (r == 11)
            {
                Console.WriteLine($"Winning split bets are {chance[r - 1]} and {chance[r + 12]}" +
                    $"\nWinning corner bets are {chance[r - 1]}, {chance[r + 11]}, and {chance[r + 12]}");
            }
            else if (r == 12)
            {
                Console.WriteLine($"Winning split bets are {chance[r - 12]}, {chance[r + 1]} and {chance[r + 12]}" +
                    $"\nWinning corner bets are {chance[r - 12]}, {chance[r - 11]}, {chance[r + 1]}, {chance[r + 12]} " +
                    $"and {chance[r + 13]}");
            }
            else if (r > 12 & r < 22)
            {
                Console.WriteLine($"winning split bets are {chance[r - 1]}, {chance[r + 1]}, {chance[r - 12]} and {chance[r + 12]}" +
                    $"\nWinning corner bets are {chance[r - 13]},{chance[r - 12]}, {chance[r - 11]}, {chance[r - 1]}, " +
                    $"{chance[r + 1]}, {chance[r + 11]}, {chance[r + 12]} and {chance[r + 13]}");
            }
            else if (r == 22)
            {
                Console.WriteLine($"Winning split bets are {chance[r - 12]}, {chance[r - 1]} and {chance[r + 12]}" +
                    $"\nWinning corner bets are {chance[r - 13]}, {chance[r - 12]} {chance[r + 11]}and {chance[r + 12]}");
            }
            else if (r == 23)
            {
                Console.WriteLine($"Winning split bets are {chance[r - 12]} and {chance[r + 12]}" +
                       $"\nWinning corner bets are {chance[r - 12]}, {chance[r - 11]}, and {chance[r + 1]}");
            }
            else if (r > 23 && r < 33)
            {
                Console.WriteLine($"winning split bets are {chance[r - 1]}, {chance[r + 1]} and {chance[r - 12]}" +
                    $"\nWinning corner bets are {chance[r - 13]},{chance[r - 12]}, {chance[r - 11]}, {chance[r - 1]}, " +
                    $" and {chance[r + 1]}");
            }
            else if (r == 33)
            {
                Console.WriteLine($"winning split bets are {chance[r - 1]},  and {chance[r - 12]}" +
                    $"\nWinning corner bets are {chance[r - 1]}, {chance[r - 13]} and {chance[r - 12]}");
            }
        }

        public void highLow(int x)
        {
            if (x > 0 && x < 19)
            {
                Console.WriteLine("Winner low!");
            }
            else if (x > 18 && x <= 36)
            {
                Console.WriteLine("Winner high!");
            }
            else { }
        }

        public void streetRowSwitch(int x)
        {
            switch (x)
            {
                case var i when(i >= 1 && i <= 3)://good
                    
                    {
                        Console.WriteLine("street 1 winner!");
                        Console.WriteLine("Winner double row 1-2.");
                    }
                    break;
                case var i when (i >= 4 && i <= 6)://good
                    {
                        Console.WriteLine("street 2 winner!");
                        Console.WriteLine("Winner double row 1-2.");
                        Console.WriteLine("Winner double row 2-3.");
                    }
                    break;
                case var i when (i >= 7 && i <= 9)://good
                    {
                        Console.WriteLine("street 3 winner!");
                        Console.WriteLine("Winner double row 2-3.");
                        Console.WriteLine("Winner double row 3-4.");
                    }
                    break;
                    case var i when(i >= 10 && i <= 12)://good
                    {
                        Console.WriteLine("street 4 winner!");
                        Console.WriteLine("Winner double row 3-4.");
                        Console.WriteLine("Winner double row 4-5.");
                    }
                    break;
                case var i when (i >= 13 && i <= 15)://good
                    {
                        Console.WriteLine("street 5 winner!");
                        Console.WriteLine("Winner double row 4-5.");
                        Console.WriteLine("Winner double row 5-6.");
                    }
                    break;
                case var i when (i >= 16 && i <= 18)://good
                    {
                        Console.WriteLine("street 6 winner!");
                        Console.WriteLine("Winner double row 5-6.");
                        Console.WriteLine("Winner double row 6-7.");
                    }
                    break;
               case var i when (i >= 19 && i <= 21)://good
                    {
                        Console.WriteLine("street 7 winner!");
                        Console.WriteLine("Winner double row 6-7.");
                        Console.WriteLine("Winner double row 7-8.");
                    }
                    break;
                case var i when (i >= 22 && i <= 24)://good
                    {
                        Console.WriteLine("street 8 winner!");
                        Console.WriteLine("Winner double row 7-8.");
                        Console.WriteLine("Winner double row 8-9.");
                    }
                    break;
                case var i when (i >= 25 && i <= 27)://good
                    if (x >= 25 && x <= 27)
                    {
                        Console.WriteLine("street 9 winner!");
                        Console.WriteLine("Winner double row 8-9.");
                        Console.WriteLine("Winner double row 9-10.");
                    }
                    break;
                case var i when (i >= 28 && i <= 30)://good
                    {
                        Console.WriteLine("street 10 winner!");
                        Console.WriteLine("Winner double row 9-10.");
                        Console.WriteLine("Winner double row 10-11.");
                    }
                    break;
                case var i when (i >= 31 && i <= 33)://good
                    {
                        Console.WriteLine("street 11 winner!");
                        Console.WriteLine("Winner double row 10-11.");
                        Console.WriteLine("Winner double row 11-12.");
                    }
                    break;
                case var i when (i >= 34 && i <= 36)://good
                    {
                        Console.WriteLine("street 12 winner!");
                        Console.WriteLine("Winner double row 11-12.");
                    }
                    break;
            }
        }
        public void columnWinner(int x)
        {
            if (x % 3 == 0)
            {
                Console.WriteLine("Winner column 1 (3,6,9...)!");
            }
            else if ((x + 1) % 3 == 0)
            {
                Console.WriteLine("Winner column 2 (2,5,8..)!");
            }
            else
            {
                Console.WriteLine("Winner column 3 (1,4,7..)!");
            }

        }
        public void redOrBlack(int x)
        {
            if (x < 11 && x % 2 == 0)
            {
                Console.WriteLine("Winner black!");
            }
            else if ((x > 10 && x < 18) && (x % 2 != 0))
            {
                Console.WriteLine("Winner black!");
            }
            else if ((x > 19 && x < 29) && (x % 2 == 0))
            {
                Console.WriteLine("Winner black!");
            }
            else if ((x > 28 && x < 36) && (x % 2 != 0))
            {
                Console.WriteLine("Winner black!");
            }
            else
            {
                Console.WriteLine("Winner red!");
            }
        }

        public void evenOrOdd(int x)
        {
            if (x % 2 == 0)
            {
                Console.WriteLine("Winner even/odd: Even!");
            }
            else
            {
                Console.WriteLine("Winnner even/odd: Odd!");
            }
        }

        public void dozens(int x)
        {
            if (x < 13)
            {
                Console.WriteLine("Winner first dozen (1-12)!");
            }
            else if (x > 12 && x < 25)
            {
                Console.WriteLine("Winner second dozen (13-24)!");
            }
            else if (x > 24 && x < 37)
            {
                Console.WriteLine("Winner third dozen (25 - 36)!");
            }
            else { }
        }
    }
}




