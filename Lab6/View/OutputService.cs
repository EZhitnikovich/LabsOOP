using System;
using System.Collections.Generic;
using System.Text;
using Lab6.Interfaces;

namespace Lab6.View
{
    class OutputService : IOutputService
    {
        public void PrintLine(string msg)
        {
            Console.WriteLine(msg);
        }

        public void Print(string msg)
        {
            Console.Write(msg);
        }
    }
}
