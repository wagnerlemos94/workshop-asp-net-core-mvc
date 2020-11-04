using System;

namespace SalesWebMvc.Services.Excepitons
    {
    public class IntegrityException : ApplicationException
        {

        public IntegrityException(string message) : base(message)
            {

            }
        }
    }
