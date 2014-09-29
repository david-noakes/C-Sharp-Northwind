using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Data;
//using System.Data.SqlClient;
using System.Data.OleDb;



namespace NorthWindDataAccess
{
    class EmployeeDTO
    {
        // Northwind Employee Table
        private int ID;
        private String Company;
        private String LastName;
        private String FirstName;
        private String EmailAddress;
        private String JobTitle;
        private String BusinessPhone;
        private String HomePhone;
        private String MobilePhone;
        private String FaxNumber;
        private String Address;
        private String City;
        private String StateProvince;
        private String PostalCode;
        private String CountryRegion;
        private String WebPage;
        private String Notes;
        private String Attachments;
        private DateTime StartDate;


        // Attribute names
        private static String ID_name = "ID";
        private static String Company_name = "Company";
        private static String LastName_name = "LastName";
        private static String FirstName_name = "FirstName";
        private static String EmailAddress_name = "EmailAddress";
        private static String JobTitle_name = "JobTitle";
        private static String BusinessPhone_name = "BusinessPhone";
        private static String HomePhone_name = "HomePhone";
        private static String MobilePhone_name = "MobilePhone";
        private static String FaxNumber_name = "FaxNumber";
        private static String Address_name = "Address";
        private static String City_name = "City";
        private static String StateProvince_name = "StateProvince";
        private static String PostalCode_name = "PostalCode";
        private static String CountryRegion_name = "CountryRegion";
        private static String WebPage_name = "WebPage";
        private static String Notes_name = "Notes";
        private static String Attachments_name = "Attachments";
        private static String StartDate_name = "StartDate";

        private static String SET_PREFIX = "set";

        // Database field names


        // mappings

        private static Hashtable fieldList = new Hashtable();
        private static Hashtable fieldSetters = new Hashtable();

        //Constructors
        public EmployeeDTO()
            : base()
        {
            ID = 0;
            Company = "";
            LastName = "";
            FirstName = "";
            EmailAddress = "";
            JobTitle = "";
            BusinessPhone = "";
            HomePhone = "";
            MobilePhone = "";
            FaxNumber = "";
            Address = "";
            City = "";
            StateProvince = "";
            PostalCode = "";
            CountryRegion = "";
            WebPage = "";
            Notes = "";
            Attachments = "";
            if (fieldList.Count == 0)
            {
                fieldList.Add(ID_name, "ID");
                fieldList.Add(Company_name, "Company");
                fieldList.Add(LastName_name, "Last Name");
                fieldList.Add(FirstName_name, "First Name");
                fieldList.Add(EmailAddress_name, "E-mail Address");
                fieldList.Add(JobTitle_name, "Job Title");
                fieldList.Add(BusinessPhone_name, "Business Phone");
                fieldList.Add(HomePhone_name, "Home Phone");
                fieldList.Add(MobilePhone_name, "Mobile Phone");
                fieldList.Add(FaxNumber_name, "Fax Number");
                fieldList.Add(Address_name, "Address");
                fieldList.Add(City_name, "City");
                fieldList.Add(StateProvince_name, "State/Province");
                fieldList.Add(PostalCode_name, "ZIP/Postal Code");
                fieldList.Add(CountryRegion_name, "Country/Region");
                fieldList.Add(WebPage_name, "Web Page");
                fieldList.Add(Notes_name, "Notes");
                fieldList.Add(Attachments_name, "Attachments");
                fieldList.Add(StartDate_name, "Start Date");
            }
        }

        /* 
         * 
         * 
         */
        public void morphFromDB(OleDbDataReader result)
        {
            String dbFieldName;
            dbFieldName = (String)fieldList[ID_name];
            ID = (int)result[dbFieldName];
            dbFieldName = (String)fieldList[Company_name];
            setCompany(result[dbFieldName]);
            dbFieldName = (String)fieldList[LastName_name];
            setLastName(result[dbFieldName]);
            dbFieldName = (String)fieldList[FirstName_name];
            setFirstName(result[dbFieldName]);
            dbFieldName = (String)fieldList[EmailAddress_name];
            setEmailAddress(result[dbFieldName]);
            dbFieldName = (String)fieldList[JobTitle_name];
            setJobTitle(result[dbFieldName]);
            dbFieldName = (String)fieldList[BusinessPhone_name];
            setBusinessPhone(result[dbFieldName]);
            dbFieldName = (String)fieldList[HomePhone_name];
            setHomePhone(result[dbFieldName]);
            dbFieldName = (String)fieldList[MobilePhone_name];
            setMobilePhone(result[dbFieldName]);
            dbFieldName = (String)fieldList[FaxNumber_name];
            setFaxNumber(result[dbFieldName]);
            dbFieldName = (String)fieldList[Address_name];
            setAddress(result[dbFieldName]);
            dbFieldName = (String)fieldList[City_name];
            setCity(result[dbFieldName]);
            dbFieldName = (String)fieldList[StateProvince_name];
            setStateProvince(result[dbFieldName]);
            dbFieldName = (String)fieldList[PostalCode_name];
            setPostalCode(result[dbFieldName]);
            dbFieldName = (String)fieldList[CountryRegion_name];
            setCountryRegion(result[dbFieldName]);
            dbFieldName = (String)fieldList[WebPage_name];
            setWebPage(result[dbFieldName]);
            dbFieldName = (String)fieldList[Notes_name];
            setNotes(result[dbFieldName]);
            dbFieldName = (String)fieldList[Attachments_name];
            setAttachments(result[dbFieldName]);
            dbFieldName = (String)fieldList[StartDate_name];
            setStartDate(result[dbFieldName]);
        }



