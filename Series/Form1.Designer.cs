namespace Series
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
            this.lbSeries = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbAverage = new System.Windows.Forms.TextBox();
            this.tbMostSeasons = new System.Windows.Forms.TextBox();
            this.cbProduction = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.nudRating = new System.Windows.Forms.NumericUpDown();
            this.nudSeasons = new System.Windows.Forms.NumericUpDown();
            this.btnAddSeries = new System.Windows.Forms.Button();
            this.btnDeleteSeries = new System.Windows.Forms.Button();
            this.btnAddProduction = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudRating)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSeasons)).BeginInit();
            this.SuspendLayout();
            // 
            // lbSeries
            // 
            this.lbSeries.FormattingEnabled = true;
            this.lbSeries.Location = new System.Drawing.Point(393, 33);
            this.lbSeries.Name = "lbSeries";
            this.lbSeries.Size = new System.Drawing.Size(383, 290);
            this.lbSeries.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.tbMostSeasons);
            this.groupBox2.Controls.Add(this.tbAverage);
            this.groupBox2.Location = new System.Drawing.Point(384, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(404, 426);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Листа на серии";
            // 
            // tbAverage
            // 
            this.tbAverage.Location = new System.Drawing.Point(9, 345);
            this.tbAverage.Name = "tbAverage";
            this.tbAverage.Size = new System.Drawing.Size(383, 20);
            this.tbAverage.TabIndex = 0;
            // 
            // tbMostSeasons
            // 
            this.tbMostSeasons.Location = new System.Drawing.Point(9, 393);
            this.tbMostSeasons.Name = "tbMostSeasons";
            this.tbMostSeasons.Size = new System.Drawing.Size(383, 20);
            this.tbMostSeasons.TabIndex = 1;
            // 
            // cbProduction
            // 
            this.cbProduction.FormattingEnabled = true;
            this.cbProduction.Location = new System.Drawing.Point(19, 60);
            this.cbProduction.Name = "cbProduction";
            this.cbProduction.Size = new System.Drawing.Size(349, 21);
            this.cbProduction.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnDeleteSeries);
            this.groupBox1.Controls.Add(this.btnAddSeries);
            this.groupBox1.Controls.Add(this.nudSeasons);
            this.groupBox1.Controls.Add(this.nudRating);
            this.groupBox1.Controls.Add(this.tbName);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(365, 305);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Нова серија";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(7, 100);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(348, 20);
            this.tbName.TabIndex = 0;
            // 
            // nudRating
            // 
            this.nudRating.Location = new System.Drawing.Point(7, 169);
            this.nudRating.Name = "nudRating";
            this.nudRating.Size = new System.Drawing.Size(120, 20);
            this.nudRating.TabIndex = 1;
            // 
            // nudSeasons
            // 
            this.nudSeasons.Location = new System.Drawing.Point(7, 223);
            this.nudSeasons.Name = "nudSeasons";
            this.nudSeasons.Size = new System.Drawing.Size(120, 20);
            this.nudSeasons.TabIndex = 2;
            // 
            // btnAddSeries
            // 
            this.btnAddSeries.Location = new System.Drawing.Point(7, 266);
            this.btnAddSeries.Name = "btnAddSeries";
            this.btnAddSeries.Size = new System.Drawing.Size(203, 23);
            this.btnAddSeries.TabIndex = 3;
            this.btnAddSeries.Text = "Додади серија";
            this.btnAddSeries.UseVisualStyleBackColor = true;
            // 
            // btnDeleteSeries
            // 
            this.btnDeleteSeries.Location = new System.Drawing.Point(225, 266);
            this.btnDeleteSeries.Name = "btnDeleteSeries";
            this.btnDeleteSeries.Size = new System.Drawing.Size(130, 23);
            this.btnDeleteSeries.TabIndex = 4;
            this.btnDeleteSeries.Text = "Избриши серија";
            this.btnDeleteSeries.UseVisualStyleBackColor = true;
            // 
            // btnAddProduction
            // 
            this.btnAddProduction.Location = new System.Drawing.Point(20, 414);
            this.btnAddProduction.Name = "btnAddProduction";
            this.btnAddProduction.Size = new System.Drawing.Size(203, 24);
            this.btnAddProduction.TabIndex = 5;
            this.btnAddProduction.Text = "Додади продукција";
            this.btnAddProduction.UseVisualStyleBackColor = true;
            this.btnAddProduction.Click += new System.EventHandler(this.btnAddProduction_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Продукција";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Име";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Рејтинг";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Број на сезони";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 329);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Просечен рејтинг:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 377);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Најмногу сезони";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAddProduction);
            this.Controls.Add(this.cbProduction);
            this.Controls.Add(this.lbSeries);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudRating)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSeasons)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbSeries;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbMostSeasons;
        private System.Windows.Forms.TextBox tbAverage;
        private System.Windows.Forms.ComboBox cbProduction;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDeleteSeries;
        private System.Windows.Forms.Button btnAddSeries;
        private System.Windows.Forms.NumericUpDown nudSeasons;
        private System.Windows.Forms.NumericUpDown nudRating;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Button btnAddProduction;
    }
}

