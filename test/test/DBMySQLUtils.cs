using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using test;

namespace issou
{ 
    class DBMySQLUtils
    {
       
    

    public static MySqlConnection GetDBConnection(string server, string port, string database, string uid, string password)
    { 
        String connString = "Server=" + server + ";Database=" + database+ ";port=" + port + ";User Id=" + uid + ";password=" + password;
        MySqlConnection connexion = new MySqlConnection(connString);
        return connexion;
    }



       
  

        /*
            //Close connection
            private bool CloseConnection()
        {

        }

        //Insert statement
        public void Insert()
        {
        }

        //Update statement
        public void Update()
        {
        }

        //Delete statement
        public void Delete()
        {
        }

        //Select statement
        public List<string>[] Select()
        {
        }

        //Count statement
        public int Count()
        {
        }
        */

    }
}