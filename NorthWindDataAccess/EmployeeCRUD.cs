using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace NorthWindDataAccess
{
    class EmployeeCRUD
    {


        SqlConnection mySqlConnection = new SqlConnection("server=localhost;database=NorthwindEx");

        public void CreateEmployee(int dbID, String company, String lastname, String firstname,
                     String emailAddress, String jobTitle, String businessPhone, String homePhone, String mobilePhone,
                     String faxNumber, String address, String city, String stateProvince, String postCode,
                     String country, String URL, String notes, String attachments)
        {
            mySqlConnection.Open();
            SqlCommand mySqlCommand = mySqlConnection.CreateCommand();

            mySqlCommand.CommandText =
                "INSERT INTO employees (" +
                "ID, Company, [Last Name], [First Name], [E-mail Address], [Job Title], " +
                "[Business Phone], [Home Phone], [Mobile Phone], [Fax Number], Address, " +
                "City, [State/Province], [ZIP/Postal Code], [Country/Region], [Web Page], " +
                "Notes, Attachments " +
                ") VALUES ( " +
                " [@ID], [@Company], [@Lastname], [@Firstname], [@emailAddress], [@JobTitle], " +
                " [@BusinessPhone], [@HomePhone], [@MobilePhone], [@FaxNumber], [@address], " +
                " [@city], [@StateProvince], [@PostCode], [@country], [@URL], [@notes], [@attachments]" +
                ")";
            mySqlCommand.Parameters.Add("@ID", SqlDbType.Int, 5);
            mySqlCommand.Parameters.Add("@Company", SqlDbType.NVarChar, 50);
            mySqlCommand.Parameters.Add("@Lastname", SqlDbType.NVarChar, 50);
            mySqlCommand.Parameters.Add("@Firstname", SqlDbType.NVarChar, 50);
            mySqlCommand.Parameters.Add("@emailAddress", SqlDbType.NVarChar, 50);
            mySqlCommand.Parameters.Add("@JobTitle", SqlDbType.NVarChar, 50);
            mySqlCommand.Parameters.Add("@BusinessPhone", SqlDbType.NVarChar, 25);
            mySqlCommand.Parameters.Add("@HomePhone", SqlDbType.NVarChar, 25);
            mySqlCommand.Parameters.Add("@MobilePhone", SqlDbType.NVarChar, 25);
            mySqlCommand.Parameters.Add("@FaxNumber", SqlDbType.NVarChar, 25);
            mySqlCommand.Parameters.Add("@address", SqlDbType.NText);
            mySqlCommand.Parameters.Add("@city", SqlDbType.NVarChar, 50);
            mySqlCommand.Parameters.Add("@StateProvince", SqlDbType.NVarChar, 50);
            mySqlCommand.Parameters.Add("@PostCode", SqlDbType.NVarChar, 15);
            mySqlCommand.Parameters.Add("@country", SqlDbType.NVarChar, 50);
            mySqlCommand.Parameters.Add("@URL", SqlDbType.NVarChar, 255);
            mySqlCommand.Parameters.Add("@notes", SqlDbType.NText);
            mySqlCommand.Parameters.Add("@attachments", SqlDbType.NText);


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

            mySqlCommand.ExecuteNonQuery();
            Console.WriteLine("Successfully added row to Customers table");

            mySqlConnection.Close();
        }

        public EmployeeDataSet ReadEmployee(int dbID)
        {
            EmployeeDataSet theEmployee;

            mySqlConnection.Open();
            SqlCommand mySqlCommand = mySqlConnection.CreateCommand();
            // isert read code here
            mySqlCommand.CommandText = "SELECT ID, FirstName FROM Employee WHERE ID = '" + dbID + "'";

            SqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();

            while (mySqlDataReader.Read())
            {
                Console.WriteLine("mySqlDataReader[\" ID\"] = " +
                  mySqlDataReader["ID"]);
                Console.WriteLine("mySqlDataReader[\" FirstName\"] = " +
                  mySqlDataReader["FirstName"]);
            }

            mySqlDataReader.Close();

            return theEmployee.Employees.All;
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

        public List<EmployeeDataSet> retrieveAllEmployees(){
            mySqlConnection.Open();
            SqlCommand mySqlCommand = mySqlConnection.CreateCommand();

            mySqlCommand.CommandText = "Select * from employees";
            SqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
            EmployeeDataSet newEmp;
            while (mySqlDataReader.Read())
            {
                newEmp = new EmployeeDataSet();
                for (int i = 0; i < mySqlDataReader.FieldCount; i++)
                { // get field name

                }

            }

         }

    }
}
