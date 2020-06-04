using System;

namespace Cats
{
    class Program
    {
        static void Main(string[] args)
        {
            HouseCat garfield = new HouseCat("Garfield", 12.0);
            garfield.Eat();
            Console.WriteLine(garfield.Tired);

            HouseCat spike = new HouseCat("Spike");
            Console.WriteLine(spike.Weight);

            HouseCat cheshireCat = new HouseCat("Cheshire Cat", 26.0);

            Console.WriteLine(cheshireCat.Noise()); // prints "Hello, my name is Cheshire Cat!"
        }
    }
}
