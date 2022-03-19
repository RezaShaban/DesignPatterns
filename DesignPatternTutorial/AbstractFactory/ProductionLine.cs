using System;

namespace DesignPatternTutorial.AbstractFactory
{

    // The client code works with factories and products only through abstract
    // types: AbstractFactory and AbstractProduct. This lets you pass any
    // factory or product subclass to the client code without breaking it.
    public class ProductionLine
    {
        public void RunProductoin()
        {
            // The client code can work with any concrete factory class.
            Console.WriteLine("Client: Testing client code with the first factory type...");
            MakeProduct(new ModernCreator());
            Console.WriteLine();

            Console.WriteLine("Client: Testing the same client code with the second factory type...");
            MakeProduct(new VictoriaCreator());
        }

        public void MakeProduct(IAbstractFactory factory)
        {
            var chair = factory.CreateChair();
            var table = factory.CreateTable();

            Console.WriteLine(table.HasLegs());
            Console.WriteLine(table.MakeHisFamilyChairs(chair));
        }
    }
}
