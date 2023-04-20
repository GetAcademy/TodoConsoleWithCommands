namespace TodoConsoleWithCommands
{
    internal class OverLoadDemo2
    {
        public OverLoadDemo2(char c, int i) // main
        {
            Console.WriteLine("CTOR 1");
        }

        public OverLoadDemo2(char c) : this(c, 5)
        {
            Console.WriteLine("CTOR 2");
        }

        public OverLoadDemo2() : this('x')
        {
            Console.WriteLine("CTOR 3");
        }
    }
}
