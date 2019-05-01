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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            loadLines();
        }

        private void lbAvtobusi_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnRemoveBus.Enabled = lbAvtobusi.SelectedIndex !=-1;
            btnAddLine.Enabled = lbAvtobusi.SelectedIndex !=-1;
            loadLines();
        }

        private void btnAddBusses_Click(object sender, EventArgs e)
        {
            newBusForm addBus = new newBusForm();
            if (addBus.ShowDialog() == DialogResult.OK)
            {
                lbAvtobusi.Items.Add(addBus.createBus);
            }
            
        }

        private void btnRemoveBus_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Дали сте сигуни дека сакате да го избришете автобусот?","Избриши автобус", MessageBoxButtons.YesNo) == DialogResult.Yes) {
                lbAvtobusi.Items.RemoveAt(lbAvtobusi.SelectedIndex);
                loadLines();
            }
        }

        private void btnAddLine_Click(object sender, EventArgs e)
        {
            newLineForm addNewLine = new newLineForm();
            if (addNewLine.ShowDialog() == DialogResult.OK)
            {
                Bus bus = lbAvtobusi.SelectedItem as Bus;
                bus.addLine(addNewLine.createLine);
                loadLines();
            }
        }

        public void loadLines()
        {
            lbLinii.Items.Clear();
            tbAverage.Clear();
            tbExpensive.Clear();
            Bus refreshBus = lbAvtobusi.SelectedItem as Bus;
            if(refreshBus!=null && refreshBus.Lines.Count > 0)
            {
                Line maxPrice = refreshBus.Lines[0];
                float totalPrice = 0;
                foreach(Line line in refreshBus.Lines)
                {
                    lbLinii.Items.Add(line);
                    if (line.Price > maxPrice.Price)
                    {
                        maxPrice = line;
                    }
                    totalPrice += line.Price;
                }
                tbAverage.Text = string.Format("{0:#.0}",totalPrice/lbLinii.Items.Count);
                tbExpensive.Text = maxPrice.ToString();
            }
           
        }
    }
}
