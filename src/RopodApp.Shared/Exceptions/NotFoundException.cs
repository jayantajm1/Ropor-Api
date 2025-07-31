using System;

namespace RopodApp.Shared.Exceptions
{
    public class NotFoundException : BusinessException
    {
        public NotFoundException(string message) : base(message, 404)
        {
        }

        public NotFoundException(string resourceName, object key)
            : base($"{resourceName} with key '{key}' was not found.", 404)
        {
        }
    }
}
