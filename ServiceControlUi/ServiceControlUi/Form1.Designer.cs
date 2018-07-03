using System.Windows.Forms;

namespace ServiceControlUi
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tbMessage = new System.Windows.Forms.TextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.Automs_Disk = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.Automs_JSON = new System.Windows.Forms.TextBox();
            this.Delayms_Web = new System.Windows.Forms.TextBox();
            this.Automs_Web = new System.Windows.Forms.TextBox();
            this.Delayms_DB = new System.Windows.Forms.TextBox();
            this.Automs_DB = new System.Windows.Forms.TextBox();
            this.Automs = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.SaveStatus = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.chkAutoRestart_Memory = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Reset = new System.Windows.Forms.Button();
            this.chkAutoRestart = new System.Windows.Forms.CheckBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.UpdateClock_Disk = new System.Windows.Forms.Label();
            this.DiskView = new ServiceControlUi.ListViewNF();
            this.columnHeader17 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader18 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader19 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader20 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader21 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader22 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.UpdateClock_Web = new System.Windows.Forms.Label();
            this.Stop_btn = new System.Windows.Forms.Button();
            this.UpdateClock_DB = new System.Windows.Forms.Label();
            this.Start_btn = new System.Windows.Forms.Button();
            this.WebView = new ServiceControlUi.ListViewNF();
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader15 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.UpdateClock_Service = new System.Windows.Forms.Label();
            this.DBView = new ServiceControlUi.ListViewNF();
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AppServiceView = new ServiceControlUi.ListViewNF();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader16 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader23 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.chkAutoShutdown = new System.Windows.Forms.CheckBox();
            this.tabPage5.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.tbMessage);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(776, 601);
            this.tabPage5.TabIndex = 5;
            this.tabPage5.Text = "Message";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // tbMessage
            // 
            this.tbMessage.Location = new System.Drawing.Point(11, 13);
            this.tbMessage.Multiline = true;
            this.tbMessage.Name = "tbMessage";
            this.tbMessage.ReadOnly = true;
            this.tbMessage.Size = new System.Drawing.Size(753, 585);
            this.tbMessage.TabIndex = 6;
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.Gainsboro;
            this.tabPage4.Controls.Add(this.chkAutoShutdown);
            this.tabPage4.Controls.Add(this.Automs_Disk);
            this.tabPage4.Controls.Add(this.label1);
            this.tabPage4.Controls.Add(this.label18);
            this.tabPage4.Controls.Add(this.label19);
            this.tabPage4.Controls.Add(this.Automs_JSON);
            this.tabPage4.Controls.Add(this.Delayms_Web);
            this.tabPage4.Controls.Add(this.Automs_Web);
            this.tabPage4.Controls.Add(this.Delayms_DB);
            this.tabPage4.Controls.Add(this.Automs_DB);
            this.tabPage4.Controls.Add(this.Automs);
            this.tabPage4.Controls.Add(this.label15);
            this.tabPage4.Controls.Add(this.label16);
            this.tabPage4.Controls.Add(this.label17);
            this.tabPage4.Controls.Add(this.label13);
            this.tabPage4.Controls.Add(this.label14);
            this.tabPage4.Controls.Add(this.label11);
            this.tabPage4.Controls.Add(this.label12);
            this.tabPage4.Controls.Add(this.label10);
            this.tabPage4.Controls.Add(this.SaveStatus);
            this.tabPage4.Controls.Add(this.label8);
            this.tabPage4.Controls.Add(this.label9);
            this.tabPage4.Controls.Add(this.label7);
            this.tabPage4.Controls.Add(this.label6);
            this.tabPage4.Controls.Add(this.label4);
            this.tabPage4.Controls.Add(this.label3);
            this.tabPage4.Controls.Add(this.label5);
            this.tabPage4.Controls.Add(this.chkAutoRestart_Memory);
            this.tabPage4.Controls.Add(this.label2);
            this.tabPage4.Controls.Add(this.btn_Reset);
            this.tabPage4.Controls.Add(this.chkAutoRestart);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(776, 601);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Options";
            // 
            // Automs_Disk
            // 
            this.Automs_Disk.Location = new System.Drawing.Point(648, 47);
            this.Automs_Disk.Margin = new System.Windows.Forms.Padding(2);
            this.Automs_Disk.Name = "Automs_Disk";
            this.Automs_Disk.Size = new System.Drawing.Size(68, 22);
            this.Automs_Disk.TabIndex = 44;
            this.Automs_Disk.Text = "10";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(575, 51);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 12);
            this.label1.TabIndex = 43;
            this.label1.Text = "Refresh Time:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(720, 51);
            this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(19, 12);
            this.label18.TabIndex = 42;
            this.label18.Text = "sec";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(574, 21);
            this.label19.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(128, 16);
            this.label19.TabIndex = 41;
            this.label19.Text = "For DiskInfo";
            // 
            // Automs_JSON
            // 
            this.Automs_JSON.Location = new System.Drawing.Point(371, 233);
            this.Automs_JSON.Margin = new System.Windows.Forms.Padding(2);
            this.Automs_JSON.Name = "Automs_JSON";
            this.Automs_JSON.Size = new System.Drawing.Size(68, 22);
            this.Automs_JSON.TabIndex = 40;
            this.Automs_JSON.Text = "10";
            // 
            // Delayms_Web
            // 
            this.Delayms_Web.Location = new System.Drawing.Point(160, 261);
            this.Delayms_Web.Margin = new System.Windows.Forms.Padding(2);
            this.Delayms_Web.Name = "Delayms_Web";
            this.Delayms_Web.Size = new System.Drawing.Size(68, 22);
            this.Delayms_Web.TabIndex = 36;
            this.Delayms_Web.Text = "10";
            // 
            // Automs_Web
            // 
            this.Automs_Web.Location = new System.Drawing.Point(99, 233);
            this.Automs_Web.Margin = new System.Windows.Forms.Padding(2);
            this.Automs_Web.Name = "Automs_Web";
            this.Automs_Web.Size = new System.Drawing.Size(68, 22);
            this.Automs_Web.TabIndex = 33;
            this.Automs_Web.Text = "10";
            // 
            // Delayms_DB
            // 
            this.Delayms_DB.Location = new System.Drawing.Point(448, 85);
            this.Delayms_DB.Margin = new System.Windows.Forms.Padding(2);
            this.Delayms_DB.Name = "Delayms_DB";
            this.Delayms_DB.Size = new System.Drawing.Size(68, 22);
            this.Delayms_DB.TabIndex = 28;
            this.Delayms_DB.Text = "10";
            // 
            // Automs_DB
            // 
            this.Automs_DB.Location = new System.Drawing.Point(371, 55);
            this.Automs_DB.Margin = new System.Windows.Forms.Padding(2);
            this.Automs_DB.Name = "Automs_DB";
            this.Automs_DB.Size = new System.Drawing.Size(68, 22);
            this.Automs_DB.TabIndex = 21;
            this.Automs_DB.Text = "10";
            // 
            // Automs
            // 
            this.Automs.AllowDrop = true;
            this.Automs.Location = new System.Drawing.Point(98, 53);
            this.Automs.Margin = new System.Windows.Forms.Padding(2);
            this.Automs.Name = "Automs";
            this.Automs.Size = new System.Drawing.Size(68, 22);
            this.Automs.TabIndex = 16;
            this.Automs.Text = "10";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(296, 237);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(71, 12);
            this.label15.TabIndex = 39;
            this.label15.Text = "Refresh Time:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(443, 237);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(19, 12);
            this.label16.TabIndex = 38;
            this.label16.Text = "sec";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(295, 207);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(128, 16);
            this.label17.TabIndex = 37;
            this.label17.Text = "For SendJson";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(23, 263);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(133, 12);
            this.label13.TabIndex = 35;
            this.label13.Text = "Every Request Delay Time:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(236, 263);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(19, 12);
            this.label14.TabIndex = 34;
            this.label14.Text = "sec";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(23, 237);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(71, 12);
            this.label11.TabIndex = 32;
            this.label11.Text = "Refresh Time:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(169, 237);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(19, 12);
            this.label12.TabIndex = 31;
            this.label12.Text = "sec";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(22, 207);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(78, 16);
            this.label10.TabIndex = 30;
            this.label10.Text = "For Web";
            // 
            // SaveStatus
            // 
            this.SaveStatus.AutoSize = true;
            this.SaveStatus.Location = new System.Drawing.Point(11, 530);
            this.SaveStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SaveStatus.Name = "SaveStatus";
            this.SaveStatus.Size = new System.Drawing.Size(38, 12);
            this.SaveStatus.TabIndex = 29;
            this.SaveStatus.Text = "Status :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(296, 57);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 12);
            this.label8.TabIndex = 27;
            this.label8.Text = "Refresh Time:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(443, 58);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(19, 12);
            this.label9.TabIndex = 26;
            this.label9.Text = "sec";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 56);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 12);
            this.label7.TabIndex = 25;
            this.label7.Text = "Refresh Time:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(295, 21);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(178, 16);
            this.label6.TabIndex = 24;
            this.label6.Text = "For DBConnections";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(296, 87);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 12);
            this.label4.TabIndex = 23;
            this.label4.Text = "Every Connection Delay Time:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(517, 87);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 12);
            this.label3.TabIndex = 22;
            this.label3.Text = "sec";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(21, 21);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(168, 16);
            this.label5.TabIndex = 20;
            this.label5.Text = "For App/Services";
            // 
            // chkAutoRestart_Memory
            // 
            this.chkAutoRestart_Memory.AutoSize = true;
            this.chkAutoRestart_Memory.Checked = true;
            this.chkAutoRestart_Memory.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAutoRestart_Memory.Location = new System.Drawing.Point(24, 86);
            this.chkAutoRestart_Memory.Margin = new System.Windows.Forms.Padding(2);
            this.chkAutoRestart_Memory.Name = "chkAutoRestart_Memory";
            this.chkAutoRestart_Memory.Size = new System.Drawing.Size(125, 16);
            this.chkAutoRestart_Memory.TabIndex = 19;
            this.chkAutoRestart_Memory.Text = "AutoMemoryLeakFix";
            this.chkAutoRestart_Memory.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(168, 57);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 12);
            this.label2.TabIndex = 17;
            this.label2.Text = "sec";
            // 
            // btn_Reset
            // 
            this.btn_Reset.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btn_Reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Reset.Location = new System.Drawing.Point(648, 530);
            this.btn_Reset.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(107, 45);
            this.btn_Reset.TabIndex = 18;
            this.btn_Reset.Text = "Save";
            this.btn_Reset.UseVisualStyleBackColor = false;
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click_1);
            // 
            // chkAutoRestart
            // 
            this.chkAutoRestart.AutoSize = true;
            this.chkAutoRestart.Checked = true;
            this.chkAutoRestart.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAutoRestart.Location = new System.Drawing.Point(24, 113);
            this.chkAutoRestart.Name = "chkAutoRestart";
            this.chkAutoRestart.Size = new System.Drawing.Size(102, 16);
            this.chkAutoRestart.TabIndex = 15;
            this.chkAutoRestart.Text = "AutoStopToStart";
            this.chkAutoRestart.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Transparent;
            this.tabPage1.Controls.Add(this.UpdateClock_Disk);
            this.tabPage1.Controls.Add(this.DiskView);
            this.tabPage1.Controls.Add(this.UpdateClock_Web);
            this.tabPage1.Controls.Add(this.Stop_btn);
            this.tabPage1.Controls.Add(this.UpdateClock_DB);
            this.tabPage1.Controls.Add(this.Start_btn);
            this.tabPage1.Controls.Add(this.WebView);
            this.tabPage1.Controls.Add(this.UpdateClock_Service);
            this.tabPage1.Controls.Add(this.DBView);
            this.tabPage1.Controls.Add(this.AppServiceView);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(776, 601);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "DashBoard";
            // 
            // UpdateClock_Disk
            // 
            this.UpdateClock_Disk.AutoSize = true;
            this.UpdateClock_Disk.Location = new System.Drawing.Point(21, 61);
            this.UpdateClock_Disk.Name = "UpdateClock_Disk";
            this.UpdateClock_Disk.Size = new System.Drawing.Size(95, 12);
            this.UpdateClock_Disk.TabIndex = 46;
            this.UpdateClock_Disk.Text = "Disk_Update Time:";
            // 
            // DiskView
            // 
            this.DiskView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader17,
            this.columnHeader18,
            this.columnHeader19,
            this.columnHeader20,
            this.columnHeader21,
            this.columnHeader22});
            this.DiskView.Location = new System.Drawing.Point(18, 79);
            this.DiskView.Name = "DiskView";
            this.DiskView.Size = new System.Drawing.Size(737, 96);
            this.DiskView.TabIndex = 45;
            this.DiskView.UseCompatibleStateImageBehavior = false;
            this.DiskView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader17
            // 
            this.columnHeader17.Text = "Name";
            this.columnHeader17.Width = 49;
            // 
            // columnHeader18
            // 
            this.columnHeader18.Text = "Format";
            this.columnHeader18.Width = 73;
            // 
            // columnHeader19
            // 
            this.columnHeader19.Text = "AvailableSpace(B)";
            this.columnHeader19.Width = 103;
            // 
            // columnHeader20
            // 
            this.columnHeader20.Text = "TotalSize(B)";
            this.columnHeader20.Width = 95;
            // 
            // columnHeader21
            // 
            this.columnHeader21.Text = "Usage(%)";
            this.columnHeader21.Width = 101;
            // 
            // columnHeader22
            // 
            this.columnHeader22.Text = "LimitPercentage(%)";
            this.columnHeader22.Width = 104;
            // 
            // UpdateClock_Web
            // 
            this.UpdateClock_Web.AutoSize = true;
            this.UpdateClock_Web.Location = new System.Drawing.Point(21, 182);
            this.UpdateClock_Web.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.UpdateClock_Web.Name = "UpdateClock_Web";
            this.UpdateClock_Web.Size = new System.Drawing.Size(93, 12);
            this.UpdateClock_Web.TabIndex = 44;
            this.UpdateClock_Web.Text = "Web_UpdateTime:";
            // 
            // Stop_btn
            // 
            this.Stop_btn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Stop_btn.BackgroundImage = global::ServiceControlUi.Properties.Resources.if_stop_circle_o_1608388;
            this.Stop_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Stop_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Stop_btn.Font = new System.Drawing.Font("Lucida Console", 12F);
            this.Stop_btn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Stop_btn.Location = new System.Drawing.Point(679, 9);
            this.Stop_btn.Margin = new System.Windows.Forms.Padding(2);
            this.Stop_btn.Name = "Stop_btn";
            this.Stop_btn.Size = new System.Drawing.Size(50, 50);
            this.Stop_btn.TabIndex = 42;
            this.Stop_btn.UseVisualStyleBackColor = false;
            this.Stop_btn.Click += new System.EventHandler(this.Stop_btn_Click_1);
            // 
            // UpdateClock_DB
            // 
            this.UpdateClock_DB.AutoSize = true;
            this.UpdateClock_DB.Location = new System.Drawing.Point(21, 298);
            this.UpdateClock_DB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.UpdateClock_DB.Name = "UpdateClock_DB";
            this.UpdateClock_DB.Size = new System.Drawing.Size(87, 12);
            this.UpdateClock_DB.TabIndex = 43;
            this.UpdateClock_DB.Text = "DB_UpdateTime:";
            // 
            // Start_btn
            // 
            this.Start_btn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Start_btn.BackgroundImage = global::ServiceControlUi.Properties.Resources.if_f144_213224;
            this.Start_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Start_btn.Enabled = false;
            this.Start_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Start_btn.Font = new System.Drawing.Font("Lucida Console", 12F);
            this.Start_btn.Location = new System.Drawing.Point(613, 9);
            this.Start_btn.Margin = new System.Windows.Forms.Padding(2);
            this.Start_btn.Name = "Start_btn";
            this.Start_btn.Size = new System.Drawing.Size(50, 50);
            this.Start_btn.TabIndex = 41;
            this.Start_btn.UseVisualStyleBackColor = false;
            this.Start_btn.Click += new System.EventHandler(this.Start_btn_Click_1);
            // 
            // WebView
            // 
            this.WebView.BackgroundImageTiled = true;
            this.WebView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader13,
            this.columnHeader14,
            this.columnHeader15});
            this.WebView.Location = new System.Drawing.Point(18, 199);
            this.WebView.Margin = new System.Windows.Forms.Padding(2);
            this.WebView.Name = "WebView";
            this.WebView.Size = new System.Drawing.Size(737, 91);
            this.WebView.TabIndex = 3;
            this.WebView.UseCompatibleStateImageBehavior = false;
            this.WebView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "Sequence";
            // 
            // columnHeader14
            // 
            this.columnHeader14.Text = "HttpUrl";
            // 
            // columnHeader15
            // 
            this.columnHeader15.Text = "Status";
            // 
            // UpdateClock_Service
            // 
            this.UpdateClock_Service.AutoSize = true;
            this.UpdateClock_Service.Location = new System.Drawing.Point(21, 403);
            this.UpdateClock_Service.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.UpdateClock_Service.Name = "UpdateClock_Service";
            this.UpdateClock_Service.Size = new System.Drawing.Size(105, 12);
            this.UpdateClock_Service.TabIndex = 15;
            this.UpdateClock_Service.Text = "Service_UpdateTime:";
            // 
            // DBView
            // 
            this.DBView.BackgroundImageTiled = true;
            this.DBView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader12});
            this.DBView.Location = new System.Drawing.Point(18, 317);
            this.DBView.Margin = new System.Windows.Forms.Padding(2);
            this.DBView.Name = "DBView";
            this.DBView.Size = new System.Drawing.Size(737, 77);
            this.DBView.TabIndex = 5;
            this.DBView.UseCompatibleStateImageBehavior = false;
            this.DBView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Sequence";
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Data Source";
            this.columnHeader10.Width = 139;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "DBName";
            this.columnHeader11.Width = 145;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Status";
            // 
            // AppServiceView
            // 
            this.AppServiceView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader16,
            this.columnHeader23});
            this.AppServiceView.Location = new System.Drawing.Point(18, 419);
            this.AppServiceView.Margin = new System.Windows.Forms.Padding(2);
            this.AppServiceView.Name = "AppServiceView";
            this.AppServiceView.Size = new System.Drawing.Size(737, 167);
            this.AppServiceView.TabIndex = 7;
            this.AppServiceView.UseCompatibleStateImageBehavior = false;
            this.AppServiceView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Sequence";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "ServiceName";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Status";
            this.columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "PID";
            this.columnHeader4.Width = 100;
            // 
            // columnHeader5
            // 
            this.columnHeader5.DisplayIndex = 6;
            this.columnHeader5.Text = "Memory(MB)";
            this.columnHeader5.Width = 100;
            // 
            // columnHeader6
            // 
            this.columnHeader6.DisplayIndex = 4;
            this.columnHeader6.Text = "StartTime";
            this.columnHeader6.Width = 100;
            // 
            // columnHeader7
            // 
            this.columnHeader7.DisplayIndex = 5;
            this.columnHeader7.Text = "ProcessTotalTime";
            this.columnHeader7.Width = 100;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Memory Limit(MB)";
            this.columnHeader8.Width = 152;
            // 
            // columnHeader16
            // 
            this.columnHeader16.Text = "OpenPath";
            // 
            // columnHeader23
            // 
            this.columnHeader23.Text = "ShutDownTime";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.tabControl1.Location = new System.Drawing.Point(8, 8);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(784, 627);
            this.tabControl1.TabIndex = 15;
            // 
            // chkAutoShutdown
            // 
            this.chkAutoShutdown.AutoSize = true;
            this.chkAutoShutdown.Checked = true;
            this.chkAutoShutdown.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAutoShutdown.Location = new System.Drawing.Point(24, 138);
            this.chkAutoShutdown.Name = "chkAutoShutdown";
            this.chkAutoShutdown.Size = new System.Drawing.Size(94, 16);
            this.chkAutoShutdown.TabIndex = 45;
            this.chkAutoShutdown.Text = "AutoShutdown";
            this.chkAutoShutdown.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(807, 644);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WASD_Monitor";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TabPage tabPage5;
        private TextBox tbMessage;
        private TabPage tabPage4;
        private TextBox Automs_JSON;
        private TextBox Delayms_Web;
        private TextBox Automs_Web;
        private TextBox Delayms_DB;
        private TextBox Automs_DB;
        private TextBox Automs;
        private Label label15;
        private Label label16;
        private Label label17;
        private Label label13;
        private Label label14;
        private Label label11;
        private Label label12;
        private Label label10;
        private Label SaveStatus;
        private Label label8;
        private Label label9;
        private Label label7;
        private Label label6;
        private Label label4;
        private Label label3;
        private Label label5;
        private CheckBox chkAutoRestart_Memory;
        private Label label2;
        private Button btn_Reset;
        private CheckBox chkAutoRestart;
        private TabPage tabPage1;
        private Button Stop_btn;
        private ListViewNF WebView;
        private ColumnHeader columnHeader13;
        private ColumnHeader columnHeader14;
        private ColumnHeader columnHeader15;
        private Label UpdateClock_Service;
        private Button Start_btn;
        private ListViewNF DBView;
        private ColumnHeader columnHeader9;
        private ColumnHeader columnHeader10;
        private ColumnHeader columnHeader11;
        private ColumnHeader columnHeader12;
        private ListViewNF AppServiceView;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader8;
        private ColumnHeader columnHeader16;
        private TabControl tabControl1;
        private Label UpdateClock_Web;
        private Label UpdateClock_DB;
        private ListViewNF DiskView;
        private ColumnHeader columnHeader17;
        private ColumnHeader columnHeader18;
        private ColumnHeader columnHeader19;
        private ColumnHeader columnHeader20;
        private Label UpdateClock_Disk;
        private TextBox Automs_Disk;
        private Label label1;
        private Label label18;
        private Label label19;
        private ColumnHeader columnHeader21;
        private ColumnHeader columnHeader22;
        private ColumnHeader columnHeader23;
        private CheckBox chkAutoShutdown;
    }

    class ListViewNF : System.Windows.Forms.ListView
    {
        public ListViewNF()
        {
            // 开启双缓冲
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.AllPaintingInWmPaint, true);
            this.SetStyle(ControlStyles.EnableNotifyMessage, true);
        }

        protected override void OnNotifyMessage(Message m)
        {
            //Filter out the WM_ERASEBKGND message
            if (m.Msg != 0x14)
            {
                base.OnNotifyMessage(m);
            }
        }

        
    }
}

