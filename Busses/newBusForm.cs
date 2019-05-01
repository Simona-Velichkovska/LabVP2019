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
    public partial class newBusForm : Form
    {
        public Bus createBus;
        public newBusForm()
        {
            InitializeComponent();
        }

        private void tbName_Validating(object sender, CancelEventArgs e)
        {
            if (tbName.Text.Length == 0)
            {
                errorProvider1.SetError(tbName,"Името не смее да биде празно.");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(tbName, null);
                e.Cancel = false;
            }
        }

        private void tbReg_Validating(object sender, CancelEventArgs e)
        {
            if (tbReg.Text.Length != 4)
            {
                errorProvider1.SetError(tbReg, "Регистрацијата мора да биде 4 цифри.");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(tbReg, null);
                e.Cancel = false;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            createBus = new Bus(tbReg.Text, tbName.Text, cbLocal.Checked);
            DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
