using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameTicTacToe
{
    public abstract class Gamer
    {
        public int id;
        public string name { get; set; }
        public int figure { get; set; }
        public int countWinds { get; set; }

        public Gamer(int _id, string _name, int _option)
        {
            id = _id;
            name = _name;
            figure = _option;
            countWinds = 0;
        }
        abstract public GameProfile Create();
    }


}
