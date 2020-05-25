using System;

namespace WindowsFormsApp.Exceptions
{
    class DomainException : ApplicationException
    {
        public DomainException(string message) : base(message) { }
    }
}
