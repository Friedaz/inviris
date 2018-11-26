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
using MySql.Data.Types;
using System.Data.Odbc;

namespace Inviris.GUI.Solution
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BTlogin_Click(object sender, EventArgs e)
        {
            try
            {
                string myConnection = "DSN=inviris;MultipleActiveResultSets=True";
                OdbcConnection myConn = new OdbcConnection(myConnection);

                OdbcCommand SelectCommand = new OdbcCommand("SELECT * FROM inviris.user where email ='" + this.Temail.Text + "' and password='" + this.Tpassword.Text + "' ;", myConn);

                OdbcDataReader myReader;
                myConn.Open();
                myReader = SelectCommand.ExecuteReader();
                int count = 0;
                while (myReader.Read())
                {
                    count = count + 1;
                }
                if (count == 1)
                {
                    this.Hide();
                    Main fm = new Main();
                    fm.Show();
                }
                else if (count > 1)
                {
                    MessageBox.Show("Duplicate Username and password ...Access denied");
                }
                else
                    MessageBox.Show("Email or Password incorrect");
                myConn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void Tpassword_TextChanged(object sender, EventArgs e)
        {
            Tpassword.PasswordChar = '*';
        }

        private void showPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (showPassword.Checked)
            {
                Tpassword.UseSystemPasswordChar = true;
            }
            else
            {
                Tpassword.UseSystemPasswordChar = false;
            }
        }
    }





}

