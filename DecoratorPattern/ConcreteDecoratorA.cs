using System;
namespace DecoratorPattern
{
    public class ConcreteDecoratorA : Decorator
    {

        public ConcreteDecoratorA(IComponent component) : base(component)
        {
        }

        public override void Operation()
        {
            Console.WriteLine("From ConcreteDecoratorA");
            base.Operation();
        }
    }
}
