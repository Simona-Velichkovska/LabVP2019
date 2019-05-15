using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VPLab9i10
{
    public partial class Form1 : Form, IUpdatableView
    {
        ControllerForm Controller;
        RedCircles circleDoc;
        String FileName;

        bool isChanged = false;
        public Form1(RedCircles _redCircles, ControllerForm ctrl)
        {
            InitializeComponent();
            circleDoc = _redCircles;
            Controller = ctrl;
            FileName = null;
            isChanged = true;
           
        }

        private void circlePanel_Paint(object sender, PaintEventArgs e)
        {
            this.Text = "SDI Circle";
            if (FileName != null)
                this.Text += " - " +
                System.IO.Path.GetFileName(FileName);

            SolidBrush br = new SolidBrush(Color.Red);
            Pen pn = new Pen(Color.DarkRed, 1);
            Graphics canvas = circlePanel.CreateGraphics();
            canvas.Clear(Color.White);
            for (int nCount = 0; nCount < circleDoc.NumCircles; nCount++)
            {
                int y = circlePanel.Size.Height - 50 - 10 * nCount;
                canvas.FillEllipse(br, 25, y, 25, 25);
                canvas.DrawEllipse(pn, 25, y, 25, 25);
            }
            pn.Dispose();
            br.Dispose();
        }

        private void addACircleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            circleDoc.AddCircle();
            isChanged = true;

        }

        private void removeACircleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            circleDoc.RemoveCircle();
            isChanged = true;
        }

        private void toolStripStatusLabel1_Paint(object sender, PaintEventArgs e)
        {
            toolStripStatusLabel1.Text = "#Circles: " + circleDoc.NumCircles.ToString();
        }

        private void Form1_ResizeEnd(object sender, EventArgs e)
        {
            Invalidate(true);
        }

        public void UpdateView()
        {
            Invalidate(true);
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Controller.RemoveView(this);
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            circleDoc = new RedCircles(this);
            isChanged = true;
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (FileName == null)
            { // has not been saved yet
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                saveFileDialog1.Filter = "Red Circles file (*.rcrls)|*.rcrls";
                saveFileDialog1.Title = "Save a Red Circle File";
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                    FileName = saveFileDialog1.FileName;
            }
            if (FileName != null)
            {
                System.Runtime.Serialization.IFormatter fmt = new
                System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                FileStream strm = new FileStream(FileName, FileMode.Create,
                FileAccess.Write, FileShare.None);
                fmt.Serialize(strm, circleDoc);
                strm.Close();
                isChanged = false;
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileName = null;
            saveToolStripMenuItem_Click(sender, e);
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Red Circles file (*.rcrls)|*.rcrls";
            openFileDialog1.Title = "Open a Red Circle File";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                FileName = openFileDialog1.FileName;
                System.Runtime.Serialization.IFormatter fmt = new
                System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                FileStream strm = new FileStream(FileName, FileMode.Open,
                FileAccess.Read, FileShare.None);
                circleDoc = (RedCircles)fmt.Deserialize(strm);
                strm.Close();
            }
            Invalidate(true);
            isChanged = false;
        }

        private void circlePanel_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
                contextMenuStrip1.Show(this,
                new Point(e.X, e.Y));
        }

        private void saveToolStripMenuItem_Paint(object sender, PaintEventArgs e)
        {
            saveToolStripButton.Enabled = isChanged;
            saveToolStripMenuItem.Enabled = isChanged;
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '+')
                addACircleToolStripMenuItem_Click(sender, null);
            if (e.KeyChar == '-')
                removeACircleToolStripMenuItem_Click(sender, null);
        }
    }

    public interface IUpdatableView
    {
        void UpdateView();
    }
}
