using static System.Net.Mime.MediaTypeNames;

namespace TodoConsoleWithCommands
{
    internal class OverloadDemo
    {
        public OverloadDemo(string text, int padding)
        {
            var dashes = string.Empty.PadLeft(padding, '-');
            Console.Write(dashes);
            Console.Write(" ");
            Console.Write(text);
            Console.Write(" ");
            Console.WriteLine(dashes);
        }

        public OverloadDemo(string text) : this(text, 5)
        {
            //WriteHeading(text, 5);
        }

        public static void WriteHeading(string text, int padding)
        {
            var dashes = string.Empty.PadLeft(padding, '-');
            Console.Write(dashes);
            Console.Write(" ");
            Console.Write(text);
            Console.Write(" ");
            Console.WriteLine(dashes);
        }

        public static void WriteHeading(string text)
        {
            WriteHeading(text, 5);
            //int padding = 5;
            //var dashes = string.Empty.PadLeft(padding, '-');
            //Console.Write(dashes);
            //Console.Write(" ");
            //Console.Write(text);
            //Console.Write(" ");
            //Console.WriteLine(dashes);
        }

        public static void WriteHeading2(string text, int padding = 5)
        {
            var dashes = string.Empty.PadLeft(padding, '-');
            Console.Write(dashes);
            Console.Write(" ");
            Console.Write(text);
            Console.Write(" ");
            Console.WriteLine(dashes);
        }
    }
}
