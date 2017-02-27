using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace ProjectCPK
{
    public class DBConnect
    {
        MySqlConnection db_conn;
        private string db_name = "test";
        private string db_un = "rxcpk";
        private string db_pw = "EACV1VFkIQ8N6IGr";
        private string db_server;
        private string db_uid;
        private string conn_str;
        
        public DBConnect()
        {
            Initialize();
        }
        private void Initialize()
        {
            this.db_name = "test";
            this.db_un = "rxcpk";
            this.db_pw = "EACV1VFkIQ8N6IGr";
            this.db_server = "localhost";
            this.db_uid = "";
            conn_str = String.Format("server=localhost;database={0};uid={1};pwd={2};", db_name, db_un, db_pw);
            db_conn = new MySqlConnection(conn_str);
           
        }
        //open connection to database
        private bool OpenConnection()
        {
            try
            {
                db_conn.Open();
                return true;
            }
            catch (MySqlException sqle)
            {
                switch (sqle.Number)
                {
                    case 0:
                        MessageBox.Show("Cannot connect to database.");
                        break;
                    case 1:
                        MessageBox.Show("Invalid username or password.");
                        break;
                }
                return false;
            }
        }

        //Close connection
        private bool CloseConnection()
        {
            try
            {
                db_conn.Close();
                return true;
            }
            catch (MySqlException sqle)
            {
                MessageBox.Show(sqle.Message);
                return false;
            }
        }

        protected internal void UpdateConnection(string constr)
        { 
            db_conn = new MySqlConnection(constr);
        }
        public bool TestConnection()
        {
            if (OpenConnection())
            {
                CloseConnection();
                return true;
            }
            else 
                return false;
        }
        public bool TestConnection(string constr)
        {
            string temp_con = conn_str;
            conn_str = constr;
            db_conn = new MySqlConnection(conn_str);
            if (OpenConnection())
            {
                CloseConnection();
                conn_str = temp_con;
                db_conn = new MySqlConnection(conn_str);
                return true;
            }
            else
                return false;
        }
        //Insert statement
        public bool Insert(string qry = "")
        {
            //string query = "INSERT INTO tableinfo (name, age) VALUES('John Smith', '33')";

            //open connection
            if (this.OpenConnection() == true)
            {
                try
                {
                    //create command and assign the query and connection from the constructor
                    MySqlCommand cmd = new MySqlCommand(qry, db_conn);

                    //Execute command
                    cmd.ExecuteNonQuery();

                    //close connection
                    this.CloseConnection();
                }
                catch (Exception e0)
                {
                    return false;
                }
                return true;
            }
            return false;
        }

        //Update statement
        public void Update(string qry = "")
        {
            //string query = "UPDATE tableinfo SET name='Joe', age='22' WHERE name='John Smith'";

            //Open connection
            if (this.OpenConnection() == true)
            {
                //create mysql command
                MySqlCommand cmd = new MySqlCommand();
                //Assign the query using CommandText
                cmd.CommandText = qry;
                //Assign the connection using Connection
                cmd.Connection = db_conn;

                //Execute query
                cmd.ExecuteNonQuery();

                //close connection
                this.CloseConnection();
            }
        }

        //Delete statement
        public void Delete(string qry = "")
        {
            //string query = "DELETE FROM tableinfo WHERE name='John Smith'";

            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(qry, db_conn);
                cmd.ExecuteNonQuery();
                this.CloseConnection();
            }
        }

        //Select statement
        public List<string>[] Select(string select_qry)
        {
            //string query = "SELECT * FROM tableinfo";

            //Create a list to store the result
            List<string>[] list = new List<string>[3];
            list[0] = new List<string>();
            list[1] = new List<string>();
            list[2] = new List<string>();
            
            //Open connection
            if (this.OpenConnection() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(select_qry, db_conn);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    list[0].Add(dataReader["person_id"] + "");
                    list[1].Add(dataReader["person_fname"] + "");
                    list[2].Add(dataReader["person_lname"] + "");
                }

                //close Data Reader
                dataReader.Close();

                //close Connection
                this.CloseConnection();

                //return list to be displayed
                return list;
            }
            else
            {
                return list;
            }
        }

        //Count statement
        public int Count()
        {
            string query = "SELECT Count(*) FROM tableinfo";
            int Count = -1;

            //Open Connection
            if (this.OpenConnection() == true)
            {
                //Create Mysql Command
                MySqlCommand cmd = new MySqlCommand(query, db_conn);

                //ExecuteScalar will return one value
                Count = int.Parse(cmd.ExecuteScalar() + "");

                //close Connection
                this.CloseConnection();

                return Count;
            }
            else
            {
                return Count;
            }
        }

        //Backup
        public void Backup()
        {
            try
            {
                DateTime Time = DateTime.Now;
                int year = Time.Year;
                int month = Time.Month;
                int day = Time.Day;
                int hour = Time.Hour;
                int minute = Time.Minute;
                int second = Time.Second;
                int millisecond = Time.Millisecond;

                //Save file to C:\ with the current date as a filename
                string path;
                path = "C:\\MySqlBackup" + year + "-" + month + "-" + day +
                "-" + hour + "-" + minute + "-" + second + "-" + millisecond + ".sql";
                StreamWriter file = new StreamWriter(path);


                ProcessStartInfo psi = new ProcessStartInfo();
                psi.FileName = "mysqldump";
                psi.RedirectStandardInput = false;
                psi.RedirectStandardOutput = true;
                psi.Arguments = string.Format(@"-u{0} -p{1} -h{2} {3}",
                    db_uid, db_pw, db_server, db_name);
                psi.UseShellExecute = false;

                Process process = Process.Start(psi);

                string output;
                output = process.StandardOutput.ReadToEnd();
                file.WriteLine(output);
                process.WaitForExit();
                file.Close();
                process.Close();
            }
            catch (IOException ex)
            {
                MessageBox.Show("Error , unable to backup!");
            }
        }

        //Restore
        public void Restore()
        {
            try
            {
                //Read file from C:\
                string path;
                path = "C:\\MySqlBackup.sql";
                StreamReader file = new StreamReader(path);
                string input = file.ReadToEnd();
                file.Close();

                ProcessStartInfo psi = new ProcessStartInfo();
                psi.FileName = "mysql";
                psi.RedirectStandardInput = true;
                psi.RedirectStandardOutput = false;
                psi.Arguments = string.Format(@"-u{0} -p{1} -h{2} {3}",
                    db_uid, db_pw, db_server, db_name);
                psi.UseShellExecute = false;


                Process process = Process.Start(psi);
                process.StandardInput.WriteLine(input);
                process.StandardInput.Close();
                process.WaitForExit();
                process.Close();
            }
            catch (IOException ex)
            {
                MessageBox.Show("Error , unable to Restore!");
            }
        }

    }//end of DBConnect
}
