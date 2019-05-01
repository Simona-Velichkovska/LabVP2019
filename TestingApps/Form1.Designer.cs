namespace TestingApps
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
            this.testingForWhile = new System.Windows.Forms.TextBox();
            this.btnWhileTest = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // testingForWhile
            // 
            this.testingForWhile.Location = new System.Drawing.Point(337, 129);
            this.testingForWhile.Name = "testingForWhile";
            this.testingForWhile.Size = new System.Drawing.Size(100, 20);
            this.testingForWhile.TabIndex = 0;
            // 
            // btnWhileTest
            // 
            this.btnWhileTest.Location = new System.Drawing.Point(346, 174);
            this.btnWhileTest.Name = "btnWhileTest";
            this.btnWhileTest.Size = new System.Drawing.Size(75, 23);
            this.btnWhileTest.TabIndex = 1;
            this.btnWhileTest.Text = "DO!";
            this.btnWhileTest.UseVisualStyleBackColor = true;
            this.btnWhileTest.MouseHover += new System.EventHandler(this.btnWhileTest_MouseHover);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnWhileTest);
            this.Controls.Add(this.testingForWhile);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox testingForWhile;
        private System.Windows.Forms.Button btnWhileTest;
    }
}

