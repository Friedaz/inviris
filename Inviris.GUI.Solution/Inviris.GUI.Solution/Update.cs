using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Odbc;

namespace Inviris.GUI.Solution
{
    public partial class Update : Form
    { 
        public Update()
        {
            InitializeComponent();
        }

        private void Update_Load(object sender, EventArgs e)
        {
            saveUpdate.Hide();
            saveNew.Hide();
            Main fm = new Main();
            if (textBox1.Text != "")
            {
                saveUpdate.Show();
            }
            else
            {
                saveNew.Show();
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void saveUpdate_Click(object sender, EventArgs e)
        {
            string myConnection = "DSN=inviris;MultipleActiveResultSets=True";
            OdbcConnection myConn = new OdbcConnection(myConnection);

            myConn.Open();
            Main fm = new Main();

            OdbcCommand SelectCommand = new OdbcCommand("UPDATE inviris.t_airbase set nm_airbase='" + this.textBox2.Text + "', _force='" + this.textBox3.Text + "', munition='" + this.textBox4.Text + "', aviation_fuel='" + this.textBox5.Text + "', aircrews='" + this.textBox6.Text + "', groundcrews='" + this.textBox7.Text + "' where id='" + int.Parse(textBox1.Text) + "';", myConn);
            int i = SelectCommand.ExecuteNonQuery();
            if (i != 0)
            {
                MessageBox.Show("Updated");
                this.Hide();
                fm.Refresh();
            }
            else
            {
                MessageBox.Show("Update Failed");
            }
        }

        private void deleteData_Click(object sender, EventArgs e)
        {
            string myConnection = "DSN=inviris;MultipleActiveResultSets=True";
            OdbcConnection myConn = new OdbcConnection(myConnection);

            myConn.Open();
            Main fm = new Main();

            OdbcCommand SelectCommand = new OdbcCommand("DELETE FROM inviris.t_airbase WHERE id='" + int.Parse(textBox1.Text) + "';", myConn);
            int i = SelectCommand.ExecuteNonQuery();
            if (i != 0)
            {
                MessageBox.Show("Deleted");
                this.Hide();
                fm.Refresh();
            }
            else
            {
                MessageBox.Show("Can't delete data");
            }
        }

        private void saveNew_Click(object sender, EventArgs e)
        {
            string myConnection = "DSN=inviris;MultipleActiveResultSets=True";
            OdbcConnection myConn = new OdbcConnection(myConnection);

            myConn.Open();
            Main fm = new Main();

            OdbcCommand SelectCommand = new OdbcCommand("INSERT INTO inviris.t_airbase VALUES ('" + this.textBox1.Text + "','" + this.textBox2.Text + "','" + this.textBox3.Text + "','" + this.textBox4.Text + "','" + this.textBox5.Text + "','" + this.textBox6.Text + "','" + this.textBox7.Text + "');", myConn);
            int i = SelectCommand.ExecuteNonQuery();
            if (i != 0)
            {
                MessageBox.Show("Created");
                this.Hide();
                fm.Refresh();
            }
            else
            {
                MessageBox.Show("Failed to create data");
            }
        }
    }
}
