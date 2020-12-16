using System;
using System.Collections;

namespace GameTicTacToe
{
    public class Adapter : IFormatXml
    {
        FormatTxt formatTxt;

        public Adapter(FormatTxt _formatTxt)
        {
            formatTxt = _formatTxt;
        }

        public string write(IEnumerable saves)
        {
            return formatTxt.write(saves);
        }
    }
}
