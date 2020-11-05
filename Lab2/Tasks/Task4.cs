using Lab2.Services;
using System;

namespace Lab2.Tasks
{
    public static class Task4
    {
        public static void StartTask()
        {
            OutputService.ShowMessage("Input \"a\" value (int): ");
            int a = Convert.ToInt32(InputService.GetUserMsg());

            OutputService.ShowMessage("Input \"b\" value (int): ");
            int b = Convert.ToInt32(InputService.GetUserMsg());

            OutputService.ShowMessage($"a = {a}, b = {b}\n");

            a = a + b;
            b = a - b;
            a = a - b;

            OutputService.ShowMessage($"a = {a}, b = {b}\n");
        }
    }
}