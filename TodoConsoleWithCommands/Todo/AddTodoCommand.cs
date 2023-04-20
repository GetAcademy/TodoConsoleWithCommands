namespace TodoConsoleWithCommands.Todo
{
    internal class AddTodoCommand : ICommand
    {
        private TodoList _todoList;

        public string MenuText { get; } = "Legg til";

        public AddTodoCommand(TodoList todoList)
        {
            _todoList = todoList;
        }

        public void Run()
        {
            Console.WriteLine("Legg til");
            Console.Write("Hvor mange dager til fristen? ");
            var daysToDeadlineStr = Console.ReadLine();
            var daysToDeadLine = Convert.ToInt32(daysToDeadlineStr);
            Console.Write("Hva skal gjøres? ");
            var text = Console.ReadLine();
            var todoItem = new TodoItem(text, daysToDeadLine);
            _todoList.Add(todoItem);
        }
    }
}
