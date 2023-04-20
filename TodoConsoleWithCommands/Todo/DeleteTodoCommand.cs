namespace TodoConsoleWithCommands.Todo
{
    internal class DeleteTodoCommand : ICommand
    {
        private readonly TodoList _todoList;
        public string MenuText { get; } = "Slett";

        public DeleteTodoCommand(TodoList todoList)
        {
            _todoList = todoList;
        }
        public void Run()
        {
            Console.Write("Hvilket nr vil du slette? ");
            var noStr = Console.ReadLine();
            var no = Convert.ToInt32(noStr);
            var index = no - 1;
            _todoList.Delete(index);
        }
    }
}
