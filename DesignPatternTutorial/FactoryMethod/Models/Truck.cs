namespace DesignPatternTutorial.FactoryMethod
{
    public class Truck : IProduct
    {
        public string Deliver()
        {
            return $"product delivered with `Truck`";
        }
    }
}
