using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Series
{
    public partial class NewProductionForm : Form
    {
        public List<Production> createProduction;
        public NewProductionForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tbName_Validating(object sender, CancelEventArgs e)
        {
            if (tbName.Text.Length == 0)
            {
                errorProvider1.SetError(tbName, "Името не смее да биде празно.");
                e.Cancel = true;

            }
            else
            {
                errorProvider1.SetError(tbName, null);
                e.Cancel = false;
            }
        }

        private void tbSifra_Validating(object sender, CancelEventArgs e)
        {
            int flag = 0;
            if (tbSifra.Text.Length != 2)
            {
                    errorProvider1.SetError(tbSifra,"Треба да има само 2 цифри");
                    e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(tbSifra, null);
                e.Cancel = false;
            }


          
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Production newProduction = new Production(tbName.Text, tbSifra.Text);
            createProduction = new List<Production>();
            if (createProduction != null)
            {
                foreach (Production production in createProduction)
                {
                    if (production.Code == newProduction.Code)
                    {
                        errorProvider1.SetError(tbSifra, "Продукција со таа шифра веќе постои");
                        DialogResult = DialogResult.Abort;

                    }
                    else
                    {

                       
                        errorProvider1.SetError(tbSifra, null);
                        createProduction.Add(newProduction);
                        DialogResult = DialogResult.OK;
                    }


                }
            }
                createProduction.Add(newProduction);
                DialogResult = DialogResult.OK;
            
        }


    }
}
