namespace Avtec.DevMorningFix
{
    public interface IDependencyResolver
    {
        T Create<T>() where T : class;
    }
}