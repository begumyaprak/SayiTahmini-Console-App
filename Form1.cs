using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SayiTahmini
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

            int finalNumber;
            RandomNumber number = new RandomNumber();
           



        public void Form1_Load(object sender, EventArgs e)
        {

             
             

             finalNumber  = number.Estimation();

            
        }

        private void btnEstimation_Click(object sender, EventArgs e)
        {

            //int? convertedNumber = Convert.ToInt32(tbxNumberInput.Text);

            //if (convertedNumber != null)
            //{


            //}
            //else
            //{

            //    MessageBox.Show("Lütfen Sayı Giriniz!!!");
            //}

            if (string.IsNullOrEmpty(tbxNumberInput.Text))
            {
                DialogResult result1 = MessageBox.Show("Lütfen boş geçmeyiniz!", "Hata", MessageBoxButtons.OK);

                if (result1 == DialogResult.OK)
                {

                    finalNumber = number.Estimation();
                }
            }
            else
            {
                if (finalNumber.ToString() == tbxNumberInput.Text)
                {
                    DialogResult result1 = MessageBox.Show("Tebrikler tutulan sayı " + finalNumber.ToString() + ".", "Tahmin Sonucu", MessageBoxButtons.OK);

                    if (result1 == DialogResult.OK)
                    {

                        finalNumber = number.Estimation();
                    }
                }
                else
                {
                    DialogResult result2 = MessageBox.Show("Tutulan sayı:" + finalNumber.ToString() + "." + "Tekrar deneyiniz!", "Tahmin Sonucu", MessageBoxButtons.RetryCancel);

                    if (result2 == DialogResult.Cancel)
                    {
                        finalNumber = number.Estimation();

                    }
                    else if (result2 == DialogResult.Retry)
                    {
                        finalNumber = number.Estimation();
                    }
                }
            }


            
        }

        private void tbxNumberInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        
    }
}
