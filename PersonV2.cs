using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Week6NoahUkura
{
    class PersonV2:Person
    {   
        private string ig;
        private string cellnum;

        public string IG
        {
            
            get
            {
                return ig;
            }
            set
            {
                
                if (ValidationLibrary.IsItFilledIn(value))
                {
                    ig = value;
                }
                else
                {
                    feedback += "\nError: Please enter the instagram URL";
                }
                if (ValidationLibrary.ValidIG(value))
                {
                    ig = value;
                }
                else
                {
                    feedback += "\nError: Please enter a valid instagram URL (ex. www.instagram.com/name)";
                }
            }
        }
        public string CellNum
        {
            get
            {
                return cellnum;
            }
            set
            {
                if (ValidationLibrary.ValidCPhone(value))
                {
                    cellnum = value;
                }
                else
                {
                    feedback += "\nError: Invalid Phone Format. Enter 10 or less numbers";
                }
                if (ValidationLibrary.IsItFilledIn(value))
                {
                    cellnum = value;
                }
                else
                {
                    feedback += "\nError: Please enter the cell phone number";
                }
            }
        }
        public PersonV2()
        {
            ig = "";
            cellnum = "";
        }
        public string AddRecord()
        {
            string stringResult = "";
            SqlConnection Conn = new SqlConnection();
            Conn.ConnectionString = @"Server=sql.neit.edu\sqlstudentserver,4500;Database=SE245_NUkura;User Id=SE245_NUkura;Password=008008083";


            string strSQL = "INSERT INTO PersonV2 (FName, MName, LName, Street1, Street2, City, State, Zip, Phone, Email) VALUES (@FName, @MName, @LName, @Street1, @Street2, @City, @State, @Zip, @Phone, @Email)";
            SqlCommand comm = new SqlCommand();
            comm.CommandText = strSQL;
            comm.Connection = Conn;
            comm.Parameters.AddWithValue("@FName", FName);
            comm.Parameters.AddWithValue("@MName", MName);
            comm.Parameters.AddWithValue("@LName", LName);
            comm.Parameters.AddWithValue("@Street1", Street1);
            comm.Parameters.AddWithValue("@Street2", Street2);
            comm.Parameters.AddWithValue("@City", City);
            comm.Parameters.AddWithValue("@State", State);
            comm.Parameters.AddWithValue("@Zip", Zip);
            comm.Parameters.AddWithValue("@Phone", Phone);
            comm.Parameters.AddWithValue("@Email", Email);
            try
            {
                Conn.Open();
                int intRecs = comm.ExecuteNonQuery();
                stringResult = "Success: Inserted {intRecs} records";
                Conn.Close();
            }
            catch(Exception err)
            {
                stringResult = "Error: " + err.Message;
            }
            finally
            {

            }
            return stringResult;
        }    
    }
}
