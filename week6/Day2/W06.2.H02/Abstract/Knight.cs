namespace Abstract;

public class Knight : ChessPiece
{

	public Knight(int iX, int iY, bool isWhite) : base(iX, iY, isWhite) {}

	public override bool CanMove(int iToX, int iToY)
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