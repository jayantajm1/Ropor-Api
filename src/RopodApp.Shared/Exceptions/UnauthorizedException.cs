using System;

namespace RopodApp.Shared.Exceptions
{
    public class UnauthorizedException : BusinessException
    {
        public UnauthorizedException(string message = "Unauthorized access.") : base(message, 401)
        {
        }

        public UnauthorizedException(string message, Exception innerException)
            : base(message, innerException, 401)
        {
        }
    }
}
