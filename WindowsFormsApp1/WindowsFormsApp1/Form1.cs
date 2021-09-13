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

    public class Sum
    {
        public string SumAction(string leftNumb, string rightNum)
        {

            int arabicLeft;
            int arabicRight;

            if (Int32.TryParse(leftNumb, out arabicLeft ) == true && Int32.TryParse(rightNum, out arabicRight) == true )
            {
                return (arabicLeft + arabicRight).ToString();
            }

            return null;
        }


        private int SumArabic(int leftNum, int rightNum)
        {
            return leftNum + rightNum;
        }
    }


    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
