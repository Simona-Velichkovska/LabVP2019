using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4
{
    public partial class Form1 : Form
    {
        public Produkti products;
        public Form1()
        {
            InitializeComponent();
            
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            DodadiProdukt form = new DodadiProdukt();
            if (form.ShowDialog() == DialogResult.OK)
            {
                lbProdukti.Items.Add(form.produkt);
            }
        }

        private void lbProdukti_SelectedIndexChanged(object sender, EventArgs e)
        {
            listaProduktiChange(sender,e);
        }

        private void listaProduktiChange(object sender, EventArgs e)
        {
            if (lbProdukti.SelectedIndex == -1)
                return;
            else
            {
                Produkti produkt = lbProdukti.SelectedItem as Produkti;
                tbIme.Text = produkt.Ime;
                tbKategorija.Text = produkt.Katerogija;
                tbCena.Text = String.Format("{0:0.00}", produkt.Cena);
            }

        }
        public void presmetajVkupno()
        {
            double vkupnoSuma = 0;
            Produkti produkt;
            for (int i = 0; i < lbKoshnichka.Items.Count; i++)
            {
                produkt = lbKoshnichka.Items[i] as Produkti;
                vkupnoSuma += produkt.Cena *produkt.Kolicina;
            }
            tbVkupno.Text = String.Format("{0:0.00}", vkupnoSuma);
        }

        private void btnAddKoshnicka_Click(object sender, EventArgs e)
        {
            if (lbProdukti.SelectedIndex == -1)
            {
                MessageBox.Show("Изберете го продуктот што сакате да го внесете во кошничката.", "Грешка!");
            }
            else {
                Produkti newProduct = lbProdukti.SelectedItem as Produkti;
                if (nudKolicina.Value > newProduct.preostanataKolicina)
                {
               
              
                    MessageBox.Show("Нема толку количина од овој продукт", "Грешка");
                }
                else
                {
                    newProduct.newKolicina((int)nudKolicina.Value);
                    newProduct.preostanataKolicina = newProduct.preostanataKolicina - newProduct.Kolicina;                   
                    lbKoshnichka.Items.Add(newProduct);
                    presmetajVkupno();
                }
            }
        }

        private void btnEmptyProducts_Click(object sender, EventArgs e)
        {
            DialogResult res =
                MessageBox.Show("Дали сте сигурни дека сакате да ја испразните листата со продукти",
                "Испразни ја листата?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
                lbProdukti.Items.Clear();
            tbIme.Text = "";
            tbKategorija.Text = "";
            tbCena.Text = "";
        }

        private void btnEmptyKoshnichka_Click(object sender, EventArgs e)
        {
            DialogResult res =
                MessageBox.Show("Дали сте сигурни дека сакате да ја испразните кошничката?",
                "Испразни ја кошничката?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
                lbKoshnichka.Items.Clear();
            presmetajVkupno();
        }

        private void btnRemoveProduct_Click(object sender, EventArgs e)
        {
            if (lbProdukti.SelectedIndex == -1)
                MessageBox.Show("Изберете го продуктот што сакате да го избришете.", "Грешка!");
            else
            {
                lbProdukti.Items.RemoveAt(lbProdukti.SelectedIndex);
                tbIme.Text = "";
                tbKategorija.Text = "";
                tbCena.Text = "";
            }
        }

        private void btnRemoveFromKoshnicka_Click(object sender, EventArgs e)
        {
            if (lbKoshnichka.SelectedIndex == -1)
                MessageBox.Show("Изберете го продуктот што сакате да го тргнете од кошничката.", "Грешка!");
            else
                lbKoshnichka.Items.RemoveAt(lbKoshnichka.SelectedIndex);
            presmetajVkupno();
        }

        private void lbKoshnichka_Format(object sender, ListControlConvertEventArgs e)
        {
            
        }
    }
}
