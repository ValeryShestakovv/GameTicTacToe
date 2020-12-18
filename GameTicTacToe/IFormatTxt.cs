using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameTicTacToe
{
    /// <summary>
    /// Интерфейс формата txt
    /// </summary>
    public interface IFormatTxt
    {
        string write(IEnumerable saves);
    }
}
