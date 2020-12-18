using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameTicTacToe
{
    /// <summary>
    /// Интерфейс формата XML
    /// </summary>
    public interface IFormatXml
    {
        /// <summary>
        /// Запись
        /// </summary>
        /// <returns>Строку формата XML</returns>
        string write(IEnumerable saves);
    }
}
