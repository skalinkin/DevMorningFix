using System;

namespace Avtec.DevMorningFix.Container
{
    public interface IContainer
    {
        void Register<TTypeToResolve, TConcrete>();
        void Register<TTypeToResolve, TConcrete>(LifeCycle lifeCycle);
        void Register(Type tif, Type tcon);
        void Register(Type tif, Type tcon, LifeCycle lifeCycle);
        TTypeToResolve Resolve<TTypeToResolve>();
        object Resolve(Type typeToResolve);
    }
}