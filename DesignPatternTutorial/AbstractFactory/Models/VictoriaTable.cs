namespace DesignPatternTutorial.AbstractFactory
{
    public class VictoriaTable : ITable
    {
        public bool HasLegs()
        {
            return true;
        }

        public string MakeHisFamilyChairs(IChair collaborator)
        {
            var result = collaborator.HasLegs();

            return $"his family chairs is made with legs: ({result})";
        }
    }
}
