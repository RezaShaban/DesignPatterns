namespace DesignPatternTutorial.AbstractFactory
{
    // Each Concrete Factory has a corresponding product variant.
    public class VictoriaCreator : IAbstractFactory
    {
        public IChair CreateChair()
        {
            return new VictoriaChair();
        }

        public ITable CreateTable()
        {
            return new VictoriaTable();
        }
    }
}
