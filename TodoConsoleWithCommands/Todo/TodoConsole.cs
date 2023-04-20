using System.Reflection;

namespace TodoConsoleWithCommands.Todo
{
    internal class TodoConsole
    {
        public static void RunWithCommands()
        {
            var todoList = new TodoList();

            //var commands = new ICommand[]
            //{
            //    new AddTodoCommand(todoList),
            //    new DeleteTodoCommand(todoList),
            //    new SetTodoAsDoneCommand(todoList),
            //};

            //var type = typeof(TodoItem);
            var iCommandType = typeof(ICommand);

            var allTypes = Assembly.GetExecutingAssembly().GetTypes();
            var commandTypes = allTypes.Where(t => t.IsAssignableTo(iCommandType) && t != iCommandType).ToArray();
            var commands = new List<ICommand>();
            foreach (var commandType in commandTypes)
            {
                var instance = (ICommand)Activator.CreateInstance(commandType, new object[]{todoList});
                commands.Add(instance);
            }


            while (true)
            {
                Console.Clear();
                Console.WriteLine("Todo:");
                Console.WriteLine(todoList.ListAsText());
                Console.WriteLine("Kommandoer");
                for (var index = 0; index < commands.Count; index++)
                {
                    var command = commands[index];
                    var commandNo = index + 1;
                    Console.WriteLine($"{commandNo}: {command.MenuText}");
                }
                var selectedCommandNo = Console.ReadLine();
                var selectedCommandIndex = Convert.ToInt32(selectedCommandNo) - 1;
                commands[selectedCommandIndex].Run();
            }
        }


        public static void RunWithoutCommands()
        {
            var todoList = new TodoList();

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Todo:");
                Console.WriteLine(todoList.ListAsText());
                Console.WriteLine("Kommandoer");
                Console.WriteLine("1 - legg til");
                Console.WriteLine("2 - slett");
                Console.WriteLine("3 - marker som utført");

                var cmd = Console.ReadLine();
                if (cmd == "1")
                {
                    Console.WriteLine("Legg til");
                    Console.Write("Hvor mange dager til fristen? ");
                    var daysToDeadlineStr = Console.ReadLine();
                    var daysToDeadLine = Convert.ToInt32(daysToDeadlineStr);
                    Console.Write("Hva skal gjøres? ");
                    var text = Console.ReadLine();
                    var todoItem = new TodoItem(text, daysToDeadLine);
                    todoList.Add(todoItem);
                }
                else if (cmd == "2")
                {
                    Console.Write("Hvilket nr vil du slette? ");
                    var noStr = Console.ReadLine();
                    var no = Convert.ToInt32(noStr);
                    var index = no - 1;
                    todoList.Delete(index);
                }
                else if (cmd == "3")
                {
                    Console.Write("Hvilket nr vil du sette som utført? ");
                    var noStr = Console.ReadLine();
                    var no = Convert.ToInt32(noStr);
                    var index = no - 1;
                    todoList.MarkAsDone(index);
                }
            }
        }



    }
}
