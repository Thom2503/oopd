public class IDEFactory : IFactory<IDE>
{
	public IDE CreateLightTheme() => new IDE("White", "Black", "Light blue");

	public IDE CreateDarkTheme() => new IDE("Black", "White", "Light yellow");
}