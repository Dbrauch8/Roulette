using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Get to work
namespace Roulette
{
    class Program
    {
        static void Main(string[] args)
        {
            CrossingFingers finger = new CrossingFingers();
            finger.doWork();
            Console.ReadLine();

            Random rnd = new Random();
        }

    }
}

