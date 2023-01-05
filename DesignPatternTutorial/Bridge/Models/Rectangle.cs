namespace DesignPatternTutorial.Bridge
{
    public class Rectangle : IShape
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public decimal CalcArea()
        {
            System.Console.Write($"I'm a {this.GetType().Name}, my area is: ");
            return (Width + Height) * 2;
        }
    }
}
