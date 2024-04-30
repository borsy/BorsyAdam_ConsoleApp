
namespace GUI
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
            this.listBox_dolgozok = new System.Windows.Forms.ListBox();
            this.label_nev = new System.Windows.Forms.Label();
            this.label_reszleg = new System.Windows.Forms.Label();
            this.label_nem = new System.Windows.Forms.Label();
            this.label_belepeseve = new System.Windows.Forms.Label();
            this.label_fizetes = new System.Windows.Forms.Label();
            this.textBox_nev = new System.Windows.Forms.TextBox();
            this.textBox_reszleg = new System.Windows.Forms.TextBox();
            this.textBox_nem = new System.Windows.Forms.TextBox();
            this.numericUpDown_belepeseve = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_fizetes = new System.Windows.Forms.NumericUpDown();
            this.button_rogzites = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_belepeseve)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_fizetes)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox_dolgozok
            // 
            this.listBox_dolgozok.Dock = System.Windows.Forms.DockStyle.Left;
            this.listBox_dolgozok.FormattingEnabled = true;
            this.listBox_dolgozok.Location = new System.Drawing.Point(0, 0);
            this.listBox_dolgozok.Name = "listBox_dolgozok";
            this.listBox_dolgozok.Size = new System.Drawing.Size(187, 450);
            this.listBox_dolgozok.TabIndex = 0;
            // 
            // label_nev
            // 
            this.label_nev.AutoSize = true;
            this.label_nev.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_nev.Location = new System.Drawing.Point(214, 21);
            this.label_nev.Name = "label_nev";
            this.label_nev.Size = new System.Drawing.Size(34, 13);
            this.label_nev.TabIndex = 1;
            this.label_nev.Text = "Név:";
            // 
            // label_reszleg
            // 
            this.label_reszleg.AutoSize = true;
            this.label_reszleg.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_reszleg.Location = new System.Drawing.Point(214, 58);
            this.label_reszleg.Name = "label_reszleg";
            this.label_reszleg.Size = new System.Drawing.Size(56, 13);
            this.label_reszleg.TabIndex = 2;
            this.label_reszleg.Text = "Részleg:";
            // 
            // label_nem
            // 
            this.label_nem.AutoSize = true;
            this.label_nem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_nem.Location = new System.Drawing.Point(214, 97);
            this.label_nem.Name = "label_nem";
            this.label_nem.Size = new System.Drawing.Size(36, 13);
            this.label_nem.TabIndex = 3;
            this.label_nem.Text = "Nem:";
            // 
            // label_belepeseve
            // 
            this.label_belepeseve.AutoSize = true;
            this.label_belepeseve.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_belepeseve.Location = new System.Drawing.Point(214, 137);
            this.label_belepeseve.Name = "label_belepeseve";
            this.label_belepeseve.Size = new System.Drawing.Size(81, 13);
            this.label_belepeseve.TabIndex = 4;
            this.label_belepeseve.Text = "Belépés éve:";
            // 
            // label_fizetes
            // 
            this.label_fizetes.AutoSize = true;
            this.label_fizetes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_fizetes.Location = new System.Drawing.Point(214, 174);
            this.label_fizetes.Name = "label_fizetes";
            this.label_fizetes.Size = new System.Drawing.Size(51, 13);
            this.label_fizetes.TabIndex = 5;
            this.label_fizetes.Text = "Fizetés:";
            // 
            // textBox_nev
            // 
            this.textBox_nev.Location = new System.Drawing.Point(348, 21);
            this.textBox_nev.Name = "textBox_nev";
            this.textBox_nev.Size = new System.Drawing.Size(428, 20);
            this.textBox_nev.TabIndex = 6;
            // 
            // textBox_reszleg
            // 
            this.textBox_reszleg.Location = new System.Drawing.Point(348, 55);
            this.textBox_reszleg.Name = "textBox_reszleg";
            this.textBox_reszleg.Size = new System.Drawing.Size(428, 20);
            this.textBox_reszleg.TabIndex = 7;
            // 
            // textBox_nem
            // 
            this.textBox_nem.Location = new System.Drawing.Point(348, 90);
            this.textBox_nem.Name = "textBox_nem";
            this.textBox_nem.Size = new System.Drawing.Size(428, 20);
            this.textBox_nem.TabIndex = 8;
            // 
            // numericUpDown_belepeseve
            // 
            this.numericUpDown_belepeseve.Location = new System.Drawing.Point(348, 130);
            this.numericUpDown_belepeseve.Name = "numericUpDown_belepeseve";
            this.numericUpDown_belepeseve.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown_belepeseve.TabIndex = 9;
            // 
            // numericUpDown_fizetes
            // 
            this.numericUpDown_fizetes.Location = new System.Drawing.Point(348, 167);
            this.numericUpDown_fizetes.Name = "numericUpDown_fizetes";
            this.numericUpDown_fizetes.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown_fizetes.TabIndex = 10;
            // 
            // button_rogzites
            // 
            this.button_rogzites.Location = new System.Drawing.Point(217, 267);
            this.button_rogzites.Name = "button_rogzites";
            this.button_rogzites.Size = new System.Drawing.Size(559, 86);
            this.button_rogzites.TabIndex = 11;
            this.button_rogzites.Text = "Rögzítés";
            this.button_rogzites.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_rogzites);
            this.Controls.Add(this.numericUpDown_fizetes);
            this.Controls.Add(this.numericUpDown_belepeseve);
            this.Controls.Add(this.textBox_nem);
            this.Controls.Add(this.textBox_reszleg);
            this.Controls.Add(this.textBox_nev);
            this.Controls.Add(this.label_fizetes);
            this.Controls.Add(this.label_belepeseve);
            this.Controls.Add(this.label_nem);
            this.Controls.Add(this.label_reszleg);
            this.Controls.Add(this.label_nev);
            this.Controls.Add(this.listBox_dolgozok);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_belepeseve)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_fizetes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox_dolgozok;
        private System.Windows.Forms.Label label_nev;
        private System.Windows.Forms.Label label_reszleg;
        private System.Windows.Forms.Label label_nem;
        private System.Windows.Forms.Label label_belepeseve;
        private System.Windows.Forms.Label label_fizetes;
        private System.Windows.Forms.TextBox textBox_nev;
        private System.Windows.Forms.TextBox textBox_reszleg;
        private System.Windows.Forms.TextBox textBox_nem;
        private System.Windows.Forms.NumericUpDown numericUpDown_belepeseve;
        private System.Windows.Forms.NumericUpDown numericUpDown_fizetes;
        private System.Windows.Forms.Button button_rogzites;
    }
}

