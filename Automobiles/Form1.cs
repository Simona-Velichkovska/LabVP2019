using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Automobiles
{
    public partial class Form1 : Form
    {
        public Automobile automobile;
        public List<Automobile> auto;
        public Form1()
        {
            InitializeComponent();
            auto = new List<Automobile>();
        }

        private void btnAddMarka_Click(object sender, EventArgs e)
        {
            NovaMarka marka = new NovaMarka();
            if (marka.ShowDialog() == DialogResult.OK)
            {
                lbMarka.Items.Add(marka.createdMarka);
                cbMarka.Items.Add(marka.createdMarka);
            }
        }

        private void btnAddAutomobile_Click(object sender, EventArgs e)
        {
            if (cbMarka.Text.Trim().Length == 0)
            {
                MessageBox.Show("Изберете марка", "Error", MessageBoxButtons.OK);
            }
            else if(tbModel.Text.Trim().Length == 0)
            {
                MessageBox.Show("Внесете модел", "Error", MessageBoxButtons.OK);
            }
            else
            {
                automobile = new Automobile(tbModel.Text.Trim(), (int)nudPotrosuvacka.Value, (int)nudCena.Value);
                automobile.addMarka(cbMarka.SelectedItem as Marka);
                lbAutomobiles.Items.Add(automobile);
                loadListAuto();
                tbModel.Clear();

                nudPotrosuvacka.Value = 0;
                nudPotrosuvacka.ResetText();


                nudCena.Value = 0;
                nudCena.ResetText();

                cbMarka.Text = null;
                cbMarka.ResetText();
            }
            
        }


        public void loadListAuto()
        {
            tbAverage.Clear();
            tbExpensive.Clear();
            tbEconomic.Clear();
            foreach(Automobile automobile in lbAutomobiles.Items)
            {
                auto.Add(automobile);
            }
            float sumOfPotroshuvacka = 0;
            if (auto!=null)
            {
               
                Automobile najekonomicen = auto[0];
                Automobile maxAuto = auto[0];

                foreach(Automobile automobile in auto)
                {
                    
                    if(maxAuto.Cena < automobile.Cena)
                    {
                        maxAuto = automobile;
                    }
                    if (najekonomicen.Potroshuvacka > automobile.Potroshuvacka)
                    {
                        najekonomicen = automobile;
                    }
                    sumOfPotroshuvacka += (float)automobile.Potroshuvacka;
                }
                tbAverage.Text = string.Format("{0:#.0}",sumOfPotroshuvacka/lbAutomobiles.Items.Count);
                tbExpensive.Text = maxAuto.ToString();
                tbEconomic.Text = najekonomicen.ToString();
                sumOfPotroshuvacka = 0;
            }
            

            
        }

        private void btnDeleteAutomobile_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Дали сте сигурни дека саката да го избришете автомобилот?","Потврда за бришење", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                lbAutomobiles.Items.RemoveAt(lbAutomobiles.SelectedIndex);
                auto.Clear();
                if (lbAutomobiles.Items.Count > 0)
                {
                    loadListAuto();
                }
                else
                {
                    tbEconomic.Clear();
                    tbAverage.Clear();
                    tbExpensive.Clear();
                }
            }
        }
    }
}
