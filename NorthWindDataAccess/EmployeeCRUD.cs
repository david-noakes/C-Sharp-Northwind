using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Data.OleDb;
using System.Data.Odbc;

namespace NorthWindDataAccess
{
    class EmployeeCRUD
    {

        SessionData sessionData;
        //SqlConnection mySqlConnection;
        OleDbConnection mySqlConnection;


        public EmployeeCRUD()
        {
            sessionData = SessionData.getInstance();
            mySqlConnection = sessionData.getConnection();
        }

        public void CreateEmployee(int dbID, String company, String lastname, String firstname,
                     String emailAddress, String jobTitle, String businessPhone, String homePhone, String mobilePhone,
                     String faxNumber, String address, String city, String stateProvince, String postCode,
                     String country, String URL, String notes, String attachments, DateTime dateStarted)
        {
            mySqlConnection.Open();
            //SqlCommand mySqlCommand = mySqlConnection.CreateCommand();
            OleDbCommand mySqlCommand = mySqlConnection.CreateCommand();

            mySqlCommand.CommandText =
                "INSERT INTO employees (" +
                "ID, Company, [Last Name], [First Name], [E-mail Address], [Job Title], " +
                "[Business Phone], [Home Phone], [Mobile Phone], [Fax Number], Address, " +
                "City, [State/Province], [ZIP/Postal Code], [Country/Region], [Web Page], " +
                "Notes, Attachments, [Start Date] " +
                ") VALUES ( " +
                " [@ID], [@Company], [@Lastname], [@Firstname], [@emailAddress], [@JobTitle], " +
                " [@BusinessPhone], [@HomePhone], [@MobilePhone], [@FaxNumber], [@address], " +
                " [@city], [@StateProvince], [@PostCode], [@country], [@URL], [@notes], [@attachments]" +
                " [@StartDate] " +
                ")";

            mySqlCommand.Parameters.Add("@ID", OleDbType.Integer, 5);
            mySqlCommand.Parameters.Add("@Company", OleDbType.VarChar, 50);
            mySqlCommand.Parameters.Add("@Lastname", OleDbType.VarChar, 50);
            mySqlCommand.Parameters.Add("@Firstname", OleDbType.VarChar, 50);
            mySqlCommand.Parameters.Add("@emailAddress", OleDbType.VarChar, 50);
            mySqlCommand.Parameters.Add("@JobTitle", OleDbType.VarChar, 50);
            mySqlCommand.Parameters.Add("@BusinessPhone", OleDbType.VarChar, 25);
            mySqlCommand.Parameters.Add("@HomePhone", OleDbType.VarChar, 25);
            mySqlCommand.Parameters.Add("@MobilePhone", OleDbType.VarChar, 25);
            mySqlCommand.Parameters.Add("@FaxNumber", OleDbType.VarChar, 25);
            mySqlCommand.Parameters.Add("@address", OleDbType.VarChar);
            mySqlCommand.Parameters.Add("@city", OleDbType.VarChar, 50);
            mySqlCommand.Parameters.Add("@StateProvince", OleDbType.VarChar, 50);
            mySqlCommand.Parameters.Add("@PostCode", OleDbType.VarChar, 15);
            mySqlCommand.Parameters.Add("@country", OleDbType.VarChar, 50);
            mySqlCommand.Parameters.Add("@URL", OleDbType.VarChar, 255);
            mySqlCommand.Parameters.Add("@notes", OleDbType.VarChar);
            mySqlCommand.Parameters.Add("@attachments", OleDbType.VarChar);
            mySqlCommand.Parameters.Add("@StartDate", OleDbType.Date);


            mySqlCommand.Parameters["@ID"].Value = dbID;
            mySqlCommand.Parameters["@Company"].Value = company;
            //mySqlCommand.Parameters["@ContactName"].IsNullable = true;
            //mySqlCommand.Parameters["@ContactName"].Value = DBNull.Value;
            mySqlCommand.Parameters["@Lastname"].Value = lastname;
            mySqlCommand.Parameters["@Firstname"].Value = firstname;
            mySqlCommand.Parameters["@emailAddress"].Value = emailAddress;
            mySqlCommand.Parameters["@JobTitle"].Value = jobTitle;
            mySqlCommand.Parameters["@BusinessPhone"].Value = businessPhone;
            mySqlCommand.Parameters["@HomePhone"].Value = homePhone;
            mySqlCommand.Parameters["@MobilePhone"].Value = mobilePhone;
            mySqlCommand.Parameters["@FaxNumber"].Value = faxNumber;
            mySqlCommand.Parameters["@address"].Value = address;
            mySqlCommand.Parameters["@city"].Value = city;
            mySqlCommand.Parameters["@StateProvince"].Value = stateProvince;
            mySqlCommand.Parameters["@PostCode"].Value = postCode;
            mySqlCommand.Parameters["@country"].Value = country;
            mySqlCommand.Parameters["@URL"].Value = URL;
            mySqlCommand.Parameters["@notes"].Value = notes;
            mySqlCommand.Parameters["@attachments"].Value = attachments;
            mySqlCommand.Parameters["@StartDate"].Value = dateStarted;

            mySqlCommand.ExecuteNonQuery();
            Console.WriteLine("Successfully added row to Employee table");

            mySqlConnection.Close();
        }

        public EmployeeDTO ReadEmployee(int dbID)
        {
            EmployeeDTO employee = new EmployeeDTO();

            mySqlConnection.Open();
            //SqlCommand mySqlCommand = mySqlConnection.CreateCommand();
            OleDbCommand mySqlCommand = mySqlConnection.CreateCommand();

            // isert read code here
            mySqlCommand.CommandText = "SELECT ID, FirstName FROM Employee WHERE ID = '" + dbID + "'";

            //SqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
            OleDbDataReader mySqlDataReader = mySqlCommand.ExecuteReader();


            while (mySqlDataReader.Read())
            {

                employee = new EmployeeDTO();
                employee.morphFromDB(mySqlDataReader);
                Console.WriteLine("mySqlDataReader[\" ID\"] = " + employee.getID() + "mySqlDataReader[\" FirstName\"] = " +
                  employee.getFirstName() + "mySqlDataReader[\" FirstName\"] = " + employee.getLastName());
            }

            mySqlDataReader.Close();

            return employee;
        }
        public void UpdateEmployee(int dbID, String company, String lastname, String firstname,
                     String emailAddress, String jobTitle, String businessPhone, String homePhone, String mobilePhone,
                     String faxNumber, String address, String city, String stateProvince, String postCode,
                     String country, String URL, String notes, String attachments)
        {

        }

        public void DeleteEmployee(int dbID)
        {

        }

        public List<EmployeeDTO> retrieveAllEmployees()
        {
            mySqlConnection.Open();
            //SqlCommand mySqlCommand = mySqlConnection.CreateCommand();
            OleDbCommand mySqlCommand = mySqlConnection.CreateCommand();

            List<EmployeeDTO> empList = new List<EmployeeDTO>();

            mySqlCommand.CommandText = "Select * from employees";
            //SqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
            OleDbDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
            EmployeeDTO newEmp;
            while (mySqlDataReader.Read())
            {
                newEmp = new EmployeeDTO();
                newEmp.morphFromDB(mySqlDataReader);
                empList.Add(newEmp);
               // Console.WriteLine("mySqlDataReader[\" ID\"] = " + newEmp.getID() + "mySqlDataReader[\" FirstName\"] = " +
               //   newEmp.getFirstName() + "mySqlDataReader[\" FirstName\"] = " + newEmp.getLastName());
            }
            return empList;
         }

    }
}
