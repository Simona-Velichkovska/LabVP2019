namespace F1Trka
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
            this.lbVozaci = new System.Windows.Forms.ListBox();
            this.btnAddDrivers = new System.Windows.Forms.Button();
            this.btnDeleteDriver = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.minLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nupTime = new System.Windows.Forms.NumericUpDown();
            this.tbBest = new System.Windows.Forms.TextBox();
            this.btnAddRound = new System.Windows.Forms.Button();
            this.nupSecs = new System.Windows.Forms.NumericUpDown();
            this.nupMins = new System.Windows.Forms.NumericUpDown();
            this.lbKrugovi = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupSecs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupMins)).BeginInit();
            this.SuspendLayout();
            // 
            // lbVozaci
            // 
            this.lbVozaci.FormattingEnabled = true;
            this.lbVozaci.Location = new System.Drawing.Point(9, 19);
            this.lbVozaci.Name = "lbVozaci";
            this.lbVozaci.Size = new System.Drawing.Size(333, 394);
            this.lbVozaci.TabIndex = 0;
            this.lbVozaci.SelectedIndexChanged += new System.EventHandler(this.lbVozaci_SelectedIndexChanged);
            // 
            // btnAddDrivers
            // 
            this.btnAddDrivers.Location = new System.Drawing.Point(21, 451);
            this.btnAddDrivers.Name = "btnAddDrivers";
            this.btnAddDrivers.Size = new System.Drawing.Size(333, 49);
            this.btnAddDrivers.TabIndex = 1;
            this.btnAddDrivers.Text = "Додади возач";
            this.btnAddDrivers.UseVisualStyleBackColor = true;
            this.btnAddDrivers.Click += new System.EventHandler(this.btnAddDrivers_Click);
            // 
            // btnDeleteDriver
            // 
            this.btnDeleteDriver.Enabled = false;
            this.btnDeleteDriver.Location = new System.Drawing.Point(21, 506);
            this.btnDeleteDriver.Name = "btnDeleteDriver";
            this.btnDeleteDriver.Size = new System.Drawing.Size(333, 49);
            this.btnDeleteDriver.TabIndex = 2;
            this.btnDeleteDriver.Text = "Избриши возач";
            this.btnDeleteDriver.UseVisualStyleBackColor = true;
            this.btnDeleteDriver.Click += new System.EventHandler(this.btnDeleteDriver_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbVozaci);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(355, 559);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Возачи";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.minLabel);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.nupTime);
            this.groupBox2.Controls.Add(this.tbBest);
            this.groupBox2.Controls.Add(this.btnAddRound);
            this.groupBox2.Controls.Add(this.nupSecs);
            this.groupBox2.Controls.Add(this.nupMins);
            this.groupBox2.Controls.Add(this.lbKrugovi);
            this.groupBox2.Location = new System.Drawing.Point(373, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(326, 559);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Кругови";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(104, 409);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Секунди";
            // 
            // minLabel
            // 
            this.minLabel.AutoSize = true;
            this.minLabel.Location = new System.Drawing.Point(6, 409);
            this.minLabel.Name = "minLabel";
            this.minLabel.Size = new System.Drawing.Size(44, 13);
            this.minLabel.TabIndex = 9;
            this.minLabel.Text = "Минути";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 507);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Време";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 459);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Најдобар круг";
            // 
            // nupTime
            // 
            this.nupTime.Location = new System.Drawing.Point(6, 523);
            this.nupTime.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.nupTime.Name = "nupTime";
            this.nupTime.Size = new System.Drawing.Size(120, 20);
            this.nupTime.TabIndex = 6;
            this.nupTime.ValueChanged += new System.EventHandler(this.nupTime_ValueChanged);
            // 
            // tbBest
            // 
            this.tbBest.Enabled = false;
            this.tbBest.Location = new System.Drawing.Point(6, 478);
            this.tbBest.Name = "tbBest";
            this.tbBest.Size = new System.Drawing.Size(313, 20);
            this.tbBest.TabIndex = 5;
            // 
            // btnAddRound
            // 
            this.btnAddRound.Enabled = false;
            this.btnAddRound.Location = new System.Drawing.Point(205, 421);
            this.btnAddRound.Name = "btnAddRound";
            this.btnAddRound.Size = new System.Drawing.Size(115, 36);
            this.btnAddRound.TabIndex = 4;
            this.btnAddRound.Text = "Додади круг";
            this.btnAddRound.UseVisualStyleBackColor = true;
            this.btnAddRound.Click += new System.EventHandler(this.btnAddRound_Click);
            // 
            // nupSecs
            // 
            this.nupSecs.Location = new System.Drawing.Point(107, 425);
            this.nupSecs.Name = "nupSecs";
            this.nupSecs.Size = new System.Drawing.Size(91, 20);
            this.nupSecs.TabIndex = 3;
            this.nupSecs.ValueChanged += new System.EventHandler(this.nupSecs_ValueChanged);
            // 
            // nupMins
            // 
            this.nupMins.Location = new System.Drawing.Point(7, 425);
            this.nupMins.Name = "nupMins";
            this.nupMins.Size = new System.Drawing.Size(94, 20);
            this.nupMins.TabIndex = 2;
            // 
            // lbKrugovi
            // 
            this.lbKrugovi.FormattingEnabled = true;
            this.lbKrugovi.Location = new System.Drawing.Point(6, 19);
            this.lbKrugovi.Name = "lbKrugovi";
            this.lbKrugovi.Size = new System.Drawing.Size(314, 381);
            this.lbKrugovi.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 583);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnDeleteDriver);
            this.Controls.Add(this.btnAddDrivers);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupSecs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupMins)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbVozaci;
        private System.Windows.Forms.Button btnAddDrivers;
        private System.Windows.Forms.Button btnDeleteDriver;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label minLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nupTime;
        private System.Windows.Forms.TextBox tbBest;
        private System.Windows.Forms.Button btnAddRound;
        private System.Windows.Forms.NumericUpDown nupSecs;
        private System.Windows.Forms.NumericUpDown nupMins;
        private System.Windows.Forms.ListBox lbKrugovi;
    }
}

