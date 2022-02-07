using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace logical_operators
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Int32 age;
            Int32.TryParse(this.cu_age_textBox2.Text, out age);

            if ((this.cu_namre_textBox1.Text=="bob") &&(age>20)&&(age<50))
            {
                MessageBox.Show("You win!");
            }
            else
            {
                MessageBox.Show("You Lost!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {


            if ((this.name_textBox2.Text=="bob")||(this.name_textBox2.Text=="boby") ||(this.name_textBox2.Text == "bobi"))
            {
                MessageBox.Show("You win!");
            }
            else
            {
                MessageBox.Show("You Lost!");
            }
        }
    }
}
