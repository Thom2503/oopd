public class Person : IEquatable<Person>
{
	public string Name { get; set; }
	public int Age { get; set; }

	public virtual bool Equals(Person other)
	{
		if (other == null)
			return false;

		return other.Name == Name && other.Age == Age;
	}
}