using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            textBox4.Enabled = false;
            dateTimePicker2.Enabled = false;

            category.Items.Add("Database Systems");
            category.Items.Add("OOP");
            category.Items.Add("Artificial Intelligence");

            category.SelectedIndex = 0;
        }

        private void label4_Click(object sender, EventArgs e)
        {
        }


        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.ToString();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (category.SelectedIndex == 0)
            {
                subcategory.Items.Clear();
                subcategory.Items.Add("ERD");
                subcategory.Items.Add("SQL");
                subcategory.Items.Add("OLAP");
                subcategory.Items.Add("Data Mining");
            }
            else if (category.SelectedIndex == 1)
            {
                subcategory.Items.Clear();
                subcategory.Items.Add("C++");
                subcategory.Items.Add("Java");
            }
            else
            {
                subcategory.Items.Clear();
                subcategory.Items.Add("Machine Learning");
                subcategory.Items.Add("Robotics");
                subcategory.Items.Add("Computer vision");
            }
        }

        private void subcategory_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void add_Click(object sender, EventArgs e)
        {
            authorBox.Items.Add(authorName.Text);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
        }   

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            textBox4.Enabled = false;
            dateTimePicker2.Enabled = false;

            if (checkBox1.Checked == true)
            {
                dateTimePicker2.Enabled = true;
                textBox4.Enabled = true;
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 12 || dateTimePicker1.Value > DateTime.Now)
            {
                MessageBox.Show("The length of ISBN is greater than 12 or Purchased On Date is greater than today!", "confirmation", MessageBoxButtons.OK);

            }
            else if (radioButton3.Checked == true && authorBox.Items.Count > 0)
            {
                MessageBox.Show("Book of Journal Type should have no authors.", "confirmation", MessageBoxButtons.OK);
            }

            else if (radioButton3.Checked == false && authorBox.Items.Count == 0)
            {
                MessageBox.Show("Reference and Textbook should have atleast one author", "confirmation", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Book added successfully", "confirmation", MessageBoxButtons.OK);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
