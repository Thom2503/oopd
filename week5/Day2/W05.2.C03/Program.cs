public static class Program
{
	public static void Main(string[] args)
	{
		BankAccount bankAccount = new BankAccount(10000.00);
		Console.WriteLine(bankAccount.Withdraw(100.00));
		Console.WriteLine(bankAccount.Withdraw(9900.00));
	}
}