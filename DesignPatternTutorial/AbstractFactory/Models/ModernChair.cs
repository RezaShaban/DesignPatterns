namespace DesignPatternTutorial.AbstractFactory
{
    // Concrete Products are created by corresponding Concrete Factories.
    public class ModernChair : IChair
    {
        public bool HasCushion()
        {
            return false;
        }

        public bool HasLegs()
        {
            return true;
        }
    }
}
