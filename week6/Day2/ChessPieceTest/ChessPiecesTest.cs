using Interface;
using Abstract;

namespace ChessPieces.Tests;

[TestClass]
public class ChessPiecesTest
{
    /* 
        Create data rows for the following moves: 
            x=1,y=3,expected=true
            x=4,y=2,expected=true
            x=4,y=3,expected=false
    */
    [DataTestMethod]
    [DataRow(1, 3, true)]
    [DataRow(4, 2, true)]
    [DataRow(4, 3, false)]
    public void CanMove_WhiteKnight(int x, int y, bool expected)
    {
        // create a white knight object with x = 2 and y = 1
        // Assert that the boolean value returned from the CanMove method equals the expected boolean value
		Abstract.Knight wKnight = new Abstract.Knight(2, 1, true);
		string strAssertMessage = expected == true ? "The Knight should be able to move." : "The Knight shouldn't be able to move.";
		Assert.IsTrue(wKnight.CanMove(x, y) == expected, strAssertMessage);
    }

    /* 
        Create data rows for the following moves: 
            x=6,y=6,expected=true
            x=5,y=7,expected=true
            x=8,y=8,expected=false
    */
    [DataTestMethod]
    [DataRow(6, 6, true)]
    [DataRow(5, 7, true)]
    [DataRow(8, 8, false)]
    public void CanMove_BlackKnight(int x, int y, bool expected)
    {
        // create a black knight object with x = 7 and y = 8
        // Assert that the boolean value returned from the CanMove method equals the expected boolean value
		Interface.Knight bKnight = new Interface.Knight(7, 8, false);
		string strAssertMessage = expected == true ? "The Knight should be able to move." : "The Knight shouldn't be able to move.";
		Assert.IsTrue(bKnight.CanMove(x, y) == expected, strAssertMessage);
    }

}