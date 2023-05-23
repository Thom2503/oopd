public static class HOF
{
    // Filter goes here
	public static List<T> Filter<T>(List<T> lst, Func<T, bool> func)
	{
		List<T> newlst = new List<T>();
		foreach (T _lItem in lst)
			if (func(_lItem) == true)
				newlst.Add(_lItem);

		return newlst;
	}
}