using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameTicTacToe
{
    /// <summary>
    /// Игровой профиль для игрового персонажа, управлемым компьютером
    /// </summary>
    class ComputerGameProfile : GameProfile
    {
        public string name { get; set; }
        public int option { get; set; }
        /// <summary>
        /// Создать игровой профиль для игрового персонажа, управлемым компьютером
        /// </summary>
        public ComputerGameProfile()
        {
        }
    }
}
