using System;
using Avtec.DevMorningFix.ConsoleApp.Container;

namespace Avtec.DevMorningFix.ConsoleApp.DevMorningFixDomain
{
    public interface IContainer
    {
        void Register<TTypeToResolve, TConcrete>();
        void Register<TTypeToResolve, TConcrete>(LifeCycle lifeCycle);
        TTypeToResolve Resolve<TTypeToResolve>();
        object Resolve(Type typeToResolve);
    }
}