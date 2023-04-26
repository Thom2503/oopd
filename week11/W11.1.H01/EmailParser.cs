public static class EmailParser
{
	public static (string recipient, string domain, string topLevelDomain) ParseEmail(string emailAddress)
	{
		Console.WriteLine(emailAddress);
		bool isValid = false;
		(string recipient, string domain, string topLevelDomain) invalidReturn = (null, null, null);
		emailAddress = emailAddress.Trim();
		if (emailAddress.Contains("@") == true)
			isValid = true;
		if (emailAddress.Contains(".") == true)
			isValid = true;

		if (isValid == false)
			return invalidReturn;

		string user = emailAddress.Substring(0, emailAddress.IndexOf("@"));
		Console.WriteLine(user);
		string domain = emailAddress.Substring(emailAddress.IndexOf("@") + 1);
		if (domain.Contains("@") == true)
			return invalidReturn;
		string tld = emailAddress.Substring(emailAddress.IndexOf(".") + 1);
		if (tld.Contains("@") == true)
			return invalidReturn;

		return (user, domain, tld);
	}
}