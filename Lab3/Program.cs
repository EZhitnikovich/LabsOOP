using System;
using System.Collections.Generic;
using System.Reflection;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IDataTypeTester> dataTypeTesters = new List<IDataTypeTester>
            {
                new DataTypesTester<bool>(true, false),
                new DataTypesTester<byte>(1, 102),
                new DataTypesTester<short>(5, 2),
                new DataTypesTester<int>(2, 4),
                new DataTypesTester<long>(6, 2),
                new DataTypesTester<float>(6.1f, 2.4f),
                new DataTypesTester<double>(5.6, 2.1),
                new DataTypesTester<char>('c', 'b')
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
