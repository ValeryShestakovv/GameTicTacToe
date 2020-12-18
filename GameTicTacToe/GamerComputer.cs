using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameTicTacToe
{
    /// <summary>
    /// Создаем игрового персонажа, управлемым компьютером
    /// </summary>
    public class GamerComputer : Gamer
    {
        //c помощью base мы обращаемся к конструктору родительского класса Gamer
        public GamerComputer(int id, int figure) : base(id, "Компьютер", figure)
        { }

        public override GameProfile Create()
        {
            return new ComputerGameProfile();
        }
    }
}
