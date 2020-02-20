using System;
using System.Collections.Generic;
using System.Text;
using TestSystem.Common.Enums;

namespace TestSystem.Common.Exceptions
{
    public class InvalidParamsSystemException : SystemException
    {
        public InvalidParamsSystemException(HttpCode statusCode = HttpCode.BadRequest)
            : base(statusCode) { }

        public InvalidParamsSystemException(string message, HttpCode statusCode = HttpCode.BadRequest)
            : base(statusCode, message) { }

        public InvalidParamsSystemException(string message, Exception innerException, HttpCode statusCode = HttpCode.BadRequest)
            : base(statusCode, message, innerException) { }
    }
}
