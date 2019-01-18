namespace Avtec.DevMorningFix
{
    public interface IDependencyResolver
    {
        IStartup GetCompositionRoot();
    }
}