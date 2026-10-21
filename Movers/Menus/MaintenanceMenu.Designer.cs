
namespace Movers
{
    partial class MaintenanceMenu
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dateLbl = new System.Windows.Forms.Label();
            this.typeCbx = new System.Windows.Forms.ComboBox();
            this.typeLbl = new System.Windows.Forms.Label();
            this.aedBtn = new System.Windows.Forms.Button();
            this.mainMenuBtn = new System.Windows.Forms.Button();
            this.menuLbl = new System.Windows.Forms.Label();
            this.maintenanceDGV = new System.Windows.Forms.DataGridView();
            this.exitBtn = new System.Windows.Forms.Button();
            this.reportBtn = new System.Windows.Forms.Button();
            this.dateDtp = new System.Windows.Forms.DateTimePicker();
            this.durationLbl = new System.Windows.Forms.Label();
            this.durationCbx = new System.Windows.Forms.ComboBox();
            this.dateEnabler = new System.Windows.Forms.CheckBox();
            this.vanLbl = new System.Windows.Forms.Label();
            this.vanCbx = new System.Windows.Forms.ComboBox();
            this.mType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mDuration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mDriver = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mEngineer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mVan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mDetails = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.maintenanceDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // dateLbl
            // 
            this.dateLbl.AutoSize = true;
            this.dateLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLbl.Location = new System.Drawing.Point(943, 340);
            this.dateLbl.Name = "dateLbl";
            this.dateLbl.Size = new System.Drawing.Size(63, 25);
            this.dateLbl.TabIndex = 39;
            this.dateLbl.Text = "Date:";
            // 
            // typeCbx
            // 
            this.typeCbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.typeCbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typeCbx.FormattingEnabled = true;
            this.typeCbx.Location = new System.Drawing.Point(948, 295);
            this.typeCbx.Name = "typeCbx";
            this.typeCbx.Size = new System.Drawing.Size(203, 33);
            this.typeCbx.TabIndex = 37;
            this.typeCbx.SelectedIndexChanged += new System.EventHandler(this.typeCbx_SelectedIndexChanged);
            // 
            // typeLbl
            // 
            this.typeLbl.AutoSize = true;
            this.typeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typeLbl.Location = new System.Drawing.Point(943, 267);
            this.typeLbl.Name = "typeLbl";
            this.typeLbl.Size = new System.Drawing.Size(196, 25);
            this.typeLbl.TabIndex = 35;
            this.typeLbl.Text = "Maintenance Type:";
            // 
            // aedBtn
            // 
            this.aedBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aedBtn.Location = new System.Drawing.Point(948, 550);
            this.aedBtn.Name = "aedBtn";
            this.aedBtn.Size = new System.Drawing.Size(203, 99);
            this.aedBtn.TabIndex = 34;
            this.aedBtn.Text = "Maintenance AED";
            this.aedBtn.UseVisualStyleBackColor = true;
            this.aedBtn.Click += new System.EventHandler(this.aedBtn_Click);
            // 
            // mainMenuBtn
            // 
            this.mainMenuBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainMenuBtn.Location = new System.Drawing.Point(948, 12);
            this.mainMenuBtn.Name = "mainMenuBtn";
            this.mainMenuBtn.Size = new System.Drawing.Size(203, 117);
            this.mainMenuBtn.TabIndex = 33;
            this.mainMenuBtn.Text = "Return to Main Menu";
            this.mainMenuBtn.UseVisualStyleBackColor = true;
            this.mainMenuBtn.Click += new System.EventHandler(this.mainMenuBtn_Click);
            // 
            // menuLbl
            // 
            this.menuLbl.AutoSize = true;
            this.menuLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuLbl.Location = new System.Drawing.Point(459, 55);
            this.menuLbl.Name = "menuLbl";
            this.menuLbl.Size = new System.Drawing.Size(434, 55);
            this.menuLbl.TabIndex = 32;
            this.menuLbl.Text = "Maintenance Menu";
            // 
            // maintenanceDGV
            // 
            this.maintenanceDGV.AllowUserToAddRows = false;
            this.maintenanceDGV.AllowUserToDeleteRows = false;
            this.maintenanceDGV.AllowUserToResizeColumns = false;
            this.maintenanceDGV.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.maintenanceDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.maintenanceDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.maintenanceDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mType,
            this.mDate,
            this.mTime,
            this.mDuration,
            this.mDriver,
            this.mEngineer,
            this.mVan,
            this.mDetails});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.maintenanceDGV.DefaultCellStyle = dataGridViewCellStyle4;
            this.maintenanceDGV.Location = new System.Drawing.Point(74, 166);
            this.maintenanceDGV.Name = "maintenanceDGV";
            this.maintenanceDGV.ReadOnly = true;
            this.maintenanceDGV.ShowCellErrors = false;
            this.maintenanceDGV.Size = new System.Drawing.Size(830, 473);
            this.maintenanceDGV.TabIndex = 31;
            // 
            // exitBtn
            // 
            this.exitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBtn.Location = new System.Drawing.Point(33, 45);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(110, 55);
            this.exitBtn.TabIndex = 30;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // reportBtn
            // 
            this.reportBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportBtn.Location = new System.Drawing.Point(948, 140);
            this.reportBtn.Name = "reportBtn";
            this.reportBtn.Size = new System.Drawing.Size(203, 113);
            this.reportBtn.TabIndex = 42;
            this.reportBtn.Text = "Create Report";
            this.reportBtn.UseVisualStyleBackColor = true;
            this.reportBtn.Click += new System.EventHandler(this.reportBtn_Click);
            // 
            // dateDtp
            // 
            this.dateDtp.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateDtp.CustomFormat = "dd-MM-yyyy";
            this.dateDtp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateDtp.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateDtp.Location = new System.Drawing.Point(946, 368);
            this.dateDtp.Name = "dateDtp";
            this.dateDtp.Size = new System.Drawing.Size(205, 31);
            this.dateDtp.TabIndex = 43;
            this.dateDtp.ValueChanged += new System.EventHandler(this.dateDtp_ValueChanged);
            // 
            // durationLbl
            // 
            this.durationLbl.AutoSize = true;
            this.durationLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.durationLbl.Location = new System.Drawing.Point(943, 412);
            this.durationLbl.Name = "durationLbl";
            this.durationLbl.Size = new System.Drawing.Size(99, 25);
            this.durationLbl.TabIndex = 45;
            this.durationLbl.Text = "Duration:";
            // 
            // durationCbx
            // 
            this.durationCbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.durationCbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.durationCbx.FormattingEnabled = true;
            this.durationCbx.Location = new System.Drawing.Point(946, 440);
            this.durationCbx.Name = "durationCbx";
            this.durationCbx.Size = new System.Drawing.Size(203, 33);
            this.durationCbx.TabIndex = 46;
            this.durationCbx.SelectedIndexChanged += new System.EventHandler(this.durationCbx_SelectedIndexChanged);
            // 
            // dateEnabler
            // 
            this.dateEnabler.AutoSize = true;
            this.dateEnabler.Location = new System.Drawing.Point(1013, 345);
            this.dateEnabler.Name = "dateEnabler";
            this.dateEnabler.Size = new System.Drawing.Size(59, 17);
            this.dateEnabler.TabIndex = 47;
            this.dateEnabler.Text = "Enable";
            this.dateEnabler.UseVisualStyleBackColor = true;
            this.dateEnabler.CheckedChanged += new System.EventHandler(this.dateEnabler_CheckedChanged);
            // 
            // vanLbl
            // 
            this.vanLbl.AutoSize = true;
            this.vanLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vanLbl.Location = new System.Drawing.Point(943, 483);
            this.vanLbl.Name = "vanLbl";
            this.vanLbl.Size = new System.Drawing.Size(56, 25);
            this.vanLbl.TabIndex = 48;
            this.vanLbl.Text = "Van:";
            // 
            // vanCbx
            // 
            this.vanCbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.vanCbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vanCbx.FormattingEnabled = true;
            this.vanCbx.Location = new System.Drawing.Point(946, 511);
            this.vanCbx.Name = "vanCbx";
            this.vanCbx.Size = new System.Drawing.Size(203, 33);
            this.vanCbx.TabIndex = 49;
            this.vanCbx.SelectedIndexChanged += new System.EventHandler(this.vanCbx_SelectedIndexChanged);
            // 
            // mType
            // 
            this.mType.HeaderText = "Type";
            this.mType.Name = "mType";
            this.mType.ReadOnly = true;
            // 
            // mDate
            // 
            dataGridViewCellStyle2.Format = "d";
            dataGridViewCellStyle2.NullValue = null;
            this.mDate.DefaultCellStyle = dataGridViewCellStyle2;
            this.mDate.HeaderText = "Date";
            this.mDate.Name = "mDate";
            this.mDate.ReadOnly = true;
            // 
            // mTime
            // 
            dataGridViewCellStyle3.Format = "t";
            dataGridViewCellStyle3.NullValue = null;
            this.mTime.DefaultCellStyle = dataGridViewCellStyle3;
            this.mTime.HeaderText = "Time";
            this.mTime.Name = "mTime";
            this.mTime.ReadOnly = true;
            // 
            // mDuration
            // 
            this.mDuration.HeaderText = "Duration";
            this.mDuration.Name = "mDuration";
            this.mDuration.ReadOnly = true;
            // 
            // mDriver
            // 
            this.mDriver.HeaderText = "Driver";
            this.mDriver.Name = "mDriver";
            this.mDriver.ReadOnly = true;
            // 
            // mEngineer
            // 
            this.mEngineer.HeaderText = "Engineer";
            this.mEngineer.Name = "mEngineer";
            this.mEngineer.ReadOnly = true;
            // 
            // mVan
            // 
            this.mVan.HeaderText = "Van";
            this.mVan.Name = "mVan";
            this.mVan.ReadOnly = true;
            // 
            // mDetails
            // 
            this.mDetails.HeaderText = "Details";
            this.mDetails.Name = "mDetails";
            this.mDetails.ReadOnly = true;
            // 
            // MaintenanceMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.ControlBox = false;
            this.Controls.Add(this.vanCbx);
            this.Controls.Add(this.vanLbl);
            this.Controls.Add(this.dateEnabler);
            this.Controls.Add(this.durationCbx);
            this.Controls.Add(this.durationLbl);
            this.Controls.Add(this.dateDtp);
            this.Controls.Add(this.reportBtn);
            this.Controls.Add(this.dateLbl);
            this.Controls.Add(this.typeCbx);
            this.Controls.Add(this.typeLbl);
            this.Controls.Add(this.aedBtn);
            this.Controls.Add(this.mainMenuBtn);
            this.Controls.Add(this.menuLbl);
            this.Controls.Add(this.maintenanceDGV);
            this.Controls.Add(this.exitBtn);
            this.Name = "MaintenanceMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MaintenanceMenu";
            ((System.ComponentModel.ISupportInitialize)(this.maintenanceDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label dateLbl;
        private System.Windows.Forms.ComboBox typeCbx;
        private System.Windows.Forms.Label typeLbl;
        private System.Windows.Forms.Button aedBtn;
        private System.Windows.Forms.Button mainMenuBtn;
        private System.Windows.Forms.Label menuLbl;
        private System.Windows.Forms.DataGridView maintenanceDGV;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Button reportBtn;
        private System.Windows.Forms.DateTimePicker dateDtp;
        private System.Windows.Forms.Label durationLbl;
        private System.Windows.Forms.ComboBox durationCbx;
        private System.Windows.Forms.CheckBox dateEnabler;
        private System.Windows.Forms.Label vanLbl;
        private System.Windows.Forms.ComboBox vanCbx;
        private System.Windows.Forms.DataGridViewTextBoxColumn mType;
        private System.Windows.Forms.DataGridViewTextBoxColumn mDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn mTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn mDuration;
        private System.Windows.Forms.DataGridViewTextBoxColumn mDriver;
        private System.Windows.Forms.DataGridViewTextBoxColumn mEngineer;
        private System.Windows.Forms.DataGridViewTextBoxColumn mVan;
        private System.Windows.Forms.DataGridViewTextBoxColumn mDetails;
    }
}