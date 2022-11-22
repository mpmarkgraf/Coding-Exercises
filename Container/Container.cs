using System;
using System.Diagnostics;

namespace DeveloperSample.Container
{
    public class Container
    {
        private Type _interfaceType;
        private Type _implementationType;

        public void Bind(Type interfaceType, Type implementationType)
        {
            _interfaceType = interfaceType;
            _implementationType = implementationType;
        }

        public T Get<T>()
        {
            if (typeof(T).Equals(_interfaceType))
                return (T)Activator.CreateInstance(_implementationType);

            throw new InvalidCastException($"{typeof(T).Name} has not been bound to {_implementationType.Name}");
        }
    }
}