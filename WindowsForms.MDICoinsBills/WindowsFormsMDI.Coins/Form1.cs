using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsMDI.Coins
{
    public partial class MDIForm : Form
    {
        public MDIForm()
        {
            InitializeComponent();
        }

        private void newCoinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Declare the child form as a new one.
            FormCircleView childForm = new FormCircleView();
            // Set the main form as a parent form.
            childForm.MdiParent = this;
            // Show the child form.
            childForm.Show();
        }

        private void newBilltoolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Declare the child form as a new one.
            FormTriangleView childForm = new FormTriangleView(this);
            // Set the main form as a parent form.
            childForm.MdiParent = this;
            // Show the child form.
            childForm.Show();
        }

        private void toolStripMenuItemOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Triangle or Circle file (*.crcl;*.tri)|*.crcl;*.tri|Circle file (*.crcl)|*.crcl|Triangle file (*.tri)|*.tri";
            openFileDialog1.Title = "Open a Circle or Triangle File";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if (System.IO.Path.GetExtension(openFileDialog1.FileName) == ".crcl")
                {
                    FormCircleView childForm = new FormCircleView(this, openFileDialog1.FileName);
                    if (childForm.FileName == null)
                        childForm.Dispose();
                    else
                        childForm.Show(); 
                }
                else if (System.IO.Path.GetExtension(openFileDialog1.FileName) == ".tri")
                {
                    FormTriangleView childForm = new FormTriangleView(this, openFileDialog1.FileName);
                    if (childForm.FileName == null)
                        childForm.Dispose();
                    else
                        childForm.Show(); 
                }
            }
        }

        private void saveToolStripMenuItemSave_Click(object sender, EventArgs e)
        {
            Form activeChild = this.ActiveMdiChild;
            if (activeChild is FormCircleView)
            {
                ((FormCircleView)activeChild).SaveFile();
            }
            else if (activeChild is FormTriangleView)
            {
                ((FormTriangleView)activeChild).SaveFile();
            }

        }

        private void cascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void tileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void tileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }
    }
}
