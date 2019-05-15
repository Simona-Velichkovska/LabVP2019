using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VPLab9i10
{
    public partial class ControllerForm : Form, IUpdatableView
    {
        RedCircles circlesDoc;
        List<IUpdatableView> views = new List<IUpdatableView>();
        public ControllerForm()
        {
            InitializeComponent();
            circlesDoc = new RedCircles(this);
        }

        private void ControllerForm_Load(object sender, EventArgs e)
        {
            UpdateView();
        }

       private void button3_Click(object sender, EventArgs e)
        {
            Form1 newForm = new Form1(circlesDoc, this);
            views.Add(newForm);
            newForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            circlesDoc.AddCircle();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            circlesDoc.RemoveCircle();
        }

        public void RemoveView(Form1 closingForm)
        {
            views.Remove(closingForm);
        }

        public void UpdateView()
        {
            textBox1.Text = circlesDoc.NumCircles.ToString();
            Invalidate(true);
            foreach (IUpdatableView uv in views)
            {
                if (uv != null)
                    uv.UpdateView();
            }
        }
    }
}
