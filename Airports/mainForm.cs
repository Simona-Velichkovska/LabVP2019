using System;
using System.Windows.Forms;

namespace Airports
{
    public partial class mainForm : Form
    {
        
        public mainForm()
        {
            InitializeComponent();
            Airport airport = new Airport("Aлександар Велики", "Скопје", "SKP");
            airport.addDestination(new Destination("Виена",1240,260));
            lbAirports.Items.Add(airport);
            loadDestinations();
        }

        private void addAirport_Click(object sender, EventArgs e)
        {
            airportForm newAirport = new airportForm();
            if(newAirport.ShowDialog()==DialogResult.OK)
            {
                lbAirports.Items.Add(newAirport.createAirport);
            }
        }

        private void deleteAirport_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Дали сакате да го избришете аеродромот?","Избриши аеродром", MessageBoxButtons.YesNo) == DialogResult.Yes && lbAirports.SelectedIndex!=-1)
            {
                lbAirports.Items.RemoveAt(lbAirports.SelectedIndex);

            }
        }

        private void addDestination_Click(object sender, EventArgs e)
        {
            destinationForm newDestination = new destinationForm();
            if (newDestination.ShowDialog() == DialogResult.OK)
            {
                Airport airport = lbAirports.SelectedItem as Airport;
                airport.addDestination(newDestination.createDestination);
                loadDestinations();
            }
        }

        private void lbAirports_SelectedIndexChanged(object sender, EventArgs e)
        {
            deleteAirport.Enabled = lbAirports.SelectedIndex != -1;
            addDestination.Enabled = lbAirports.SelectedIndex != -1;
            loadDestinations();

        }

        void loadDestinations()
        {
            lbDestinations.Items.Clear();
            avrgDisplay.Clear();
            maxDisplay.Clear();
            Airport airport = lbAirports.SelectedItem as Airport;
            if(airport != null && airport.Destinations.Count > 0)
            {
                Destination maxPrice = airport.Destinations[0];
                float totalDistance = 0;
                foreach(Destination destination in airport.Destinations)
                {
                    lbDestinations.Items.Add(destination);
                    if (destination.Price > maxPrice.Price)
                    {
                        maxPrice = destination;
                    }
                    totalDistance += destination.Distance;
                }
                avrgDisplay.Text = string.Format("{0:#.0}", totalDistance / lbDestinations.Items.Count);
                maxDisplay.Text = maxPrice.ToString();
            }

        }
    }
}
