public static class Converter
{
	public static T2 ConvertVariables<T1, T2>(T1 t1) => (T2)Convert.ChangeType(t1, typeof(T2));
}