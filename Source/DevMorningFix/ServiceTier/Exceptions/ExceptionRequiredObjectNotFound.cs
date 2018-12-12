using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevMorningFix.services.Exceptions
{
    class ExceptionRequiredObjectNotFound :Exception
    {
        public ExceptionRequiredObjectNotFound(String s) 
            : base (s)
        {

        }
    }
}
