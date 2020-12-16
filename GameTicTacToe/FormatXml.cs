using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace GameTicTacToe
{
    public class FormatXml : IFormatXml
    {
        public string write(IEnumerable saves)
        {
            XDocument xdoc = new XDocument();
            XElement elementSaves = new XElement("saves");
            foreach (string[] save in saves)
            {
                XElement elementSave = new XElement("save");
                XAttribute attributeDate = new XAttribute("date", save[0]);
                XAttribute attributeGamerUser = new XAttribute("gamer-user", save[1]);
                XAttribute attributeGamerComputer = new XAttribute("gamer-computer", save[2]);
                elementSave.Add(attributeDate);
                elementSave.Add(attributeGamerUser);
                elementSave.Add(attributeGamerComputer);
                elementSaves.Add(elementSave);
            }
            xdoc.Add(elementSaves);
            return xdoc.ToString();
        }
    }
}
