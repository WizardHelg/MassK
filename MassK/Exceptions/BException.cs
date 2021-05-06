using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MassK.Exceptions
{
    class BException : Exception
    {
        public BException(string message) : base(message) { }
    }
}
