using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameTicTacToe
{
    public class GamerComputer : Gamer
    {
        public GamerComputer(int id, int figure) : base(id, "Компьютер", figure)
        { }

        public override GameProfile Create()
        {
            return new ComputerGameProfile();
        }
    }
}
