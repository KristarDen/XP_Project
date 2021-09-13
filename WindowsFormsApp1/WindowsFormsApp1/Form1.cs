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

<<<<<<< HEAD
        private void Form1_Load(object sender, EventArgs e)
        {

=======
        private void FirstNumber_TextChanged(object sender, EventArgs e)
        {
            if (Form_Check_Letters(FirstNumber.Text) == false)
            {
                MessageBox.Show("Форма введена неправильно");
            }
        }

        private void SecondNumber_TextChanged(object sender, EventArgs e)
        {
            if (Form_Check_Letters(SecondNumber.Text) == false)
            {
                MessageBox.Show("Форма введена неправильно");
            }
        }

        private bool Form_Check_Letters(string str)//checking for wrong symbols
        {
            const string allowed_characters = "ivxlcdm"; 


            if (str.Trim().Length <= 0) return false; //check of empty string

            else
            {
                str = str.ToLower();

                //Check every sybols on right
                foreach (var item in str)
                {
                    //if the character is not in the list
                    if (allowed_characters.Contains(item) == false) return false;
                }
            }

            return true;
>>>>>>> 12ee7cac895a279141d8d62872560dd72ca058ae
        }
    }
}
