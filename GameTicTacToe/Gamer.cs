using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameTicTacToe
{
    /// <summary>
    /// Абстрактный класс игрового персонажа
    /// </summary>
    public abstract class Gamer
    {
        /// <summary>
        /// Идентификатор игрока
        /// </summary>
        public int id;
        /// <summary>
        /// Имя игрового персонажа
        /// </summary>
        public string name { get; set; }
        /// <summary>
        /// Игровая фигура 
        /// </summary>
        public int figure { get; set; }
        /// <summary>
        /// Количество побед
        /// </summary>
        public int countWinds { get; set; }

        public Gamer(int _id, string _name, int _option)
        {
            id = _id;
            name = _name;
            figure = _option;
            countWinds = 0;
        }
        /// <summary>
        /// Создать игровой профиль
        /// </summary>
        /// <returns></returns>
        abstract public GameProfile Create();
    }


}
