using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternTutorial
{
    public class Human
    {
        private List<object> parts = new List<object>();
        public void Add(string part)
        {
            this.parts.Add(part);
        }

        public string ShowHuman()
        {
            return "Human parts: " + string.Join(", ", parts) + "\n";
        }
    }
}
