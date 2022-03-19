using System;

namespace DesignPatternTutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            new FactoryMethod.ProductionLine().StartProduction();
            Console.WriteLine($"{Environment.NewLine}FactoryMethod => end production!{Environment.NewLine}");

            new AbstractFactory.ProductionLine().RunProductoin();
        }
    }
}
