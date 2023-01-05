namespace DesignPatternTutorial.Bridge
{
    public class ExtendedShape : Shape
    {
        public ExtendedShape(IShape _shape) : base(_shape)
        {
        }

        public override decimal CalcArea()
        {
            return (2 * 3.14M) / base.shape.CalcArea();
        }
    }
}
