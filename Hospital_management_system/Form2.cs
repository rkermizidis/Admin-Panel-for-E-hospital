using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital_management_system
{
    public partial class Form2 : MaterialSkin.Controls.MaterialForm
    {
        public Form2()
        {
            InitializeComponent();

        }

        private void Form2_Load(object sender, EventArgs e)
        {

           
        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {

          

             
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void materialFlatButton1_Click_1(object sender, EventArgs e)
        {

            materialFlatButton1.Enabled = false;


            MySqlConnection connection;
            String server = "127.0.0.1";
            String database = "hospitaldb";
            String uid = "root";
            String password = "123456";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";
            connection = new MySqlConnection(connectionString);
            string commandLine1 = "SELECT COUNT(*) FROM rantevou where E_eid = 1";
            string commandLine2 = "SELECT COUNT(*) FROM rantevou where E_eid = 2";
            string commandLine3 = "SELECT COUNT(*) FROM rantevou where E_eid = 6";
            string commandLine4 = "SELECT COUNT(*) FROM rantevou where E_eid = 4";
            string commandLine5 = "SELECT COUNT(*) FROM rantevou where E_eid = 5";
            string commandLine6 = "SELECT COUNT(*) FROM rantevou where E_eid = 8";
            string commandLine7 = "SELECT COUNT(*) FROM rantevou where E_eid = 3";
            string commandLine8 = "SELECT COUNT(*) FROM rantevou where E_eid = 7";





            string commandLine9 = "SELECT COUNT(*) FROM rantevou where wra = 1";
            string commandLine10 = "SELECT COUNT(*) FROM rantevou where wra = 2";
            string commandLine11 = "SELECT COUNT(*) FROM rantevou where wra = 3";
            string commandLine12 = "SELECT COUNT(*) FROM rantevou where wra = 4";
            string commandLine13 = "SELECT COUNT(*) FROM rantevou where wra = 5";
            string commandLine14 = "SELECT COUNT(*) FROM rantevou where wra = 6";
            string commandLine15 = "SELECT COUNT(*) FROM rantevou where wra = 8";
            string commandLine16 = "SELECT COUNT(*) FROM rantevou where wra = 9";
            string commandLine17 = "SELECT COUNT(*) FROM rantevou where wra = 10";
            string commandLine18 = "SELECT COUNT(*) FROM rantevou where wra = 11";
            string commandLine19 = "SELECT COUNT(*) FROM rantevou where wra = 12"; 
            string commandLine20 = "SELECT COUNT(*) FROM rantevou where wra = 13";
            string a = "SELECT COUNT(*) FROM rantevou where wra = 7";



            string commandLine23 = "SELECT COUNT(*) from rantevou,perioxes where perioxes.id = rantevou.perioxi and rantevou.perioxi = 1";
            string commandLine24 = "SELECT COUNT(*) from rantevou,perioxes where perioxes.id = rantevou.perioxi and rantevou.perioxi = 5";
            string commandLine25 = "SELECT COUNT(*) from rantevou,perioxes where perioxes.id = rantevou.perioxi and rantevou.perioxi = 3";
            string commandLine26 = "SELECT COUNT(*) from rantevou,perioxes where perioxes.id = rantevou.perioxi and rantevou.perioxi = 2";
            string commandLine27 = "SELECT COUNT(*) from rantevou,perioxes where perioxes.id = rantevou.perioxi and rantevou.perioxi = 4";

            using (MySqlCommand cmd = new MySqlCommand(commandLine27, connection))
            {



                connection.Open();

                long count = (long)cmd.ExecuteScalar();

                chart3.Series["Λάρισα"].Points.Add(count);



                connection.Close();
            }


            using (MySqlCommand cmd = new MySqlCommand(commandLine26, connection))
            {



                connection.Open();

                long count = (long)cmd.ExecuteScalar();

                chart3.Series["Πάτρα"].Points.Add(count);



                connection.Close();
            }


            using (MySqlCommand cmd = new MySqlCommand(commandLine25, connection))
            {



                connection.Open();

                long count = (long)cmd.ExecuteScalar();

                chart3.Series["Ηράκλειο"].Points.Add(count);



                connection.Close();
            }


            using (MySqlCommand cmd = new MySqlCommand(commandLine24, connection))
            {



                connection.Open();

                long count = (long)cmd.ExecuteScalar();

                chart3.Series["Θεσσαλονίκη"].Points.Add(count);



                connection.Close();
            }

            using (MySqlCommand cmd = new MySqlCommand(commandLine23, connection))
            {



                connection.Open();

                long count = (long)cmd.ExecuteScalar();

                chart3.Series["Αθήνα"].Points.Add(count);



                connection.Close();
            }

           






            using (MySqlCommand cmd = new MySqlCommand(commandLine20, connection))
            {



                connection.Open();

                long count = (long)cmd.ExecuteScalar();

                chart2.Series["15:00"].Points.Add(count);



                connection.Close();
            } 
            using (MySqlCommand cmd = new MySqlCommand(commandLine19, connection))
            {



                connection.Open();

                long count = (long)cmd.ExecuteScalar();

                chart2.Series["14:30"].Points.Add(count);



                connection.Close();
            } 
            using (MySqlCommand cmd = new MySqlCommand(commandLine18, connection))
            {



                connection.Open();

                long count = (long)cmd.ExecuteScalar();

                chart2.Series["14:00"].Points.Add(count);



                connection.Close();
            } using (MySqlCommand cmd = new MySqlCommand(commandLine17, connection))
            {



                connection.Open();

                long count = (long)cmd.ExecuteScalar();

                chart2.Series["13:30"].Points.Add(count);



                connection.Close();
            }





            using (MySqlCommand cmd = new MySqlCommand(commandLine16, connection))
            {



                connection.Open();

                long count = (long)cmd.ExecuteScalar();

                chart2.Series["13:00"].Points.Add(count);



                connection.Close();
            }

            using (MySqlCommand cmd = new MySqlCommand(commandLine15, connection))
            {



                connection.Open();

                long count = (long)cmd.ExecuteScalar();

                chart2.Series["12:30"].Points.Add(count);



                connection.Close();
            }

            using (MySqlCommand cmd = new MySqlCommand(a, connection))
            {



                connection.Open();

                long count = (long)cmd.ExecuteScalar();

                chart2.Series["12:00"].Points.Add(count);



                connection.Close();
            }



            using (MySqlCommand cmd = new MySqlCommand(commandLine14, connection))
            {



                connection.Open();

                long count = (long)cmd.ExecuteScalar();

                chart2.Series["11:30"].Points.Add(count);



                connection.Close();
            }

            using (MySqlCommand cmd = new MySqlCommand(commandLine13, connection))
            {



                connection.Open();

                long count = (long)cmd.ExecuteScalar();

                chart2.Series["11:00"].Points.Add(count);



                connection.Close();
            }

            using (MySqlCommand cmd = new MySqlCommand(commandLine12, connection))
            {



                connection.Open();

                long count = (long)cmd.ExecuteScalar();

                chart2.Series["10:30"].Points.Add(count);



                connection.Close();
            }

            using (MySqlCommand cmd = new MySqlCommand(commandLine11, connection))
            {



                connection.Open();

                long count = (long)cmd.ExecuteScalar();

                chart2.Series["10:00"].Points.Add(count);



                connection.Close();
            }

            using (MySqlCommand cmd = new MySqlCommand(commandLine10, connection))
            {



                connection.Open();

                long count = (long)cmd.ExecuteScalar();

                chart2.Series["9:30"].Points.Add(count);



                connection.Close();
            }

            using (MySqlCommand cmd = new MySqlCommand(commandLine9, connection))
            {



                connection.Open();

                long count = (long)cmd.ExecuteScalar();

                chart2.Series["9:00"].Points.Add(count);



                connection.Close();
            }


            
              using (MySqlCommand cmd = new MySqlCommand(commandLine1, connection))
            {



                connection.Open();

                long count = (long)cmd.ExecuteScalar();

                chart1.Series["Δερματολογικό"].Points.Add(count);



                connection.Close();
            }

            using (MySqlCommand cmd = new MySqlCommand(commandLine2, connection))
            {



                connection.Open();

                long count = (long)cmd.ExecuteScalar();

                chart1.Series["Ουρολογικό"].Points.Add(count);



                connection.Close();
            }

            using (MySqlCommand cmd = new MySqlCommand(commandLine4, connection))
            {



                connection.Open();

                long count = (long)cmd.ExecuteScalar();

                chart1.Series["Ηπατολογικό"].Points.Add(count);



                connection.Close();
            }
            using (MySqlCommand cmd = new MySqlCommand(commandLine3, connection))
            {



                connection.Open();

                long count = (long)cmd.ExecuteScalar();

                chart1.Series["Παιδιατρικό"].Points.Add(count);



                connection.Close();
            }
            using (MySqlCommand cmd = new MySqlCommand(commandLine5, connection))
            {



                connection.Open();

                long count = (long)cmd.ExecuteScalar();

                chart1.Series["Παθολογικό"].Points.Add(count);



                connection.Close();
            }
            using (MySqlCommand cmd = new MySqlCommand(commandLine6, connection))
            {



                connection.Open();

                long count = (long)cmd.ExecuteScalar();

                chart1.Series["Καρδιολογικό"].Points.Add(count);



                connection.Close();
            }
            using (MySqlCommand cmd = new MySqlCommand(commandLine7, connection))
            {



                connection.Open();

                long count = (long)cmd.ExecuteScalar();

                chart1.Series["Γαστρεντερολογικό"].Points.Add(count);



                connection.Close();
            }
            using (MySqlCommand cmd = new MySqlCommand(commandLine8, connection))
            {



                connection.Open();

                long count = (long)cmd.ExecuteScalar();

                chart1.Series["Οφθαλμολογικό"].Points.Add(count);



                connection.Close();
            }

             
        }

        private void materialFlatButton2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        }

        }
       
    

        