        // Setters and Getters
        public int getID()
        {
            return ID;
        }
        public void setID(int iD)
        {
            ID = iD;
        }
        public String getCompany()
        {
            return Company;
        }
        public void setCompany(Object company)
        {
            if (company != null && company != DBNull.Value)
            {
                Company = (String)company;
            }
            else
            {
                Company = "";
            }
        }
        public String getLastName()
        {
            return LastName;
        }
        public void setLastName(Object lastName)
        {
            if (lastName != null && lastName != DBNull.Value)
            {
                LastName = (String)lastName;
            }
            else
            {
                LastName = "";
            }
        }
        public String getFirstName()
        {
            return FirstName;
        }
        public void setFirstName(Object firstName)
        {
            if (firstName != null && firstName != DBNull.Value)
            {
                FirstName = (String)firstName;
            }
            else
            {
                FirstName = "";
            }
        }
        public String getEmailAddress()
        {
            return EmailAddress;
        }
        public void setEmailAddress(Object emailAddress)
        {
            if (emailAddress != null && emailAddress != DBNull.Value)
            {
                EmailAddress = (String)emailAddress;
            }
            else
            {
                EmailAddress = "";
            }
        }
        public String getJobTitle()
        {
            return JobTitle;
        }
        public void setJobTitle(Object jobTitle)
        {
            if (jobTitle != null && jobTitle != DBNull.Value)
            {
                JobTitle = (String)jobTitle;
            }
            else
            {
                JobTitle = "";
            }
        }
        public String getBusinessPhone()
        {
            return BusinessPhone;
        }
        public void setBusinessPhone(Object businessPhone)
        {
            if (businessPhone != null && businessPhone != DBNull.Value)
            {
                BusinessPhone = (String)businessPhone;
            }
            else
            {
                BusinessPhone = "";
            }
        }
        public String getHomePhone()
        {
            return HomePhone;
        }
        public void setHomePhone(Object homePhone)
        {
            if (homePhone != null && homePhone != DBNull.Value)
            {
                HomePhone = (String)homePhone;
            }
            else
            {
                HomePhone = "";
            }
        }
        public String getMobilePhone()
        {
            return MobilePhone;
        }
        public void setMobilePhone(Object mobilePhone)
        {
            if (mobilePhone != null && mobilePhone != DBNull.Value)
            {
                MobilePhone = (String)mobilePhone;
            }
            else
            {
                MobilePhone = "";
            }
        }
        public String getFaxNumber()
        {
            return FaxNumber;
        }
        public void setFaxNumber(Object faxNumber)
        {
            if (faxNumber != null && faxNumber != DBNull.Value)
            {
                FaxNumber = (String)faxNumber;
            }
            else
            {
                FaxNumber = "";
            }
        }
        public String getAddress()
        {
            return Address;
        }
        public void setAddress(Object address)
        {
            if (address != null && address != DBNull.Value)
            {
                Address = (String)address;
            }
            else
            {
                Address = "";
            }
        }
        public String getCity()
        {
            return City;
        }
        public void setCity(Object city)
        {
            if (city != null && city != DBNull.Value)
            {
                City = (String)city;
            }
            else
            {
                City = "";
            }
        }
        public String getStateProvince()
        {
            return StateProvince;
        }
        public void setStateProvince(Object stateProvince)
        {
            if (stateProvince != null && stateProvince != DBNull.Value)
            {
                StateProvince = (String)stateProvince;
            }
            else
            {
                StateProvince = "";
            }
        }
        public String getPostalCode()
        {
            return PostalCode;
        }
        public void setPostalCode(Object postalCode)
        {
            if (postalCode != null && postalCode != DBNull.Value)
            {
                PostalCode = (String)postalCode;
            }
            else
            {
                PostalCode = "";
            }
        }
        public String getCountryRegion()
        {
            return CountryRegion;
        }
        public void setCountryRegion(Object countryRegion)
        {
            if (countryRegion != null && countryRegion != DBNull.Value)
            {
                CountryRegion = (String)countryRegion;
            }
            else
            {
                CountryRegion = "";
            }
        }
        public String getWebPage()
        {
            return WebPage;
        }
        public void setWebPage(Object webPage)
        {
            if (webPage != null && webPage != DBNull.Value)
            {
                String[] splits = ((String)webPage).Split('#');
                if (splits.Length > 1)
                {
                    if (splits[0].Length != 0)
                    {
                        WebPage = (String)splits[0];
                    }
                    else
                    {
                        WebPage = (String)splits[1];
                    }
                }
                else
                {
                    WebPage = (String)splits[0];
                }
            }
            else
            {
                WebPage = "";
            }
        }
        public String getNotes()
        {
            return Notes;
        }
        public void setNotes(Object notes)
        {
            if (notes != null && notes != DBNull.Value)
            {
                Notes = (String)notes;
            }
            else
            {
                Notes = "";
            }
        }
        public String getAttachments()
        {
            return Attachments;
        }
        public void setAttachments(Object attachments)
        {
            if (attachments != null && attachments != DBNull.Value)
            {
                Attachments = (String)attachments;
            }
            else
            {
                Attachments = "";
            }
        }

        public DateTime getStartDate()
        {
            return StartDate;
        }

        public void setStartDate(Object startDate)
        {
            if (startDate != null && startDate != DBNull.Value)
            {
                StartDate = (DateTime)startDate;
            }
            else
            {
                StartDate = DateTime.MinValue;
            }
        }

    }
}
