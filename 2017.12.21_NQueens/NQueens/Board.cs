using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace NQueens
{
   public class BoardPosition
   {
      public int XCoord;
      public int YCoord;
      public int PieceValue;
   }

   public class Board : IBoard
   {
      
      public Board(int size)
      {
         
      }

      public Board(int[,] board)
      {
          throw new NotImplementedException();
        }

      public int TotalPositions { get; }

      public int GetPieceType(int xCoord, int yCoord)
      {
          throw new NotImplementedException();
        }

      public void UpdatePosition(int xCoord, int yCoord, int pieceType)
      {
          throw new NotImplementedException();
        }

      public IBoard GetCopy()
      {
          throw new NotImplementedException();
        }
      
   }
   
}
