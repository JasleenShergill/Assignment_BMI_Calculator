using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*Name: Jasleen
 Student Number: 300929376
 Date : 13 August 
 Time: 3:01 pm
 Description:  creating splash form class for BMI calculator
 version :0.5 - Removed progress bar for timer*/

namespace Assignment_BMI_Calculator
{
    public partial class SplashForm : Form
    {
        public SplashForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// event handler for the "tick" event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
       private void SplashFormTimer_Tick(object sender, EventArgs e)
        {
            BmiCalculator bmiCalculator = new BmiCalculator();
            bmiCalculator.Show();
            this.Hide();
            SplashFormTimer.Enabled = false;//it is used to turn timer off

            //progressBar1.Increment(1);

            //  progressBar1.Minimum = 0;
            //  progressBar1.Maximum = 200;
            //
            //  for (i = 0; i <= 200; i++)
            //  {
            //      progressBar1.Value = i;
            //  }
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
            //progressBar1.Increment(100);
        }

        private void SplashForm_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

       
    }
}
