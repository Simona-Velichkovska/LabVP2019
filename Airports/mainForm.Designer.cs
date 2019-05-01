namespace Airports
{
    partial class mainForm
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
            this.destLb = new System.Windows.Forms.Label();
            this.aeroLb = new System.Windows.Forms.Label();
            this.addAirport = new System.Windows.Forms.Button();
            this.deleteAirport = new System.Windows.Forms.Button();
            this.addDestination = new System.Windows.Forms.Button();
            this.infoGroup = new System.Windows.Forms.GroupBox();
            this.avrgDisplay = new System.Windows.Forms.TextBox();
            this.maxDisplay = new System.Windows.Forms.TextBox();
            this.avrgLabel = new System.Windows.Forms.Label();
            this.maxDestination = new System.Windows.Forms.Label();
            this.lbAirports = new System.Windows.Forms.ListBox();
            this.lbDestinations = new System.Windows.Forms.ListBox();
            this.infoGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // destLb
            // 
            this.destLb.AutoSize = true;
            this.destLb.Location = new System.Drawing.Point(349, 14);
            this.destLb.Name = "destLb";
            this.destLb.Size = new System.Drawing.Size(69, 13);
            this.destLb.TabIndex = 2;
            this.destLb.Text = "Дестинации";
            // 
            // aeroLb
            // 
            this.aeroLb.AutoSize = true;
            this.aeroLb.Location = new System.Drawing.Point(15, 14);
            this.aeroLb.Name = "aeroLb";
            this.aeroLb.Size = new System.Drawing.Size(64, 13);
            this.aeroLb.TabIndex = 3;
            this.aeroLb.Text = "Аеродроми";
            // 
            // addAirport
            // 
            this.addAirport.Location = new System.Drawing.Point(16, 344);
            this.addAirport.Name = "addAirport";
            this.addAirport.Size = new System.Drawing.Size(317, 23);
            this.addAirport.TabIndex = 4;
            this.addAirport.Text = "Додади Аеродром";
            this.addAirport.UseVisualStyleBackColor = true;
            this.addAirport.Click += new System.EventHandler(this.addAirport_Click);
            // 
            // deleteAirport
            // 
            this.deleteAirport.Location = new System.Drawing.Point(16, 387);
            this.deleteAirport.Name = "deleteAirport";
            this.deleteAirport.Size = new System.Drawing.Size(317, 23);
            this.deleteAirport.TabIndex = 5;
            this.deleteAirport.Text = "Избриши аеродром";
            this.deleteAirport.UseVisualStyleBackColor = true;
            this.deleteAirport.Click += new System.EventHandler(this.deleteAirport_Click);
            // 
            // addDestination
            // 
            this.addDestination.Location = new System.Drawing.Point(16, 429);
            this.addDestination.Name = "addDestination";
            this.addDestination.Size = new System.Drawing.Size(317, 23);
            this.addDestination.TabIndex = 6;
            this.addDestination.Text = "Додади дестинација";
            this.addDestination.UseVisualStyleBackColor = true;
            this.addDestination.Click += new System.EventHandler(this.addDestination_Click);
            // 
            // infoGroup
            // 
            this.infoGroup.Controls.Add(this.avrgDisplay);
            this.infoGroup.Controls.Add(this.maxDisplay);
            this.infoGroup.Controls.Add(this.avrgLabel);
            this.infoGroup.Controls.Add(this.maxDestination);
            this.infoGroup.Location = new System.Drawing.Point(349, 321);
            this.infoGroup.Name = "infoGroup";
            this.infoGroup.Size = new System.Drawing.Size(317, 131);
            this.infoGroup.TabIndex = 7;
            this.infoGroup.TabStop = false;
            this.infoGroup.Text = "Дестинации";
            // 
            // avrgDisplay
            // 
            this.avrgDisplay.Enabled = false;
            this.avrgDisplay.Location = new System.Drawing.Point(9, 87);
            this.avrgDisplay.Name = "avrgDisplay";
            this.avrgDisplay.Size = new System.Drawing.Size(292, 20);
            this.avrgDisplay.TabIndex = 3;
            // 
            // maxDisplay
            // 
            this.maxDisplay.Enabled = false;
            this.maxDisplay.Location = new System.Drawing.Point(9, 39);
            this.maxDisplay.Name = "maxDisplay";
            this.maxDisplay.Size = new System.Drawing.Size(292, 20);
            this.maxDisplay.TabIndex = 2;
            // 
            // avrgLabel
            // 
            this.avrgLabel.AutoSize = true;
            this.avrgLabel.Location = new System.Drawing.Point(6, 71);
            this.avrgLabel.Name = "avrgLabel";
            this.avrgLabel.Size = new System.Drawing.Size(191, 13);
            this.avrgLabel.TabIndex = 1;
            this.avrgLabel.Text = "Просечна должина на дестинациите";
            // 
            // maxDestination
            // 
            this.maxDestination.AutoSize = true;
            this.maxDestination.Location = new System.Drawing.Point(7, 23);
            this.maxDestination.Name = "maxDestination";
            this.maxDestination.Size = new System.Drawing.Size(117, 13);
            this.maxDestination.TabIndex = 0;
            this.maxDestination.Text = "Најскапа дестинација";
            // 
            // lbAirports
            // 
            this.lbAirports.FormattingEnabled = true;
            this.lbAirports.Location = new System.Drawing.Point(16, 33);
            this.lbAirports.Name = "lbAirports";
            this.lbAirports.Size = new System.Drawing.Size(317, 277);
            this.lbAirports.TabIndex = 8;
            this.lbAirports.SelectedIndexChanged += new System.EventHandler(this.lbAirports_SelectedIndexChanged);
            // 
            // lbDestinations
            // 
            this.lbDestinations.FormattingEnabled = true;
            this.lbDestinations.Location = new System.Drawing.Point(349, 33);
            this.lbDestinations.Name = "lbDestinations";
            this.lbDestinations.Size = new System.Drawing.Size(317, 277);
            this.lbDestinations.TabIndex = 9;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 478);
            this.Controls.Add(this.lbDestinations);
            this.Controls.Add(this.lbAirports);
            this.Controls.Add(this.infoGroup);
            this.Controls.Add(this.addDestination);
            this.Controls.Add(this.deleteAirport);
            this.Controls.Add(this.addAirport);
            this.Controls.Add(this.aeroLb);
            this.Controls.Add(this.destLb);
            this.Name = "mainForm";
            this.Text = "Аеродроми";
            this.infoGroup.ResumeLayout(false);
            this.infoGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label destLb;
        private System.Windows.Forms.Label aeroLb;
        private System.Windows.Forms.Button addAirport;
        private System.Windows.Forms.Button deleteAirport;
        private System.Windows.Forms.Button addDestination;
        private System.Windows.Forms.GroupBox infoGroup;
        private System.Windows.Forms.TextBox avrgDisplay;
        private System.Windows.Forms.TextBox maxDisplay;
        private System.Windows.Forms.Label avrgLabel;
        private System.Windows.Forms.Label maxDestination;
        private System.Windows.Forms.ListBox lbAirports;
        private System.Windows.Forms.ListBox lbDestinations;
    }
}

