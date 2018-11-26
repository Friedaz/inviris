namespace Inviris.GUI.Solution
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.MPanel = new System.Windows.Forms.Panel();
            this.MFile = new System.Windows.Forms.Label();
            this.DataDisplay = new System.Windows.Forms.DataGridView();
            this.FileMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.airbase = new System.Windows.Forms.ToolStripMenuItem();
            this.airbaseListAircraft = new System.Windows.Forms.ToolStripMenuItem();
            this.airbaseListRunway = new System.Windows.Forms.ToolStripMenuItem();
            this.engagementHistory = new System.Windows.Forms.ToolStripMenuItem();
            this.engagementHistoryDetail = new System.Windows.Forms.ToolStripMenuItem();
            this.entityArmament = new System.Windows.Forms.ToolStripMenuItem();
            this.entityContact = new System.Windows.Forms.ToolStripMenuItem();
            this.entityList = new System.Windows.Forms.ToolStripMenuItem();
            this.masterScenario = new System.Windows.Forms.ToolStripMenuItem();
            this.metricFuel = new System.Windows.Forms.ToolStripMenuItem();
            this.mission = new System.Windows.Forms.ToolStripMenuItem();
            this.invirisConnection = new Inviris.GUI.Solution.invirisConnection();
            this.invirisConnectionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataUpdate = new System.Windows.Forms.Button();
            this.DataAdd = new System.Windows.Forms.Button();
            this.DataDelete = new System.Windows.Forms.Button();
            this.exlExport = new System.Windows.Forms.PictureBox();
            this.pdf = new System.Windows.Forms.PictureBox();
            this.line = new System.Windows.Forms.Panel();
            this.MPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataDisplay)).BeginInit();
            this.FileMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.invirisConnection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invirisConnectionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exlExport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pdf)).BeginInit();
            this.SuspendLayout();
            // 
            // MPanel
            // 
            this.MPanel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.MPanel.Controls.Add(this.MFile);
            this.MPanel.Cursor = System.Windows.Forms.Cursors.Default;
            this.MPanel.Location = new System.Drawing.Point(-5, -2);
            this.MPanel.Name = "MPanel";
            this.MPanel.Size = new System.Drawing.Size(1556, 34);
            this.MPanel.TabIndex = 0;
            this.MPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.MPanel_Paint);
            // 
            // MFile
            // 
            this.MFile.AutoSize = true;
            this.MFile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MFile.Font = new System.Drawing.Font("Sitka Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MFile.Location = new System.Drawing.Point(11, 5);
            this.MFile.Name = "MFile";
            this.MFile.Size = new System.Drawing.Size(45, 28);
            this.MFile.TabIndex = 0;
            this.MFile.Text = "File";
            this.MFile.Click += new System.EventHandler(this.MFile_Click);
            // 
            // DataDisplay
            // 
            this.DataDisplay.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataDisplay.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(64)))));
            this.DataDisplay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataDisplay.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.DataDisplay.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataDisplay.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.DataDisplay.ColumnHeadersHeight = 50;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataDisplay.DefaultCellStyle = dataGridViewCellStyle6;
            this.DataDisplay.EnableHeadersVisualStyles = false;
            this.DataDisplay.Location = new System.Drawing.Point(121, 282);
            this.DataDisplay.Name = "DataDisplay";
            this.DataDisplay.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DataDisplay.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DataDisplay.RowHeadersVisible = false;
            this.DataDisplay.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.DataDisplay.Size = new System.Drawing.Size(1015, 370);
            this.DataDisplay.TabIndex = 2;
            this.DataDisplay.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataDisplay_CellContentClick);
            this.DataDisplay.Click += new System.EventHandler(this.DataUpdate_Click);
            // 
            // FileMenu
            // 
            this.FileMenu.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.FileMenu.Font = new System.Drawing.Font("Segoe UI Historic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FileMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.airbase,
            this.airbaseListAircraft,
            this.airbaseListRunway,
            this.engagementHistory,
            this.engagementHistoryDetail,
            this.entityArmament,
            this.entityContact,
            this.entityList,
            this.masterScenario,
            this.metricFuel,
            this.mission});
            this.FileMenu.Name = "contextMenuStrip1";
            this.FileMenu.Size = new System.Drawing.Size(232, 246);
            // 
            // airbase
            // 
            this.airbase.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.airbase.Name = "airbase";
            this.airbase.Size = new System.Drawing.Size(231, 22);
            this.airbase.Text = "Airbase";
            this.airbase.Click += new System.EventHandler(this.airbase_Click_1);
            // 
            // airbaseListAircraft
            // 
            this.airbaseListAircraft.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.airbaseListAircraft.Name = "airbaseListAircraft";
            this.airbaseListAircraft.Size = new System.Drawing.Size(231, 22);
            this.airbaseListAircraft.Text = "Airbase List Aircraft";
            this.airbaseListAircraft.Click += new System.EventHandler(this.airbaseListAircraft_Click);
            // 
            // airbaseListRunway
            // 
            this.airbaseListRunway.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.airbaseListRunway.Name = "airbaseListRunway";
            this.airbaseListRunway.Size = new System.Drawing.Size(231, 22);
            this.airbaseListRunway.Text = "Airbase List Runway";
            this.airbaseListRunway.Click += new System.EventHandler(this.airbaseListRunway_Click);
            // 
            // engagementHistory
            // 
            this.engagementHistory.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.engagementHistory.Name = "engagementHistory";
            this.engagementHistory.Size = new System.Drawing.Size(231, 22);
            this.engagementHistory.Text = "Engagement History";
            this.engagementHistory.Click += new System.EventHandler(this.engagementHistory_Click);
            // 
            // engagementHistoryDetail
            // 
            this.engagementHistoryDetail.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.engagementHistoryDetail.Name = "engagementHistoryDetail";
            this.engagementHistoryDetail.Size = new System.Drawing.Size(231, 22);
            this.engagementHistoryDetail.Text = "Engagement History Detail";
            this.engagementHistoryDetail.Click += new System.EventHandler(this.engagementHistoryDetail_Click);
            // 
            // entityArmament
            // 
            this.entityArmament.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.entityArmament.Name = "entityArmament";
            this.entityArmament.Size = new System.Drawing.Size(231, 22);
            this.entityArmament.Text = "Entity Armament";
            this.entityArmament.Click += new System.EventHandler(this.entityArmament_Click);
            // 
            // entityContact
            // 
            this.entityContact.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.entityContact.Name = "entityContact";
            this.entityContact.Size = new System.Drawing.Size(231, 22);
            this.entityContact.Text = "Entity Contact";
            this.entityContact.Click += new System.EventHandler(this.entityContact_Click);
            // 
            // entityList
            // 
            this.entityList.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.entityList.Name = "entityList";
            this.entityList.Size = new System.Drawing.Size(231, 22);
            this.entityList.Text = "Entity List";
            this.entityList.Click += new System.EventHandler(this.entityList_Click);
            // 
            // masterScenario
            // 
            this.masterScenario.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.masterScenario.Name = "masterScenario";
            this.masterScenario.Size = new System.Drawing.Size(231, 22);
            this.masterScenario.Text = "Master Scenario";
            this.masterScenario.Click += new System.EventHandler(this.masterScenario_Click);
            // 
            // metricFuel
            // 
            this.metricFuel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.metricFuel.Name = "metricFuel";
            this.metricFuel.Size = new System.Drawing.Size(231, 22);
            this.metricFuel.Text = "Metric Fuel";
            this.metricFuel.Click += new System.EventHandler(this.metricFuel_Click);
            // 
            // mission
            // 
            this.mission.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.mission.Name = "mission";
            this.mission.Size = new System.Drawing.Size(231, 22);
            this.mission.Text = "Mission";
            this.mission.Click += new System.EventHandler(this.mission_Click);
            // 
            // invirisConnection
            // 
            this.invirisConnection.DataSetName = "invirisConnection";
            this.invirisConnection.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // invirisConnectionBindingSource
            // 
            this.invirisConnectionBindingSource.DataSource = this.invirisConnection;
            this.invirisConnectionBindingSource.Position = 0;
            // 
            // DataUpdate
            // 
            this.DataUpdate.BackColor = System.Drawing.SystemColors.Highlight;
            this.DataUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DataUpdate.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataUpdate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DataUpdate.Location = new System.Drawing.Point(121, 668);
            this.DataUpdate.Name = "DataUpdate";
            this.DataUpdate.Size = new System.Drawing.Size(334, 56);
            this.DataUpdate.TabIndex = 5;
            this.DataUpdate.Text = "UPDATE";
            this.DataUpdate.UseVisualStyleBackColor = false;
            this.DataUpdate.Click += new System.EventHandler(this.DataUpdate_Click);
            // 
            // DataAdd
            // 
            this.DataAdd.BackColor = System.Drawing.Color.PaleGreen;
            this.DataAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DataAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataAdd.Location = new System.Drawing.Point(461, 668);
            this.DataAdd.Name = "DataAdd";
            this.DataAdd.Size = new System.Drawing.Size(334, 56);
            this.DataAdd.TabIndex = 6;
            this.DataAdd.Text = "ADD";
            this.DataAdd.UseVisualStyleBackColor = false;
            this.DataAdd.Click += new System.EventHandler(this.DataAdd_Click);
            // 
            // DataDelete
            // 
            this.DataDelete.BackColor = System.Drawing.Color.Crimson;
            this.DataDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DataDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataDelete.Location = new System.Drawing.Point(802, 668);
            this.DataDelete.Name = "DataDelete";
            this.DataDelete.Size = new System.Drawing.Size(334, 56);
            this.DataDelete.TabIndex = 8;
            this.DataDelete.Text = "DELETE";
            this.DataDelete.UseVisualStyleBackColor = false;
            this.DataDelete.Click += new System.EventHandler(this.DataDelete_Click);
            // 
            // exlExport
            // 
            this.exlExport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exlExport.Image = ((System.Drawing.Image)(resources.GetObject("exlExport.Image")));
            this.exlExport.Location = new System.Drawing.Point(1218, 47);
            this.exlExport.Name = "exlExport";
            this.exlExport.Size = new System.Drawing.Size(34, 36);
            this.exlExport.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.exlExport.TabIndex = 4;
            this.exlExport.TabStop = false;
            this.exlExport.Click += new System.EventHandler(this.exlExport_Click);
            // 
            // pdf
            // 
            this.pdf.Image = ((System.Drawing.Image)(resources.GetObject("pdf.Image")));
            this.pdf.Location = new System.Drawing.Point(1173, 47);
            this.pdf.Name = "pdf";
            this.pdf.Size = new System.Drawing.Size(34, 36);
            this.pdf.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pdf.TabIndex = 3;
            this.pdf.TabStop = false;
            // 
            // line
            // 
            this.line.BackColor = System.Drawing.Color.Gray;
            this.line.Cursor = System.Windows.Forms.Cursors.Default;
            this.line.Location = new System.Drawing.Point(13, 94);
            this.line.Name = "line";
            this.line.Size = new System.Drawing.Size(1243, 1);
            this.line.TabIndex = 9;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(1264, 985);
            this.Controls.Add(this.line);
            this.Controls.Add(this.DataDelete);
            this.Controls.Add(this.DataAdd);
            this.Controls.Add(this.DataUpdate);
            this.Controls.Add(this.exlExport);
            this.Controls.Add(this.pdf);
            this.Controls.Add(this.MPanel);
            this.Controls.Add(this.DataDisplay);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Name = "Main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.MPanel.ResumeLayout(false);
            this.MPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataDisplay)).EndInit();
            this.FileMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.invirisConnection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invirisConnectionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exlExport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pdf)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MPanel;
        private System.Windows.Forms.Label MFile;
        private System.Windows.Forms.PictureBox pdf;
        private System.Windows.Forms.PictureBox exlExport;
        private System.Windows.Forms.ContextMenuStrip FileMenu;
        private System.Windows.Forms.ToolStripMenuItem airbase;
        private System.Windows.Forms.ToolStripMenuItem airbaseListAircraft;
        private System.Windows.Forms.ToolStripMenuItem airbaseListRunway;
        private System.Windows.Forms.ToolStripMenuItem engagementHistory;
        private System.Windows.Forms.ToolStripMenuItem engagementHistoryDetail;
        private System.Windows.Forms.ToolStripMenuItem entityArmament;
        private System.Windows.Forms.ToolStripMenuItem entityContact;
        private System.Windows.Forms.ToolStripMenuItem entityList;
        private System.Windows.Forms.ToolStripMenuItem masterScenario;
        private System.Windows.Forms.ToolStripMenuItem metricFuel;
        private System.Windows.Forms.ToolStripMenuItem mission;
        private System.Windows.Forms.BindingSource invirisConnectionBindingSource;
        private invirisConnection invirisConnection;
        private System.Windows.Forms.Button DataUpdate;
        private System.Windows.Forms.Button DataAdd;
        private System.Windows.Forms.Button DataDelete;
        private System.Windows.Forms.Panel line;
        public System.Windows.Forms.DataGridView DataDisplay;
    }
}