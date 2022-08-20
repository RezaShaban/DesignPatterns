namespace DesignPatternTutorial.Prototype
{
    public class Product
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Product ShallowCopy()
        {
            return (Product)this.MemberwiseClone();
        }

        public Product DeepCopy()
        {
            Product clone = (Product)this.MemberwiseClone();
            clone.Name = Name;
            clone.Age = Age;
            return clone;
        }
    }
}
