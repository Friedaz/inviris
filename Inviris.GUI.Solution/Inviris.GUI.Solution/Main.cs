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
using System.Data.Sql;
using System.Configuration;
using System.IO;
using System.Data.Odbc;
using PagedList;

namespace Inviris.GUI.Solution
{
    public partial class Main : Form
    { 

        string myConnection = "DSN=inviris;MultipleActiveResultSets=True";

        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            Load_Data();
        }

        public void Load_Data()
        {
            OdbcConnection myConn = new OdbcConnection(myConnection);

            myConn.Open();
            OdbcDataAdapter sqlDa = new OdbcDataAdapter("SELECT id as 'ID', nm_airbase as 'NM Airbase', _force as 'Force', munition as 'Munition', aviation_fuel as 'Aviation Fuel', aircrews as 'Air Crews', groundcrews as 'Grown Crews' FROM inviris.t_airbase", myConn);
            DataTable dtbl = new DataTable();
            sqlDa.Fill(dtbl);

            DataDisplay.DataSource = dtbl;
        }


        private void MFile_Click(object sender, EventArgs e)
        {
            FileMenu.Show(MFile, 0, MFile.Height);
        }

        

        private void DataDisplay_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedRow;
            selectedRow = e.RowIndex;
        }

        private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void backgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {

        }

        private void backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

        }

        private void exlExport_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            worksheet = workbook.Sheets["Sheet1"];
            worksheet = workbook.ActiveSheet;
            worksheet.Name = "Sheet";

            for (int i = 1; i < DataDisplay.Columns.Count+1; i++)
            {
                worksheet.Cells[i, 1] = DataDisplay.Columns[i - 1].HeaderText;
            }


            for (int i = 0; i < DataDisplay.Rows.Count; i++)
            {
                for (int j = 0; j < DataDisplay.Columns.Count; j++)
                {
                    worksheet.Cells[i+2,j+1] = DataDisplay.Rows[i].Cells[j].Value?.ToString() ?? "";
                }
            }

            var saveFileDialoge = new SaveFileDialog();
            saveFileDialoge.FileName = "*";
            saveFileDialoge.DefaultExt = ".xlsx";
            if (saveFileDialoge.ShowDialog() == DialogResult.OK)
            {
                workbook.SaveAs(saveFileDialoge.FileName, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive);
            }
            app.Quit();
        }

        private void MPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void airbase_Click_1(object sender, EventArgs e)
        {
            OdbcConnection myConn = new OdbcConnection(myConnection);

            myConn.Open();
            OdbcDataAdapter sqlDa = new OdbcDataAdapter("SELECT id as 'ID', nm_airbase as 'NM Airbase', _force as 'Force', munition as 'Munition', aviation_fuel as 'Aviation Fuel', aircrews as 'Air Crews', groundcrews as 'Grown Crews' FROM inviris.t_airbase", myConn);
            DataTable dtbl = new DataTable();
            sqlDa.Fill(dtbl);

            DataDisplay.DataSource = dtbl;
        }

        private void airbaseListAircraft_Click(object sender, EventArgs e)
        {
            OdbcConnection myConn = new OdbcConnection(myConnection);

            myConn.Open();
            OdbcDataAdapter sqlDa = new OdbcDataAdapter("SELECT id as 'ID', nm_airbase as 'NM Airbase', _force as 'Force', type_aircraft  as 'Type Aircraft', available as 'Available', in_repair as 'In repair', assigned as 'Assigned', qra as 'QRA', count as 'Count' FROM inviris.t_airbase_list_aircraft", myConn);
            DataTable dtbl = new DataTable();
            sqlDa.Fill(dtbl);

            DataDisplay.DataSource = dtbl;
        }

        private void airbaseListRunway_Click(object sender, EventArgs e)
        {
            OdbcConnection myConn = new OdbcConnection(myConnection);

            myConn.Open();
            OdbcDataAdapter sqlDa = new OdbcDataAdapter("SELECT id as 'ID', nm_airbase as 'NM Airbase', _force as 'Force', nm_runway as 'NM Runway', length as 'Length', width as 'Width', direction as 'Direction', _condition as 'Condition' FROM inviris.t_airbase_list_runway", myConn);
            DataTable dtbl = new DataTable();
            sqlDa.Fill(dtbl);

            DataDisplay.DataSource = dtbl;
        }

        private void engagementHistory_Click(object sender, EventArgs e)
        {
            OdbcConnection myConn = new OdbcConnection(myConnection);

            myConn.Open();
            OdbcDataAdapter sqlDa = new OdbcDataAdapter("SELECT * FROM inviris.t_engagement_history", myConn);
            DataTable dtbl = new DataTable();
            sqlDa.Fill(dtbl);

            DataDisplay.DataSource = dtbl;
        }

        private void engagementHistoryDetail_Click(object sender, EventArgs e)
        {
            OdbcConnection myConn = new OdbcConnection(myConnection);

            myConn.Open();
            OdbcDataAdapter sqlDa = new OdbcDataAdapter("SELECT * FROM inviris.t_engagement_history_detail", myConn);
            DataTable dtbl = new DataTable();
            sqlDa.Fill(dtbl);

            DataDisplay.DataSource = dtbl;
        }

        private void entityArmament_Click(object sender, EventArgs e)
        {
            OdbcConnection myConn = new OdbcConnection(myConnection);

            myConn.Open();
            OdbcDataAdapter sqlDa = new OdbcDataAdapter("SELECT * FROM inviris.t_entity_armament", myConn);
            DataTable dtbl = new DataTable();
            sqlDa.Fill(dtbl);

            DataDisplay.DataSource = dtbl;
        }

        private void entityContact_Click(object sender, EventArgs e)
        {
            OdbcConnection myConn = new OdbcConnection(myConnection);

            myConn.Open();
            OdbcDataAdapter sqlDa = new OdbcDataAdapter("SELECT * FROM inviris.t_entity_contact", myConn);
            DataTable dtbl = new DataTable();
            sqlDa.Fill(dtbl);

            DataDisplay.DataSource = dtbl;
        }

        private void entityList_Click(object sender, EventArgs e)
        {
            OdbcConnection myConn = new OdbcConnection(myConnection);

            myConn.Open();
            OdbcDataAdapter sqlDa = new OdbcDataAdapter("SELECT * FROM inviris.t_entity_list", myConn);
            DataTable dtbl = new DataTable();
            sqlDa.Fill(dtbl);

            DataDisplay.DataSource = dtbl;
        }

        private void masterScenario_Click(object sender, EventArgs e)
        {
            OdbcConnection myConn = new OdbcConnection(myConnection);

            myConn.Open();
            OdbcDataAdapter sqlDa = new OdbcDataAdapter("SELECT * FROM inviris.t_master_scenario", myConn);
            DataTable dtbl = new DataTable();
            sqlDa.Fill(dtbl);

            DataDisplay.DataSource = dtbl;
        }
         
        private void metricFuel_Click(object sender, EventArgs e)
        {
            OdbcConnection myConn = new OdbcConnection(myConnection);

            myConn.Open();
            OdbcDataAdapter sqlDa = new OdbcDataAdapter("SELECT * FROM inviris.t_metric_fuel", myConn);
            DataTable dtbl = new DataTable();
            sqlDa.Fill(dtbl);

            DataDisplay.DataSource = dtbl;
        }

        private void mission_Click(object sender, EventArgs e)
        {
            OdbcConnection myConn = new OdbcConnection(myConnection);

            myConn.Open();
            OdbcDataAdapter sqlDa = new OdbcDataAdapter("SELECT id as 'ID', name as 'Name', _force as 'Force', missionname as 'Mission Name', timemission as 'Time Mission' FROM inviris.t_mission", myConn);
            DataTable dtbl = new DataTable();
            sqlDa.Fill(dtbl);

            DataDisplay.DataSource = dtbl;
            }

        private void DataUpdate_Click(object sender, EventArgs e)
        {
            Update updt = new Update();

            updt.textBox1.Text = this.DataDisplay.CurrentRow.Cells[0].Value.ToString();
            updt.textBox2.Text = this.DataDisplay.CurrentRow.Cells[1].Value.ToString();
            updt.textBox3.Text = this.DataDisplay.CurrentRow.Cells[2].Value.ToString();
            updt.textBox4.Text = this.DataDisplay.CurrentRow.Cells[3].Value.ToString();
            updt.textBox5.Text = this.DataDisplay.CurrentRow.Cells[4].Value.ToString();
            updt.textBox6.Text = this.DataDisplay.CurrentRow.Cells[5].Value.ToString();
            updt.textBox7.Text = this.DataDisplay.CurrentRow.Cells[6].Value.ToString();
            updt.ShowDialog();

        }

        private void DataAdd_Click(object sender, EventArgs e)
        {
            Update updt = new Update();
            updt.ShowDialog();
        }

        private void DataDelete_Click(object sender, EventArgs e)
        {
            Update updt = new Update();

            updt.textBox1.Text = this.DataDisplay.CurrentRow.Cells[0].Value.ToString();
            updt.textBox2.Text = this.DataDisplay.CurrentRow.Cells[1].Value.ToString();
            updt.textBox3.Text = this.DataDisplay.CurrentRow.Cells[2].Value.ToString();
            updt.textBox4.Text = this.DataDisplay.CurrentRow.Cells[3].Value.ToString();
            updt.textBox5.Text = this.DataDisplay.CurrentRow.Cells[4].Value.ToString();
            updt.textBox6.Text = this.DataDisplay.CurrentRow.Cells[5].Value.ToString();
            updt.textBox7.Text = this.DataDisplay.CurrentRow.Cells[6].Value.ToString();
            updt.ShowDialog();
        }

        private void pdf_Click(object sender, EventArgs e)
        {

        }
    }
}
