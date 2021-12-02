using Microsoft.AspNetCore.Mvc;

namespace Vuture.Exceptions.ExceptionResponses
{
    public class ExceptionResponse
    {
        public ExceptionResponse(int statusCode, string message, string type)
        {
            StatusCode = statusCode;
            Message = message;
            Type = type;
        }

        private int StatusCode { get; }
        private string Message { get; }
        private string Type { get; }

        public ObjectResult CreateObjectResult()
        {
            return new(this)
            {
                Value = Message,
                StatusCode = StatusCode
            };
        }
    }
}