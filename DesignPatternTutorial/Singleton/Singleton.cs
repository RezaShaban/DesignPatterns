using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternTutorial
{
    public sealed class Singleton
    {
        private static Singleton instance;
        // We now have a lock object that will be used to synchronize threads
        // during first access to the Singleton.
        private static readonly object _lock = new object();
        public static Singleton Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (_lock)
                    {
                        if(instance == null)
                            instance = new Singleton();
                    }
                }
                return instance;
            }
        }

        public void DoSomething()
        {

        }
    }
}
