using System;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Se crea ConcreteComponent y 2 Decoradores

            ConcreteComponent c = new ConcreteComponent();
            ConcreteDecoratorA d1 = new ConcreteDecoratorA();
            ConcreteDecoratorB d2 = new ConcreteDecoratorB();

            // Se liga los decoradores

            d1.SetComponent(c);
            d2.SetComponent(d1);

            d2.Operation();

            // Espera al usuario

            Console.ReadKey();
        }
    }
}

