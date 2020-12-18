using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameTicTacToe
{
    /// <summary>
    /// Конфигурация
    /// </summary>
    public class Config
    {
        private static Config instance;
        /// <summary>
        /// Наименования приложения
        /// </summary>
        public string nameApp { get; private set; }

        public Config(string _nameApp)
        {
            nameApp = _nameApp;
        }

        public static Config getInstance(string name)
        {
            if (instance == null)
                instance = new Config(name);
            return instance;
        }
    }
}
