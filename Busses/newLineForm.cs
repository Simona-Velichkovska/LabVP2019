using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Busses
{
    public partial class newLineForm : Form
    {
        public Line createLine;
        public newLineForm()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void tbDestination_Validating(object sender, CancelEventArgs e)
        {
            if (tbDestination.Text.Length == 0)
            {
                errorProvider1.SetError(tbDestination, "Ова поле не смее да биде празно");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(tbDestination, null);
                e.Cancel = false;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            createLine = new Line(tbDestination.Text, (int)nupHour.Value, (int)nupMinute.Value, (int)nupPrice.Value);
            DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
