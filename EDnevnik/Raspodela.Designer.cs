
namespace EDnevnik
{
    partial class Raspodela
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
            this.cmbNastavnik = new System.Windows.Forms.ComboBox();
            this.cmbPredmet = new System.Windows.Forms.ComboBox();
            this.cmbGodina = new System.Windows.Forms.ComboBox();
            this.cmbOdeljenje = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnBrisi = new System.Windows.Forms.Button();
            this.btnIzmeni = new System.Windows.Forms.Button();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnSkrozDesno = new System.Windows.Forms.Button();
            this.btnDesno = new System.Windows.Forms.Button();
            this.btnLevo = new System.Windows.Forms.Button();
            this.btnSkrozLevo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbNastavnik
            // 
            this.cmbNastavnik.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cmbNastavnik.FormattingEnabled = true;
            this.cmbNastavnik.Location = new System.Drawing.Point(158, 171);
            this.cmbNastavnik.Name = "cmbNastavnik";
            this.cmbNastavnik.Size = new System.Drawing.Size(173, 28);
            this.cmbNastavnik.TabIndex = 0;
            // 
            // cmbPredmet
            // 
            this.cmbPredmet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cmbPredmet.FormattingEnabled = true;
            this.cmbPredmet.Location = new System.Drawing.Point(158, 248);
            this.cmbPredmet.Name = "cmbPredmet";
            this.cmbPredmet.Size = new System.Drawing.Size(173, 28);
            this.cmbPredmet.TabIndex = 1;
            // 
            // cmbGodina
            // 
            this.cmbGodina.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cmbGodina.FormattingEnabled = true;
            this.cmbGodina.Location = new System.Drawing.Point(158, 104);
            this.cmbGodina.Name = "cmbGodina";
            this.cmbGodina.Size = new System.Drawing.Size(173, 28);
            this.cmbGodina.TabIndex = 2;
            // 
            // cmbOdeljenje
            // 
            this.cmbOdeljenje.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cmbOdeljenje.FormattingEnabled = true;
            this.cmbOdeljenje.Location = new System.Drawing.Point(158, 316);
            this.cmbOdeljenje.Name = "cmbOdeljenje";
            this.cmbOdeljenje.Size = new System.Drawing.Size(173, 28);
            this.cmbOdeljenje.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(45, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Id";
            // 
            // tbId
            // 
            this.tbId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tbId.Location = new System.Drawing.Point(158, 33);
            this.tbId.Name = "tbId";
            this.tbId.ReadOnly = true;
            this.tbId.Size = new System.Drawing.Size(173, 26);
            this.tbId.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(45, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Godina";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(45, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Nastavnik";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(45, 256);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Predmet";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(45, 324);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Odeljenje";
            // 
            // btnBrisi
            // 
            this.btnBrisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnBrisi.Location = new System.Drawing.Point(259, 441);
            this.btnBrisi.Name = "btnBrisi";
            this.btnBrisi.Size = new System.Drawing.Size(93, 36);
            this.btnBrisi.TabIndex = 30;
            this.btnBrisi.Text = "Brisi";
            this.btnBrisi.UseVisualStyleBackColor = true;
            this.btnBrisi.Click += new System.EventHandler(this.btnBrisi_Click);
            // 
            // btnIzmeni
            // 
            this.btnIzmeni.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnIzmeni.Location = new System.Drawing.Point(139, 441);
            this.btnIzmeni.Name = "btnIzmeni";
            this.btnIzmeni.Size = new System.Drawing.Size(93, 36);
            this.btnIzmeni.TabIndex = 29;
            this.btnIzmeni.Text = "Izmeni";
            this.btnIzmeni.UseVisualStyleBackColor = true;
            this.btnIzmeni.Click += new System.EventHandler(this.btnIzmeni_Click);
            // 
            // btnDodaj
            // 
            this.btnDodaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnDodaj.Location = new System.Drawing.Point(18, 441);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(93, 36);
            this.btnDodaj.TabIndex = 28;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // btnSkrozDesno
            // 
            this.btnSkrozDesno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnSkrozDesno.Location = new System.Drawing.Point(306, 379);
            this.btnSkrozDesno.Name = "btnSkrozDesno";
            this.btnSkrozDesno.Size = new System.Drawing.Size(46, 29);
            this.btnSkrozDesno.TabIndex = 27;
            this.btnSkrozDesno.Text = ">>";
            this.btnSkrozDesno.UseVisualStyleBackColor = true;
            this.btnSkrozDesno.Click += new System.EventHandler(this.btnSkrozDesno_Click);
            // 
            // btnDesno
            // 
            this.btnDesno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnDesno.Location = new System.Drawing.Point(233, 379);
            this.btnDesno.Name = "btnDesno";
            this.btnDesno.Size = new System.Drawing.Size(46, 29);
            this.btnDesno.TabIndex = 26;
            this.btnDesno.Text = ">";
            this.btnDesno.UseVisualStyleBackColor = true;
            this.btnDesno.Click += new System.EventHandler(this.btnDesno_Click);
            // 
            // btnLevo
            // 
            this.btnLevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnLevo.Location = new System.Drawing.Point(96, 379);
            this.btnLevo.Name = "btnLevo";
            this.btnLevo.Size = new System.Drawing.Size(46, 29);
            this.btnLevo.TabIndex = 25;
            this.btnLevo.Text = "<";
            this.btnLevo.UseVisualStyleBackColor = true;
            this.btnLevo.Click += new System.EventHandler(this.btnLevo_Click);
            // 
            // btnSkrozLevo
            // 
            this.btnSkrozLevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnSkrozLevo.Location = new System.Drawing.Point(18, 379);
            this.btnSkrozLevo.Name = "btnSkrozLevo";
            this.btnSkrozLevo.Size = new System.Drawing.Size(46, 29);
            this.btnSkrozLevo.TabIndex = 24;
            this.btnSkrozLevo.Text = "<<";
            this.btnSkrozLevo.UseVisualStyleBackColor = true;
            this.btnSkrozLevo.Click += new System.EventHandler(this.btnSkrozLevo_Click);
            // 
            // Raspodela
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 528);
            this.Controls.Add(this.btnBrisi);
            this.Controls.Add(this.btnIzmeni);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.btnSkrozDesno);
            this.Controls.Add(this.btnDesno);
            this.Controls.Add(this.btnLevo);
            this.Controls.Add(this.btnSkrozLevo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbOdeljenje);
            this.Controls.Add(this.cmbGodina);
            this.Controls.Add(this.cmbPredmet);
            this.Controls.Add(this.cmbNastavnik);
            this.Name = "Raspodela";
            this.Text = "Raspodela";
            this.Load += new System.EventHandler(this.Raspodela_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbNastavnik;
        private System.Windows.Forms.ComboBox cmbPredmet;
        private System.Windows.Forms.ComboBox cmbGodina;
        private System.Windows.Forms.ComboBox cmbOdeljenje;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnBrisi;
        private System.Windows.Forms.Button btnIzmeni;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnSkrozDesno;
        private System.Windows.Forms.Button btnDesno;
        private System.Windows.Forms.Button btnLevo;
        private System.Windows.Forms.Button btnSkrozLevo;
    }
}