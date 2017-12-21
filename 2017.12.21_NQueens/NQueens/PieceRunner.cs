using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NQueens
{
   public class PieceRunner : IManipulator
   {
      public PieceRunner(int piecesToPlace)
      {
         
      }

      public IEnumerable<BoardPosition> GetPositions(IBoard board)
      {
          throw new NotImplementedException();
      }

      public IEnumerable<BoardPosition> GetPositions(IBoard board, int input_x, int input_y)
      {
          throw new NotImplementedException();
      }

      public IBoard PlacePiece(IBoard board, IPiece piece)
      {
          throw new NotImplementedException();
        }
      
      public IBoard PlacePiece(IBoard board, int piecesPlaced, IPiece piece)
      {
         throw new NotImplementedException();
      }
   }
}
