using System;
// Import SqlClient namespace: it contains SqlConnection, SqlCommand, SqlDataReader classes
// In VSCode run command 'dotnet add package System.Data.SqlClient' on the terminal
using System.Data.SqlClient;

namespace database
{
    class Program
    {
        // global variable space
        // Reference: https://www.connectionstrings.com/sql-server/
        // Basic Standard Format: 
        // Server=myServerAddress;Database=myDataBase;User Id=myUsername;Password=myPassword;
        // Somee.com Format:
        const string connStr = "workstation id=ibtcollege.mssql.somee.com;packet size=4096;user id=ibtcollege_SQLLogin_1;pwd=dd69kxzi3m;data source=ibtcollege.mssql.somee.com;persist security info=False;initial catalog=ibtcollege";

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            ShowNames();
        }

        public static void ShowNames()
        {
            // show all names in the students table
            // ID-FirstName-LastName-EmailAddress
            // ADO.NET > simplest way to connect to a SQL database

            
            // 1) Create connection object and open a connection to the DB
            // Using > creates an object
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();

                // 2) Create an empty command object
                using(SqlCommand cmd = new SqlCommand())
                {   
                    // Associate connection and command text values
                    cmd.Connection = conn;
                    cmd.CommandText = "SELECT * FROM Students";

                    // 3) Extract information using SqlDataReader
                    SqlDataReader reader = cmd.ExecuteReader(); // execute reader returns a reader object containing all the results from the query
                    // use a loop to access each record
                    // read() returns true if there are more records to read
                    while (reader.Read()) 
                    {
                        // access data by column name
                        string fullName = reader["FirstName"] + " " + reader["LastName"];
                        Console.WriteLine(fullName);
                    }
                }
            }
            // Cleanup > All objects created inside using statement are disposed (connections are closed)
        }
    }
}
