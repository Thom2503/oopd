namespace Interface;

public class Knight : IChessPiece
{
	public int X { get; set; }
	public int Y { get; set; }
	public bool IsWhite { get; set; }

	public Knight(int iX, int iY, bool isWhite)
	{
		X = iX;
		Y = iY;
		IsWhite = isWhite;
	}

	public bool CanMove(int iToX, int iToY)
	{
		int xDiff = Math.Abs(this.X - iToX);
		int yDiff = Math.Abs(this.Y - iToY);

		if ((xDiff == 2 && yDiff == 1) || (xDiff == 1 && yDiff == 2))
			return true;

		return false;
	}

	public override string ToString()
	{
		string strWhiteBlack = this.IsWhite == true ? "White" : "Black";
		return $"{strWhiteBlack} Knight at ({this.X}, {this.Y})";
	}
}