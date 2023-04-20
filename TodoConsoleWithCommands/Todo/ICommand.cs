namespace TodoConsoleWithCommands.Todo
{
    internal interface ICommand
    {
        string MenuText { get; }
        void Run();
    }
}
