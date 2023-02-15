class CarFactory
{
	public int MaxAmount;

	public CarFactory(int iMaxAmount)
	{
		MaxAmount = iMaxAmount;
	}

	public LimitedEditionCar? ProduceLimitedEditionCar()
	{
		if (LimitedEditionCar.Counter >= this.MaxAmount)
			return null;

		LimitedEditionCar.Counter++;

		return new LimitedEditionCar();
	}
}