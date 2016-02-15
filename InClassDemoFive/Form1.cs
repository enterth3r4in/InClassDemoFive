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
                MessageBox.Show("Transfer failed and aborted!");
            }
        }
    }
}
