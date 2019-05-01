using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Automobiles
{
    public partial class NovaMarka : Form
    {
        public Marka createdMarka;
        public NovaMarka()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            createdMarka = new Marka(tbName.Text.Trim(), mtbSifra.Text.Trim());
            DialogResult = DialogResult.OK;
        }

        private void tbName_Validating(object sender, CancelEventArgs e)
        {
            if (tbName.Text.Trim().Length == 0)
            {
                errorProvider1.SetError(tbName, "Името е задолжително");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(tbName, null);
                e.Cancel = false;
            }
        }

        private void mtbSifra_Validating(object sender, CancelEventArgs e)
        {
            if (mtbSifra.Text.Trim().Length == 0)
            {
                errorProvider1.SetError(mtbSifra, "Шифрата е задолжително");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(mtbSifra, null);
                e.Cancel = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
