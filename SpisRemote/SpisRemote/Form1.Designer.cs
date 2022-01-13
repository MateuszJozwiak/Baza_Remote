
namespace SpisRemote
{
    partial class Form1
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
            this.NazwaS = new System.Windows.Forms.TextBox();
            this.ZadanieS = new System.Windows.Forms.TextBox();
            this.NumerS = new System.Windows.Forms.TextBox();
            this.dataS = new System.Windows.Forms.DateTimePicker();
            this.StatkiLista = new System.Windows.Forms.ListBox();
            this.WczytajB = new System.Windows.Forms.Button();
            this.ZapiszB = new System.Windows.Forms.Button();
            this.UsunB = new System.Windows.Forms.Button();
            this.NowyB = new System.Windows.Forms.Button();
            this.NotatkiS = new System.Windows.Forms.TextBox();
            this.rozpiska = new System.Windows.Forms.MonthCalendar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Notatki = new System.Windows.Forms.Label();
            this.Obrazek = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.Adres = new System.Windows.Forms.Button();
            this.textAdres = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Obrazek)).BeginInit();
            this.SuspendLayout();
            // 
            // NazwaS
            // 
            this.NazwaS.Location = new System.Drawing.Point(579, 86);
            this.NazwaS.Name = "NazwaS";
            this.NazwaS.Size = new System.Drawing.Size(264, 20);
            this.NazwaS.TabIndex = 0;
            // 
            // ZadanieS
            // 
            this.ZadanieS.Location = new System.Drawing.Point(579, 129);
            this.ZadanieS.Name = "ZadanieS";
            this.ZadanieS.Size = new System.Drawing.Size(264, 20);
            this.ZadanieS.TabIndex = 1;
            // 
            // NumerS
            // 
            this.NumerS.Location = new System.Drawing.Point(579, 174);
            this.NumerS.Name = "NumerS";
            this.NumerS.Size = new System.Drawing.Size(264, 20);
            this.NumerS.TabIndex = 2;
            // 
            // dataS
            // 
            this.dataS.Location = new System.Drawing.Point(579, 224);
            this.dataS.Name = "dataS";
            this.dataS.Size = new System.Drawing.Size(264, 20);
            this.dataS.TabIndex = 3;
            // 
            // StatkiLista
            // 
            this.StatkiLista.FormattingEnabled = true;
            this.StatkiLista.Location = new System.Drawing.Point(12, 64);
            this.StatkiLista.Name = "StatkiLista";
            this.StatkiLista.Size = new System.Drawing.Size(179, 147);
            this.StatkiLista.TabIndex = 4;
            this.StatkiLista.SelectedIndexChanged += new System.EventHandler(this.StatkiLista_SelectedIndexChanged);
            // 
            // WczytajB
            // 
            this.WczytajB.Location = new System.Drawing.Point(213, 64);
            this.WczytajB.Name = "WczytajB";
            this.WczytajB.Size = new System.Drawing.Size(75, 23);
            this.WczytajB.TabIndex = 6;
            this.WczytajB.Text = "Wczytaj";
            this.WczytajB.UseVisualStyleBackColor = true;
            this.WczytajB.Click += new System.EventHandler(this.WczytajB_Click);
            // 
            // ZapiszB
            // 
            this.ZapiszB.Enabled = false;
            this.ZapiszB.Location = new System.Drawing.Point(213, 187);
            this.ZapiszB.Name = "ZapiszB";
            this.ZapiszB.Size = new System.Drawing.Size(75, 23);
            this.ZapiszB.TabIndex = 7;
            this.ZapiszB.Text = "Zapisz";
            this.ZapiszB.UseVisualStyleBackColor = true;
            this.ZapiszB.Click += new System.EventHandler(this.ZapiszB_Click);
            // 
            // UsunB
            // 
            this.UsunB.Enabled = false;
            this.UsunB.Location = new System.Drawing.Point(213, 109);
            this.UsunB.Name = "UsunB";
            this.UsunB.Size = new System.Drawing.Size(75, 23);
            this.UsunB.TabIndex = 8;
            this.UsunB.Text = "Usun";
            this.UsunB.UseVisualStyleBackColor = true;
            this.UsunB.Click += new System.EventHandler(this.UsunB_Click);
            // 
            // NowyB
            // 
            this.NowyB.Location = new System.Drawing.Point(213, 152);
            this.NowyB.Name = "NowyB";
            this.NowyB.Size = new System.Drawing.Size(75, 23);
            this.NowyB.TabIndex = 9;
            this.NowyB.Text = "Nowy";
            this.NowyB.UseVisualStyleBackColor = true;
            this.NowyB.Click += new System.EventHandler(this.NowyB_Click);
            // 
            // NotatkiS
            // 
            this.NotatkiS.Location = new System.Drawing.Point(13, 250);
            this.NotatkiS.Multiline = true;
            this.NotatkiS.Name = "NotatkiS";
            this.NotatkiS.Size = new System.Drawing.Size(549, 132);
            this.NotatkiS.TabIndex = 10;
            // 
            // rozpiska
            // 
            this.rozpiska.BackColor = System.Drawing.SystemColors.MenuBar;
            this.rozpiska.Location = new System.Drawing.Point(579, 253);
            this.rozpiska.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.rozpiska.Name = "rozpiska";
            this.rozpiska.ShowWeekNumbers = true;
            this.rozpiska.TabIndex = 12;
            this.rozpiska.TitleBackColor = System.Drawing.SystemColors.ControlLightLight;
            this.rozpiska.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.rozpiska_DateChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(579, 63);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Nazwa Statku";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(581, 110);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Tytuł case\'a";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(584, 154);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Numer AX";
            // 
            // Notatki
            // 
            this.Notatki.AutoSize = true;
            this.Notatki.Location = new System.Drawing.Point(12, 224);
            this.Notatki.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Notatki.Name = "Notatki";
            this.Notatki.Size = new System.Drawing.Size(41, 13);
            this.Notatki.TabIndex = 16;
            this.Notatki.Text = "Notatki";
            // 
            // Obrazek
            // 
            this.Obrazek.Location = new System.Drawing.Point(354, 12);
            this.Obrazek.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Obrazek.Name = "Obrazek";
            this.Obrazek.Size = new System.Drawing.Size(139, 141);
            this.Obrazek.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Obrazek.TabIndex = 11;
            this.Obrazek.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Adres
            // 
            this.Adres.Location = new System.Drawing.Point(213, 13);
            this.Adres.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Adres.Name = "Adres";
            this.Adres.Size = new System.Drawing.Size(75, 19);
            this.Adres.TabIndex = 17;
            this.Adres.Text = "Adres";
            this.Adres.UseVisualStyleBackColor = true;
            this.Adres.Click += new System.EventHandler(this.Adres_Click);
            // 
            // textAdres
            // 
            this.textAdres.Location = new System.Drawing.Point(15, 12);
            this.textAdres.Name = "textAdres";
            this.textAdres.Size = new System.Drawing.Size(176, 20);
            this.textAdres.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 431);
            this.Controls.Add(this.textAdres);
            this.Controls.Add(this.Adres);
            this.Controls.Add(this.Notatki);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rozpiska);
            this.Controls.Add(this.Obrazek);
            this.Controls.Add(this.NotatkiS);
            this.Controls.Add(this.NowyB);
            this.Controls.Add(this.UsunB);
            this.Controls.Add(this.ZapiszB);
            this.Controls.Add(this.WczytajB);
            this.Controls.Add(this.StatkiLista);
            this.Controls.Add(this.dataS);
            this.Controls.Add(this.NumerS);
            this.Controls.Add(this.ZadanieS);
            this.Controls.Add(this.NazwaS);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Obrazek)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NazwaS;
        private System.Windows.Forms.TextBox ZadanieS;
        private System.Windows.Forms.TextBox NumerS;
        private System.Windows.Forms.DateTimePicker dataS;
        private System.Windows.Forms.ListBox StatkiLista;
        private System.Windows.Forms.Button WczytajB;
        private System.Windows.Forms.Button ZapiszB;
        private System.Windows.Forms.Button UsunB;
        private System.Windows.Forms.Button NowyB;
        private System.Windows.Forms.TextBox NotatkiS;
        private System.Windows.Forms.PictureBox Obrazek;
        private System.Windows.Forms.MonthCalendar rozpiska;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Notatki;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button Adres;
        private System.Windows.Forms.TextBox textAdres;
    }
}

