public class ToDo
{
	public List<Task> TaskList;

	public ToDo()
	{
		TaskList = new List<Task>();
	}

	public void AddTask(string strTaskName)
	{
		Task newTask = new Task(strTaskName);
		this.TaskList.Add(newTask);
	}

	public Task GetTask(string strTaskName)
	{
		foreach (Task task in this.TaskList)
		{
			if (task.Name == strTaskName)
				return task;
		}
		return null;
	}

	public string Report()
	{
		string strReport = "";

		foreach (Task task in this.TaskList)
		{
			strReport += task.Info() + "\n";
		}

		return strReport;
	}
}