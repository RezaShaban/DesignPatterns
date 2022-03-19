namespace DesignPatternTutorial.AbstractFactory
{
    public class VictoriaChair : IChair
    {
        public bool HasCushion()
        {
            return true;
        }

        public bool HasLegs()
        {
            return true;
        }
    }
}
