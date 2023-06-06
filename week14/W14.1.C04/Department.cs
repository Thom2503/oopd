public class Department
{
	public string Name { get; set; }
	private Queue<Request> _requests { get; set; }

	public Department(string name)
	{
		Name = name;
		_requests = new Queue<Request>();
	}

	public void AddRequest(Request request) => _requests.Enqueue(request);

	public Request SolveNextRequest() => _requests.Dequeue();
	//public Request SolveNextRequest()
	//{
	//	_requests.Dequeue();
	//	return _requests.Peek();
	//}

	public Request GetNextRequest() => _requests.Peek();

	public void PrintAllRequests()
	{
		foreach (Request _request in _requests)
		{
			Console.Write(_request.ToString());
			Console.WriteLine();
		}
	}
}