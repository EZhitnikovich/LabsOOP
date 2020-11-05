using System;

namespace Lab2
{
    public static class OutputService
    {
        public static void ShowMessage<T>(T msg)
        {
            Console.WriteLine(msg);
        }
    }
}