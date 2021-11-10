using System;
using System.Collections.Generic;
using System.Text;

namespace Zork
{
   internal class ConsoleInputService: IInputService
    {
        public event EventHandler<string> InputRecieved;
    }
}
