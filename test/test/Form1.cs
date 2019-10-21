using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using issou;
using MySql.Data.MySqlClient;


namespace test
{
    public partial class Form1 : Form
    {

        private static string server;
        private static string database;
        private static string uid;
        private static string password;
        private static string port;

        public Form1()
        {
            InitializeComponent();
        }

        public void Label3_Click(object sender, EventArgs e)
        {
      
        server = textBox1.Text;
        database = textBox4.Text;
        uid = textBox3.Text;
        password = textBox2.Text;
        port = textBox5.Text;
        }

        public static MySqlConnection GetDBConnection()
        {
            return DBMySQLUtils.GetDBConnection(server,port,database,uid,password);
        }

     }
}
