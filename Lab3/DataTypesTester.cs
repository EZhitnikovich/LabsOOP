using System;
using System.Collections.Generic;
using System.Text;

namespace Lab3
{
    class DataTypesTester<T> : IDataTypeTester
    {
        public T Value1 { get; set; }
        public T Value2 { get; set; }

        public DataTypesTester(T v1, T v2)
        {
            Value1 = v1;
            Value2 = v2;
        }

        public Func<string>[] GetOperatiounsResults()
        {
            OutputService.ShowMessage(typeof(T).Name);
            Func<string>[] operations = new Func<string>[]
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
                () => $"{Value2}++ = {new Func<dynamic, dynamic>((v1) => v1++).Invoke(Value2)}",
                () => $"++{Value2} = {new Func<dynamic, dynamic>((v1) => ++v1).Invoke(Value2)}",
                () => $"{Value2}-- = {new Func<dynamic, dynamic>((v1) => v1--).Invoke(Value2)}",
                () => $"--{Value2} = {new Func<dynamic, dynamic>((v1) => --v1).Invoke(Value2)}",
                () => $"~{Value2} = {new Func<dynamic, dynamic>((v1) => ~v1).Invoke(Value2)}",
                () => $"!{Value2} = {new Func<dynamic, dynamic>((v1) => !v1).Invoke(Value2)}",
                () => $"{Value1} > {Value2} ? true : false = {new Func<dynamic, dynamic, dynamic>((v1, v2) => v1 > v2 ? true : false).Invoke(Value1, Value2)}",
            };

            return operations;
        }
    }
}
