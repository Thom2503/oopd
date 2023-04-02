namespace Abstract;

public abstract class ChessPiece
{
	public int X { get; set; }
	public int Y { get; set; }
	public bool IsWhite { get; set; }

	protected ChessPiece(int iX, int iY, bool isWhite)
	{
		X = iX;
		Y = iY;
		IsWhite = isWhite;
	}

	public abstract bool CanMove(int iToX, int iToY);
}