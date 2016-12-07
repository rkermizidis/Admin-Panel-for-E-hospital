using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;
using System.Threading;
namespace Hospital_management_system
{



    public partial class Login : MetroFramework.Forms.MetroForm
    {


        public Login()
        {
           
            InitializeComponent();
            circularProgressBar1.Value = 0;
            
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            circularProgressBar1.Value = 0;
            circularProgressBar1.Minimum = 0;
            circularProgressBar1.Maximum = 100;
            
        }
        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void unameTB_Click(object sender, EventArgs e)
        {

        }

        private void loginTB_Click(object sender, EventArgs e)
        {
            
         

            {


                MySqlConnection connection;
                String server = "127.0.0.1";
                String database = "hospitaldb";
                String uid = "root";
                 String   password = "123456";
        string connectionString;
        connectionString = "SERVER=" + server + ";" + "DATABASE=" + 
		database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

        connection = new MySqlConnection(connectionString);
       

                for (int i = 1; i <= 100; i++)
                {
                    //Thread.Sleep(1);
                    circularProgressBar1.Value = i;
                    circularProgressBar1.Update();
                }
                    try
                    {
                        connection.Open();
                        //    MessageBox.Show("Connection Open ! ");
                        connection.Close();
                        String uname = unameTB.Text;
                        String passwd = passwdTB.Text;
                        MySqlCommand msqlcommand = new MySqlCommand("Select * from hospitaldb.login where username='" + uname + "'and password='" + passwd + "';", connection);
                        MySqlDataReader myReader;

                        connection.Open();
                        myReader = msqlcommand.ExecuteReader();
                        int count = 0;
                        while (myReader.Read())
                        {
                            count = count + 1;

                            
                        }

                        if (count == 1)
                        {
                            
                            // MessageBox.Show("Correct");
                            Form2 f2 = new Form2();
                            this.Hide();
                            f2.ShowDialog();
                        }
                        else
                        {
                            MessageBox.Show("Λάθος username ή password.Δοκίμασε ξανά");
                            circularProgressBar1.Value = 0;
                        }

                        connection.Close();







                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        circularProgressBar1.Value = 0;
                    }




            }
        }

        private void circularProgressBar1_Click(object sender, EventArgs e)
        {

        }




    }
}
