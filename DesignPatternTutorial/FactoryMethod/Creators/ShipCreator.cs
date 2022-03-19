namespace DesignPatternTutorial.FactoryMethod
{
    public class ShipCreator : Creator
    {
        public override IProduct CreateProduct()
        {
            return new Ship();
        }
    }
}
