using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InClassDemoFive
{
    public partial class formMain : Form
    {
        public formMain()
        {
            InitializeComponent();
            //lbLocations.Items.Add("Seattle, WA");
            //lbLocations.Items.Add("Boston, MA");
            //lbLocations.Items.Add("Chicago, IL");
            //lbLocations.Items.Add("Portland, OR");
            //lbLocations.Items.Add("Los Angeles, CA");
            //lbLocations.Items.Add("Miami, FL");
        }

        private double add_checkboxes()
        {
            double totalValue = 0.0;
            if (cb00.Checked)
                totalValue += 0.0;
            if (cb10.Checked)
                totalValue += 1.0;
            if (cb20.Checked)
                totalValue += 2.0;
            if (cb30.Checked)
                totalValue += 3.0;
            if (cb40.Checked)
                totalValue += 4.0;
 
            return totalValue;
        }

        private void btnWhoWins_Click(object sender, EventArgs e)
        {
            if (int.Parse(tbRedWingScore.Text) > int.Parse(tbIslandersScore.Text) && int.Parse(tbGameNumber.Text) > 60)
                MessageBox.Show("Red Wings Win A Playoff Game");
            else if (int.Parse(tbRedWingScore.Text) < int.Parse(tbIslandersScore.Text) && int.Parse(tbGameNumber.Text) > 60)
                MessageBox.Show("Islanders Win A Playoff Game");
            else if (int.Parse(tbRedWingScore.Text) > int.Parse(tbIslandersScore.Text) && int.Parse(tbGameNumber.Text) < 61)
                MessageBox.Show("Red Wings Win A Regular Game");
            else if (int.Parse(tbRedWingScore.Text) < int.Parse(tbIslandersScore.Text) && int.Parse(tbGameNumber.Text) < 61)
                MessageBox.Show("Islanders Win A Regular Game");
            else if (int.Parse(tbRedWingScore.Text) == int.Parse(tbIslandersScore.Text) && int.Parse(tbGameNumber.Text) > 60)
                MessageBox.Show("It's A Tie Playoff Game");
            else if (int.Parse(tbRedWingScore.Text) == int.Parse(tbIslandersScore.Text) && int.Parse(tbGameNumber.Text) < 61)
                MessageBox.Show("It's A Tie Regular Game");
            else
                MessageBox.Show("HOW DID YOU DO THIS?!?!?!?!");
        }

        private void btnExitProgram_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCompareStrings_Click(object sender, EventArgs e)
        {
            if (tbThingOne.Text.ToLower() != tbThingTwo.Text.ToLower())
                MessageBox.Show("These are not the same things");
            else if (tbThingOne.Text.ToLower() != tbThingTwo.Text.ToLower() || tbThingTwo.Text.ToLower() == "kale")
                MessageBox.Show("These are not the same or Thing Two is a SUPERFOOD!");
            else
                MessageBox.Show("These are the same thing");
        }

        private void btnTransferNumber_Click(object sender, EventArgs e)
        {
            double tempDoubleStorage = 0.0;
            if(double.TryParse(tbNumberOne.Text, out tempDoubleStorage))
            {
                tbNumberTwo.Text = tempDoubleStorage.ToString();
                MessageBox.Show("Transfer complete!");
            }
            else
            {
                tbNumberTwo.Text = tempDoubleStorage.ToString();
                MessageBox.Show("Transfer failed and aborted!");
            }
        }

        private void btnShippingMethod_Click(object sender, EventArgs e)
        {
            if (rbUSPS.Checked)
                MessageBox.Show("United States Postal Service is selected!");
            else if (rbUPS.Checked)
                MessageBox.Show("United Parcel Service is selected!");
            else if (rbFedEx.Checked)
                MessageBox.Show("Federal Express is selected!");
            else
                MessageBox.Show("Don't be dumb. Select something first!");
        }

        private void cb40_CheckedChanged(object sender, EventArgs e)
        {
            double totalValue = 0.0;
            totalValue = add_checkboxes();
            MessageBox.Show("Total Checked: " + totalValue);
        }

        private void cb30_CheckedChanged(object sender, EventArgs e)
        {
            double totalValue = 0.0;
            totalValue = add_checkboxes();
            MessageBox.Show("Total Checked: " + totalValue);
        }

        private void cb20_CheckedChanged(object sender, EventArgs e)
        {
            double totalValue = 0.0;
            totalValue = add_checkboxes();
            MessageBox.Show("Total Checked: " + totalValue);
        }

        private void cb10_CheckedChanged(object sender, EventArgs e)
        {
            double totalValue = 0.0;
            totalValue = add_checkboxes();
            MessageBox.Show("Total Checked: " + totalValue);
        }

        private void cb00_CheckedChanged(object sender, EventArgs e)
        {
            double totalValue = 0.0;
            totalValue = add_checkboxes();
            MessageBox.Show("Total Checked: " + totalValue);
        }

        private void lbLocations_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show("You selected '" + lbLocations.SelectedItem.ToString() 
                + "' at index " + lbLocations.SelectedIndex.ToString());
        }

        /*
        private void button1_Click(object sender, EventArgs e)
        {
            int index = 0;
            int limit = int.Parse(tbCityName.Text);

            while(index < limit)
            {
                MessageBox.Show("Running " + index);
                lbLocations.Items.Add(index.ToString());
                index++;
            }
            for(int i = 0; i < limit; i++)
            {
                MessageBox.Show("Running " + i);
                lbLocations.Items.Add(i.ToString());
            }
        }
         */

        private void button1_Click(object sender, EventArgs e)
        {
            const int START_SPEED = 60;
            const int END_SPEED = 130;
            const int INTERVAL = 10;
            const double CONVERSION_FACTOR = 0.6214;

            int kph;
            double mph;

            for(kph = START_SPEED; kph <= END_SPEED; kph += INTERVAL)
            {
                mph = kph * CONVERSION_FACTOR;
                lbLocations.Items.Add(kph + " KPH is the same as " + mph + " MPH");
            }
        }
    }
}
