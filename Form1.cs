using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Week6NoahUkura

{

    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        public Form1(int intPersonV2_ID)
        {
            InitializeComponent();
            PersonV2 temp = new PersonV2();
            SqlDataReader dr = temp.FindOneRecord(intPersonV2_ID);
            while (dr.Read())
            {
                txtFName.Text = dr["FName"].ToString();
                txtMName.Text = dr["MName"].ToString();
                txtLName.Text = dr["LName"].ToString();
                txtStreet1.Text = dr["Street1"].ToString();
                txtStreet2.Text = dr["Street2"].ToString();
                txtCity.Text = dr["City"].ToString();
                txtState.Text = dr["State"].ToString();
                txtZip.Text = dr["Zip"].ToString();
                txtPhone.Text = dr["Phone"].ToString();
                txtEmail.Text = dr["Email"].ToString();
                lblPersonV2_ID.Text = dr["PersonID"].ToString();


            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Customers temp = new Customers();

            temp.FName = txtFName.Text;
            temp.MName = txtMName.Text;
            temp.LName = txtLName.Text;
            temp.Street1 = txtStreet1.Text;
            temp.Street2 = txtStreet2.Text;
            temp.City = txtCity.Text;
            temp.State = txtState.Text;
            temp.Zip = txtZip.Text;
            temp.Phone = txtPhone.Text;
            temp.Email = txtEmail.Text;
            temp.CellNum = txtCell.Text;
            temp.IG = txtIG.Text;
            temp.CustomerSince = dateTimePicker1.Value;

            double dblTotalPurchases;
            bool blnResult1 = Double.TryParse(txtPurchases.Text, out dblTotalPurchases);
            if (blnResult1 == false)
            {
                lblFeedback.Text += "\nError: Please enter a valid amount for total purchased";
            }
            else
            {
                temp.TotalPurchases = dblTotalPurchases;
            }
            bool blnMember;
            bool blnResult2 = Boolean.TryParse(txtPurchases.Text, out blnMember);
            if (blnResult2 == false)
            {
                lblFeedback.Text += "\nError: Please enter true or false if you are a member or not";
            }
            else
            {
                temp.DiscountMember = blnMember;
            }

            int intRewards;
            bool blnResult3 = Int32.TryParse(txtRewards.Text, out intRewards);
            if (blnResult3 == false)
            {
                lblFeedback.Text += "\nError: Please enter a valid amount you received in rewards";
            }


            //temp.RewardsEarned = txtRewards.Text;



            if (temp.Feedback.Contains("Error:"))
            {
                lblFeedback.Text = temp.Feedback;

            }
            else
            {
                lblFeedback.Text = "Person Added: " + temp.FName + " " + temp.MName + " " + temp.LName + "\n" + temp.Street1 + ", " + temp.Street2 + "\n" + temp.City + " " + temp.State + " " + temp.Zip + "\n" + temp.Email + " " + temp.Phone + "\n" + temp.IG + "\n" + temp.CellNum;
                lblFeedback.Text = temp.AddRecord();
            }
        }

       
    }
}
