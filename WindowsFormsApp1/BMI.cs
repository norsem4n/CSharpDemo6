/* Assignment HW3 - Program 6
 * Developed by Christopher Karnas
 * Date Created: September, 2020
 * Date Last Modified: 10.8.20
 * Class Name: BMI (Body Mass Index)
 * Class Purpose: Calculate the BMI of an individual
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class BMI
    {
        #region "Variables/Fields"

        // instance variables

        private string strName;
        private int intWeight, intHeight;

        #endregion

        #region "Properties"

        // public get/set accessors

        public string StrName { get { return strName; } set { strName = value; } }

        public int IntWeight { get { return intWeight; } set { intWeight = value; } }

        public int IntHeight { get { return intHeight; } set { intHeight = value; } }

        #endregion

        #region "Constructor"

        public BMI(string strName, int intWeight, int intHeight)
        {
            StrName = strName;
            IntWeight = intWeight;
            IntHeight = intHeight;
        }
        #endregion

        #region "Methods"

        // Instance method to calculate and return the user's BMI

        public double CalculateBMI()
        {
            // Declare any constants and variables

            double doubleBMI;

            // Calculate and return User BMI using the properties
            // Equation = User weight * 703 / height^2

            doubleBMI = (IntWeight * 703) / Math.Pow(IntHeight, 2);
            return doubleBMI;
        }

        #endregion
    }
}
