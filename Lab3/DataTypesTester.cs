using System;
using System.Collections.Generic;
using System.Text;
using static Lab3.Program;

namespace Lab3
{
    class DataTypesTester<T> : IDataTypeTester where T : unmanaged
    {
        private Func<string>[] operations;

        TestStruct<T> ExampleStruct { get; set; }

        public DataTypesTester(TestStruct<T> testSturct)
        {
            ExampleStruct = testSturct;
        }

        public Func<string>[] GetOperatiounsResults()
        {

            var Value1 = ExampleStruct.value1;
            var Value2 = ExampleStruct.value2;
            OutputService.ShowMessage(typeof(T).Name);
            int[] numbers = new[] { 0, 10, 20, 30, 40, 50 };
            unsafe
            {
                TestStruct<T> exStruct = new TestStruct<T>();
                TestStruct<T>* pointer = &exStruct;
                operations = new Func<string>[]
                {
                    () => $"{Value1} + {Value2} = {new Func<dynamic, dynamic, dynamic>((v1, v2) => v1 + v2).Invoke(Value1, Value2)}",
                    () => $"{Value1} - {Value2} = {new Func<dynamic, dynamic, dynamic>((v1, v2) => v1 - v2).Invoke(Value1, Value2)}",
                    () => $"{Value1} * {Value2} = {new Func<dynamic, dynamic, dynamic>((v1, v2) => v1 * v2).Invoke(Value1, Value2)}",
                    () => $"{Value1} / {Value2} = {new Func<dynamic, dynamic, dynamic>((v1, v2) => v1 / v2).Invoke(Value1, Value2)}",
                    () => $"{Value1} % {Value2} = {new Func<dynamic, dynamic, dynamic>((v1, v2) => v1 & v2).Invoke(Value1, Value2)}",
                    () => $"{Value1} & {Value2} = {new Func<dynamic, dynamic, dynamic>((v1, v2) => v1 & v2).Invoke(Value1, Value2)}",
                    () => $"{Value1} | {Value2} = {new Func<dynamic, dynamic, dynamic>((v1, v2) => v1 | v2).Invoke(Value1, Value2)}",
                    () => $"{Value1} && {Value2} = {new Func<dynamic, dynamic, dynamic>((v1, v2) => v1 && v2).Invoke(Value1, Value2)}",
                    () => $"{Value1} || {Value2} = {new Func<dynamic, dynamic, dynamic>((v1, v2) => v1 || v2).Invoke(Value1, Value2)}",
                    () => $"{Value1} ?? {Value2} = {new Func<dynamic, dynamic, dynamic>((v1, v2) => v1 ?? v2).Invoke(Value1, Value2)}",
                    () => $"{Value1} ^ {Value2} = {new Func<dynamic, dynamic, dynamic>((v1, v2) => v1 ^ v2).Invoke(Value1, Value2)}",
                    () => $"{Value1} > {Value2} = {new Func<dynamic, dynamic, dynamic>((v1, v2) => v1 > v2).Invoke(Value1, Value2)}",
                    () => $"{Value1} < {Value2} = {new Func<dynamic, dynamic, dynamic>((v1, v2) => v1 < v2).Invoke(Value1, Value2)}",
                    () => $"{Value1} <= {Value2} = {new Func<dynamic, dynamic, dynamic>((v1, v2) => v1 <= v2).Invoke(Value1, Value2)}",
                    () => $"{Value1} >= {Value2} = {new Func<dynamic, dynamic, dynamic>((v1, v2) => v1 >= v2).Invoke(Value1, Value2)}",
                    () => $"{Value1} == {Value2} = {new Func<dynamic, dynamic, dynamic>((v1, v2) => v1 == v2).Invoke(Value1, Value2)}",
                    () => $"{Value1} != {Value2} = {new Func<dynamic, dynamic, dynamic>((v1, v2) => v1 != v2).Invoke(Value1, Value2)}",
                    () => $"{Value1} >> {Value2} = {new Func<dynamic, dynamic, dynamic>((v1, v2) => v1 >> v2).Invoke(Value1, Value2)}",
                    () => $"{Value1} << {Value2} = {new Func<dynamic, dynamic, dynamic>((v1, v2) => v1 << v2).Invoke(Value1, Value2)}",
                    () => $"{Value1} = {Value2} = {new Func<dynamic, dynamic, dynamic>((v1, v2) => v1 = v2).Invoke(Value1, Value2)}",
                    () => $"{Value1} += {Value2} = {new Func<dynamic, dynamic, dynamic>((v1, v2) => v1 += v2).Invoke(Value1, Value2)}",
                    () => $"{Value1} -= {Value2} = {new Func<dynamic, dynamic, dynamic>((v1, v2) => v1 -= v2).Invoke(Value1, Value2)}",
                    () => $"{Value1} *= {Value2} = {new Func<dynamic, dynamic, dynamic>((v1, v2) => v1 *= v2).Invoke(Value1, Value2)}",
                    () => $"{Value1} /= {Value2} = {new Func<dynamic, dynamic, dynamic>((v1, v2) => v1 /= v2).Invoke(Value1, Value2)}",
                    () => $"{Value1} %= {Value2} = {new Func<dynamic, dynamic, dynamic>((v1, v2) => v1 %= v2).Invoke(Value1, Value2)}",
                    () => $"{Value1} &= {Value2} = {new Func<dynamic, dynamic, dynamic>((v1, v2) => v1 &= v2).Invoke(Value1, Value2)}",
                    () => $"{Value1} |= {Value2} = {new Func<dynamic, dynamic, dynamic>((v1, v2) => v1 |= v2).Invoke(Value1, Value2)}",
                    () => $"{Value1} ??= {Value2} = {new Func<dynamic, dynamic, dynamic>((v1, v2) => v1 ??= v2).Invoke(Value1, Value2)}",
                    () => $"{Value1} ^= {Value2} = {new Func<dynamic, dynamic, dynamic>((v1, v2) => v1 ^= v2).Invoke(Value1, Value2)}",
                    () => $"{Value1} >>= {Value2} = {new Func<dynamic, dynamic, dynamic>((v1, v2) => v1 >>= v2).Invoke(Value1, Value2)}",
                    () => $"{Value1} <<= {Value2} = {new Func<dynamic, dynamic, dynamic>((v1, v2) => v1 <<= v2).Invoke(Value1, Value2)}",
                    () => $"{Value2}++ = {new Func<dynamic, dynamic>((v1) => v1++).Invoke(Value2)}",
                    () => $"++{Value2} = {new Func<dynamic, dynamic>((v1) => ++v1).Invoke(Value2)}",
                    () => $"{Value2}-- = {new Func<dynamic, dynamic>((v1) => v1--).Invoke(Value2)}",
                    () => $"--{Value2} = {new Func<dynamic, dynamic>((v1) => --v1).Invoke(Value2)}",
                    () => $"~{Value2} = {new Func<dynamic, dynamic>((v1) => ~v1).Invoke(Value2)}",
                    () => $"!{Value2} = {new Func<dynamic, dynamic>((v1) => !v1).Invoke(Value2)}",
                    () => $"{Value1} > {Value2} ? true : false = {new Func<dynamic, dynamic, dynamic>((v1, v2) => v1 > v2 ? true : false).Invoke(Value1, Value2)}",
                    () => $"+{Value2} = {new Func<dynamic, dynamic>((v1) => +v1).Invoke(Value2)}",
                    () => $"-{Value2} = {new Func<dynamic, dynamic>((v1) => -v1).Invoke(Value2)}",
                    () => $"{Value2}! = {new Func<dynamic, dynamic>((v1) => v1!).Invoke(Value2)}",
                    () => $"(byte){Value2} = {new Func<dynamic, dynamic>((v1) => (byte)v1).Invoke(Value2)}",
                    () => $"(short){Value2} = {new Func<dynamic, dynamic>((v1) => (short)v1).Invoke(Value2)}",
                    () => $"(char){Value2} = {new Func<dynamic, dynamic>((v1) => (char)v1).Invoke(Value2)}",
                    () => $"(int){Value2} = {new Func<dynamic, dynamic>((v1) => (int)v1).Invoke(Value2)}",
                    () => $"(long){Value2} = {new Func<dynamic, dynamic>((v1) => (long)v1).Invoke(Value2)}",
                    () => $"(float){Value2} = {new Func<dynamic, dynamic>((v1) => (float)v1).Invoke(Value2)}",
                    () => $"(double){Value2} = {new Func<dynamic, dynamic>((v1) => (double)v1).Invoke(Value2)}",
                    () => $"(decimal){Value2} = {new Func<dynamic, dynamic>((v1) => (decimal)v1).Invoke(Value2)}",
                    () => $"(bool){Value2} = {new Func<dynamic, dynamic>((v1) => (bool)v1).Invoke(Value2)}",
                    () => $"{Value2} is byte = {new Func<dynamic, dynamic>((v1) => v1 is byte).Invoke(Value2)}",
                    () => $"{Value2} is short = {new Func<dynamic, dynamic>((v1) => v1 is short).Invoke(Value2)}",
                    () => $"{Value2} is char = {new Func<dynamic, dynamic>((v1) => v1 is char).Invoke(Value2)}",
                    () => $"{Value2} is int = {new Func<dynamic, dynamic>((v1) => v1 is int).Invoke(Value2)}",
                    () => $"{Value2} is long = {new Func<dynamic, dynamic>((v1) => v1 is long).Invoke(Value2)}",
                    () => $"{Value2} is float = {new Func<dynamic, dynamic>((v1) => v1 is float).Invoke(Value2)}",
                    () => $"{Value2} is double = {new Func<dynamic, dynamic>((v1) => v1 is double).Invoke(Value2)}",
                    () => $"{Value2} is decimal = {new Func<dynamic, dynamic>((v1) => v1 is decimal).Invoke(Value2)}",
                    () => $"{Value2} is bool = {new Func<dynamic, dynamic>((v1) => v1 is bool).Invoke(Value2)}",
                    () => $"{Value1}..{Value2} = {GetRangeResultString<T>((v1, v2, arr) => arr[v1..v2], Value1, Value2, numbers)}",
                    () => $"{Value1}..^{Value2} = {GetRangeResultString<T>((v1, v2, arr) => arr[v1..^v2], Value1, Value2, numbers)}",
                    () => $"^{Value1}..{Value2} = {GetRangeResultString<T>((v1, v2, arr) => arr[^v1..v2], Value1, Value2, numbers)}",
                    () => $"^{Value1}..^{Value2} = {GetRangeResultString<T>((v1, v2, arr) => arr[^v1..^v2], Value1, Value2, numbers)}",
                    () => $"..^{Value2} = {GetRangeResultString<T>((v2, v1, arr) => arr[..^v2], Value1, Value2, numbers)}",
                    () => $"^{Value2}.. = {GetRangeResultString<T>((v2, v1, arr) => arr[^v2..], Value1, Value2, numbers)}",
                    () => $"..{Value2} = {GetRangeResultString<T>((v2, v1, arr) => arr[..v2], Value1, Value2, numbers)}",
                    () => $"{Value2}.. = {GetRangeResultString<T>((v2, v1, arr) => arr[v2..], Value1, Value2, numbers)}",
                    () => $"sizeof(T) = {sizeof(T)}",
                    () => $"typeof(T) = {typeof(T)}",
                    () => $"default(T) = {default(T)}",
                    () => $"&pointer = {new IntPtr(pointer)}",
                    () => $"*pointer = {*pointer}",
                    () => $"pointer->ToString() = {pointer->ToString()}",
                };
            }

            return operations;
        }

        private string GetRangeResultString<T>(Func<dynamic, dynamic, int[], int[]> func, T v1, T v2, int[] arr)
        {
            var resArr = RunDelegate(func, v1, v2, arr);
            return resArr is null ? "Operation not supported" : string.Join(',', resArr);
        }

        private int[] RunDelegate<T>(Func<T, T, int[], int[]> func, T v1, T v2, int[] arr)
        {
            try
            {
                return func.Invoke(v1, v2, arr);
            }
            catch
            {
                return null;
            }
        }
    }
}
