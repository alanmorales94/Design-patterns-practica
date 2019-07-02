using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    class ConcreteDecoratorB : Decorator

    {
        public override void Operation()
        {
            base.Operation();
            AddedBehavior();
            Console.WriteLine("ConcreteDecoratorB.Operation()");
        }

        void AddedBehavior()
        {
        }
    }
}
