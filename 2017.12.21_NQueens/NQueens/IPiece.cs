using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NQueens
{
    public interface IPiece
    {
        int PieceType { get; }
        
        bool CanAttack(int piece_x, int piece_y, int attack_x, int attack_y);   
    }
}
