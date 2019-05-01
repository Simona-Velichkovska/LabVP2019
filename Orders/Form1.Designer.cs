namespace Orders
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnAddNarachka = new System.Windows.Forms.Button();
            this.btnAddSmetka = new System.Windows.Forms.Button();
            this.lbNarachki = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbShowDate = new System.Windows.Forms.Label();
            this.lbShowTime = new System.Windows.Forms.Label();
            this.lbSmetki = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbVkupno = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbNarachki);
            this.groupBox1.Controls.Add(this.btnAddSmetka);
            this.groupBox1.Controls.Add(this.btnAddNarachka);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(381, 425);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Нарачај";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbVkupno);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.lbSmetki);
            this.groupBox2.Controls.Add(this.lbShowTime);
            this.groupBox2.Controls.Add(this.lbShowDate);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(407, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(381, 425);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Сметки";
            // 
            // btnAddNarachka
            // 
            this.btnAddNarachka.Location = new System.Drawing.Point(7, 20);
            this.btnAddNarachka.Name = "btnAddNarachka";
            this.btnAddNarachka.Size = new System.Drawing.Size(368, 23);
            this.btnAddNarachka.TabIndex = 0;
            this.btnAddNarachka.Text = "Внеси нарачка";
            this.btnAddNarachka.UseVisualStyleBackColor = true;
            this.btnAddNarachka.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAddSmetka
            // 
            this.btnAddSmetka.Location = new System.Drawing.Point(6, 396);
            this.btnAddSmetka.Name = "btnAddSmetka";
            this.btnAddSmetka.Size = new System.Drawing.Size(368, 23);
            this.btnAddSmetka.TabIndex = 1;
            this.btnAddSmetka.Text = "Сметка";
            this.btnAddSmetka.UseVisualStyleBackColor = true;
            // 
            // lbNarachki
            // 
            this.lbNarachki.FormattingEnabled = true;
            this.lbNarachki.Location = new System.Drawing.Point(7, 50);
            this.lbNarachki.Name = "lbNarachki";
            this.lbNarachki.Size = new System.Drawing.Size(367, 342);
            this.lbNarachki.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Време";
            // 
            // lbShowDate
            // 
            this.lbShowDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbShowDate.AutoSize = true;
            this.lbShowDate.Location = new System.Drawing.Point(296, 16);
            this.lbShowDate.Name = "lbShowDate";
            this.lbShowDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbShowDate.Size = new System.Drawing.Size(65, 13);
            this.lbShowDate.TabIndex = 1;
            this.lbShowDate.Text = "lbShowDate";
            this.lbShowDate.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lbShowTime
            // 
            this.lbShowTime.AutoSize = true;
            this.lbShowTime.Location = new System.Drawing.Point(296, 50);
            this.lbShowTime.Name = "lbShowTime";
            this.lbShowTime.Size = new System.Drawing.Size(65, 13);
            this.lbShowTime.TabIndex = 2;
            this.lbShowTime.Text = "lbShowTime";
            // 
            // lbSmetki
            // 
            this.lbSmetki.FormattingEnabled = true;
            this.lbSmetki.Location = new System.Drawing.Point(10, 75);
            this.lbSmetki.Name = "lbSmetki";
            this.lbSmetki.Size = new System.Drawing.Size(351, 316);
            this.lbSmetki.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 401);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Вкупно";
            // 
            // tbVkupno
            // 
            this.tbVkupno.Location = new System.Drawing.Point(86, 398);
            this.tbVkupno.Name = "tbVkupno";
            this.tbVkupno.Size = new System.Drawing.Size(275, 20);
            this.tbVkupno.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lbNarachki;
        private System.Windows.Forms.Button btnAddSmetka;
        private System.Windows.Forms.Button btnAddNarachka;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tbVkupno;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lbSmetki;
        private System.Windows.Forms.Label lbShowTime;
        private System.Windows.Forms.Label lbShowDate;
        private System.Windows.Forms.Label label1;
    }
}

