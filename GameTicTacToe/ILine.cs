using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameTicTacToe
{
    /// <summary>
    /// Прототип для линии
    /// </summary>
    public interface ILine
    {
        /// <summary>
        /// Клонирование
        /// </summary>
        /// <returns></returns>
        ILine Clone();
        /// <summary>
        /// Отрисовка
        /// </summary>
        /// <param name="x"></param>
        void draw(int x);

    }


}