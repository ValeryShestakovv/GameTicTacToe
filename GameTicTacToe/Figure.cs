using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace GameTicTacToe
{
    /// <summary>
    /// Геометрическая фигура
    /// </summary>
    public abstract class Figure
    {
        public IColorFigure colorFigure;

        public Color color;

        public IColorFigure Color
        {
            set { colorFigure = value; }
        }
        public Figure(IColorFigure _color)
        {
            colorFigure = _color;
            color = colorFigure.getColor();
        }
        public virtual void setColor()
        {
            color = colorFigure.getColor();
        }
        /// <summary>
        /// Вычисление параметров фигуры
        /// </summary>
        /// <param name="section">Номер секции</param>
        protected abstract void calc(int x, int y);
    }
}
