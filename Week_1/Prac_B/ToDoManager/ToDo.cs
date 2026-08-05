public class Todo
{
    private List<string> tasks = new List<string>();
    private Dictionary<string, List<int>> tags = new Dictionary<string, List<int>>();

    public void AddTask(string task)
    {
        tasks.Add(task);
    }

    public void RemoveTask(int id)
    {
        id = id-1;
        tasks.RemoveAt(id);
    }

    public void DisplayTasks()
    {
        for (int i = 0; i < tasks.Count; i++)
        {
            Console.WriteLine($"Task {i+1}: {tasks[i]}");
        }
    }

    public void AddTag(int id, string tag) 
    {
        tags.Add(tag, new List<int>());
        tags[tag].Add(id-1);
    }

    public void DiplayTags()
    {
        for (int i = 0; i < tags.Count; i++)
        {
            Console.WriteLine($"Tag: {tags.ElementAt(i).Key}");

            for (int j = 0; j < tags.ElementAt(i).Value.Count; j++)
            {
                int taskID = tags.ElementAt(i).Value[j];
                Console.WriteLine($"Task {taskID + 1}: {tasks[taskID]}");
            }
        }
    }
}