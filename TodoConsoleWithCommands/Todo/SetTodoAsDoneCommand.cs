namespace TodoConsoleWithCommands.Todo
{
    internal class SetTodoAsDoneCommand : ICommand
    {
        private readonly TodoList _todoList;
        public string MenuText { get; } = "Sett som gjort";

        public SetTodoAsDoneCommand(TodoList todoList)
        {
            _todoList = todoList;
        }
        public void Run()
        {
            Console.Write("Hvilket nr vil du sette som utført? ");
            var noStr = Console.ReadLine();
            var no = Convert.ToInt32(noStr);
            var index = no - 1;
            _todoList.MarkAsDone(index);
        }
    }
}
