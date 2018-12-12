using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevMorningFix.services.Exceptions
{
    class ExceptionServiceNotFound : Exception
    {
        public ExceptionServiceNotFound(String s) 
            : base (s)
        {

        }
    }
}
