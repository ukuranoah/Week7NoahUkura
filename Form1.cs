using lab4;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Week5NoahUkura

{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Person temp = new Person();
            temp.Feedback = "";
            temp.FName = txtFName.Text;
            temp.LName = txtLName.Text;
            //temp.Feedback = lblFeedback.Text;
            lblFeedback.Text = "Person Added: " + temp.FName + " " + temp.LName;

            if (temp.Feedback.Contains("ERROR:"))
            {
                lblFeedback.Text = temp.Feedback;
            }
            else
            {
                lblFeedback.Text = temp.FName + " you've entered an invalid email.";
            }

        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblFeedback_Click(object sender, EventArgs e)
        {

        }
        
    }
}
