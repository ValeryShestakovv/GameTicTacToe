using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameTicTacToe
{
    /// <summary>
    /// Создаем игрового персонажа, управлемым человеком
    /// </summary>
    public class GamerUser : Gamer
    {
        //c помощью base мы обращаемся к конструктору родительского класса Gamer
        public GamerUser(int id, string name, int figure) : base(id, name, figure)
        { }

        public override GameProfile Create()
        {
            return new UserGameProfile();
        }
    }
}
