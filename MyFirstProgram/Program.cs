using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("HIKyle");
            Console.WriteLine("what is your name?");
            string yourName;
            yourName = Console.ReadLine();
            Console.WriteLine("OK I will call you {0}", yourName);
            Console.WriteLine("What Is your Favorite Number?");
            int favoriteNumber;
            favoriteNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("{0} is a cool number", favoriteNumber);
            Random randomNumberGenerator = new Random();
            Console.WriteLine("My Favorite Number Is {0}. it's random, I know", randomNumberGenerator.Next());
            Console.WriteLine("What is your favorite Car?");
            string yourFavoriteCar;
            yourFavoriteCar = Console.ReadLine();
            Console.ReadLine();
        }
    }
}
