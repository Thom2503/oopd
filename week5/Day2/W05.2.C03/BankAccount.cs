public class BankAccount
{
	private double _balance;

	public BankAccount(double dbBalance)
	{
		_balance = dbBalance;
	}

	public double ReadBalance() => _balance;

	public void Deposit(double dbAmount)
	{
		if (dbAmount > 0)
			_balance += dbAmount;
	}

	public double Withdraw(double dbAmount)
	{
		if (SufficientBalance(dbAmount))
			return 0.0;

		_balance -= dbAmount;
		return _balance;
	}

	private bool SufficientBalance(double dbAmount) 
	{
		double dbTempBal = _balance - dbAmount;
		return dbTempBal < 0;
	}
}