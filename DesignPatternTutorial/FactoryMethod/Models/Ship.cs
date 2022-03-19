namespace DesignPatternTutorial.FactoryMethod
{
    public class Ship : IProduct
    {
        public string Deliver()
        {
            return $"product delivered with `Ship`";
        }
    }
}
