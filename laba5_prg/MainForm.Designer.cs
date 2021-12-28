namespace laba5_prg
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поискToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.функцииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ofOrClickToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.firstWordsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.firstLetterCountsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtbFindString = new System.Windows.Forms.TextBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.lstbRegex = new System.Windows.Forms.ListBox();
            this.rtbFileText = new System.Windows.Forms.RichTextBox();
            this.rtbSearchResult = new System.Windows.Forms.RichTextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.индЗадToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.поискToolStripMenuItem,
            this.функцииToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip.Size = new System.Drawing.Size(636, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.открытьToolStripMenuItem.Text = "Открыть";
            this.открытьToolStripMenuItem.Click += new System.EventHandler(this.OpenFile);
            // 
            // поискToolStripMenuItem
            // 
            this.поискToolStripMenuItem.Name = "поискToolStripMenuItem";
            this.поискToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.поискToolStripMenuItem.Text = "Поиск";
            // 
            // функцииToolStripMenuItem
            // 
            this.функцииToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ofOrClickToolStripMenuItem1,
            this.firstWordsToolStripMenuItem,
            this.firstLetterCountsToolStripMenuItem,
            this.индЗадToolStripMenuItem});
            this.функцииToolStripMenuItem.Name = "функцииToolStripMenuItem";
            this.функцииToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.функцииToolStripMenuItem.Text = "Функции";
            // 
            // ofOrClickToolStripMenuItem1
            // 
            this.ofOrClickToolStripMenuItem1.Name = "ofOrClickToolStripMenuItem1";
            this.ofOrClickToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.ofOrClickToolStripMenuItem1.Text = "OfOrClick";
            this.ofOrClickToolStripMenuItem1.Click += new System.EventHandler(this.OfOrClick);
            // 
            // firstWordsToolStripMenuItem
            // 
            this.firstWordsToolStripMenuItem.Name = "firstWordsToolStripMenuItem";
            this.firstWordsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.firstWordsToolStripMenuItem.Text = "FirstWords";
            this.firstWordsToolStripMenuItem.Click += new System.EventHandler(this.FindSentencesFirstWords);
            // 
            // firstLetterCountsToolStripMenuItem
            // 
            this.firstLetterCountsToolStripMenuItem.Name = "firstLetterCountsToolStripMenuItem";
            this.firstLetterCountsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.firstLetterCountsToolStripMenuItem.Text = "FirstLetterCounts";
            this.firstLetterCountsToolStripMenuItem.Click += new System.EventHandler(this.FirstLetterCounts);
            // 
            // txtbFindString
            // 
            this.txtbFindString.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbFindString.Location = new System.Drawing.Point(10, 38);
            this.txtbFindString.Margin = new System.Windows.Forms.Padding(2);
            this.txtbFindString.Name = "txtbFindString";
            this.txtbFindString.Size = new System.Drawing.Size(389, 20);
            this.txtbFindString.TabIndex = 1;
            this.txtbFindString.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DownAnyKey);
            // 
            // btnFind
            // 
            this.btnFind.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFind.Location = new System.Drawing.Point(436, 37);
            this.btnFind.Margin = new System.Windows.Forms.Padding(2);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(56, 19);
            this.btnFind.TabIndex = 2;
            this.btnFind.Text = "Найти";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.Find);
            // 
            // btnNext
            // 
            this.btnNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNext.Location = new System.Drawing.Point(527, 37);
            this.btnNext.Margin = new System.Windows.Forms.Padding(2);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(56, 19);
            this.btnNext.TabIndex = 3;
            this.btnNext.Text = "Ещё";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.NextMatch);
            // 
            // lstbRegex
            // 
            this.lstbRegex.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lstbRegex.FormattingEnabled = true;
            this.lstbRegex.Location = new System.Drawing.Point(10, 62);
            this.lstbRegex.Margin = new System.Windows.Forms.Padding(2);
            this.lstbRegex.Name = "lstbRegex";
            this.lstbRegex.Size = new System.Drawing.Size(189, 381);
            this.lstbRegex.TabIndex = 4;
            // 
            // rtbFileText
            // 
            this.rtbFileText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbFileText.Location = new System.Drawing.Point(203, 62);
            this.rtbFileText.Margin = new System.Windows.Forms.Padding(2);
            this.rtbFileText.Name = "rtbFileText";
            this.rtbFileText.ReadOnly = true;
            this.rtbFileText.Size = new System.Drawing.Size(269, 299);
            this.rtbFileText.TabIndex = 5;
            this.rtbFileText.Text = "";
            this.rtbFileText.TextChanged += new System.EventHandler(this.rtbFileText_TextChanged);
            // 
            // rtbSearchResult
            // 
            this.rtbSearchResult.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbSearchResult.Location = new System.Drawing.Point(203, 366);
            this.rtbSearchResult.Margin = new System.Windows.Forms.Padding(2);
            this.rtbSearchResult.Name = "rtbSearchResult";
            this.rtbSearchResult.Size = new System.Drawing.Size(425, 83);
            this.rtbSearchResult.TabIndex = 6;
            this.rtbSearchResult.Text = "";
            // 
            // textBox1
            // 
            this.textBox1.AllowDrop = true;
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(477, 62);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(147, 20);
            this.textBox1.TabIndex = 7;
            // 
            // индЗадToolStripMenuItem
            // 
            this.индЗадToolStripMenuItem.Name = "индЗадToolStripMenuItem";
            this.индЗадToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.индЗадToolStripMenuItem.Text = "Инд.Зад";
            this.индЗадToolStripMenuItem.Click += new System.EventHandler(this.Name_pers);
            // 
            // MainForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 480);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.rtbSearchResult);
            this.Controls.Add(this.rtbFileText);
            this.Controls.Add(this.lstbRegex);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.txtbFindString);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.Text = "Поиск в текстовом файле";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SaveSettings);
            this.Load += new System.EventHandler(this.LoadSettings);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.TextBox txtbFindString;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.ListBox lstbRegex;
        private System.Windows.Forms.RichTextBox rtbFileText;
        private System.Windows.Forms.RichTextBox rtbSearchResult;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поискToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem функцииToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ofOrClickToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem firstWordsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem firstLetterCountsToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ToolStripMenuItem индЗадToolStripMenuItem;
    }
}

