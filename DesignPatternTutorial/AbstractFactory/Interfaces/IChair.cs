﻿namespace DesignPatternTutorial.AbstractFactory
{
    // Each distinct product of a product family should have a base interface.
    // All variants of the product must implement this interface.
    public interface IChair
    {
        bool HasLegs();
        bool HasCushion();
    }
}
