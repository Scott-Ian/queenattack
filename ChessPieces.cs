using System;
using System.Collections.Generic;

namespace Chess.Pieces
{


  public class Queen
  {
    public int PositionX {get; set;}
    public int PositionY {get; set;}

    public Queen(int xPosition, int yPosition)
    {
      PositionX = xPosition;
      PositionY = yPosition;
    }
  }

  public class Opponent
  {
    public int OpponentPositionX {get; set;}
    public int OpponentPositionY {get; set;}

    public Opponent(int opponentXPosition, int opponentYPosition)
    {
      OpponentPositionX = opponentXPosition;
      OpponentPositionY = opponentYPosition;
    }
}
}