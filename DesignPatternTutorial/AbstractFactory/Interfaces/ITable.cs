namespace DesignPatternTutorial.AbstractFactory
{
    public interface ITable
    {
        // Product B is able to do its own thing...
        bool HasLegs();

        // ...but it also can collaborate with the chair.
        //
        // The Abstract Factory makes sure that all products it creates are of
        // the same variant and thus, compatible.
        string MakeHisFamilyChairs(IChair collaborator);
    }
}
