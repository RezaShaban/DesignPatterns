﻿using System;

namespace DesignPatternTutorial.Bridge
{
    public class BridgeClient
    {
        // Except for the initialization phase, where an Abstraction object gets
        // linked with a specific Implementation object, the client code should
        // only depend on the Abstraction class. This way the client code can
        // support any abstraction-implementation combination.
        public void CreateShape(Shape shape)
        {
            Console.Write(shape.CalcArea());
        }
    }
}
