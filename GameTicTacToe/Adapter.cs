using System;
using System.Collections;

namespace GameTicTacToe
{
    /// <summary>
    /// Адаптер от FormatJson к IFormatXml
    /// </summary>
    public class Adapter : IFormatXml
    {
        FormatTxt formatTxt;
        /// <summary>
        /// Адаптер
        /// </summary>
        /// <param name="_formatTxt"></param>
        public Adapter(FormatTxt _formatTxt)
        {
            formatTxt = _formatTxt;
        }
        /// <summary>
        /// Записать
        /// </summary>
        public string write(IEnumerable saves)
        {
            return formatTxt.write(saves);
        }
    }
}
