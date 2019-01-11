using System;
using Avtec.DevMorningFix.Infrastructure;

namespace Container
{
    public class RegisteredObject
    {
        public RegisteredObject(Type typeToResolve, Type concreteType, LifeCycle lifeCycle)
        {
            TypeToResolve = typeToResolve;
            ConcreteType = concreteType;
            LifeCycle = lifeCycle;
        }

        public Type TypeToResolve { get; }

        public Type ConcreteType { get; }

        public object Instance { get; private set; }

        public LifeCycle LifeCycle { get; }

        public void CreateInstance(params object[] args)
        {
            Instance = Activator.CreateInstance(ConcreteType, args);
        }
    }
}