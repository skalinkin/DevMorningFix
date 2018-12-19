using System;

namespace DevMorningFix.services.Exceptions
{
    internal class ExceptionRequiredObjectNotFound : Exception
    {
        public ExceptionRequiredObjectNotFound(string s)
            : base(s)
        {
        }
    }
}