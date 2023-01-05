namespace DesignPatternTutorial.Bridge
{
    // The Shape defines the interface for the "control" part of the two
    // class hierarchies. It maintains a reference to an object of the
    // Implementation hierarchy and delegates all of the real work to this
    // object.
    public class Shape
    {
        protected IShape shape;

        public Shape(IShape _shape)
        {
            this.shape = _shape;
        }

        public virtual decimal CalcArea()
        {
            return shape.CalcArea();
        }
    }
}
