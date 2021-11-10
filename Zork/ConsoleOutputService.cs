using System;
using System.Collections.Generic;
using System.Text;
using Zork.Common;

namespace Zork
{
    internal class ConsoleOutputService : IOutputService
    {
        public void Write(object value)
        {
            Console.Write(Value);
        }


        void WriteLine(object value)
        {
            Console.WriteLine(value);
        }

    }
}
