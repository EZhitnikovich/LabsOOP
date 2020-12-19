using System;
using System.Collections.Generic;
using System.Text;
using Lab6.Interfaces;

namespace Lab6.Utils
{
    class InputService : IInputService
    {
        public string GetUserMsg()
        {
            return Console.ReadLine();
        }
    }
}
