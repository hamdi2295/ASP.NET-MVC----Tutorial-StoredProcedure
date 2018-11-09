using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using StoredProcedure.Models;


namespace StoredProcedure.DataAccess
{
    public class Employee
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Koneksi"].ConnectionString);
        
        public void AddEmployee(Models.Employees emp)
        {
            SqlCommand com = new SqlCommand("Employee_Add", con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@FirstName", emp.FirstName);
            com.Parameters.AddWithValue("@LastName", emp.LastName);
            com.Parameters.AddWithValue("@Gender", emp.Gender);
            com.Parameters.AddWithValue("@Address", emp.Address);
            com.Parameters.AddWithValue("@PhoneNumber", emp.PhoneNumber);
            con.Open();
            com.ExecuteNonQuery();
            con.Close();
        }

        public void UpdateEmployee(Models.Employees emp)
        {
            SqlCommand com = new SqlCommand("Employee_Update", con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@Id", emp.Id);
            com.Parameters.AddWithValue("@FirstName", emp.FirstName);
            com.Parameters.AddWithValue("@LastName", emp.LastName);
            com.Parameters.AddWithValue("@Gender", emp.Gender);
            com.Parameters.AddWithValue("@Address", emp.Address);
            com.Parameters.AddWithValue("@PhoneNumber", emp.PhoneNumber);
            con.Open();
            com.ExecuteNonQuery();
            con.Close();
        }

        public DataSet GetById(int id)
        {
            SqlCommand com = new SqlCommand("Employee_Id", con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@Id", id);
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }


        public DataSet GetAll()
        {
            SqlCommand com = new SqlCommand("Employee_All", con);
            com.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }

        public void DeleteEmployee(int id)
        {
            SqlCommand com = new SqlCommand("Employee_Delete", con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@Id", id);
            con.Open();
            com.ExecuteNonQuery();
            con.Close();
        }

    }
}