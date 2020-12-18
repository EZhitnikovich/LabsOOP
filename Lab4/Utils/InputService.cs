using Lab4.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lab4.Utils
{
    class InputService : IInputService
    {
        public string GetUserMsg()
        {
            return Console.ReadLine();
        }
    }
}
