using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameTicTacToe
{
    /// <summary>
    /// Фигура - крестик
    /// </summary>
    class CrossFigure : Figure
    {
        /// <summary>
        /// Координаты точки x1 для линии 1
        /// </summary>
        public int l1x1 { get; set; }
        /// <summary>
        /// /// Координаты точки x2 для линии 1
        /// </summary>
        public int l1x2 { get; set; }
        /// <summary>
        /// /// Координаты точки y1 для линии 1
        /// </summary>
        public int l1y1 { get; set; }
        /// <summary>
        /// /// Координаты точки y2 для линии 1
        /// </summary>
        public int l1y2 { get; set; }
        /// <summary>
        /// /// Координаты точки x1 для линии 2
        /// </summary>
        public int l2x1 { get; set; }
        /// <summary>
        /// /// Координаты точки x2 для линии 2
        /// </summary>
        public int l2x2 { get; set; }
        /// <summary>
        /// /// Координаты точки y1 для линии 2
        /// </summary>
        public int l2y1 { get; set; }
        /// <summary>
        /// /// Координаты точки y2 для линии 2
        /// </summary>
        public int l2y2 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="color"></param>
        public CrossFigure(IColorFigure color, int _x, int _y) : base(color)
        {
            calc(_x, _y);
        }
  
        /// <summary>
        /// 
        /// </summary>
        /// <param name="_x"></param>
        /// <param name="_y"></param>
        protected override void calc(int _x, int _y)
        {
            // graphics.DrawLine(pen, (125 * x) + 10, (125 * y) + 10, (125 * (x+1)) - 10, (125 * (y + 1)) - 10);
            // graphics.DrawLine(pen, (125 * x) + 10, (125 * (y + 1)) - 10, (125 * (x + 1)) - 10, (125 * y) + 10);
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