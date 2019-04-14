using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            Random rnd = new Random();
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

            int r = rnd.Next(0, 38);
            int x = int.Parse(rolls[r].number);

       
            if (r >= 36)
            {
                Console.WriteLine($"The winning bet is {rolls[r].number}.");
            }
            else
            {
                Console.WriteLine($"{rolls[r].number} is the winning number! \n\nOther wins include\ncolor: {rolls[r].color} \nEven/Odd: {rolls[r].oddEven}");
            }
            
/*
            //HighLow(x)// High/Low winner determination


            Console.ReadLine();
            //side,corner bets
            int[,] myArray = new int[,]
        {
                {3, 6, 9, 12, 15, 18, 21, 24, 27, 30, 33, 36},
                {2, 5, 8, 11, 14, 17, 20, 23, 26, 29, 32, 35},
                {1, 4, 7, 10, 13, 16, 19, 22, 25, 28, 31, 34}
        };
            
                foreach (int i in myArray)
                {
                int x;
                int y;
                if ([x,y] == [0,0])
                {

                }

            }
                Console.WriteLine("Winner Dozen");
            }
          
            }
            //side bets
            //if 

        
        public static void HighLow(int x)
        {
            if (x > 0 && x < 19)
            {
                Console.WriteLine("High/Low: Low range win!");
            }
            else if (x > 18 && x <= 36)
            {
                Console.WriteLine("High/Low: High range win!");
            }*/
        }
    }
}
