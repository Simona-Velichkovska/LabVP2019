using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Airports
{
    public partial class destinationForm : Form
    {
        public Destination createDestination { get; set; }
        public destinationForm()
        {
            InitializeComponent();
            this.Text = "Нова дестинација";           
        }

        private void destinationForm_Load(object sender, EventArgs e)
        {

        }

        private void tbDestName_Validating(object sender, CancelEventArgs e)
        {
            if(tbDestName.Text.Length==0)
            {
                errorProvider1.SetError(tbDestName, "Името не смее да биде празно.");
                e.Cancel = true;
          
            }
            else
            {
                errorProvider1.SetError(tbDestName, null);
                e.Cancel = false;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            createDestination = new Destination(tbDestName.Text, (int)nupDistance.Value, (int)nupCost.Value);
            DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
