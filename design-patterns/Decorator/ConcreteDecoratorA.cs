using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    class ConcreteDecoratorA : Decorator

    {
        public override void Operation()
        {
            base.Operation();
            Console.WriteLine("ConcreteDecoratorA.Operation()");
        }
    }
}
