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
            using (StreamReader sr = new StreamReader(fileName))
            {
                this.Text = sr.ReadToEnd().Replace("\r", "");  //стандартный символ конца строки	
            }
        }

        internal void Find(string re)
        {
            this.Match = Regex.Match(this.Text, re);
        }
    }
}
