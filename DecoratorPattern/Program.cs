using System;

namespace DecoratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            IComponent concreteComponent = new ConcreteComponent();
            IComponent component = new ConcreteDecoratorA(new ConcreteDecoratorB(concreteComponent));
            component.Operation();
            Console.ReadKey();
        }
    }
}
