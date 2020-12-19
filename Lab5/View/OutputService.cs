using Lab5.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5.View
{
    class OutputService: IOutputService
    {
        public void ShowMessage(string msg)
        {
            Console.WriteLine(msg);
        }
    }
}
