using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Get to work
namespace Roulette
{
    public struct Roll
    {
        public string number;
        public string color;
        public string oddEven;
    }

    class Program
    {
        static void Main(string[] args)
        {
            CrossingFingers finger = new CrossingFingers();
            finger.doWork();
            Console.ReadLine();

            Random rnd = new Random();


            /*
            Console.WriteLine("Welcome to the Roulette table!");
            Console.WriteLine("Press any key to place a bet.");
            Console.Write("Place your bet (min $5): ");
            //double bet = double.Parse(Console.ReadLine());
            Console.WriteLine("Press any key to spin the wheel!");
            Console.ReadLine();
            Console.Clear();
            Roll[] rolls = new Roll[38];
            rolls[0] = new Roll { number = "3", color = "red", oddEven = "odd" };
            rolls[1] = new Roll { number = "6", color = "black", oddEven = "even" };
            rolls[2] = new Roll { number = "9", color = "red", oddEven = "odd" };
            rolls[3] = new Roll { number = "12", color = "red", oddEven = "even" };

            rolls[4] = new Roll { number = "15", color = "black", oddEven = "odd" };
            rolls[5] = new Roll { number = "18", color = "red", oddEven = "even" };
            rolls[6] = new Roll { number = "21", color = "red", oddEven = "odd" };
            rolls[7] = new Roll { number = "24", color = "black", oddEven = "even" };

            rolls[8] = new Roll { number = "27", color = "red", oddEven = "odd" };
            rolls[9] = new Roll { number = "30", color = "red", oddEven = "even" };
            rolls[10] = new Roll { number = "33", color = "black", oddEven = "odd" };
            rolls[11] = new Roll { number = "36", color = "red", oddEven = "even" };

            rolls[12] = new Roll { number = "2", color = "black", oddEven = "even" };
            rolls[13] = new Roll { number = "5", color = "red", oddEven = "odd" };
            rolls[14] = new Roll { number = "8", color = "black", oddEven = "even" };
            rolls[15] = new Roll { number = "11", color = "black", oddEven = "odd" };

            rolls[16] = new Roll { number = "14", color = "red", oddEven = "even" };
            rolls[17] = new Roll { number = "17", color = "black", oddEven = "odd" };
            rolls[18] = new Roll { number = "20", color = "black", oddEven = "even" };
            rolls[19] = new Roll { number = "23", color = "red", oddEven = "odd" };

            rolls[20] = new Roll { number = "26", color = "black", oddEven = "even" };
            rolls[21] = new Roll { number = "29", color = "black", oddEven = "odd" };
            rolls[22] = new Roll { number = "32", color = "red", oddEven = "even" };
            rolls[23] = new Roll { number = "35", color = "black", oddEven = "odd" };

            rolls[24] = new Roll { number = "1", color = "red", oddEven = "odd" };
            rolls[25] = new Roll { number = "4", color = "black", oddEven = "even" };
            rolls[26] = new Roll { number = "7", color = "red", oddEven = "odd" };
            rolls[27] = new Roll { number = "10", color = "black", oddEven = "even" };

            rolls[28] = new Roll { number = "13", color = "black", oddEven = "odd" };
            rolls[29] = new Roll { number = "16", color = "red", oddEven = "even" };
            rolls[30] = new Roll { number = "19", color = "red", oddEven = "odd" };
            rolls[31] = new Roll { number = "22", color = "black", oddEven = "even" };

            rolls[32] = new Roll { number = "25", color = "red", oddEven = "odd" };
            rolls[33] = new Roll { number = "28", color = "black", oddEven = "even" };
            rolls[34] = new Roll { number = "31", color = "black", oddEven = "odd" };
            rolls[35] = new Roll { number = "34", color = "red", oddEven = "even" };

            rolls[36] = new Roll { number = "0", color = "Green", oddEven = "NA" };
            rolls[37] = new Roll { number = "00", color = "Green", oddEven = "NA" };

            int r = rnd.Next(0, 37);
            int x = int.Parse(rolls[r].number);

            if (r >= 36)
            {
                Console.WriteLine($"The winning bet is {rolls[r].number}.");
            }
            else
            {
                Console.WriteLine($"{rolls[r].number} is the winning number! \nWinning color: {rolls[r].color} \nWinner Even/Odd: {rolls[r].oddEven}");
            }

            Dozens(x);
            Streets(r);

            //Splits and Corners
            if (r == 0)
            {
                Console.WriteLine($"Winning split bets are {rolls[1].number} and {rolls[12].number}" +
                    $"\nWinning corner bets are {rolls[2].number}, {rolls[12].number} and {rolls[13].number}");
            }
            else if (r > 0 & r < 11)
            {
                Console.WriteLine($"winning split bets are {rolls[r - 1].number}, {rolls[r + 1].number} and {rolls[r + 12].number}" +
                    $"\nWinning corner bets are {rolls[r - 1].number}, {rolls[r + 1].number}, {rolls[r + 11].number}, {rolls[r + 12].number} and {rolls[r + 13].number}");
            }
            else if (r == 11)
            {
                Console.WriteLine($"Winning split bets are {rolls[r - 1].number} and {rolls[r + 12].number}" +
                    $"\nWinning corner bets are {rolls[r + 11].number}, {rolls[12].number} and {rolls[13].number}");
            }
            else if (r == 12)
            {
                Console.WriteLine($"Winning split bets are {rolls[r - 12].number}, {rolls[r + 1].number} and {rolls[r + 12].number}" +
                    $"\nWinning corner bets are {rolls[r - 12].number}, {rolls[r - 11].number}, {rolls[r + 1].number}, {rolls[r + 12].number} " +
                    $"and {rolls[r + 13].number}");
            }
            else if (r > 12 & r < 22)
            {
                Console.WriteLine($"winning split bets are {rolls[r - 1].number}, {rolls[r + 1].number}, {rolls[r - 12].number} and {rolls[r + 12].number}" +
                    $"\nWinning corner bets are {rolls[r - 13].number},{rolls[r - 12].number}, {rolls[r - 11].number}, {rolls[r - 1].number}, " +
                    $"{rolls[r + 1].number}, {rolls[r + 11].number}, {rolls[r + 12].number} and {rolls[r + 13].number}");
            }
            else if (r == 22)
            {
                Console.WriteLine($"Winning split bets are {rolls[r - 12].number}, {rolls[r - 1].number} and {rolls[r + 12].number}" +
                    $"\nWinning corner bets are {rolls[r - 13].number}, {rolls[r - 12].number} {rolls[r + 11].number}and {rolls[r + 12].number}");
            }
            else if (r == 23)
            {
                Console.WriteLine($"Winning split bets are {rolls[r - 12].number} and {rolls[r + 12].number}" +
                       $"\nWinning corner bets are {rolls[r - 12].number}, {rolls[r - 11].number}, and {rolls[r + 1].number}");
            }
            else if (r > 23 && r < 33)
            {
                Console.WriteLine($"winning split bets are {rolls[r - 1].number}, {rolls[r + 1].number} and {rolls[r - 12].number}" +
                    $"\nWinning corner bets are {rolls[r - 13].number},{rolls[r - 12].number}, {rolls[r - 11].number}, {rolls[r - 1].number}, " +
                    $" and {rolls[r + 1].number}");
            }
            else if (r == 33)
            {
                Console.WriteLine($"winning split bets are {rolls[r - 1].number},  and {rolls[r - 12].number}" +
                    $"\nWinning corner bets are {rolls[r - 1].number}, {rolls[r - 13].number} and {rolls[r - 12].number}");
            }

            Console.ReadLine();
        }


        private static void Dozens(int x)
        {
            if (x <= 12)
            {
                Console.WriteLine("Winner first dozen");
            }
            else if (x > 12 && x < 25)
            {
                Console.WriteLine("Winner second dozen");
            }
            else if (x > 24 && x <= 36)
            {
                Console.WriteLine("Winner third dozen");
            }
            else { }

        }
        private static void Streets(int r)
        {
            if (r <= 11)
            {
                Console.WriteLine("Winner row 1 (1-12)");
            }
            else if (r > 11 && r < 22)
            {
                Console.WriteLine("Winner row 2 (13-24)");
            }
            else if (r > 22 && r > 34)
            {
                Console.WriteLine("Winner row 3 (25-36)");
            }
            else { }
            */

        }

    }
}

