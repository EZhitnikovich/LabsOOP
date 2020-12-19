using Lab5.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5.Utils
{
    class InputService: IInputService
    {
        public string GetUserMsg()
        {
            return Console.ReadLine();
        }
    }
}
