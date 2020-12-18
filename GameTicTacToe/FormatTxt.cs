using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameTicTacToe
{
    /// <summary>
    /// Запись формата xml
    /// </summary>
    public class FormatTxt : IFormatTxt
    {
        public string write(IEnumerable saves)
        {
            string txt = "";
            foreach (string[] save in saves)
            {
                txt += String.Format("{0}: gamer-user: {1}, gamer-computer: {2}\n", save[0], save[1], save[2]);
            }
            return txt;
        }
    }
}
