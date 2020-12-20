using System;
using System.Collections.Generic;
using System.Reflection;

namespace Lab3
{
    class Program
    {
        public struct TestStruct<T>
        {
            public T value1;
            public T value2;
        }

        static void Main(string[] args)
        {
            List<IDataTypeTester> dataTypeTesters = new List<IDataTypeTester>
            {
                new DataTypesTester<bool>(new TestStruct<bool>(){value1 = true, value2 = false }),
                new DataTypesTester<byte>(new TestStruct<byte>(){value1 = 1, value2 = 3 }),
                new DataTypesTester<short>(new TestStruct<short>(){value1 = 1, value2 = 3 }),
                new DataTypesTester<int>(new TestStruct<int>(){value1 = 1, value2 = 3 }),
                new DataTypesTester<long>(new TestStruct<long>(){value1 = 152L, value2 = 325L }),
                new DataTypesTester<float>(new TestStruct<float>(){value1 = 1.5f, value2 = 3.523f }),
                new DataTypesTester<double>(new TestStruct<double>(){value1 = 1.5, value2 = 3.234 }),
                new DataTypesTester<char>(new TestStruct<char>(){value1 = '4', value2 = 'h' })
            };

            foreach(var type in dataTypeTesters)
            {
                ShowOperationsResults(type.GetOperatiounsResults());
            }
        }

        private static void ShowOperationsResults(Func<string>[] operations)
        {
            foreach (var operation in operations)
            {
                try
                {
                    OutputService.ShowMessage(operation.Invoke());
                }
                catch (Exception ex)
                {
                    OutputService.ShowMessage(ex.Message);
                }
            }
        }
    }
}
