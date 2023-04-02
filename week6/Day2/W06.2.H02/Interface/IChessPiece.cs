namespace Interface;

public interface IChessPiece
{
	public int X { get; set; }
	public int Y { get; set; }
	public bool IsWhite { get; set; }

	 bool CanMove(int iToX, int iToY);
}