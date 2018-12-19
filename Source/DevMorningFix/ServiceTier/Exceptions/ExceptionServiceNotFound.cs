using System;

namespace DevMorningFix.services.Exceptions
{
    internal class ExceptionServiceNotFound : Exception
    {
        public ExceptionServiceNotFound(string s)
            : base(s)
        {
        }
    }
}