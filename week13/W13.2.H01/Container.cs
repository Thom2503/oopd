public class Container
{
	public string Code { get; }
	public string Manifest { get; }
	public string[] Categories { get; }
	public string Origin { get; }
	public double Weight { get; }
	public int Status { get; set; }

	public Container(string code, string manifest, string[] categories, string origin, string weight, int status)
	{
		Code = code;
		Manifest = manifest;
		Categories = categories;
		Origin = origin;
		Status = status;
		Weight = Math.Round(Convert.ToDouble(weight.Split(" ")[0]) * 0.45359237, 2);
	}

	public override string ToString()
	{
		string categories = string.Join(",", Categories);
		return $"Container(Code:'{Code}', Manifest:'{Manifest}', Categories:'{categories}', Origin:'{Origin}', Status:'{Status}', Weight:'{Weight}')";
	}
}