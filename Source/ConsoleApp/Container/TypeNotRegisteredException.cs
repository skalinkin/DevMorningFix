using System;

namespace Avtec.DevMorningFix.ConsoleApp.Container
{
    public class TypeNotRegisteredException : Exception
    {
        public TypeNotRegisteredException(string message)
            : base(message)
        {
        }
    }
}