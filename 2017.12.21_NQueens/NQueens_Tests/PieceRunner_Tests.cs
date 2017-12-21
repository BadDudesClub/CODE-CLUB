using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NQueens;
using Xunit;

namespace NQueens_Tests
{
   public class PieceRunner_Tests
   {
      //Piece returns the correct total places:
      [Theory]
      [InlineData(5, 25)]
      [InlineData(6, 36)]
      [InlineData(7, 49)]
      [InlineData(8, 64)]
      [InlineData(9, 81)]
      public void GetPositions_StartOfBoard_ReturnsCorrectInput(int boardSize, int expectedTotal)
      {
         Board board = new Board(boardSize);

         PieceRunner pieceRunner = new PieceRunner(0);

         var positions = pieceRunner.GetPositions(board);

         int actualCount = positions.Count();

         Assert.Equal(expectedTotal, actualCount);
      }

      //Piece returns the correct total places:
      [Theory]
      [InlineData(3, 3, 5, 7)]
      [InlineData(0, 4, 5, 5)]
      [InlineData(4, 4, 5, 1)]
      [InlineData(0, 0, 5, 25)]
      public void GetPositions_MiddleOfBoard_ReturnsCorrectInput(int xStart, int yStart, int width, int expectedTotal)
      {
         Board board = new Board(width);

         PieceRunner pieceRunner = new PieceRunner(0);

         var positions = pieceRunner.GetPositions(board, xStart, yStart);

         int actualCount = positions.Count();

         Assert.Equal(expectedTotal, actualCount);
      }
   }
}
