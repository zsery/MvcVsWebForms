namespace Utils
{
    using System;
    using System.Net.Http;

    public class ValidationException:Exception
    {
        ValidationExceptionType Type;

        public ValidationException(string message, ValidationExceptionType type)
            : base(message)
        {
            this.Type = type;
        }
    }
}