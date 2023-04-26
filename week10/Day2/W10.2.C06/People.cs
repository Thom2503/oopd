using System.Collections;

public class People : IEnumerable
{
	private List<Person> _people = new List<Person>();
	
	public void Add(Person person) => _people.Add(person);

	public IEnumerator<Person> GetEnumerator()
	{
		foreach (Person _person in _people)
		{
			yield return _person;
		}
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return (IEnumerator)GetEnumerator();
	}
}