public class Company
{
    private List<Employee> _employees { get; } = new();
    public void HireEmployee(Employee emp) => _employees.Add(emp);

    // FilterEmployees goes here
	public List<Employee> FilterEmployees(Func<Employee, bool> func)
	{
		List<Employee> employees = new List<Employee>();
		foreach (Employee _employee in _employees)
			if (func(_employee) == true)
				employees.Add(_employee);

		return employees;
	}
}