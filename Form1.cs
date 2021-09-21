using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace part_4_random_numbers
{
    public partial class Form1 : Form
    {
        Random generator = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnInt_Click(object sender, EventArgs e)
        {
            int randomInt;
            int minValue = Convert.ToInt32(txtMinValue.Text);
            int maxValue = Convert.ToInt32(txtMaxValue.Text);
            randomInt = generator.Next(minValue, maxValue);
            lblOutput.Text = randomInt + "";
            
        }

        private void dblBtn_Click(object sender, EventArgs e)
        {
            double randomDbl;
            int randomInt;
            int minValue = Convert.ToInt32(txtMinValue.Text);
            int maxValue = Convert.ToInt32(txtMaxValue.Text);
            randomInt = generator.Next(minValue, maxValue);
            randomDbl = generator.NextDouble();
            lblOutput.Text = (randomDbl + randomInt) + "";
        }
    }
}
