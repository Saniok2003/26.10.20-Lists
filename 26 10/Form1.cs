using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _26_10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Add(textBox3.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            comboBox2.Items.Add(textBox4.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            comboBox3.Items.Add(textBox5.Text);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            comboBox4.Items.Add(new Employee() { Surname = textBox1.Text, Salary = Convert.ToDouble(textBox2.Text), Position = comboBox1.Text, City = comboBox2.Text, Street = comboBox3.Text });
        }

        private void button5_Click(object sender, EventArgs e)
        {
            checkedListBox1.Items.Add(comboBox4.Text);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            while (checkedListBox1.CheckedItems.Count > 0)
            {
                checkedListBox1.Items.Remove(checkedListBox1.CheckedItems[0]);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (checkedListBox1.CheckedItems.Count != 1)
            {
                MessageBox.Show("Будьласка виберіть одного робітника","Ворнінг");
            }
            else
            {
                textBox3.Visible = false;
                textBox4.Visible = false;
                textBox5.Visible = false;
            }
        }
    }
}
