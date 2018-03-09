using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;

namespace EmployeeDirectory
{
    public class EmployeeDirectory
    {
        #region Declarations
        public string name { get; set; }
        public string lname { get; set; }
        public string fname { get; set; }
        public Guid guid { get; set; }
        public string email { get; set; }
        public string officeloc { get; set; }
        public string phonenum { get; set; }
        public string jobtitle { get; set; }
        #endregion

        #region Methods
        public List<EmployeeDirectory> GetEmployeesView(string lastname)
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ed"].ConnectionString);
            SqlCommand cmd = new SqlCommand("spEmployeeDirectoryViewDetail", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter parameterLName = new SqlParameter("@LName", SqlDbType.VarChar, 50);
            parameterLName.Value = lastname;
            cmd.Parameters.Add(parameterLName);
            List<EmployeeDirectory> employees = new List<EmployeeDirectory>();
            try
            {
                conn.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    EmployeeDirectory ed = new EmployeeDirectory();
                    ed.name = rdr["Name"].ToString();
                    ed.guid = new Guid(rdr["Guid"].ToString());
                    employees.Add(ed);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
            finally
            {
                cmd.Dispose();
                conn.Close();
            }
            return employees;

        }

        public void GetEmployeesViewGuid(Guid guid)
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ed"].ConnectionString);
            SqlCommand cmd = new SqlCommand("spEmployeeDirectoryViewGuid", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter parameterGuid = new SqlParameter("@Guid", SqlDbType.UniqueIdentifier, 37);
            parameterGuid.Value = guid;
            cmd.Parameters.Add(parameterGuid);
            try
            {
                conn.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                if (rdr.Read())
                {
                    lname = rdr["LName"].ToString();
                    fname = rdr["FName"].ToString();
                    email = rdr["Email"].ToString();
                    officeloc = rdr["OfficeLoc"].ToString();
                    jobtitle = rdr["JobTitle"].ToString();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
            finally
            {
                cmd.Dispose();
                conn.Close();
            }
            #endregion
        }

        }
}