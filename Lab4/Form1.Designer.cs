namespace Lab4
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
            this.lbProdukti = new System.Windows.Forms.ListBox();
            this.lbKoshnichka = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Име = new System.Windows.Forms.Label();
            this.tbCena = new System.Windows.Forms.TextBox();
            this.tbKategorija = new System.Windows.Forms.TextBox();
            this.tbIme = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnEmptyProducts = new System.Windows.Forms.Button();
            this.btnEmptyKoshnichka = new System.Windows.Forms.Button();
            this.btnAddKoshnicka = new System.Windows.Forms.Button();
            this.btnRemoveFromKoshnicka = new System.Windows.Forms.Button();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.btnRemoveProduct = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tbVkupno = new System.Windows.Forms.TextBox();
            this.nudKolicina = new System.Windows.Forms.NumericUpDown();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudKolicina)).BeginInit();
            this.SuspendLayout();
            // 
            // lbProdukti
            // 
            this.lbProdukti.FormattingEnabled = true;
            this.lbProdukti.Location = new System.Drawing.Point(13, 24);
            this.lbProdukti.Name = "lbProdukti";
            this.lbProdukti.Size = new System.Drawing.Size(280, 342);
            this.lbProdukti.TabIndex = 0;
            this.lbProdukti.SelectedIndexChanged += new System.EventHandler(this.lbProdukti_SelectedIndexChanged);
            // 
            // lbKoshnichka
            // 
            this.lbKoshnichka.FormattingEnabled = true;
            this.lbKoshnichka.Location = new System.Drawing.Point(605, 24);
            this.lbKoshnichka.Name = "lbKoshnichka";
            this.lbKoshnichka.Size = new System.Drawing.Size(280, 303);
            this.lbKoshnichka.TabIndex = 1;
            this.lbKoshnichka.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.lbKoshnichka_Format);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.Име);
            this.groupBox1.Controls.Add(this.tbCena);
            this.groupBox1.Controls.Add(this.tbKategorija);
            this.groupBox1.Controls.Add(this.tbIme);
            this.groupBox1.Location = new System.Drawing.Point(299, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(300, 181);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Детали за продуктот";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 109);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Цена";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Категорија";
            // 
            // Име
            // 
            this.Име.AutoSize = true;
            this.Име.Location = new System.Drawing.Point(7, 24);
            this.Име.Name = "Име";
            this.Име.Size = new System.Drawing.Size(29, 13);
            this.Име.TabIndex = 3;
            this.Име.Text = "Име";
            // 
            // tbCena
            // 
            this.tbCena.Enabled = false;
            this.tbCena.Location = new System.Drawing.Point(10, 125);
            this.tbCena.Name = "tbCena";
            this.tbCena.Size = new System.Drawing.Size(131, 20);
            this.tbCena.TabIndex = 2;
            this.tbCena.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbKategorija
            // 
            this.tbKategorija.Enabled = false;
            this.tbKategorija.Location = new System.Drawing.Point(10, 80);
            this.tbKategorija.Name = "tbKategorija";
            this.tbKategorija.Size = new System.Drawing.Size(280, 20);
            this.tbKategorija.TabIndex = 1;
            // 
            // tbIme
            // 
            this.tbIme.Enabled = false;
            this.tbIme.Location = new System.Drawing.Point(9, 40);
            this.tbIme.Name = "tbIme";
            this.tbIme.Size = new System.Drawing.Size(280, 20);
            this.tbIme.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Листа на продукти";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(602, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Кошничка";
            // 
            // btnEmptyProducts
            // 
            this.btnEmptyProducts.Location = new System.Drawing.Point(12, 373);
            this.btnEmptyProducts.Name = "btnEmptyProducts";
            this.btnEmptyProducts.Size = new System.Drawing.Size(280, 23);
            this.btnEmptyProducts.TabIndex = 5;
            this.btnEmptyProducts.Text = "Испразни ја кошничката со продукти?";
            this.btnEmptyProducts.UseVisualStyleBackColor = true;
            this.btnEmptyProducts.Click += new System.EventHandler(this.btnEmptyProducts_Click);
            // 
            // btnEmptyKoshnichka
            // 
            this.btnEmptyKoshnichka.Location = new System.Drawing.Point(605, 373);
            this.btnEmptyKoshnichka.Name = "btnEmptyKoshnichka";
            this.btnEmptyKoshnichka.Size = new System.Drawing.Size(280, 23);
            this.btnEmptyKoshnichka.TabIndex = 6;
            this.btnEmptyKoshnichka.Text = "Испразни ја кошничката?";
            this.btnEmptyKoshnichka.UseVisualStyleBackColor = true;
            this.btnEmptyKoshnichka.Click += new System.EventHandler(this.btnEmptyKoshnichka_Click);
            // 
            // btnAddKoshnicka
            // 
            this.btnAddKoshnicka.Location = new System.Drawing.Point(299, 218);
            this.btnAddKoshnicka.Name = "btnAddKoshnicka";
            this.btnAddKoshnicka.Size = new System.Drawing.Size(224, 23);
            this.btnAddKoshnicka.TabIndex = 7;
            this.btnAddKoshnicka.Text = "Додади во кошничка >>";
            this.btnAddKoshnicka.UseVisualStyleBackColor = true;
            this.btnAddKoshnicka.Click += new System.EventHandler(this.btnAddKoshnicka_Click);
            // 
            // btnRemoveFromKoshnicka
            // 
            this.btnRemoveFromKoshnicka.Location = new System.Drawing.Point(299, 257);
            this.btnRemoveFromKoshnicka.Name = "btnRemoveFromKoshnicka";
            this.btnRemoveFromKoshnicka.Size = new System.Drawing.Size(300, 23);
            this.btnRemoveFromKoshnicka.TabIndex = 8;
            this.btnRemoveFromKoshnicka.Text = "Избриши од кошничка";
            this.btnRemoveFromKoshnicka.UseVisualStyleBackColor = true;
            this.btnRemoveFromKoshnicka.Click += new System.EventHandler(this.btnRemoveFromKoshnicka_Click);
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Location = new System.Drawing.Point(299, 295);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(300, 23);
            this.btnAddProduct.TabIndex = 9;
            this.btnAddProduct.Text = "Додади нов продукт";
            this.btnAddProduct.UseVisualStyleBackColor = true;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // btnRemoveProduct
            // 
            this.btnRemoveProduct.Location = new System.Drawing.Point(299, 335);
            this.btnRemoveProduct.Name = "btnRemoveProduct";
            this.btnRemoveProduct.Size = new System.Drawing.Size(300, 23);
            this.btnRemoveProduct.TabIndex = 10;
            this.btnRemoveProduct.Text = "Избриши продукт";
            this.btnRemoveProduct.UseVisualStyleBackColor = true;
            this.btnRemoveProduct.Click += new System.EventHandler(this.btnRemoveProduct_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(602, 345);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Вкупно";
            // 
            // tbVkupno
            // 
            this.tbVkupno.Enabled = false;
            this.tbVkupno.Location = new System.Drawing.Point(668, 340);
            this.tbVkupno.Name = "tbVkupno";
            this.tbVkupno.Size = new System.Drawing.Size(217, 20);
            this.tbVkupno.TabIndex = 12;
            // 
            // nudKolicina
            // 
            this.nudKolicina.Location = new System.Drawing.Point(530, 220);
            this.nudKolicina.Name = "nudKolicina";
            this.nudKolicina.Size = new System.Drawing.Size(69, 20);
            this.nudKolicina.TabIndex = 13;
            this.nudKolicina.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudKolicina.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 408);
            this.Controls.Add(this.nudKolicina);
            this.Controls.Add(this.tbVkupno);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnRemoveProduct);
            this.Controls.Add(this.btnAddProduct);
            this.Controls.Add(this.btnRemoveFromKoshnicka);
            this.Controls.Add(this.btnAddKoshnicka);
            this.Controls.Add(this.btnEmptyKoshnichka);
            this.Controls.Add(this.btnEmptyProducts);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbKoshnichka);
            this.Controls.Add(this.lbProdukti);
            this.Name = "Form1";
            this.Text = "Потрошувачка кошничка";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudKolicina)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbProdukti;
        private System.Windows.Forms.ListBox lbKoshnichka;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label Име;
        private System.Windows.Forms.TextBox tbCena;
        private System.Windows.Forms.TextBox tbKategorija;
        private System.Windows.Forms.TextBox tbIme;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnEmptyProducts;
        private System.Windows.Forms.Button btnEmptyKoshnichka;
        private System.Windows.Forms.Button btnAddKoshnicka;
        private System.Windows.Forms.Button btnRemoveFromKoshnicka;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.Button btnRemoveProduct;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbVkupno;
        private System.Windows.Forms.NumericUpDown nudKolicina;
    }
}

