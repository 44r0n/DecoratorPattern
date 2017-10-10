using System;
namespace DecoratorPattern
{
    public abstract class Decorator : IComponent
    {
        private IComponent _component;

        public Decorator(IComponent component)
        {
            this._component = component;
        }

        public virtual void Operation()
        {
            Console.WriteLine("From Decorator");
            _component.Operation();
        }
    }
}
