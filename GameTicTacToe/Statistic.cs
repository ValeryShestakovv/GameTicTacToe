using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace GameTicTacToe
{
    /// <summary>
    /// Ведение статистики
    /// </summary>
    class Statistic
    {
        public List<string[]> saves;

        public Statistic()
        {
            saves = new List<string[]>();
        }
          
        public string write(IFormatXml transport, IEnumerable saves)
        {
            return transport.write(saves);
        }
    }
}
