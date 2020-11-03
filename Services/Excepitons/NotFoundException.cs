using System;

namespace SalesWebMvc.Services.Excepitons
    {
    public class NotFoundException : ApplicationException
        {

        public NotFoundException(string message) : base(message)
            {
            }



        }
    }
