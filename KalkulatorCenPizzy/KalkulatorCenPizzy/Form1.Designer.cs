
namespace KalkulatorCenPizzy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupRoz = new System.Windows.Forms.GroupBox();
            this.radioDuza = new System.Windows.Forms.RadioButton();
            this.radioSrednia = new System.Windows.Forms.RadioButton();
            this.radioMala = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupSos = new System.Windows.Forms.GroupBox();
            this.radioPikantny = new System.Windows.Forms.RadioButton();
            this.radioLagodny = new System.Windows.Forms.RadioButton();
            this.radioBez = new System.Windows.Forms.RadioButton();
            this.groupSklPodst = new System.Windows.Forms.GroupBox();
            this.checkPieczarki = new System.Windows.Forms.CheckBox();
            this.checkCzosnek = new System.Windows.Forms.CheckBox();
            this.checkSer = new System.Windows.Forms.CheckBox();
            this.checkSos = new System.Windows.Forms.CheckBox();
            this.groupRodz = new System.Windows.Forms.GroupBox();
            this.radioWege = new System.Windows.Forms.RadioButton();
            this.radioMieso = new System.Windows.Forms.RadioButton();
            this.groupDodatWege = new System.Windows.Forms.GroupBox();
            this.checkPapryka = new System.Windows.Forms.CheckBox();
            this.checkOscypek = new System.Windows.Forms.CheckBox();
            this.checkCebula = new System.Windows.Forms.CheckBox();
            this.groupDodatMieso = new System.Windows.Forms.GroupBox();
            this.checkKielbasa = new System.Windows.Forms.CheckBox();
            this.checkSzynka = new System.Windows.Forms.CheckBox();
            this.checkSalami = new System.Windows.Forms.CheckBox();
            this.groupCena = new System.Windows.Forms.GroupBox();
            this.btnOblicz = new System.Windows.Forms.Button();
            this.labelCena = new System.Windows.Forms.Label();
            this.groupIleSztuk = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupRoz.SuspendLayout();
            this.groupSos.SuspendLayout();
            this.groupSklPodst.SuspendLayout();
            this.groupRodz.SuspendLayout();
            this.groupDodatWege.SuspendLayout();
            this.groupDodatMieso.SuspendLayout();
            this.groupCena.SuspendLayout();
            this.groupIleSztuk.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(57, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(531, 240);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // groupRoz
            // 
            this.groupRoz.Controls.Add(this.radioDuza);
            this.groupRoz.Controls.Add(this.radioSrednia);
            this.groupRoz.Controls.Add(this.radioMala);
            this.groupRoz.Location = new System.Drawing.Point(57, 376);
            this.groupRoz.Name = "groupRoz";
            this.groupRoz.Size = new System.Drawing.Size(531, 74);
            this.groupRoz.TabIndex = 1;
            this.groupRoz.TabStop = false;
            this.groupRoz.Text = "Rozmiar";
            // 
            // radioDuza
            // 
            this.radioDuza.AutoSize = true;
            this.radioDuza.Checked = true;
            this.radioDuza.Location = new System.Drawing.Point(359, 38);
            this.radioDuza.Name = "radioDuza";
            this.radioDuza.Size = new System.Drawing.Size(62, 21);
            this.radioDuza.TabIndex = 2;
            this.radioDuza.TabStop = true;
            this.radioDuza.Text = "Duża";
            this.radioDuza.UseVisualStyleBackColor = true;
            // 
            // radioSrednia
            // 
            this.radioSrednia.AutoSize = true;
            this.radioSrednia.Location = new System.Drawing.Point(210, 38);
            this.radioSrednia.Name = "radioSrednia";
            this.radioSrednia.Size = new System.Drawing.Size(78, 21);
            this.radioSrednia.TabIndex = 1;
            this.radioSrednia.Text = "Średnia";
            this.radioSrednia.UseVisualStyleBackColor = true;
            // 
            // radioMala
            // 
            this.radioMala.AutoSize = true;
            this.radioMala.Location = new System.Drawing.Point(82, 38);
            this.radioMala.Name = "radioMala";
            this.radioMala.Size = new System.Drawing.Size(59, 21);
            this.radioMala.TabIndex = 0;
            this.radioMala.Text = "Mała";
            this.radioMala.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label1.Font = new System.Drawing.Font("Gadugi", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(190, 284);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "TWOJE ZAMÓWIENIE";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.comboBox1.Location = new System.Drawing.Point(106, 11);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(89, 24);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.Text = "1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ile sztuk pizzy:";
            // 
            // groupSos
            // 
            this.groupSos.Controls.Add(this.radioPikantny);
            this.groupSos.Controls.Add(this.radioLagodny);
            this.groupSos.Controls.Add(this.radioBez);
            this.groupSos.Location = new System.Drawing.Point(57, 456);
            this.groupSos.Name = "groupSos";
            this.groupSos.Size = new System.Drawing.Size(531, 70);
            this.groupSos.TabIndex = 5;
            this.groupSos.TabStop = false;
            this.groupSos.Text = "Sos";
            // 
            // radioPikantny
            // 
            this.radioPikantny.AutoSize = true;
            this.radioPikantny.Location = new System.Drawing.Point(359, 21);
            this.radioPikantny.Name = "radioPikantny";
            this.radioPikantny.Size = new System.Drawing.Size(83, 21);
            this.radioPikantny.TabIndex = 2;
            this.radioPikantny.Text = "Pikantny";
            this.radioPikantny.UseVisualStyleBackColor = true;
            // 
            // radioLagodny
            // 
            this.radioLagodny.AutoSize = true;
            this.radioLagodny.Checked = true;
            this.radioLagodny.Location = new System.Drawing.Point(204, 21);
            this.radioLagodny.Name = "radioLagodny";
            this.radioLagodny.Size = new System.Drawing.Size(84, 21);
            this.radioLagodny.TabIndex = 1;
            this.radioLagodny.TabStop = true;
            this.radioLagodny.Text = "Łagodny";
            this.radioLagodny.UseVisualStyleBackColor = true;
            // 
            // radioBez
            // 
            this.radioBez.AutoSize = true;
            this.radioBez.Location = new System.Drawing.Point(82, 21);
            this.radioBez.Name = "radioBez";
            this.radioBez.Size = new System.Drawing.Size(53, 21);
            this.radioBez.TabIndex = 0;
            this.radioBez.Text = "Bez";
            this.radioBez.UseVisualStyleBackColor = true;
            // 
            // groupSklPodst
            // 
            this.groupSklPodst.Controls.Add(this.checkPieczarki);
            this.groupSklPodst.Controls.Add(this.checkCzosnek);
            this.groupSklPodst.Controls.Add(this.checkSer);
            this.groupSklPodst.Controls.Add(this.checkSos);
            this.groupSklPodst.Location = new System.Drawing.Point(57, 532);
            this.groupSklPodst.Name = "groupSklPodst";
            this.groupSklPodst.Size = new System.Drawing.Size(531, 134);
            this.groupSklPodst.TabIndex = 6;
            this.groupSklPodst.TabStop = false;
            this.groupSklPodst.Text = "Składniki podstawowe:";
            // 
            // checkPieczarki
            // 
            this.checkPieczarki.AutoSize = true;
            this.checkPieczarki.Location = new System.Drawing.Point(6, 102);
            this.checkPieczarki.Name = "checkPieczarki";
            this.checkPieczarki.Size = new System.Drawing.Size(87, 21);
            this.checkPieczarki.TabIndex = 4;
            this.checkPieczarki.Text = "Pieczarki";
            this.checkPieczarki.UseVisualStyleBackColor = true;
            // 
            // checkCzosnek
            // 
            this.checkCzosnek.AutoSize = true;
            this.checkCzosnek.Location = new System.Drawing.Point(6, 75);
            this.checkCzosnek.Name = "checkCzosnek";
            this.checkCzosnek.Size = new System.Drawing.Size(84, 21);
            this.checkCzosnek.TabIndex = 3;
            this.checkCzosnek.Text = "Czosnek";
            this.checkCzosnek.UseVisualStyleBackColor = true;
            // 
            // checkSer
            // 
            this.checkSer.AutoSize = true;
            this.checkSer.Checked = true;
            this.checkSer.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkSer.Location = new System.Drawing.Point(6, 48);
            this.checkSer.Name = "checkSer";
            this.checkSer.Size = new System.Drawing.Size(52, 21);
            this.checkSer.TabIndex = 2;
            this.checkSer.Text = "Ser";
            this.checkSer.UseVisualStyleBackColor = true;
            // 
            // checkSos
            // 
            this.checkSos.AutoSize = true;
            this.checkSos.Checked = true;
            this.checkSos.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkSos.Location = new System.Drawing.Point(6, 21);
            this.checkSos.Name = "checkSos";
            this.checkSos.Size = new System.Drawing.Size(133, 21);
            this.checkSos.TabIndex = 1;
            this.checkSos.Text = "Sos pomidorowy";
            this.checkSos.UseVisualStyleBackColor = true;
            // 
            // groupRodz
            // 
            this.groupRodz.Controls.Add(this.radioWege);
            this.groupRodz.Controls.Add(this.radioMieso);
            this.groupRodz.Location = new System.Drawing.Point(57, 672);
            this.groupRodz.Name = "groupRodz";
            this.groupRodz.Size = new System.Drawing.Size(531, 57);
            this.groupRodz.TabIndex = 7;
            this.groupRodz.TabStop = false;
            this.groupRodz.Text = "Rodzaj";
            // 
            // radioWege
            // 
            this.radioWege.AutoSize = true;
            this.radioWege.Checked = true;
            this.radioWege.Location = new System.Drawing.Point(283, 21);
            this.radioWege.Name = "radioWege";
            this.radioWege.Size = new System.Drawing.Size(124, 21);
            this.radioWege.TabIndex = 1;
            this.radioWege.TabStop = true;
            this.radioWege.Text = "Wegetariańska";
            this.radioWege.UseVisualStyleBackColor = true;
            this.radioWege.CheckedChanged += new System.EventHandler(this.radioWege_CheckedChanged);
            // 
            // radioMieso
            // 
            this.radioMieso.AutoSize = true;
            this.radioMieso.Location = new System.Drawing.Point(116, 21);
            this.radioMieso.Name = "radioMieso";
            this.radioMieso.Size = new System.Drawing.Size(74, 21);
            this.radioMieso.TabIndex = 0;
            this.radioMieso.Text = "Mięsna";
            this.radioMieso.UseVisualStyleBackColor = true;
            this.radioMieso.CheckedChanged += new System.EventHandler(this.radioMieso_CheckedChanged);
            // 
            // groupDodatWege
            // 
            this.groupDodatWege.Controls.Add(this.checkPapryka);
            this.groupDodatWege.Controls.Add(this.checkOscypek);
            this.groupDodatWege.Controls.Add(this.checkCebula);
            this.groupDodatWege.Location = new System.Drawing.Point(367, 741);
            this.groupDodatWege.Name = "groupDodatWege";
            this.groupDodatWege.Size = new System.Drawing.Size(221, 103);
            this.groupDodatWege.TabIndex = 8;
            this.groupDodatWege.TabStop = false;
            this.groupDodatWege.Text = "Dodatki wegetariańskie";
            // 
            // checkPapryka
            // 
            this.checkPapryka.AutoSize = true;
            this.checkPapryka.Location = new System.Drawing.Point(6, 75);
            this.checkPapryka.Name = "checkPapryka";
            this.checkPapryka.Size = new System.Drawing.Size(82, 21);
            this.checkPapryka.TabIndex = 3;
            this.checkPapryka.Text = "Papryka";
            this.checkPapryka.UseVisualStyleBackColor = true;
            // 
            // checkOscypek
            // 
            this.checkOscypek.AutoSize = true;
            this.checkOscypek.Location = new System.Drawing.Point(6, 48);
            this.checkOscypek.Name = "checkOscypek";
            this.checkOscypek.Size = new System.Drawing.Size(85, 21);
            this.checkOscypek.TabIndex = 2;
            this.checkOscypek.Text = "Oscypek";
            this.checkOscypek.UseVisualStyleBackColor = true;
            // 
            // checkCebula
            // 
            this.checkCebula.AutoSize = true;
            this.checkCebula.Location = new System.Drawing.Point(6, 21);
            this.checkCebula.Name = "checkCebula";
            this.checkCebula.Size = new System.Drawing.Size(74, 21);
            this.checkCebula.TabIndex = 0;
            this.checkCebula.Text = "Cebula";
            this.checkCebula.UseVisualStyleBackColor = true;
            // 
            // groupDodatMieso
            // 
            this.groupDodatMieso.Controls.Add(this.checkKielbasa);
            this.groupDodatMieso.Controls.Add(this.checkSzynka);
            this.groupDodatMieso.Controls.Add(this.checkSalami);
            this.groupDodatMieso.Location = new System.Drawing.Point(57, 735);
            this.groupDodatMieso.Name = "groupDodatMieso";
            this.groupDodatMieso.Size = new System.Drawing.Size(221, 109);
            this.groupDodatMieso.TabIndex = 9;
            this.groupDodatMieso.TabStop = false;
            this.groupDodatMieso.Text = "Dodatki mięsne";
            this.groupDodatMieso.Visible = false;
            // 
            // checkKielbasa
            // 
            this.checkKielbasa.AutoSize = true;
            this.checkKielbasa.Location = new System.Drawing.Point(6, 75);
            this.checkKielbasa.Name = "checkKielbasa";
            this.checkKielbasa.Size = new System.Drawing.Size(84, 21);
            this.checkKielbasa.TabIndex = 3;
            this.checkKielbasa.Text = "Kiełbasa";
            this.checkKielbasa.UseVisualStyleBackColor = true;
            // 
            // checkSzynka
            // 
            this.checkSzynka.AutoSize = true;
            this.checkSzynka.Location = new System.Drawing.Point(6, 48);
            this.checkSzynka.Name = "checkSzynka";
            this.checkSzynka.Size = new System.Drawing.Size(76, 21);
            this.checkSzynka.TabIndex = 2;
            this.checkSzynka.Text = "Szynka";
            this.checkSzynka.UseVisualStyleBackColor = true;
            // 
            // checkSalami
            // 
            this.checkSalami.AutoSize = true;
            this.checkSalami.Location = new System.Drawing.Point(6, 21);
            this.checkSalami.Name = "checkSalami";
            this.checkSalami.Size = new System.Drawing.Size(72, 21);
            this.checkSalami.TabIndex = 1;
            this.checkSalami.Text = "Salami";
            this.checkSalami.UseVisualStyleBackColor = true;
            // 
            // groupCena
            // 
            this.groupCena.Controls.Add(this.btnOblicz);
            this.groupCena.Controls.Add(this.labelCena);
            this.groupCena.Location = new System.Drawing.Point(57, 850);
            this.groupCena.Name = "groupCena";
            this.groupCena.Size = new System.Drawing.Size(531, 56);
            this.groupCena.TabIndex = 9;
            this.groupCena.TabStop = false;
            this.groupCena.Text = "Cena";
            // 
            // btnOblicz
            // 
            this.btnOblicz.Location = new System.Drawing.Point(283, 17);
            this.btnOblicz.Name = "btnOblicz";
            this.btnOblicz.Size = new System.Drawing.Size(94, 29);
            this.btnOblicz.TabIndex = 1;
            this.btnOblicz.Text = "Oblicz";
            this.btnOblicz.UseVisualStyleBackColor = true;
            this.btnOblicz.Click += new System.EventHandler(this.btnOblicz_Click);
            // 
            // labelCena
            // 
            this.labelCena.AutoSize = true;
            this.labelCena.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelCena.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelCena.Location = new System.Drawing.Point(77, 17);
            this.labelCena.Name = "labelCena";
            this.labelCena.Size = new System.Drawing.Size(113, 29);
            this.labelCena.TabIndex = 0;
            this.labelCena.Text = "Łącznie";
            // 
            // groupIleSztuk
            // 
            this.groupIleSztuk.Controls.Add(this.label2);
            this.groupIleSztuk.Controls.Add(this.comboBox1);
            this.groupIleSztuk.Location = new System.Drawing.Point(57, 328);
            this.groupIleSztuk.Name = "groupIleSztuk";
            this.groupIleSztuk.Size = new System.Drawing.Size(531, 42);
            this.groupIleSztuk.TabIndex = 12;
            this.groupIleSztuk.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(295, 946);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 1;
            this.button1.Text = "Edycja cen";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnOblicz_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(440, 946);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 29);
            this.button2.TabIndex = 1;
            this.button2.Text = "Zakończ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btnOblicz_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 1026);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupDodatMieso);
            this.Controls.Add(this.groupIleSztuk);
            this.Controls.Add(this.groupDodatWege);
            this.Controls.Add(this.groupCena);
            this.Controls.Add(this.groupRodz);
            this.Controls.Add(this.groupSklPodst);
            this.Controls.Add(this.groupSos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupRoz);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Pizzeria Klaudia";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupRoz.ResumeLayout(false);
            this.groupRoz.PerformLayout();
            this.groupSos.ResumeLayout(false);
            this.groupSos.PerformLayout();
            this.groupSklPodst.ResumeLayout(false);
            this.groupSklPodst.PerformLayout();
            this.groupRodz.ResumeLayout(false);
            this.groupRodz.PerformLayout();
            this.groupDodatWege.ResumeLayout(false);
            this.groupDodatWege.PerformLayout();
            this.groupDodatMieso.ResumeLayout(false);
            this.groupDodatMieso.PerformLayout();
            this.groupCena.ResumeLayout(false);
            this.groupCena.PerformLayout();
            this.groupIleSztuk.ResumeLayout(false);
            this.groupIleSztuk.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupRoz;
        private System.Windows.Forms.RadioButton radioDuza;
        private System.Windows.Forms.RadioButton radioSrednia;
        private System.Windows.Forms.RadioButton radioMala;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupSos;
        private System.Windows.Forms.RadioButton radioPikantny;
        private System.Windows.Forms.RadioButton radioLagodny;
        private System.Windows.Forms.RadioButton radioBez;
        private System.Windows.Forms.GroupBox groupSklPodst;
        private System.Windows.Forms.CheckBox checkPieczarki;
        private System.Windows.Forms.CheckBox checkCzosnek;
        private System.Windows.Forms.CheckBox checkSer;
        private System.Windows.Forms.CheckBox checkSos;
        private System.Windows.Forms.GroupBox groupRodz;
        private System.Windows.Forms.RadioButton radioWege;
        private System.Windows.Forms.RadioButton radioMieso;
        private System.Windows.Forms.GroupBox groupDodatWege;
        private System.Windows.Forms.CheckBox checkPapryka;
        private System.Windows.Forms.CheckBox checkOscypek;
        private System.Windows.Forms.CheckBox checkCebula;
        private System.Windows.Forms.GroupBox groupDodatMieso;
        private System.Windows.Forms.CheckBox checkKielbasa;
        private System.Windows.Forms.CheckBox checkSzynka;
        private System.Windows.Forms.CheckBox checkSalami;
        private System.Windows.Forms.GroupBox groupCena;
        private System.Windows.Forms.Button btnOblicz;
        private System.Windows.Forms.Label labelCena;
        private System.Windows.Forms.GroupBox groupIleSztuk;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

