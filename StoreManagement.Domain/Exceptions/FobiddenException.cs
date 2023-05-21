using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreManagement.Domain.Exceptions
{
    public class FobiddenException : Exception
    {
        public FobiddenException(string message):base(message) { }
    }
}
