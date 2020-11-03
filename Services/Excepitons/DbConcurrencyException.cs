using System;

namespace SalesWebMvc.Services.Excepitons
    {
    public class DbConcurrencyException : ApplicationException
        {

        public DbConcurrencyException(string message) : base(message)
            {

            }
        }
    }
