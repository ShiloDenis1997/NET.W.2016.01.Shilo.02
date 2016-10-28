using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6.Logic
{
    /// <summary>
    /// Exception to determine when argument contains illegal characters
    /// </summary>
    public class ArgumentIllegalCharactersException : ArgumentException
    {
        public ArgumentIllegalCharactersException() {}

        public ArgumentIllegalCharactersException(string message)
            : base(message) {}

        public ArgumentIllegalCharactersException
            (string message, Exception exception)
            :base(message, exception) { }

        public ArgumentIllegalCharactersException
            (string message, string paramName)
            :base(message, paramName) { }
    }
}
