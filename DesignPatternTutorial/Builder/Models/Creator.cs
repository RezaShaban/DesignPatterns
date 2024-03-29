﻿namespace DesignPatternTutorial
{
    public class Creator : IBuilder
    {
        private Human _human = new Human();

        // A fresh builder instance should contain a blank product object, which
        // is used in further assembly.
        public Creator()
        {
            this.Reset();
        }

        public void Reset()
        {
            this._human = new Human();
        }

        public void BuildBody()
        {
            this._human.Add("Body");
        }

        public void BuildHands()
        {
            this._human.Add("Hands");
        }

        public void BuildHead()
        {
            this._human.Add("Head");
        }

        public void BuildLegs()
        {
            this._human.Add("Legs");
        }

        // Concrete Builders are supposed to provide their own methods for
        // retrieving results. That's because various types of builders may
        // create entirely different products that don't follow the same
        // interface. Therefore, such methods cannot be declared in the base
        // Builder interface (at least in a statically typed programming
        // language).
        //
        // Usually, after returning the end result to the client, a builder
        // instance is expected to be ready to start producing another product.
        // That's why it's a usual practice to call the reset method at the end
        // of the `GetProduct` method body. However, this behavior is not
        // mandatory, and you can make your builders wait for an explicit reset
        // call from the client code before disposing of the previous result.
        public Human GetHuman()
        {
            Human result = this._human;

            this.Reset();

            return result;
        }
    }
}
