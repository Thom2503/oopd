class LimitedEditionCar
{
	public const string Model = "Mazda RX7 VeilSide";
	public readonly string ChassisNumber = $"CHNO{LimitedEditionCar.Counter}";
	public static int Counter = 0;
}