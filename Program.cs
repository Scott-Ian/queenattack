using System;
using System.Collections.Generic;
using Chess.Pieces;

namespace Chess
{
	public class Program
	{
		static void Main()
		{
			int queenXPosition;
			int queenYPosition;
			int opponentXPosition;
			int opponentYPosition;

			Console.WriteLine("Welcome to PROGRAM NAME");
			queenXPosition = GetPosition("Queen", "X");
			queenYPosition = GetPosition("Queen", "Y");

			opponentXPosition = GetPosition("Enemy", "X");
			opponentYPosition = GetPosition("Enemy", "Y");

			Queen queen = new Queen(queenXPosition, queenYPosition);
			Console.WriteLine("Queen x: " + queen.PositionX);
			Console.WriteLine("Queen y: " + queen.PositionY);

			if (queen.CanQueenMove(opponentXPosition, opponentYPosition))
			{
				Console.WriteLine("Opponent x: " + opponentXPosition);
				Console.WriteLine("Opponent y: " + opponentYPosition);
				Console.WriteLine("ATTACK!");
			}
			else
			{
				Console.WriteLine("Nay");
			}
		}
		
		private static int GetPosition (string gamePiece, string axis) 
		{
			Console.WriteLine("Please enter the " + axis + " axis position for the " + gamePiece);
			string userInput = Console.ReadLine();
			int position;
			bool canBeParsed = int.TryParse(userInput, out position);
				
			if (canBeParsed)
			{
				position = int.Parse(userInput);
				if (position <= 0 || position >= 9)
				{
					Console.WriteLine("Please enter a number betweeen 1 and 8, inclusive.");
					position = GetPosition(gamePiece, axis);
					return position;  
				} 
				else 
				{
					
					return position;
				}
			}
			else
			{
				Console.WriteLine("Numbers Only!");
				position = GetPosition(gamePiece, axis);
				return position;
			}
		}
	}
}