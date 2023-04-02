public class KeyValuePair<TKey, TVal>
{
	public TKey Key { get; set; }
	public TVal Value { get; set; }

	public KeyValuePair(TKey key, TVal val)
	{
		Key = key;
		Value = val;
	}

}