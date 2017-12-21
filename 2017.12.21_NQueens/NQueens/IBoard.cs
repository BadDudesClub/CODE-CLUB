using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NQueens
{
   public interface IBoard
   {
      int TotalPositions { get; }

      int GetPieceType(int xCoord, int yCoord);
      
      void UpdatePosition(int xCoord, int yCoord, int pieceType);

      IBoard GetCopy();
   }

   public interface IManipulator
   {
      IBoard PlacePiece(IBoard board, IPiece piece);
   }
}
