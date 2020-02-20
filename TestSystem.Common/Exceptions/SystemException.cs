using System;
using System.Collections.Generic;
using System.Text;
using TestSystem.Common.Enums;

namespace TestSystem.Common.Exceptions
{
    public class SystemException : Exception
    {
        public HttpCode StatusCode { get; set; }

        public SystemException(HttpCode statusCode) : base()
        {
            StatusCode = statusCode;
        }

        public SystemException(HttpCode statusCode, string message) : base(message)
        {
            StatusCode = statusCode;
        }

        public SystemException(HttpCode statusCode, string message, Exception innerException) : base(message, innerException)
        {
            StatusCode = statusCode;
        }
    }
}
