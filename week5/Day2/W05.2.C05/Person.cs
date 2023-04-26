public class Person
{
	private string _firstName;
	private string _lastName;

	public string FullName { get => $"{_firstName} {_lastName}"; }

	public Person(string firstName, string lastName)
	{
		_firstName = firstName;
		_lastName = lastName;
	}
}