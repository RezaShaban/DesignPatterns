namespace DesignPatternTutorial.AbstractFactory
{
    public class ModernTable : ITable
    {
        public bool HasLegs()
        {
            return true;
        }

        // The variant, Product B1, is only able to work correctly with the
        // variant, Product A1. Nevertheless, it accepts any instance of
        // AbstractProductA as an argument.
        public string MakeHisFamilyChairs(IChair collaborator)
        {
            var result = collaborator.HasLegs();

            return $"his family chairs is made with legs: ({result})";
        }
    }
}
