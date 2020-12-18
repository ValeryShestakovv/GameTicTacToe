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
    /// Запись формата xml
    /// </summary>
    public class FormatXml : IFormatXml
    {
        /// <summary>
        /// Запись
        /// </summary>
        public string write(IEnumerable saves)
        {
            //создаем хмл документ
            XDocument xdoc = new XDocument();
            // создаем корневой элемент, который позволяет получать вложенные элементы и управлять ими
            XElement elementSaves = new XElement("saves");
            foreach (string[] save in saves)
            {
                //создаем элемент-строку
                XElement elementSave = new XElement("save");
                //берем атрибуты строки
                XAttribute attributeDate = new XAttribute("date", save[0]);
                XAttribute attributeGamerUser = new XAttribute("gamer-user", save[1]);
                XAttribute attributeGamerComputer = new XAttribute("gamer-computer", save[2]);
                //добавляем их в строку
                elementSave.Add(attributeDate);
                elementSave.Add(attributeGamerUser);
                elementSave.Add(attributeGamerComputer);
                //добавляем строку в корневой элемент
                elementSaves.Add(elementSave);
            }
            //добавляем корневой элемент в файл
            xdoc.Add(elementSaves);
            return xdoc.ToString();
        }
    }
}
