using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace XIVDB.Exceptions
{
    class APIErrorException : Exception
    {
        public APIErrorException()
        {
        }

        public APIErrorException(string message) : base(message)
        {
        }

        public APIErrorException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected APIErrorException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
