using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Orders
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            Timer time = new Timer();
            InitializeComponent();
            lbShowDate.Text = DateTime.Now.ToLongDateString();
            lbShowTime.Text = DateTime.Now.ToLongTimeString();
            time.Interval = 500;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
