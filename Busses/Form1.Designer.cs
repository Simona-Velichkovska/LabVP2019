namespace Busses
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbAvtobusi = new System.Windows.Forms.ListBox();
            this.lbLinii = new System.Windows.Forms.ListBox();
            this.btnAddBusses = new System.Windows.Forms.Button();
            this.btnRemoveBus = new System.Windows.Forms.Button();
            this.btnAddLine = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbExpensive = new System.Windows.Forms.TextBox();
            this.tbAverage = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbAvtobusi
            // 
            this.lbAvtobusi.FormattingEnabled = true;
            this.lbAvtobusi.Location = new System.Drawing.Point(13, 24);
            this.lbAvtobusi.Name = "lbAvtobusi";
            this.lbAvtobusi.Size = new System.Drawing.Size(363, 277);
            this.lbAvtobusi.TabIndex = 0;
            this.lbAvtobusi.SelectedIndexChanged += new System.EventHandler(this.lbAvtobusi_SelectedIndexChanged);
            // 
            // lbLinii
            // 
            this.lbLinii.FormattingEnabled = true;
            this.lbLinii.Location = new System.Drawing.Point(397, 24);
            this.lbLinii.Name = "lbLinii";
            this.lbLinii.Size = new System.Drawing.Size(363, 277);
            this.lbLinii.TabIndex = 1;
            // 
            // btnAddBusses
            // 
            this.btnAddBusses.Location = new System.Drawing.Point(13, 322);
            this.btnAddBusses.Name = "btnAddBusses";
            this.btnAddBusses.Size = new System.Drawing.Size(363, 23);
            this.btnAddBusses.TabIndex = 2;
            this.btnAddBusses.Text = "Додади автобус";
            this.btnAddBusses.UseVisualStyleBackColor = true;
            this.btnAddBusses.Click += new System.EventHandler(this.btnAddBusses_Click);
            // 
            // btnRemoveBus
            // 
            this.btnRemoveBus.Enabled = false;
            this.btnRemoveBus.Location = new System.Drawing.Point(12, 364);
            this.btnRemoveBus.Name = "btnRemoveBus";
            this.btnRemoveBus.Size = new System.Drawing.Size(363, 23);
            this.btnRemoveBus.TabIndex = 3;
            this.btnRemoveBus.Text = "Избриши автобус";
            this.btnRemoveBus.UseVisualStyleBackColor = true;
            this.btnRemoveBus.Click += new System.EventHandler(this.btnRemoveBus_Click);
            // 
            // btnAddLine
            // 
            this.btnAddLine.Enabled = false;
            this.btnAddLine.Location = new System.Drawing.Point(12, 405);
            this.btnAddLine.Name = "btnAddLine";
            this.btnAddLine.Size = new System.Drawing.Size(363, 23);
            this.btnAddLine.TabIndex = 4;
            this.btnAddLine.Text = "Додади Линија";
            this.btnAddLine.UseVisualStyleBackColor = true;
            this.btnAddLine.Click += new System.EventHandler(this.btnAddLine_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tbAverage);
            this.groupBox1.Controls.Add(this.tbExpensive);
            this.groupBox1.Location = new System.Drawing.Point(397, 307);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(363, 121);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Линии";
            // 
            // tbExpensive
            // 
            this.tbExpensive.Enabled = false;
            this.tbExpensive.Location = new System.Drawing.Point(7, 38);
            this.tbExpensive.Name = "tbExpensive";
            this.tbExpensive.Size = new System.Drawing.Size(350, 20);
            this.tbExpensive.TabIndex = 0;
            // 
            // tbAverage
            // 
            this.tbAverage.Enabled = false;
            this.tbAverage.Location = new System.Drawing.Point(7, 82);
            this.tbAverage.Name = "tbAverage";
            this.tbAverage.Size = new System.Drawing.Size(350, 20);
            this.tbAverage.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Автобуси";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(394, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Линии";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Најскапа линија";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Просечна цена на линиите";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnAddLine);
            this.Controls.Add(this.btnRemoveBus);
            this.Controls.Add(this.btnAddBusses);
            this.Controls.Add(this.lbLinii);
            this.Controls.Add(this.lbAvtobusi);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbAvtobusi;
        private System.Windows.Forms.ListBox lbLinii;
        private System.Windows.Forms.Button btnAddBusses;
        private System.Windows.Forms.Button btnRemoveBus;
        private System.Windows.Forms.Button btnAddLine;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbAverage;
        private System.Windows.Forms.TextBox tbExpensive;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

