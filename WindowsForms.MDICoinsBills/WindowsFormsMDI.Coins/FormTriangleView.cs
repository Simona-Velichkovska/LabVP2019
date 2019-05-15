using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsMDI.Coins
{
    public partial class FormTriangleView : Form
    {
        private Triangle triangleDoc;
        public String FileName
            { get; private set; }
        public bool isChanged // save required
            { get; private set; }

        public FormTriangleView()
        {
            InitializeComponent();
            triangleDoc = new Triangle();
            isChanged = true;
            //menuStrip1.AllowMerge = false;
            
        }

        public FormTriangleView(Form parent, String fileName = null) : this()
        {
            this.MdiParent = parent;
            if (fileName != null)
                openFile(fileName);
        }

        private void addABillToolStripMenuItem_Click(object sender, EventArgs e)
        {
            triangleDoc.AddBill();
            isChanged = true;
            Invalidate(true);
        }

        private void removeABillToolStripMenuItem_Click(object sender, EventArgs e)
        {
            triangleDoc.RemoveBill();
            isChanged = true;
            Invalidate(true);
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFile();
        }

        public void SaveFile()
        {
            if (FileName == null)
            {
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                saveFileDialog1.Filter = "Triangle file (*.tri)|*.tri";
                saveFileDialog1.Title = "Save a Triangle File";
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                    FileName = saveFileDialog1.FileName;
            }
            if (FileName != null)
            {
                System.Runtime.Serialization.IFormatter fmt = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                System.IO.FileStream strm = new FileStream(FileName, FileMode.Create, FileAccess.Write, FileShare.None);
                fmt.Serialize(strm, triangleDoc);
                strm.Close();
                isChanged = false;
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String oldName = FileName;
            FileName = null;
            saveToolStripMenuItem_Click(sender, e);
            if (FileName == null)
                FileName = oldName;
        }

        public void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Triangle file (*.tri)|*.tri";
            openFileDialog1.Title = "Open a Triangle File";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                openFile(openFileDialog1.FileName);
            }
            Invalidate(true);
        }

        public void openFile(string fileName)
        {
            try
            {
                FileName = fileName;
                System.Runtime.Serialization.IFormatter fmt = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                System.IO.FileStream strm = new FileStream(FileName, FileMode.Open, FileAccess.Read, FileShare.None);
                triangleDoc = (Triangle)fmt.Deserialize(strm);
                strm.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: Could not read file \"" + fileName + "\" from disk. Original error: " + ex.Message);
                FileName = null;
            }
            if (FileName != null)
                isChanged = false;
        }


        private void FormBillView_Paint(object sender, PaintEventArgs e)
        {
            this.Text = "Triangles";
            if (FileName != null)
                this.Text += " - " + System.IO.Path.GetFileName(FileName);

            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            for (int nCount = 0; nCount < triangleDoc.NumTriangles; nCount++)
            {
                int y = nCount * 20;
                PointF[] pts = StarPoints(5, this.ClientRectangle,y);
                e.Graphics.DrawPolygon(Pens.Yellow, pts);
                e.Graphics.FillPolygon(Brushes.Yellow, pts);
            }

        }
        private PointF[] StarPoints(int num_points, Rectangle bounds,int y)
        {
            
            // Make room for the points.
            PointF[] pts = new PointF[num_points];
            double rx = bounds.Width / 6;
            double ry = bounds.Height / 6;
            double cx = bounds.X + rx +20+ y;
            double cy = bounds.Y + ry +20 +y;


            // Start at the top.
            double theta = -Math.PI / 2;
            double dtheta = 4 * Math.PI / num_points;
            for (int i = 0; i < num_points; i++)
            {
                pts[i] = new PointF(
                (float)(cx + rx * Math.Cos(theta)),
                (float)(cy + ry * Math.Sin(theta)));
                theta += dtheta;
            }

            return pts;
        }
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            triangleDoc = new Triangle();
            isChanged = true;
            Invalidate(true);
        }

        private void saveToolStripMenuItem_Paint(object sender, PaintEventArgs e)
        {
            saveToolStripButton.Enabled = isChanged;
            saveToolStripButton.Enabled = isChanged;
        }

        private void toolStripStatusLabelBills_Paint(object sender, PaintEventArgs e)
        {
            toolStripStatusLabelBills.Text = "#Triangles: " + triangleDoc.NumTriangles.ToString();
        }

    }
}
