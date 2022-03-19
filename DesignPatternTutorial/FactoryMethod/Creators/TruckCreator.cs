namespace DesignPatternTutorial.FactoryMethod
{
    public class TruckCreator : Creator
    {
        public override IProduct CreateProduct()
        {
            return new Truck();
        }
    }
}
