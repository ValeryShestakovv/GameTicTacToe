using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameTicTacToe
{
    class ZeroFigure : Figure
    {
        public int x { get; set; }
        public int y { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public ZeroFigure(IColorFigure color, int _x, int _y, int _width, int _height) : base(color)
        {
            calc(_x, _y);
            width = _width;
            height = _height;
        }
        protected override void calc(int _x, int _y)
        {
            // graphics.DrawEllipse(pen, (125 * x) + 10, (125 * y) + 10, 105, 105);
            x = (125 * _x) + 10;
            y = (125 * _y) + 10;
        }
    }
}