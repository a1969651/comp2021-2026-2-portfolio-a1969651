using System;

class Program
{
    static void Main()
    {
        Todo todo = new Todo();

        todo.AddTask("Buy milk");
        todo.AddTask("Walk dog");
        todo.DisplayTasks();

        Console.WriteLine();

        todo.RemoveTask(2);
        todo.DisplayTasks();

        Console.WriteLine();

        todo.AddTag(1, "Urgent");
        todo.DiplayTags();

    }
}