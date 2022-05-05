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
            Console.WriteLine(garfield.Family);
            HouseCat toby = new HouseCat("Toby");
            Console.WriteLine(toby.Weight);
            Cat plainCat = new Cat(8.6);
            Console.WriteLine(plainCat.Noise());
            Console.WriteLine(garfield.Noise());
            Console.WriteLine(toby.Noise());


        }
    }
}
