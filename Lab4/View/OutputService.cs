using Lab4.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lab4.View
{
    class OutputService : IOutputService
    {
        public void ShowMessage(string msg)
        {
            Console.WriteLine(msg);
        }
    }
}
