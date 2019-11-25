using System;

namespace Boilerplate.API.Exceptions
{
    public class UnauthorizedException : Exception
    {
        public UnauthorizedException(string message = "You are not authorized to perform this action") : base(message) { }
        public UnauthorizedException(string message, Exception inner) : base(message, inner) { }
    }
}
