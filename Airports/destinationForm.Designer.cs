namespace Airports
{
    partial class destinationForm
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
            this.components = new System.ComponentModel.Container();
            this.groupNewDest = new System.Windows.Forms.GroupBox();
            this.nupDistance = new System.Windows.Forms.NumericUpDown();
            this.nupCost = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.tbDestName = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupNewDest.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupDistance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupCost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupNewDest
            // 
            this.groupNewDest.Controls.Add(this.nupDistance);
            this.groupNewDest.Controls.Add(this.nupCost);
            this.groupNewDest.Controls.Add(this.label3);
            this.groupNewDest.Controls.Add(this.label2);
            this.groupNewDest.Controls.Add(this.label1);
            this.groupNewDest.Controls.Add(this.btnCancel);
            this.groupNewDest.Controls.Add(this.btnSave);
            this.groupNewDest.Controls.Add(this.tbDestName);
            this.groupNewDest.Location = new System.Drawing.Point(12, 12);
            this.groupNewDest.Name = "groupNewDest";
            this.groupNewDest.Size = new System.Drawing.Size(266, 216);
            this.groupNewDest.TabIndex = 14;
            this.groupNewDest.TabStop = false;
            this.groupNewDest.Text = "Додади дестинација";
            // 
            // nupDistance
            // 
            this.nupDistance.Location = new System.Drawing.Point(6, 93);
            this.nupDistance.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.nupDistance.Name = "nupDistance";
            this.nupDistance.Size = new System.Drawing.Size(120, 20);
            this.nupDistance.TabIndex = 15;
            // 
            // nupCost
            // 
            this.nupCost.Location = new System.Drawing.Point(6, 140);
            this.nupCost.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.nupCost.Name = "nupCost";
            this.nupCost.Size = new System.Drawing.Size(120, 20);
            this.nupCost.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Цена";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Должина";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Име:";
            // 
            // btnCancel
            // 
            this.btnCancel.CausesValidation = false;
            this.btnCancel.Location = new System.Drawing.Point(131, 178);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(112, 23);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Откажи";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(6, 178);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(107, 23);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Додади";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // tbDestName
            // 
            this.tbDestName.Location = new System.Drawing.Point(6, 46);
            this.tbDestName.Name = "tbDestName";
            this.tbDestName.Size = new System.Drawing.Size(237, 20);
            this.tbDestName.TabIndex = 6;
            this.tbDestName.Validating += new System.ComponentModel.CancelEventHandler(this.tbDestName_Validating);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // destinationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 240);
            this.Controls.Add(this.groupNewDest);
            this.Name = "destinationForm";
            this.Text = "destinationForm";
            this.Load += new System.EventHandler(this.destinationForm_Load);
            this.groupNewDest.ResumeLayout(false);
            this.groupNewDest.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupDistance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupCost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupNewDest;
        private System.Windows.Forms.NumericUpDown nupDistance;
        private System.Windows.Forms.NumericUpDown nupCost;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox tbDestName;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}