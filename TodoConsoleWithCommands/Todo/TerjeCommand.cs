using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoConsoleWithCommands.Todo
{
    internal class TerjeCommand : ICommand
    {
        public string MenuText { get; } = "Terje!";

        public TerjeCommand(TodoList todoList)
        {
        }

        public void Run()
        {
            Console.WriteLine("Terje!");
        }
    }
}
