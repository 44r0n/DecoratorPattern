using System;
namespace DecoratorPattern
{
    public class ConcreteDecoratorB : Decorator
    {
        public ConcreteDecoratorB(IComponent component) : base(component)
        {
        }

        public override void Operation()
        {
            Console.WriteLine("From ConcreteDecoratorB");
            base.Operation();
        }
    }
}
