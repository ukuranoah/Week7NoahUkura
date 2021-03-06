﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace Week6NoahUkura
{
    class PersonV2:Person
    {   
        private string ig;
        private string cellnum;
        public int PersonID;
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


            string strSQL = "INSERT INTO PersonssV2 (FName, MName, LName, Street1, Street2, City, State, Zip, Phone, Email) VALUES (@FName, @MName, @LName, @Street1, @Street2, @City, @State, @Zip, @Phone, @Email)";
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
                stringResult = $"Success: Inserted {intRecs} records";
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
        public string UpdateARecord()
        {
            int intRecords = 0;
            string stringResult = "";
            string strSQL = "UPDATE PersonssV2 SET FName = @FName, MName = @MName, LName = @LName, Street1 = @Street1, Street2 = @Street2, City = @City, State = @State, Zip = @Zip, Phone = @Phone, Email = @Email WHERE PersonID = @PersonID;";
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Server=sql.neit.edu\sqlstudentserver,4500;Database=SE245_NUkura;User Id=SE245_NUkura;Password=008008083";


            
            SqlCommand comm = new SqlCommand();
            comm.CommandText = strSQL;
            comm.Connection = conn;
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
            comm.Parameters.AddWithValue("@PersonID", PersonID);
            try
            {
                conn.Open();
                intRecords = comm.ExecuteNonQuery();
                stringResult = intRecords.ToString() + " Records Updated";
                
            }
            catch (Exception err)
            {
                stringResult = "Error: " + err.Message;
            }
            finally
            {
                conn.Close();
            }
            return stringResult;
        }
        public DataSet SearchARecord(String strFName, String strLName)
        {
            DataSet ds = new DataSet();
            SqlCommand comm = new SqlCommand();
            String strSQL = "SELECT PersonID, FName, LName FROM PersonssV2 WHERE 0=0";
            if (strFName.Length > 0)
            {
                strSQL += " AND FName LIKE @FName";
                comm.Parameters.AddWithValue("@FName", "%" + strFName + "%");
            }
            if (strLName.Length > 0)
            {
                strSQL += " AND LName LIKE @LNAME";
                comm.Parameters.AddWithValue("@LName", "%" + strLName + "%");
            }

            SqlConnection conn = new SqlConnection();
            string strConn = @"Server=sql.neit.edu\sqlstudentserver,4500;Database=SE245_NUkura;User Id=SE245_NUkura;Password=008008083";
            conn.ConnectionString = strConn;
            comm.Connection = conn;
            comm.CommandText = strSQL;
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = comm;

            conn.Open();
            da.Fill(ds, "PersonV2_Temp");
            conn.Close();

            return ds;

        }
        public SqlDataReader FindOneRecord(int intPersonV2_ID)
        {
            SqlConnection conn = new SqlConnection();
            SqlCommand comm = new SqlCommand();
            string strConn = @"Server=sql.neit.edu\sqlstudentserver,4500;Database=SE245_NUkura;User Id=SE245_NUkura;Password=008008083";
            string sqlstring = "SELECT * FROM PersonssV2 WHERE PersonID = @PersonV2_ID;";
            conn.ConnectionString = strConn;
            comm.Connection = conn;
            comm.CommandText = sqlstring;
            comm.Parameters.AddWithValue("@PersonV2_ID", intPersonV2_ID);
            conn.Open();
            return comm.ExecuteReader();

        }
        public string DeleteOneRecord(int intPersonV2_ID)
        {
            Int32 intRecords = 0;
            string strResult = "";
            SqlConnection conn = new SqlConnection();
            SqlCommand comm = new SqlCommand();
            string sqlString = "DELETE FROM PersonssV2 WHERE PersonID = @PersonID;";
            conn.ConnectionString = @"Server=sql.neit.edu\sqlstudentserver,4500;Database=SE245_NUkura;User Id=SE245_NUkura;Password=008008083";
            comm.Connection = conn;
            comm.CommandText = sqlString;
            comm.Parameters.AddWithValue("@PersonID", intPersonV2_ID);
            try
            {
                conn.Open();
                intRecords = comm.ExecuteNonQuery();
                strResult = intRecords.ToString() + " Records Deleted";
            }
            catch(Exception err)
            {
                strResult = "Error:" + err.Message;
            }
            finally
            {
                conn.Close();
            }
            return strResult;
        }
    }
}
