
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
            ((System.ComponentModel.ISupportInitialize)(this.Obrazek)).BeginInit();
            this.SuspendLayout();
            // 
            // NazwaS
            // 
            this.NazwaS.Location = new System.Drawing.Point(772, 106);
            this.NazwaS.Margin = new System.Windows.Forms.Padding(4);
            this.NazwaS.Name = "NazwaS";
            this.NazwaS.Size = new System.Drawing.Size(351, 22);
            this.NazwaS.TabIndex = 0;
            // 
            // ZadanieS
            // 
            this.ZadanieS.Location = new System.Drawing.Point(772, 159);
            this.ZadanieS.Margin = new System.Windows.Forms.Padding(4);
            this.ZadanieS.Name = "ZadanieS";
            this.ZadanieS.Size = new System.Drawing.Size(351, 22);
            this.ZadanieS.TabIndex = 1;
            // 
            // NumerS
            // 
            this.NumerS.Location = new System.Drawing.Point(772, 214);
            this.NumerS.Margin = new System.Windows.Forms.Padding(4);
            this.NumerS.Name = "NumerS";
            this.NumerS.Size = new System.Drawing.Size(351, 22);
            this.NumerS.TabIndex = 2;
            // 
            // dataS
            // 
            this.dataS.Location = new System.Drawing.Point(772, 276);
            this.dataS.Margin = new System.Windows.Forms.Padding(4);
            this.dataS.Name = "dataS";
            this.dataS.Size = new System.Drawing.Size(351, 22);
            this.dataS.TabIndex = 3;
            // 
            // StatkiLista
            // 
            this.StatkiLista.FormattingEnabled = true;
            this.StatkiLista.ItemHeight = 16;
            this.StatkiLista.Location = new System.Drawing.Point(16, 15);
            this.StatkiLista.Margin = new System.Windows.Forms.Padding(4);
            this.StatkiLista.Name = "StatkiLista";
            this.StatkiLista.Size = new System.Drawing.Size(237, 244);
            this.StatkiLista.TabIndex = 4;
            this.StatkiLista.SelectedIndexChanged += new System.EventHandler(this.StatkiLista_SelectedIndexChanged);
            // 
            // WczytajB
            // 
            this.WczytajB.Location = new System.Drawing.Point(284, 15);
            this.WczytajB.Margin = new System.Windows.Forms.Padding(4);
            this.WczytajB.Name = "WczytajB";
            this.WczytajB.Size = new System.Drawing.Size(100, 28);
            this.WczytajB.TabIndex = 6;
            this.WczytajB.Text = "Wczytaj";
            this.WczytajB.UseVisualStyleBackColor = true;
            this.WczytajB.Click += new System.EventHandler(this.WczytajB_Click);
            // 
            // ZapiszB
            // 
            this.ZapiszB.Enabled = false;
            this.ZapiszB.Location = new System.Drawing.Point(284, 78);
            this.ZapiszB.Margin = new System.Windows.Forms.Padding(4);
            this.ZapiszB.Name = "ZapiszB";
            this.ZapiszB.Size = new System.Drawing.Size(100, 28);
            this.ZapiszB.TabIndex = 7;
            this.ZapiszB.Text = "Zapisz";
            this.ZapiszB.UseVisualStyleBackColor = true;
            this.ZapiszB.Click += new System.EventHandler(this.ZapiszB_Click);
            // 
            // UsunB
            // 
            this.UsunB.Enabled = false;
            this.UsunB.Location = new System.Drawing.Point(284, 134);
            this.UsunB.Margin = new System.Windows.Forms.Padding(4);
            this.UsunB.Name = "UsunB";
            this.UsunB.Size = new System.Drawing.Size(100, 28);
            this.UsunB.TabIndex = 8;
            this.UsunB.Text = "Usun";
            this.UsunB.UseVisualStyleBackColor = true;
            this.UsunB.Click += new System.EventHandler(this.UsunB_Click);
            // 
            // NowyB
            // 
            this.NowyB.Location = new System.Drawing.Point(284, 187);
            this.NowyB.Margin = new System.Windows.Forms.Padding(4);
            this.NowyB.Name = "NowyB";
            this.NowyB.Size = new System.Drawing.Size(100, 28);
            this.NowyB.TabIndex = 9;
            this.NowyB.Text = "Nowy";
            this.NowyB.UseVisualStyleBackColor = true;
            this.NowyB.Click += new System.EventHandler(this.NowyB_Click);
            // 
            // NotatkiS
            // 
            this.NotatkiS.Location = new System.Drawing.Point(17, 308);
            this.NotatkiS.Margin = new System.Windows.Forms.Padding(4);
            this.NotatkiS.Multiline = true;
            this.NotatkiS.Name = "NotatkiS";
            this.NotatkiS.Size = new System.Drawing.Size(731, 162);
            this.NotatkiS.TabIndex = 10;
            // 
            // rozpiska
            // 
            this.rozpiska.BackColor = System.Drawing.SystemColors.MenuBar;
            this.rozpiska.Location = new System.Drawing.Point(772, 311);
            this.rozpiska.Name = "rozpiska";
            this.rozpiska.ShowWeekNumbers = true;
            this.rozpiska.TabIndex = 12;
            this.rozpiska.TitleBackColor = System.Drawing.SystemColors.ControlLightLight;
            this.rozpiska.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.rozpiska_DateChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(772, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "Nazwa Statku";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(775, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "Tytuł case\'a";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(778, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 17);
            this.label3.TabIndex = 15;
            this.label3.Text = "Numer AX";
            // 
            // Notatki
            // 
            this.Notatki.AutoSize = true;
            this.Notatki.Location = new System.Drawing.Point(16, 276);
            this.Notatki.Name = "Notatki";
            this.Notatki.Size = new System.Drawing.Size(52, 17);
            this.Notatki.TabIndex = 16;
            this.Notatki.Text = "Notatki";
            // 
            // Obrazek
            // 
            this.Obrazek.Location = new System.Drawing.Point(472, 15);
            this.Obrazek.Name = "Obrazek";
            this.Obrazek.Size = new System.Drawing.Size(185, 174);
            this.Obrazek.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Obrazek.TabIndex = 11;
            this.Obrazek.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1175, 531);
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
            this.Margin = new System.Windows.Forms.Padding(4);
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
    }
}

