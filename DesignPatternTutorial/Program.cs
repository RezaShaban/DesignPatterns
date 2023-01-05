using DesignPatternTutorial.Adapter;
using DesignPatternTutorial.Bridge;
using System;

namespace DesignPatternTutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------------------------------FactoryMethod");
            new FactoryMethod.ProductionLine().StartProduction();
            Console.WriteLine($"{Environment.NewLine}FactoryMethod => end production!{Environment.NewLine}");

            Console.WriteLine("---------------------------------AbstractFactory");
            new AbstractFactory.ProductionLine().RunProductoin();

            Console.WriteLine("---------------------------------Singleton");
            Singleton.Instance.DoSomething();

            Console.WriteLine("---------------------------------Builder");
            new HumanCreator().CreateHuman();

            Console.WriteLine("---------------------------------Adapter");
            ITarget target = new Adapter.Adapter(new Adaptee());
            Console.WriteLine(target.GetRequest());

            Console.WriteLine("---------------------------------Bridge");
            BridgeClient bridge = new BridgeClient();
            bridge.CreateShape(new Shape(new Square() { Width = 4, Height = 4 }));
            Console.WriteLine(Environment.NewLine);
            bridge.CreateShape(new Shape(new Rectangle() { Width = 8, Height = 4 }));
        }
    }
}
