namespace DesignPatternTutorial.FactoryMethod
{
    public abstract class Creator
    {
        public abstract IProduct CreateProduct();

        public string DisplayStatus()
        {
            var product = CreateProduct();
            return $"{product.Deliver()}";
        }
    }
}
