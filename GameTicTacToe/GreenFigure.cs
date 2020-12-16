using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameTicTacToe
{
    class GreenFigure : IColorFigure
    {
        public System.Drawing.Color getColor()
        {
            return System.Drawing.Color.Green;
        }
    }
}
