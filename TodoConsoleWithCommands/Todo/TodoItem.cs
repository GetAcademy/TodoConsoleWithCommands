namespace TodoConsoleWithCommands.Todo
{
    internal class TodoItem
    {
        public string Text { get; set; }
        public DateTime Deadline { get; set; }
        public DateTime? Done { get; set; }
        public string AsText => Deadline.ToShortDateString().PadRight(11)
                                + (Done?.ToShortDateString() ?? "").PadRight(11)
                                + Text;

        public TodoItem(string text, DateTime deadline)
        {
            Text = text;
            Deadline = deadline;
        }

        public TodoItem(string text, int daysToDeadLine)
        : this(text, DateTime.Now.AddDays(daysToDeadLine))
        {
        }


        public void MarkAsDone()
        {
            Done = DateTime.Now;
        }
    }
}
