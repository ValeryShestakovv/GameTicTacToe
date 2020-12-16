using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace GameTicTacToe
{
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
        protected abstract void calc(int x, int y);
    }
}
