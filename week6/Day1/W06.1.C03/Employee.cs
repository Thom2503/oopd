public class Employee : IPayable
{
    public double Salary { get; set; }
    public int EmployeeId { get; set; }
    public static int EmployeeCounter = 0;
	public string Name { get; set; }

	public string Info
	{
		get => $"ID: {this.EmployeeId} ({this.Name}); {this.Salary}/month";
	}

    public Employee(string name, double salary)
    {
        Name = name;
        Salary = salary;
        EmployeeId = ++EmployeeCounter;
    }

	public double GetPaymentAmount() => this.Salary;
}