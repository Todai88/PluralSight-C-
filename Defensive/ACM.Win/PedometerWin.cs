using ACM.BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ACM.Win
{
    public partial class PedometerWin : Form
    {
        public PedometerWin()
        {
            InitializeComponent();
        }

        private void txt_StepGoalToday_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txt_StepsToday_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Calculate_Click(object sender, EventArgs e)
        {
            var customer = new Customer();
            try
            {
                var result = customer.CalculatePercentOfGoalSteps(this.txt_StepGoalToday.Text,
                                                                this.txt_StepsToday.Text);

                lbl_TodayStepResult.Text = $"You reached {result}% of your daily goal.";
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show("Your entry was not valid: " + ex.Message);
                lbl_TodayStepResult.Text = String.Empty;
            }
            

            
        }
    }
}
