using System;

namespace DesignPatternTutorial.FactoryMethod
{
    public class ProductionLine
    {
        public void StartProduction()
        {
            Console.WriteLine("App: Launched with the ShipCreator.");
            MakeProduct(new ShipCreator());

            Console.WriteLine("");

            Console.WriteLine("App: Launched with the TruckCreator.");
            MakeProduct(new TruckCreator());
        }
        public void MakeProduct(Creator creator)
        {
            var product = creator.CreateProduct();
            Console.WriteLine("Client:\n" + product.Deliver());
        }
    }
}
