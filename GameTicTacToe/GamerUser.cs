using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameTicTacToe
{
    public class GamerUser : Gamer
    {
        public GamerUser(int id, string name, int figure) : base(id, name, figure)
        { }

        public override GameProfile Create()
        {
            return new UserGameProfile();
        }
    }
}
