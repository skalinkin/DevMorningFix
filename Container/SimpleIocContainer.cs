using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Avtec.DevMorningFix.Infrastructure;

namespace Container
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
            var registeredObject = Enumerable.Where(registeredObjects, o => o.TypeToResolve == typeToResolve).ToArray();
            if (!Enumerable.Any(registeredObject))
            {
                throw new TypeNotRegisteredException($"The type {typeToResolve.Name} has not been registered");
            }

            if (registeredObject.Length == 1)
            {
            return GetInstance(Enumerable.First(registeredObject));
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
                registeredObject.CreateInstance(Enumerable.ToArray<object>(parameters));
            }

            return registeredObject.Instance;
        }

        private IEnumerable<object> ResolveConstructorParameters(RegisteredObject registeredObject)
        {
            var constructorInfo = Enumerable.First<ConstructorInfo>(registeredObject.ConcreteType.GetConstructors());
            foreach (var parameter in constructorInfo.GetParameters())
            {
                yield return ResolveObject(parameter.ParameterType);
            }
        }
    }
}