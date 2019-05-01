namespace Automobiles
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDeleteAutomobile = new System.Windows.Forms.Button();
            this.btnAddAutomobile = new System.Windows.Forms.Button();
            this.nudCena = new System.Windows.Forms.NumericUpDown();
            this.nudPotrosuvacka = new System.Windows.Forms.NumericUpDown();
            this.tbModel = new System.Windows.Forms.TextBox();
            this.cbMarka = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbExpensive = new System.Windows.Forms.TextBox();
            this.tbEconomic = new System.Windows.Forms.TextBox();
            this.tbAverage = new System.Windows.Forms.TextBox();
            this.lbAutomobiles = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnAddMarka = new System.Windows.Forms.Button();
            this.lbMarka = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCena)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPotrosuvacka)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnDeleteAutomobile);
            this.groupBox1.Controls.Add(this.btnAddAutomobile);
            this.groupBox1.Controls.Add(this.nudCena);
            this.groupBox1.Controls.Add(this.nudPotrosuvacka);
            this.groupBox1.Controls.Add(this.tbModel);
            this.groupBox1.Controls.Add(this.cbMarka);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(361, 255);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Нов автомобил";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Цена:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Потрошувачка:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Модел:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Марка:";
            // 
            // btnDeleteAutomobile
            // 
            this.btnDeleteAutomobile.Location = new System.Drawing.Point(236, 220);
            this.btnDeleteAutomobile.Name = "btnDeleteAutomobile";
            this.btnDeleteAutomobile.Size = new System.Drawing.Size(119, 23);
            this.btnDeleteAutomobile.TabIndex = 5;
            this.btnDeleteAutomobile.Text = "Избриши автомобил";
            this.btnDeleteAutomobile.UseVisualStyleBackColor = true;
            this.btnDeleteAutomobile.Click += new System.EventHandler(this.btnDeleteAutomobile_Click);
            // 
            // btnAddAutomobile
            // 
            this.btnAddAutomobile.Location = new System.Drawing.Point(7, 220);
            this.btnAddAutomobile.Name = "btnAddAutomobile";
            this.btnAddAutomobile.Size = new System.Drawing.Size(223, 23);
            this.btnAddAutomobile.TabIndex = 4;
            this.btnAddAutomobile.Text = "Додади автомобил";
            this.btnAddAutomobile.UseVisualStyleBackColor = true;
            this.btnAddAutomobile.Click += new System.EventHandler(this.btnAddAutomobile_Click);
            // 
            // nudCena
            // 
            this.nudCena.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudCena.Location = new System.Drawing.Point(7, 194);
            this.nudCena.Maximum = new decimal(new int[] {
            1241513983,
            370409800,
            542101,
            0});
            this.nudCena.Name = "nudCena";
            this.nudCena.Size = new System.Drawing.Size(120, 20);
            this.nudCena.TabIndex = 3;
            // 
            // nudPotrosuvacka
            // 
            this.nudPotrosuvacka.DecimalPlaces = 1;
            this.nudPotrosuvacka.Location = new System.Drawing.Point(7, 145);
            this.nudPotrosuvacka.Name = "nudPotrosuvacka";
            this.nudPotrosuvacka.Size = new System.Drawing.Size(120, 20);
            this.nudPotrosuvacka.TabIndex = 2;
            // 
            // tbModel
            // 
            this.tbModel.Location = new System.Drawing.Point(7, 97);
            this.tbModel.Name = "tbModel";
            this.tbModel.Size = new System.Drawing.Size(348, 20);
            this.tbModel.TabIndex = 1;
            // 
            // cbMarka
            // 
            this.cbMarka.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMarka.FormattingEnabled = true;
            this.cbMarka.Location = new System.Drawing.Point(7, 40);
            this.cbMarka.Name = "cbMarka";
            this.cbMarka.Size = new System.Drawing.Size(348, 21);
            this.cbMarka.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.tbExpensive);
            this.groupBox2.Controls.Add(this.tbEconomic);
            this.groupBox2.Controls.Add(this.tbAverage);
            this.groupBox2.Controls.Add(this.lbAutomobiles);
            this.groupBox2.Location = new System.Drawing.Point(379, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(361, 494);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Листа на автомоили";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 449);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Најскап";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 407);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Најекономичен";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 384);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Просечна потрошувачка:";
            // 
            // tbExpensive
            // 
            this.tbExpensive.Enabled = false;
            this.tbExpensive.Location = new System.Drawing.Point(6, 465);
            this.tbExpensive.Name = "tbExpensive";
            this.tbExpensive.Size = new System.Drawing.Size(342, 20);
            this.tbExpensive.TabIndex = 5;
            // 
            // tbEconomic
            // 
            this.tbEconomic.Enabled = false;
            this.tbEconomic.Location = new System.Drawing.Point(6, 423);
            this.tbEconomic.Name = "tbEconomic";
            this.tbEconomic.Size = new System.Drawing.Size(342, 20);
            this.tbEconomic.TabIndex = 4;
            // 
            // tbAverage
            // 
            this.tbAverage.Enabled = false;
            this.tbAverage.Location = new System.Drawing.Point(177, 384);
            this.tbAverage.Name = "tbAverage";
            this.tbAverage.Size = new System.Drawing.Size(171, 20);
            this.tbAverage.TabIndex = 3;
            // 
            // lbAutomobiles
            // 
            this.lbAutomobiles.FormattingEnabled = true;
            this.lbAutomobiles.Location = new System.Drawing.Point(6, 19);
            this.lbAutomobiles.Name = "lbAutomobiles";
            this.lbAutomobiles.Size = new System.Drawing.Size(342, 342);
            this.lbAutomobiles.TabIndex = 2;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnAddMarka);
            this.groupBox3.Controls.Add(this.lbMarka);
            this.groupBox3.Location = new System.Drawing.Point(12, 273);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(355, 233);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Марки на автомобили";
            // 
            // btnAddMarka
            // 
            this.btnAddMarka.Location = new System.Drawing.Point(144, 201);
            this.btnAddMarka.Name = "btnAddMarka";
            this.btnAddMarka.Size = new System.Drawing.Size(205, 23);
            this.btnAddMarka.TabIndex = 1;
            this.btnAddMarka.Text = "Додади нова марка";
            this.btnAddMarka.UseVisualStyleBackColor = true;
            this.btnAddMarka.Click += new System.EventHandler(this.btnAddMarka_Click);
            // 
            // lbMarka
            // 
            this.lbMarka.FormattingEnabled = true;
            this.lbMarka.Location = new System.Drawing.Point(7, 20);
            this.lbMarka.Name = "lbMarka";
            this.lbMarka.Size = new System.Drawing.Size(342, 173);
            this.lbMarka.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 518);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCena)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPotrosuvacka)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDeleteAutomobile;
        private System.Windows.Forms.Button btnAddAutomobile;
        private System.Windows.Forms.NumericUpDown nudCena;
        private System.Windows.Forms.NumericUpDown nudPotrosuvacka;
        private System.Windows.Forms.TextBox tbModel;
        private System.Windows.Forms.ComboBox cbMarka;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbExpensive;
        private System.Windows.Forms.TextBox tbEconomic;
        private System.Windows.Forms.TextBox tbAverage;
        private System.Windows.Forms.ListBox lbAutomobiles;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnAddMarka;
        private System.Windows.Forms.ListBox lbMarka;
    }
}

