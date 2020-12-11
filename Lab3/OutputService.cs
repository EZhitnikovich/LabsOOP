using System;
using System.Collections.Generic;
using System.Text;

namespace Lab3
{
    public static class OutputService
    {
        public static void ShowMessage<T>(T msg)
        {
            Console.WriteLine(msg);
        }
    }
}
