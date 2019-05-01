using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace F1Trka
{
    public partial class Form1 : Form
    {
        public Round newRound;
        public Driver newDriver;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAddDrivers_Click(object sender, EventArgs e)
        {
            AddDriverForm addDriverForm = new AddDriverForm();
            if(addDriverForm.ShowDialog() == DialogResult.OK)
            {
                lbVozaci.Items.Add(addDriverForm.createDriver);
            }
          
        }

        private void btnDeleteDriver_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Дали сте сигурни дека саката да го избришете возачот?", "Избриши Возач", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                lbVozaci.Items.RemoveAt(lbVozaci.SelectedIndex);
            }
        }

        private void btnAddRound_Click(object sender, EventArgs e)
        {
            newRound = new Round((int)nupMins.Value,(int)nupSecs.Value);
            Driver driver = lbVozaci.SelectedItem as Driver;
            driver.addRound(newRound);
            nupMins.Value = 0;
            nupSecs.Value = 0;
            loadRounds();
        }

        private void nupSecs_ValueChanged(object sender, EventArgs e)
        {
            int value = (int)nupSecs.Value;
            if (value < 0)
            {
                int min = (int)nupMins.Value;
                if (min > 0)
                {
                    nupMins.Value = min - 1;
                    nupSecs.Value = 59;
                }
                else
                {
                    nupSecs.Value = 0;
                }

            }
            else
            {
                nupSecs.Value = value % 60;
                nupMins.Value += value / 60;
            }


        }


        public void loadRounds()
        {
            lbKrugovi.Items.Clear();
            Driver driver = lbVozaci.SelectedItem as Driver;
            if(driver!=null && driver.Rounds.Count > 0)
            {
                int limitedByTime = (int)nupTime.Value;
                Round bestRound = driver.Rounds[0];
                foreach(Round round in driver.Rounds)
                {
                    if(limitedByTime > 0)
                    {
                        if(round.Time > limitedByTime)
                        {
                            lbKrugovi.Items.Add(round);
                        }
                    }
                    else
                    {
                        lbKrugovi.Items.Add(round);
                    }
                    if (round.Time < bestRound.Time)
                    {
                        bestRound = round;
                    }
                }
                tbBest.Text = bestRound.ToString();
            }
            else
            {
                tbBest.Clear();
            }
        }

        private void lbVozaci_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnAddRound.Enabled = lbVozaci.SelectedIndex != -1;
            btnDeleteDriver.Enabled = lbVozaci.SelectedIndex != -1;
            loadRounds();
        }

        private void nupTime_ValueChanged(object sender, EventArgs e)
        {
            loadRounds();
        }
    }
}
