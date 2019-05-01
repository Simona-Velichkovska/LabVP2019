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
    public partial class airportForm : Form
    {
        public Airport createAirport { get; set; }
        public airportForm()
        {
            InitializeComponent();

            
            this.Text = "Нов аеродром";
        }

        private void airportForm_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            
            createAirport = new Airport(tbCity.Text, tbName.Text, tbShortcut.Text);
            DialogResult = DialogResult.OK;

        }

        private void tbCity_Validating(object sender, CancelEventArgs e)
        {

            if (tbCity.Text.Length == 0)
            {
                errorProvider1.SetError(tbCity,"Името на градот е задолжително");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(tbCity, null);
                e.Cancel = false;
            }
        }

        private void tbName_Validating(object sender, CancelEventArgs e)
        {
            if (tbName.Text.Length == 0)
            {
                errorProvider1.SetError(tbName, "Името на градот е задолжително");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(tbName, null);
                e.Cancel = false;
            }
        }

        private void tbShortcut_Validating(object sender, CancelEventArgs e)
        {

            if (tbShortcut.Text.Length != 3 || tbShortcut.Text[0] == 0 || Char.IsNumber(tbShortcut.Text[0]) || Char.IsNumber(tbShortcut.Text[1]) || Char.IsNumber(tbShortcut.Text[2]) || Char.IsLower(tbShortcut.Text[0]) || Char.IsLower(tbShortcut.Text[1]) || Char.IsLower(tbShortcut.Text[2]))
            {
                errorProvider1.SetError(tbShortcut, "Треба да има само 3 големи букви");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(tbShortcut, null);
                e.Cancel = false;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            
            DialogResult = DialogResult.Cancel;
        }
    }
}
