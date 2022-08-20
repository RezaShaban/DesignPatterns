using System;

namespace DesignPatternTutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("FactoryMethod");
            new FactoryMethod.ProductionLine().StartProduction();
            Console.WriteLine($"{Environment.NewLine}FactoryMethod => end production!{Environment.NewLine}");

            Console.WriteLine("AbstractFactory");
            new AbstractFactory.ProductionLine().RunProductoin();

            Console.WriteLine("Singleton");
            Singleton.Instance.DoSomething();

            Console.WriteLine("Builder");
            new HumanCreator().CreateHuman();
        }
    }
}
