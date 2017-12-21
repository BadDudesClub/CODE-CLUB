using System;
using System.Collections.Generic;
using System.Text;
using NQueens;
using Xunit;

namespace NQueens_Tests
{
    public class Queen_Tests
    {
        [Theory]
        [InlineData("4,4", "5,3", "Bishop: Can attack one position to the upper right")]
        [InlineData("4,4","5,5", "Bishop: Can attack one position to the lower right")]
        [InlineData("4,4", "3,3", "Bishop: Can attack one position to the upper left")]
        [InlineData("4,4", "3,5", "Bishop: Can attack one position to the lower left")]
        public void CanAttack_ReturnsTrueWhenItCanAttack_Bishop(string queensPosition, string newPiecePosition, string testMessage)
        {
            int queenXCoord = Convert.ToInt32(queensPosition.Split(',')[0]);
            int queenYCoord = Convert.ToInt32(queensPosition.Split(',')[1]);

            int pieceXCoord = Convert.ToInt32(newPiecePosition.Split(',')[0]);
            int pieceYCoord = Convert.ToInt32(newPiecePosition.Split(',')[1]);

            Queen queen = new Queen();

            Assert.True(queen.CanAttack(queenXCoord, queenYCoord, pieceXCoord, pieceYCoord), testMessage);
        }

        [Theory]
        [InlineData("4,4", "5,4", "Rook: Can attack one position to the right")]
        [InlineData("4,4", "3,4", "Rook: Can attack one position to the left")]
        [InlineData("4,4", "4,3", "Rook: Can attack one position above")]
        [InlineData("4,4", "4,5", "Rook: Can attack one position below")]
        public void CanAttack_ReturnsTrueWhenItCanAttack_Rook(string queensPosition, string newPiecePosition, string testMessage)
        {
            int queenXCoord = Convert.ToInt32(queensPosition.Split(',')[0]);
            int queenYCoord = Convert.ToInt32(queensPosition.Split(',')[1]);

            int pieceXCoord = Convert.ToInt32(newPiecePosition.Split(',')[0]);
            int pieceYCoord = Convert.ToInt32(newPiecePosition.Split(',')[1]);

            Queen queen = new Queen();

            Assert.True(queen.CanAttack(queenXCoord, queenYCoord, pieceXCoord, pieceYCoord), testMessage);
        }

        [Theory]
        [InlineData("4,4", "2,3", "Knight: Can't attack upper left")]
        [InlineData("4,4", "6,3", "Knight: Can't attack upper right")]
        [InlineData("4,4", "2,5", "Knight: Can't attack lower left")]
        [InlineData("4,4", "6,5", "Knight: Can't attack lower right")]
        public void CanAttack_ReturnsFalseWhenItCantAttack_Knight(string queensPosition, string newPiecePosition, string testMessage)
        {
            int queenXCoord = Convert.ToInt32(queensPosition.Split(',')[0]);
            int queenYCoord = Convert.ToInt32(queensPosition.Split(',')[1]);

            int pieceXCoord = Convert.ToInt32(newPiecePosition.Split(',')[0]);
            int pieceYCoord = Convert.ToInt32(newPiecePosition.Split(',')[1]);

            Queen queen = new Queen();

            Assert.False(queen.CanAttack(queenXCoord, queenYCoord, pieceXCoord, pieceYCoord), testMessage);
        }
    }
}
