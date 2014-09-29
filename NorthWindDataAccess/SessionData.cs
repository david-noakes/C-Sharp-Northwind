using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Data;
//using System.Data.SqlClient;
using System.Data.OleDb;

namespace NorthWindDataAccess
{

    class SessionData : Hashtable
    {
	    public static String CONTEXT = "context";
	    public static String DESTINATION = "destination";
	
	    private String username = " ";
	    private String password = " ";
	    private static SessionData instance = null;
        //private SqlConnection connection;
	    private OleDbConnection connection;

        
        private SessionData() : base()
        {
            //connection = new SqlConnection("server=localhost;database=NorthwindEx");
            String connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Documents and Settings\\NoakesD\\My Documents\\Desktop Northwind 2007 sample database.accdb;Persist Security Info=False;";
            connection = new OleDbConnection(connectionString);


        }

        public static SessionData getInstance()
        {
            if (instance == null)
            {
                instance = new SessionData();
            }

            return instance;
        }

        //public SqlConnection getConnection()
        public OleDbConnection getConnection()
        {
            return connection;
        }

	}

}
