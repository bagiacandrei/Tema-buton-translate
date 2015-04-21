using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Humanizer;
using System.Globalization;
namespace Tema_buton_traducere
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal myDec;
            var Result = decimal.TryParse(textBox1.Text, out myDec);
            if (!Result)
                MessageBox.Show("You did't enter a number!");
            else
            {
                int anInteger;
                anInteger = int.Parse(textBox1.Text);
                int numberChecked = 0;
                CheckBox[] array = new CheckBox[] { checkBoxFrench,checkBoxGerman,checkBoxRussian };
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i].Checked)
                        numberChecked++;
                }

                if (numberChecked > 1)
                    MessageBox.Show("You have chosen " + numberChecked.ToString() + " languages. Please select just one!");
                else
                {
                    if (checkBoxFrench.Checked)
                        MessageBox.Show(anInteger.ToWords(new CultureInfo("fr")));
                    else
                        if (checkBoxRussian.Checked)
                            MessageBox.Show(anInteger.ToWords(new CultureInfo("ru")));
                        else
                            if (checkBoxGerman.Checked)
                                MessageBox.Show(anInteger.ToWords(new CultureInfo("de")));
                            else
                                MessageBox.Show("Please select a language!");
                }  
            }
                
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {          
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }  
    }
}
