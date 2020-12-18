using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameTicTacToe
{
    /// <summary>
    /// Вертикальная линия
    /// </summary>
    public class LineVertical : ILine
    {
        Graphics graphics;
        Pen pen;
        int width;
        public LineVertical(Graphics _graphics, Pen _pen, int _width)
        {
            graphics = _graphics;
            pen = _pen;
            width = _width;
        }
        public ILine Clone()
        {
            return new LineVertical(graphics, pen, width);
        }
        public void draw(int y)
        {
            graphics.DrawLine(pen, 0, y, 375, y);
        }
    }
}
