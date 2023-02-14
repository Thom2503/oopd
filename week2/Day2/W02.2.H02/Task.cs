public class Task
{
	public string Name;
	public bool IsDone;

	public Task(string strName)
	{
		Name = strName;
	}

	public void Done()
	{
		this.IsDone = true;
	}

	public string Info()
	{
		string strIsPending = this.IsDone == true ? "Done" : "Pending";
		return $"Task: {this.Name}, Status: {strIsPending}";
	}
}