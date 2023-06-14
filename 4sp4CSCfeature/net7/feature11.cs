using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class feature11
    {
        // Before C# 11:
        public class TypeAttribute : Attribute
        {
            public TypeAttribute(Type t)
            {
                ParamType = t;
            }

            public Type ParamType { get; }
        }

        [TypeAttribute(typeof(string))]
        public string Method()
        {
            return default;
        }
        // C# 11 feature:
        public class GenericAttribute<T> : Attribute { }

        [GenericAttribute<string>()]
        public string Method2()
        {
            return default;
        }



        public static void test()
        {
            int safetyScore = 40;
            string message = $"The usage policy for {safetyScore} is {safetyScore switch
            {
                > 90 => "Unlimited usage",
                > 80 => "General usage, with daily safety check",
                > 70 => "Issues must be addressed within 1 week",
                > 50 => "Issues must be addressed within 1 day",
                _ => "Issues must be addressed before continued use",
            }}";

            int X = 2;
            int Y = 3;

            var pointMessage = $"""The point "{X}, {Y}" is {Math.Sqrt(X * X + Y * Y)} from the origin""";

            Console.WriteLine(pointMessage);
            // output:  The point "2, 3" is 3.605551275463989 from the origin.


            var pointMessage2 = $$"""The point {{{X}}, {{Y}}} is {{Math.Sqrt(X * X + Y * Y)}} from the origin""";
            Console.WriteLine(pointMessage2);
            // output:  The point {2, 3} is 3.605551275463989 from the origin.

            int x = -8;
            Console.WriteLine($"Before:    {x,11}, hex: {x,8:x}, binary: {Convert.ToString(x, toBase: 2),32}");

            int y = x >> 2;
            Console.WriteLine($"After  >>: {y,11}, hex: {y,8:x}, binary: {Convert.ToString(y, toBase: 2),32}");

            int z = x >>> 2;
            Console.WriteLine($"After >>>: {z,11}, hex: {z,8:x}, binary: {Convert.ToString(z, toBase: 2).PadLeft(32, '0'),32}");
            // Output:
            // Before:             -8, hex: fffffff8, binary: 11111111111111111111111111111000
            // After  >>:          -2, hex: fffffffe, binary: 11111111111111111111111111111110
            // After >>>:  1073741822, hex: 3ffffffe, binary: 00111111111111111111111111111110
        }

        public readonly struct Measurement
        {
            public Measurement()
            {
                Value = double.NaN;
                Description = "Undefined";
            }

            public Measurement(double value, string description)
            {
                Value = value;
                Description = description;
            }

            public double Value { get; init; }
            public string Description { get; init; }

            public override string ToString() => $"{Value} ({Description})";
        }


        public static void test2()
        {
            var m1 = new Measurement();
            Console.WriteLine(m1);  // output: NaN (Undefined)

            var m2 = default(Measurement);
            Console.WriteLine(m2);  // output: 0 ()

            var ms = new Measurement[2];
            Console.WriteLine(string.Join(", ", ms));  // output: 0 (), 0 ()

            ReadOnlySpan<byte> AuthWithTrailingSpace = new byte[] { 0x41, 0x55, 0x54, 0x48, 0x20 };
            ReadOnlySpan<byte> AuthStringLiteral = "AUTH "u8;
            byte[] AuthStringLiteral2 = "AUTH "u8.ToArray();

            var person = new VersionNinePoint2.Person("John");
            person = new VersionNinePoint2.Person { FirstName = "John" };
            // Error CS9035: Required member `Person.FirstName` must be set:
            //person = new VersionNinePoint2.Person();


        }

    }
}
