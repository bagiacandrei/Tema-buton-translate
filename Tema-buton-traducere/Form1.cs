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
            int anInteger;
            anInteger = int.Parse(textBox1.Text);
            if (checkBox1.Checked)
                MessageBox.Show(anInteger.ToWords(new CultureInfo("fr")));
            if (checkBox2.Checked)
                MessageBox.Show(anInteger.ToWords(new CultureInfo("ru")));
            if (checkBox3.Checked)
                MessageBox.Show(anInteger.ToWords(new CultureInfo("de")));
                
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {          
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }  
    }
}
