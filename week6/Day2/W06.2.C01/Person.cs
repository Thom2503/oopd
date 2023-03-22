public abstract class Person
{
	public int Age { get; set; }
	public abstract string FirstName { get; set; }
	public abstract string LastName { get; set; }

	protected Person(string strFirst, string strLast, int iAge)
	{
		FirstName = strFirst;
		LastName = strLast;
		Age = iAge;
	}

	public abstract string Greet();
	public virtual string GetFullName() => $"{this.FirstName} {this.LastName}";
}