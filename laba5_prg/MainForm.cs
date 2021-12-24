using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laba5_prg
{
    public partial class MainForm : Form
    {
        Data data = new Data();
        public MainForm()
        {
            InitializeComponent();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*"; // расширения
            dlg.FilterIndex = 1;
            DialogResult res = dlg.ShowDialog(); // показываем диалог и ждём ok или отмены
            if (res == DialogResult.OK) // если не нажали отмену
            {
                data.ReadFromFile(dlg.FileName);
                Console.WriteLine($"File is open: {dlg.FileName}");
                rtbFileText.Text = data.Text;
            }
        }

        private void Find(object sender, EventArgs e)
        {
            data.Find(txtbFindString.Text);
            this.ShowMatch();
        }

        private void ShowMatch()
        { 
            Match m = data.Match; // получить m из data, добавить using
            if (m != null && m.Success)
            {
                rtbFileText.SelectionBackColor = Color.White; // сброс подсветки
                rtbFileText.SelectionStart = m.Index;
                // начало - место, на котором
                // в строке найдено регулярное выражение
                rtbFileText.SelectionLength = m.Value.Length;
                // длина найденного фрагмента
                rtbFileText.ScrollToCaret(); // прокрутка на выделенное место
                rtbFileText.SelectionBackColor = Color.Yellow; // подсветка

                rtbSearchResult.Text = $"Найдено[{m.Index}]: ##{m.Value}##\n";

            }
        }
    }
}
