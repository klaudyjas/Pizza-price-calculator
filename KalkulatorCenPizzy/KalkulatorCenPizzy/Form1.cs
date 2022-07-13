using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KalkulatorCenPizzy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioWege_CheckedChanged(object sender, EventArgs e)
        {
            if (radioWege.Checked)
            {
                groupDodatWege.Visible = true;
                groupDodatMieso.Visible = false;

                // Odznaczanie Miesa
                checkSalami.Checked = false;
                checkSzynka.Checked = false;
                checkKielbasa.Checked = false;
            }

        }

        private void radioMieso_CheckedChanged(object sender, EventArgs e)
        {
            if (radioMieso.Checked)
            {
                groupDodatMieso.Visible = true;
                groupDodatWege.Visible = false;

                // Odznaczanie Wege
                checkCebula.Checked = false;
                checkOscypek.Checked = false;
                checkPapryka.Checked = false;
            }
        }

        private void btnOblicz_Click(object sender, EventArgs e)
        {
            double cena = 0;
            double cenaSred = 0.8;
            double cenaMala = 0.6;

            // Skladniki Duza Cena
            int sosPom, ser, czosnek, pieczarki;
            sosPom = ser = czosnek = pieczarki = 1;

            // Dodatki Miesna Duza Cena
            int salami, szynka, kielbasa;
            salami = szynka = kielbasa = 2;

            // Dodatki Miesna Duza Cena
            int cebula, oscypek, papryka;
            cebula = oscypek = papryka = 2;

            // Rozmiar Cena
            if (radioMala.Checked)
            {
                cena += 12;

                // + Skladniki
                if (checkSos.Checked) { cena += sosPom * cenaMala; }
                if (checkSer.Checked) { cena += ser * cenaMala; }
                if (checkCzosnek.Checked) { cena += czosnek * cenaMala; }
                if (checkPieczarki.Checked) { cena += pieczarki * cenaMala; }

                // + Dodatki
                if (checkSalami.Checked) { cena += salami * cenaMala; }
                if (checkSzynka.Checked) { cena += szynka * cenaMala; }
                if (checkKielbasa.Checked) { cena += kielbasa * cenaMala; }
                if (checkCebula.Checked) { cena += cebula * cenaMala; }
                if (checkOscypek.Checked) { cena += oscypek * cenaMala; }
                if (checkPapryka.Checked) { cena += papryka * cenaMala; }
            }
            if (radioSrednia.Checked)
            {
                cena += 16;
                // + Skladniki
                if (checkSos.Checked) { cena += sosPom * cenaSred; }
                if (checkSer.Checked) { cena += ser * cenaSred; }
                if (checkCzosnek.Checked) { cena += czosnek * cenaSred; }
                if (checkPieczarki.Checked) { cena += pieczarki * cenaSred; }

                // + Dodatki
                if (checkSalami.Checked) { cena += salami * cenaSred; }
                if (checkSzynka.Checked) { cena += szynka * cenaSred; }
                if (checkKielbasa.Checked) { cena += kielbasa * cenaSred; }
                if (checkCebula.Checked) { cena += cebula * cenaSred; }
                if (checkOscypek.Checked) { cena += oscypek * cenaSred; }
                if (checkPapryka.Checked) { cena += papryka * cenaSred; }
            }
            if (radioDuza.Checked)
            {
                cena += 20;
                // + Skladniki
                if (checkSos.Checked) { cena += sosPom; }
                if (checkSer.Checked) { cena += ser; }
                if (checkCzosnek.Checked) { cena += czosnek; }
                if (checkPieczarki.Checked) { cena += pieczarki; }

                // + Dodatki
                if (checkSalami.Checked) { cena += salami; }
                if (checkSzynka.Checked) { cena += szynka; }
                if (checkKielbasa.Checked) { cena += kielbasa; }
                if (checkCebula.Checked) { cena += cebula; }
                if (checkOscypek.Checked) { cena += oscypek; }
                if (checkPapryka.Checked) { cena += papryka; }

            }

            // Sos Cena (Lagodny lub Pikantny)
            if (radioLagodny.Checked || radioPikantny.Checked) { cena += 2; }



            // Oblicz Cene
            int ile = Convert.ToInt32(comboBox1.Text); // Converting to Integer
            cena = cena * ile; // Number (Double)
            labelCena.Text = Convert.ToString(cena) + " zł"; // Converting to a String
        }

    }
}
