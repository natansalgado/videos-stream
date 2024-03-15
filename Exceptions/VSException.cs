using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace videos_steam.Exceptions
{
    public class VSException : Exception
    {
        public int StatusCode { get; set; }

        public VSException(int statusCode, string message) : base(message)
        {
            StatusCode = statusCode;
        }
    }
}