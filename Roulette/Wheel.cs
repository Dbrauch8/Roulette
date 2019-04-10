using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roulette
{
    class Wheel
    {
        Random rand = new Random();

        int[,] myArray = new int[,]
        {
            {3, 6, 9, 12, 15, 18, 21, 24, 27, 30, 33, 36},
            {2, 5, 8, 11, 14, 17, 20, 23, 26, 29, 32, 35},
            {1, 4, 7, 10, 13, 16, 19, 22, 25, 28, 31, 34}
            
        };
        void Test(int [] myArray)
        {
            Console.WriteLine(myArray[1] + myArray[10]);
        }
        
    }
}
