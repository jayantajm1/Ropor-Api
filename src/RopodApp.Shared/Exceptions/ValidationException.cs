using System;
using System.Collections.Generic;
using RopodApp.Shared.Models;

namespace RopodApp.Shared.Exceptions
{
    public class ValidationException : BusinessException
    {
        public List<ValidationError> ValidationErrors { get; }

        public ValidationException(List<ValidationError> validationErrors)
            : base("One or more validation errors occurred.", 422)
        {
            ValidationErrors = validationErrors;
        }

        public ValidationException(string field, string message) : base(message, 422)
        {
            ValidationErrors = new List<ValidationError>
            {
                new ValidationError { Field = field, Message = message }
            };
        }
    }
}
