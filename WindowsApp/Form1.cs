using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace WindowsApp
{
    public partial class Form1 : Form
    {
        public Form1()
            ///hi
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int day = 1; day <= 31; day++)
                comboBox2.Items.Add(day);

            for (int month = 1; month <= 12; month++)
                comboBox3.Items.Add(month);

            for (int year = 1900; year <= 2026; year++)
                comboBox1.Items.Add(year);

            ArrayList programs = new ArrayList();

            programs.Add("Bachelor of Science in Computer Science");
            programs.Add("Bachelor of Science in Information Technology");
            programs.Add("Bachelor of Science in Information Systems");
            programs.Add("Bachelor of Science in Computer EngineeringSs");
            
            foreach (string program in programs) 
            {
                comboBox4.Items.Add(program);
            }
        }
             

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string lastName = textBox3.Text;
            string firstName = textBox2.Text;
            string middleName = maskedTextBox1.Text;
            string gender = radioButton1.Checked ? "Male" : "Female";

            if (comboBox2.SelectedItem != null && comboBox3.SelectedItem != null && comboBox1.SelectedItem != null && 
                comboBox4.SelectedItem != null)
            {

                string day = comboBox2.SelectedItem.ToString() ?? "Not Selected";
                string month = comboBox3.SelectedItem.ToString() ?? "Not Selected";
                string year = comboBox1.SelectedItem.ToString() ?? "Not Selected";
                string program = comboBox4.SelectedItem.ToString() ?? "Not Selected";

                string students = ($"StudentName: {lastName}  { firstName}  { middleName} \n" +
                                 $"Gender:   {gender} \n" +
                                 $"BirthDate: {day}  {month} {year} \n" +
                                 $"Program:  {program} \n" );

                MessageBox.Show(students);
            }


        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
