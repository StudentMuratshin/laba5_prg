﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using laba5_prg.Properties;

namespace laba5_prg
{
    public partial class MainForm : Form
    {
        Data data = new Data();
        public MainForm()
        {
            InitializeComponent();
            this.lstbRegex.Items.Add(@"\b(([А-Я])[а-я]+)\?");
            this.lstbRegex.Items.Add(@"\s(и...)\s");
            this.lstbRegex.Click += (s, e) =>
            {
                this.txtbFindString.Text = lstbRegex.Text;
                Find(s, e);
            };
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

                for (int i = 0; i < m.Groups.Count; i++)
                {
                    rtbSearchResult.Text += String.Format("Groups[{0}]={1}\n", i, m.Groups[i]);
                }

            }
        }

        private void rtbFileText_TextChanged(object sender, EventArgs e)
        {

        }

        private void NextMatch(object sender, EventArgs e)
        {
            data.Next();
            this.ShowMatch();
        }

        private void DownAnyKey(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Find(sender, e);
                e.SuppressKeyPress = true; // дальше событие нажатие кнопки игнорируется
            }
        }

        private void SaveSettings(object sender, FormClosingEventArgs e)
        {
            Settings.Default.FileName = data.FileName;
            Settings.Default.Save();
        }

        private void LoadSettings(object sender, EventArgs e)
        {
            data.ReadFromFile(Settings.Default.FileName);
            Console.WriteLine($"File is open: {data.FileName}");
            rtbFileText.Text = data.Text;
        }
    }
}
