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
    /**
        Class for additions
        */
    public class Sum
    {
        public decimal SumAction(string leftNumb, string rightNum)
        {

            decimal arabicLeft;
            decimal arabicRight;

            if (Decimal.TryParse(leftNumb, out arabicLeft) == true && Decimal.TryParse(rightNum, out arabicRight) == true)
            {
                return arabicLeft + arabicRight;
            }

            throw new Exception("error");
        }

        /**
         * Method Sum Arabical num
             */
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

            str = str.Trim();
            if (str.Length <= 0) return false; //check of empty string

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

        }



       

        private void GetResult_Click(object sender, EventArgs e)
        {
            int firstNum;
            int secondNum;
            var sum = new Sum();

            try
            {

                //is data in form number(arabic) or text (romaian)
                if (Int32.TryParse(FirstNumber.Text, out firstNum) == false && Int32.TryParse(SecondNumber.Text, out secondNum) == false)
                {
                    //if data is text - convert romanian number on arabic
                    if (Form_Check_Letters(FirstNumber.Text) != false && Form_Check_Letters(SecondNumber.Text) != false)
                    {
                        string firstStr = FirstNumber.Text;
                        string secondStr = SecondNumber.Text;

                        firstNum = RomanNum.ToArabic(firstStr.ToUpper());
                        secondNum = RomanNum.ToArabic(secondStr.ToUpper());

                        //sum converted number and convert result (number) back to romanian and output
                        Result.Text = RomanNum.ToRoman(Convert.ToInt32(sum.SumAction(firstNum.ToString(), secondNum.ToString())));



                        if (ArabRadioBut.Checked == true)
                        {
                            Result.Text = (RomanNum.ToArabic(Result.Text)).ToString();
                        }

                    }

                    else MessageBox.Show("Форма введена неправильно");
                }

                //if data is number (arabic)
                else {

                    Result.Text = sum.SumAction(FirstNumber.Text, SecondNumber.Text).ToString();

                    if(RomRadioBut.Checked == true )
                    {
                        Result.Text = RomanNum.ToRoman(int.Parse(Result.Text));
                    }
                }





            }

            catch
            {
                Result.Text = "";
                MessageBox.Show("Форма введена неправильно");
            }
           

            


        }

        private void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
