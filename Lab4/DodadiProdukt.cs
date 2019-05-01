using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4
{
    public partial class DodadiProdukt : Form
    {
        public Produkti produkt;
        public DodadiProdukt()
        {
            InitializeComponent();
            tbCena.Text=String.Format("{0:0.00}", tbCena.Text.Trim());
        }

        private void tbIme_Validating(object sender, CancelEventArgs e)
        {
            if (tbIme.Text.Trim().Length == 0)
            {
                errorProvider1.SetError(tbIme, "Името не треба да биде празно");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(tbIme, null);
                e.Cancel = false;

            }
        }

        private void tbKategorija_Validating(object sender, CancelEventArgs e)
        {
            if (tbKategorija.Text.Trim().Length == 0)
            {
                errorProvider1.SetError(tbKategorija, "Категоријата не смее да биде празна");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(tbKategorija, null);
                e.Cancel = false;
            }
        }

        private void tbCena_Validating(object sender, CancelEventArgs e)
        {
            bool flag = false;
            foreach(char character in tbCena.Text.Trim())
            {
                if (char.IsLetter(character))
                {
                    flag = true;
                }
            }

            if (tbCena.Text.Trim().Length == 0)
            {
                errorProvider1.SetError(tbCena,"Цената не смее да биде празна");
                e.Cancel = true;
            }else if(flag || Convert.ToDouble(tbCena.Text.Trim()) < 40)
            {
                errorProvider1.SetError(tbCena, "Цената мора да е бројки и поголема од 40");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(tbCena, null);
                e.Cancel = false;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            produkt = new Produkti(tbIme.Text.Trim(), tbKategorija.Text.Trim(), Convert.ToDouble(tbCena.Text.Trim()),(int)nudKolicina.Value,(int)nudKolicina.Value);
            DialogResult = DialogResult.OK;
        }

        private void nudKolicina_Validating(object sender, CancelEventArgs e)
        {
            if (nudKolicina.Value > 10)
            {
                errorProvider1.SetError(nudKolicina, "Количината мора да биде помала од 10");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(nudKolicina, null);
                e.Cancel = false;
            }
        }
    }
}
