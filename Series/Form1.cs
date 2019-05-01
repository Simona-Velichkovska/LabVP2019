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
    public partial class Form1 : Form
    {
        public Series serie;
        public Form1()
        {
            InitializeComponent();
            
        }

        private void btnAddProduction_Click(object sender, EventArgs e)
        {
            NewProductionForm form = new NewProductionForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
               
                cbProduction.Items.Add(form.createProduction.Last());

            }

        }
    }
}
