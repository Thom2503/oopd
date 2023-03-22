public class Consultant : IPayable
{
    public double HourlyRate { get; set; }
    public int HoursWorked { get; set; }
	public string Name { get; set; }

	public string Info
	{
		get => $"{this.Name}; {this.HourlyRate}/hour";
	}

    public Consultant(string name, double hourlyRate)
    {
        Name = name;
        HourlyRate = hourlyRate;
    }

	public double GetPaymentAmount() => this.HoursWorked * this.HourlyRate;
}