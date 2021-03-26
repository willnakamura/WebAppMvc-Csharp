using System;

namespace SalesWebMvc.Services.Excepcions
{
    public class IntegrityException : ApplicationException
    {
        public IntegrityException(string message) : base(message)
        {
        }
    }
}
