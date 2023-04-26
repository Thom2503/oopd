public class Student : Person
{
    public string StudentId { get; set; }

	public override bool Equals(Object other)
	{
		if (other == null)
			return false;
		if (other is not Person)
			return false;

		return base.Equals(other);
	}
}