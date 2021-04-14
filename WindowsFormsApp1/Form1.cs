/* Assignment:          HW3 - Program 6
 * Developed by:        Christopher Karnas
 * Date Created:        September, 2020
 * Date Last Modified:  10.8.20
 * Class Name:          Form Class
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBMI_Click(object sender, EventArgs e)
        {
            //declare local (method level) variables 

            string strName;
            int intWeight, intHeight;
            double dblBMIResults;
            
            BMI aBMI;

            // assign input data to variables

            strName = txtbxName.Text;

            intWeight = Convert.ToInt32(nudWeight.Value);
            intHeight = Convert.ToInt32(nudHeight.Value);

            // instantiate a BMI object

            aBMI = new BMI(strName, intWeight, intHeight);

            //call the BMI method

            dblBMIResults = aBMI.CalculateBMI();

            //display the BMI

            lblBMIResults.Text = dblBMIResults.ToString("N2");

            //disable controls

            btnBMI.Enabled = false;

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            // reset the form values 

            txtbxName.Clear();
            nudWeight.Value = 0;
            nudHeight.Value = 0;
            lblBMIResults.Text = null;

            // enable control

            btnBMI.Enabled = true;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // exit the form

            this.Close();
        }
    }
}
