namespace DesignPatternTutorial
{
    public class Director
    {
        private IBuilder _builder;

        public IBuilder Builder { set { _builder = value; } }

        // The Creator can construct several product variations using the same
        // building steps.
        public void BuildMinimalViableProduct()
        {
            this._builder.BuildBody();
        }

        public void BuildFullFeaturedProduct()
        {
            this._builder.BuildHead();
            this._builder.BuildHands();
            this._builder.BuildBody();
            this._builder.BuildLegs();
        }
    }
}
