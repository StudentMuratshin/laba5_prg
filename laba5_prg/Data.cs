using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace laba5_prg
{
    internal class Data
    {
        public String Text { get; private set; }
        public String FileName { get; private set; }
        public Match Match { get; private set; }

        internal void ReadFromFile(string fileName)
        {
            if (fileName == "") 
            {
                Console.WriteLine("Попытка открытия файла без задания имени");
                return;
            }
            using (StreamReader sr = new StreamReader(fileName))
            {
                this.Text = sr.ReadToEnd().Replace("\r", "");  //стандартный символ конца строки
                this.FileName = fileName;	
            }
        }

        internal void Find(string re)
        {
            if (this.Text == null)
            {
                Console.WriteLine("Попытка поиска без открытя файла");
                return;
            }
            this.Match = Regex.Match(this.Text, re);
        }

        internal void Next()
        {
            Match = Match?.NextMatch();
        }
    }
}
