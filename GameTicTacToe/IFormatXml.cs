using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameTicTacToe
{
    public interface IFormatXml
    {
        string write(IEnumerable saves);
    }
}
