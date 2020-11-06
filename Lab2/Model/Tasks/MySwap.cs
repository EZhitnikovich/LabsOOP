namespace Lab2
{
    public static class MySwap
    {
        // Task 4
        public static void SwapNums(ref double a, ref double b)
        {
            a = a + b;
            b = a - b;
            a = a - b;
        }
    }
}