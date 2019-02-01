using System;
using System.Collections.Generic;
using System.Linq;

namespace Avtec.DevMorningFix.Container
{
    public class SimpleIocContainer : IContainer
    {
        private readonly IList<RegisteredObject> registeredObjects = new List<RegisteredObject>();

        public void Register<TTypeToResolve, TConcrete>()
        {
            Register<TTypeToResolve, TConcrete>(LifeCycle.Singleton);
        }

        public void Register<TTypeToResolve, TConcrete>(LifeCycle lifeCycle)
        {
            registeredObjects.Add(new RegisteredObject(typeof(TTypeToResolve), typeof(TConcrete), lifeCycle));
        }

        // 
        // A possible Kobayashi Maru situation
        // 
        public void Register(Type resolve, Type concrete)
        {
            registeredObjects.Add(new RegisteredObject(resolve, concrete, LifeCycle.Singleton));
        }

        public void Register(Type resolve, Type concrete, LifeCycle lifeCycle)
        {
            registeredObjects.Add(new RegisteredObject(resolve, concrete, lifeCycle));
        }

        public TTypeToResolve Resolve<TTypeToResolve>()
        {
            return (TTypeToResolve) ResolveObject(typeof(TTypeToResolve));
        }

        public object Resolve(Type typeToResolve)
        {
            return ResolveObject(typeToResolve);
        }

        private object ResolveObject(Type typeToResolve)
        {
            var registeredObject = registeredObjects.Where(o => o.TypeToResolve == typeToResolve).ToArray();
            if (!registeredObject.Any())
            {
                throw new TypeNotRegisteredException($"The type {typeToResolve.Name} has not been registered");
            }

            if (registeredObject.Length == 1)
            {
                return GetInstance(registeredObject.First());
            }

            var list = new List<object>();
            foreach (var registered in registeredObject)
            {
                list.Add(GetInstance(registered));
            }

            return list;
        }

        private object GetInstance(RegisteredObject registeredObject)
        {
            if (registeredObject.Instance == null ||
                registeredObject.LifeCycle == LifeCycle.Transient)
            {
                var parameters = ResolveConstructorParameters(registeredObject);
                registeredObject.CreateInstance(parameters.ToArray());
            }

            return registeredObject.Instance;
        }

        private IEnumerable<object> ResolveConstructorParameters(RegisteredObject registeredObject)
        {
            var constructorInfo = registeredObject.ConcreteType.GetConstructors().First();
            foreach (var parameter in constructorInfo.GetParameters())
            {
                yield return ResolveObject(parameter.ParameterType);
            }
        }
    }
}