using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameTicTacToe
{
    /// <summary>
    /// Горизонтальная линия
    /// </summary>
    public class LineHorizontal : ILine
    {
        Graphics graphics;
        Pen pen;
        int width;
        public LineHorizontal(Graphics _graphics, Pen _pen, int _width)
        {
            graphics = _graphics;
            pen = _pen;
            width = _width;
        }
        public ILine Clone()
        {
            return new LineHorizontal(graphics, pen, width);
        }
        public void draw(int x)
        {
            graphics.DrawLine(pen, x, 0, x, 375);
        }
    }
}
