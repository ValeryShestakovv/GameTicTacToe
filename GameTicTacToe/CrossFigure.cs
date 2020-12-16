using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameTicTacToe
{
    class CrossFigure : Figure
    {
        public int l1x1 { get; set; }
        public int l1x2 { get; set; }
        public int l1y1 { get; set; }
        public int l1y2 { get; set; }
        public int l2x1 { get; set; }
        public int l2x2 { get; set; }
        public int l2y1 { get; set; }
        public int l2y2 { get; set; }

        public CrossFigure(IColorFigure color, int _x, int _y) : base(color)
        {
            calc(_x, _y);
        }
  
        protected override void calc(int _x, int _y)
        {
            l1x1 = (125 * _x) + 10;
            l1y1 = (125 * _y) + 10;
            l1x2 = (125 * (_x + 1)) - 10;
            l1y2 = (125 * (_y + 1)) - 10;
            l2x1 = (125 * _x) + 10;
            l2y1 = (125 * (_y + 1)) - 10;
            l2x2 = (125 * (_x + 1)) - 10;
            l2y2 = (125 * _y) + 10;
        }
    }
}