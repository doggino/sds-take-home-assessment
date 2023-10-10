using System;
using System.Collections.Generic;

namespace DeveloperSample.Container
{
    public class Container
    {
        private Dictionary<Type, Type> Bindings { get; set; }

        public Container() {
            Bindings = new Dictionary<Type, Type>();
        }

        public void Bind(Type interfaceType, Type implementationType) {
            Bindings[interfaceType] = implementationType;
        }
        public TInterface Get<TInterface>() {
            var interfaceType = typeof(TInterface);

            if (!Bindings.ContainsKey(interfaceType)) {
                throw new Exception("No type is bound with this interface!");
            }

            Type implementationType = Bindings[interfaceType];

            return (TInterface)Activator.CreateInstance(implementationType);
        }
    }
}