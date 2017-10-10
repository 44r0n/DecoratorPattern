using System;
namespace DecoratorPattern
{
    public class ConcreteComponent : IComponent
    {
        public ConcreteComponent()
        {
        }

        public void Operation()
        {
            Console.WriteLine("From ConcreteComponent");
        }
    }
}
