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
    public partial class FormCircleView : Form
    {
        private Circle circleDoc;
        public String FileName
            { get; private set; }
        public bool isChanged // save required
            { get; private set; }

        public FormCircleView()
        {
            InitializeComponent();
            circleDoc = new Circle();
            isChanged = true;
        }

        public FormCircleView(Form parent, String fileName = null) : this()
        {
            this.MdiParent = parent;
            if (fileName != null)
                openFile(fileName);
        }

        private void panelCoinView_Paint(object sender, PaintEventArgs e)
        {
            SolidBrush br = new SolidBrush(Color.Red);
            Pen pn = new Pen(Color.Black, 1);

            Graphics canvas = panelCoinView.CreateGraphics();
            canvas.Clear(Color.White);
            for (int nCount = 0; nCount < circleDoc.NumCircles; nCount++)
            {
                int y = panelCoinView.Size.Height - 50 - 10 * nCount;
                canvas.FillEllipse(br, 40, y, 50, 50);
                canvas.DrawEllipse(pn, 40, y, 50, 50);
            }
            pn.Dispose();
            br.Dispose();

        }

        private void addACoinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            circleDoc.AddOne();
            isChanged = true;
            Invalidate(true);
        }

        private void removeACoinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            circleDoc.RemoveOne();
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
                saveFileDialog1.Filter = "Circle file (*.crcl)|*.crcl";
                saveFileDialog1.Title = "Save a Circle File";
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                    FileName = saveFileDialog1.FileName;
            }
            if (FileName != null)
            {
                System.Runtime.Serialization.IFormatter fmt = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                System.IO.FileStream strm = new FileStream(FileName, FileMode.Create, FileAccess.Write, FileShare.None);
                fmt.Serialize(strm, circleDoc);
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
            openFileDialog1.Filter = "Circle file (*.crcl)|*.crcl";
            openFileDialog1.Title = "Open a Circle File";
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
                circleDoc = (Circle)fmt.Deserialize(strm);
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

        private void FormCoinView_Paint(object sender, PaintEventArgs e)
        {
            this.Text = "Circless";
            if (FileName != null)
                this.Text += " - " + Path.GetFileName(FileName);
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            circleDoc = new Circle();
            isChanged = true;
            Invalidate(true);
        }

        private void saveToolStripButton_Paint(object sender, PaintEventArgs e)
        {
            saveToolStripButton.Enabled = isChanged;
            saveToolStripButton.Enabled = isChanged;
        }

        private void toolStripStatusLabelCoins_Paint(object sender, PaintEventArgs e)
        {
            toolStripStatusLabelCoins.Text = "#circles: " + circleDoc.NumCircles.ToString();
        }

    }
}
