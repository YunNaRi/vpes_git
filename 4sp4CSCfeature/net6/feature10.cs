global using System.Runtime.CompilerServices;
global using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class feature10
    {

        public sealed record  Point0
        {
            public double x { get; init; }
            public double y { get; init; }

            public sealed override string ToString()
            {
                return base.ToString();
            }
        }

        public record Point00
        {
            public double x { get; init; }
            public double y { get; init; }

            internal void Deconstruct(out int x, out int y)
            {
                x = 0;
                y = 0;
            }
        }

        public record struct Point
        {
            public double x { get; init; }
            public double y { get; init; }

        }

        public record struct Point2
        {
            public double x { get; set; }
            public double y { get; set; }
        }

        public record struct Point3
        {
            public double x { get; set;  }
            public double y { get; set; }
        }

        public record struct Point4 ( double x, double y );


        public readonly struct Point5
        {
            public Point5()
            {
                x = double.NaN; 
                y = double.NaN;
            }

            public Point5(double x, double y)
            {
                this.x = x;
                this.y = y;
            }

            public double x { get; init; }
            public  double y { get; init; }

            public override string ToString() => $"{x} {y}";
        }

        public static void test()
        {
            Point5 p1 = new Point5();
            Console.WriteLine(p1);

            Point5 p2 = new Point5(1, 1);
            Console.WriteLine(p2);

            Point5 p3 = default(Point5);
            Console.WriteLine(p3);

            var p4 = new Point5[2]; 
            Console.WriteLine(String.Join(",",p4));




        }

        public enum LogLevel
        {
            Off,
            Critical,
            Error,
            Warning,
            Information,
            Trace
        }

        public class Logger
        {
            public LogLevel EnabledLevel { get; init; } = LogLevel.Error;

            public void LogMessage(LogLevel level, string msg)
            {
                if (EnabledLevel < level) return;
                Console.WriteLine(msg);
            }

            public void LogMessage(LogLevel level, [InterpolatedStringHandlerArgument("", "level")] LogInterpolatedStringHandler builder)
            {
                if (EnabledLevel < level) return;
                Console.WriteLine(builder.GetFormattedText());
            }

        }


        [InterpolatedStringHandler]
        public ref struct LogInterpolatedStringHandler
        {
            // Storage for the built-up string
            StringBuilder builder;


            private readonly bool enabled;

            public LogInterpolatedStringHandler(int literalLength, int formattedCount, Logger logger, LogLevel logLevel)
            {
                enabled = logger.EnabledLevel >= logLevel;
                builder = new StringBuilder(literalLength);
                Console.WriteLine($"\tliteral length: {literalLength}, formattedCount: {formattedCount}");
            }

            public void AppendLiteral(string s)
            {
                Console.WriteLine($"\tAppendLiteral called: {{{s}}}");
                if (!enabled) return;

                builder.Append(s);
                Console.WriteLine($"\tAppended the literal string");
            }

            public void AppendFormatted<T>(T t)
            {
                Console.WriteLine($"\tAppendFormatted called: {{{t}}} is of type {typeof(T)}");
                if (!enabled) return;

                builder.Append(t?.ToString());
                Console.WriteLine($"\tAppended the formatted object");
            }

            public void AppendFormatted<T>(T t, string format) where T : IFormattable
            {
                Console.WriteLine($"\tAppendFormatted (IFormattable version) called: {t} with format {{{format}}} is of type {typeof(T)},");

                builder.Append(t?.ToString(format, null));
                Console.WriteLine($"\tAppended the formatted object");
            }

            internal string GetFormattedText() => builder.ToString();
        }

        public static void test2()
        {
            var logger = new Logger() { EnabledLevel = LogLevel.Warning };
            var time = DateTime.Now;

            logger.LogMessage(LogLevel.Error, $"Error Level. CurrentTime: {time}. This is an error. It will be printed.");
            logger.LogMessage(LogLevel.Trace, $"Trace Level. CurrentTime: {time}. This won't be printed.");
            logger.LogMessage(LogLevel.Warning, "Warning Level. This warning is a string, not an interpolated string expression.");

            logger.LogMessage(LogLevel.Error, $"Error Level. CurrentTime: {time}. The time doesn't use formatting.");
            logger.LogMessage(LogLevel.Error, $"Error Level. CurrentTime: {time:t}. This is an error. It will be printed.");
            logger.LogMessage(LogLevel.Trace, $"Trace Level. CurrentTime: {time:t}. This won't be printed.");
        }

        static bool IsConferenceDay(DateTime date) {
            return date is { 
                Year: 2020, 
                Month: 5, 
                Day: 19 or 20 or 21 
            };
        }

        static string TakeFive(object input)
        {
            return input switch
            {
                string { Length: >= 5 } s => s.Substring(0, 5),
                string s => s,

                ICollection<char> { Count: >= 5 } symbols => new string(symbols.Take(5).ToArray()),
                ICollection<char> symbols => new string(symbols.ToArray()),

                null => throw new ArgumentNullException(nameof(input)),
                _ => throw new ArgumentException("Not supported input type."),
            };
        }

        public readonly struct Point6
        {
            public int X { get; }
            public int Y { get; }

            public Point6(int x, int y) => (X, Y) = (x, y);

            public void Deconstruct(out int x, out int y) => (x, y) = (X, Y);
        }

        static string Classify(Point6 point)
        {
            return point switch
            {
                (0, 0) => "Origin",
                (1, 0) => "positive X basis end",
                (0, 1) => "positive Y basis end",
                _ => "Just a point",
            };
        }

        public static void test3()
        {
            Console.WriteLine(TakeFive("Hello, world!"));  // output: Hello
            Console.WriteLine(TakeFive("Hi!"));  // output: Hi!
            Console.WriteLine(TakeFive(new[] { '1', '2', '3', '4', '5', '6', '7' }));  // output: 12345
            Console.WriteLine(TakeFive(new[] { 'a', 'b', 'c' }));  // output: abc
            Point6 point6 = new Point6(6, 6);
            Classify(point6);

            var numbers = new List<int> { 1, 2, 3 };
            if (SumAndCount(numbers) is (Sum: var sum, Count: > 0))
            {
                Console.WriteLine($"Sum of [{string.Join(" ", numbers)}] is {sum}");  // output: Sum of [1 2 3] is 6
            }

            static (double Sum, int Count) SumAndCount(IEnumerable<int> numbers)
            {
                int sum = 0;
                int count = 0;
                foreach (int number in numbers)
                {
                    sum += number;
                    count++;
                }
                return (sum, count);
            }
        }

        public record Point7(int X, int Y);
        public record Segment(Point7 Start, Point7 End);

        static bool IsAnyEndOnXAxis(Segment segment)
        {
            return segment 
                is { 
                    Start.Y: 0 
                }
                or { 
                    End.Y: 0 
                };
        }

        public static void test4()
        {
            IsAnyEndOnXAxis(new(new(6, 6), new(6, 6))); 
            string name = "Mark";
            var date = DateTime.Now;

            // Composite formatting:
            Console.WriteLine("Hello, {0}! Today is {1}, it's {2:HH:mm} now.", name, date.DayOfWeek, date);
            // String interpolation:
            Console.WriteLine($"Hello, {name}! Today is {date.DayOfWeek}, it's {date:HH:mm} now.");
            // Both calls produce the same output that is similar to:
            // Hello, Mark! Today is Wednesday, it's 19:40 now.

            Console.WriteLine($"|{"Left",-7}|{"Right",7}|");

            const int FieldWidthRightAligned = 20;
            Console.WriteLine($"{Math.PI,FieldWidthRightAligned} - default formatting of the pi number");
            Console.WriteLine($"{Math.PI,FieldWidthRightAligned:F3} - display only three decimal digits of the pi number");
            // Expected output is:
            // |Left   |  Right|
            //     3.14159265358979 - default formatting of the pi number
            //                3.142 - display only three decimal digits of the pi number

            Point00 point00 = new Point00
            {
                x = 0,
                y = 0
            };

            // Initialization:
            (int x, int y) = point00;

            // assignment:
            int x1 = 0;
            int y1 = 0;
            (x1, y1) = point00;

            int x2 = 0;
            (x2, int y2) = point00;

#line 200 "Special"
            int i;
            int j;
#line default
            char c;
            float f;
#line hidden // numbering not affected
            string s;
            double d;

        }
        public static void Validate(bool condition, [CallerArgumentExpression("condition")] string? message = null)
        {
            if (!condition)
            {
                throw new InvalidOperationException($"Argument failed validation: <{message}>");
            }
        }
    }
}
