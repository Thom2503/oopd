class Ventilator
{
    public int Speed;
    public List<Button> Buttons;

    public Ventilator() => Buttons = new List<Button>()
        { new Button(), new Button(), new Button(), new Button() };

    public void PressButton(int number)
    {
		if (number < 0 || number >= this.Buttons.Count())
			return;

        for (int i = 0; i < Buttons.Count; i++)
        {
			if (number == i)
			{
            	Buttons[i].IsPressed = true;
            	Speed = number;
			} else
			{
				Buttons[i].IsPressed = false;
			}
        }
    }

    public string Blow() => Speed switch
    {
        <= 0 => "Off",
           1 => "~~~",
           2 => "≈≈≈",
        >= 3 => "===",
    };
}