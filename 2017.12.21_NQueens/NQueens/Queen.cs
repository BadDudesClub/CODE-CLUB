using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace NQueens
{
    public class Queen : IPieceType
    {
        public int PieceType { get; }

        public bool CanAttack(int piece_x, int piece_y, int attack_x, int attack_y)
        {
            throw new NotImplementedException();
        }
    }
}
