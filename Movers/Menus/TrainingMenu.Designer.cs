
namespace Movers
{
    partial class TrainingMenu
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
            this.typeLbl = new System.Windows.Forms.Label();
            this.staffLbl = new System.Windows.Forms.Label();
            this.mainMenuBtn = new System.Windows.Forms.Button();
            this.menuLbl = new System.Windows.Forms.Label();
            this.trainingDGV = new System.Windows.Forms.DataGridView();
            this.exitBtn = new System.Windows.Forms.Button();
            this.reportBtn = new System.Windows.Forms.Button();
            this.staffCbx = new System.Windows.Forms.ComboBox();
            this.dateDtp = new System.Windows.Forms.DateTimePicker();
            this.durationLbl = new System.Windows.Forms.Label();
            this.durationCbx = new System.Windows.Forms.ComboBox();
            this.typeCbx = new System.Windows.Forms.ComboBox();
            this.dateEnabler = new System.Windows.Forms.CheckBox();
            this.aedBtn = new System.Windows.Forms.Button();
            this.tType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mDuration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tStaff = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.trainingDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // dateLbl
            // 
            this.dateLbl.AutoSize = true;
            this.dateLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLbl.Location = new System.Drawing.Point(918, 344);
            this.dateLbl.Name = "dateLbl";
            this.dateLbl.Size = new System.Drawing.Size(69, 25);
            this.dateLbl.TabIndex = 39;
            this.dateLbl.Text = "Date: ";
            // 
            // typeLbl
            // 
            this.typeLbl.AutoSize = true;
            this.typeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typeLbl.Location = new System.Drawing.Point(918, 273);
            this.typeLbl.Name = "typeLbl";
            this.typeLbl.Size = new System.Drawing.Size(150, 25);
            this.typeLbl.TabIndex = 38;
            this.typeLbl.Text = "Training Type:";
            // 
            // staffLbl
            // 
            this.staffLbl.AutoSize = true;
            this.staffLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staffLbl.Location = new System.Drawing.Point(918, 200);
            this.staffLbl.Name = "staffLbl";
            this.staffLbl.Size = new System.Drawing.Size(146, 25);
            this.staffLbl.TabIndex = 34;
            this.staffLbl.Text = "Staff Member:";
            // 
            // mainMenuBtn
            // 
            this.mainMenuBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainMenuBtn.Location = new System.Drawing.Point(948, 23);
            this.mainMenuBtn.Name = "mainMenuBtn";
            this.mainMenuBtn.Size = new System.Drawing.Size(203, 130);
            this.mainMenuBtn.TabIndex = 33;
            this.mainMenuBtn.Text = "Return to Main Menu";
            this.mainMenuBtn.UseVisualStyleBackColor = true;
            this.mainMenuBtn.Click += new System.EventHandler(this.mainMenuBtn_Click);
            // 
            // menuLbl
            // 
            this.menuLbl.AutoSize = true;
            this.menuLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuLbl.Location = new System.Drawing.Point(293, 55);
            this.menuLbl.Name = "menuLbl";
            this.menuLbl.Size = new System.Drawing.Size(331, 55);
            this.menuLbl.TabIndex = 32;
            this.menuLbl.Text = "Training Menu";
            // 
            // trainingDGV
            // 
            this.trainingDGV.AllowUserToAddRows = false;
            this.trainingDGV.AllowUserToDeleteRows = false;
            this.trainingDGV.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.trainingDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.trainingDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.trainingDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tType,
            this.mDate,
            this.mTime,
            this.mDuration,
            this.tStaff});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.trainingDGV.DefaultCellStyle = dataGridViewCellStyle4;
            this.trainingDGV.Location = new System.Drawing.Point(33, 165);
            this.trainingDGV.Name = "trainingDGV";
            this.trainingDGV.ReadOnly = true;
            this.trainingDGV.Size = new System.Drawing.Size(879, 473);
            this.trainingDGV.TabIndex = 31;
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
            this.reportBtn.Location = new System.Drawing.Point(709, 23);
            this.reportBtn.Name = "reportBtn";
            this.reportBtn.Size = new System.Drawing.Size(203, 130);
            this.reportBtn.TabIndex = 43;
            this.reportBtn.Text = "Create Report";
            this.reportBtn.UseVisualStyleBackColor = true;
            this.reportBtn.Click += new System.EventHandler(this.reportBtn_Click);
            // 
            // staffCbx
            // 
            this.staffCbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.staffCbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staffCbx.FormattingEnabled = true;
            this.staffCbx.Location = new System.Drawing.Point(923, 228);
            this.staffCbx.Name = "staffCbx";
            this.staffCbx.Size = new System.Drawing.Size(228, 33);
            this.staffCbx.TabIndex = 44;
            this.staffCbx.SelectedIndexChanged += new System.EventHandler(this.staffCbx_SelectedIndexChanged);
            // 
            // dateDtp
            // 
            this.dateDtp.CustomFormat = "dd-MM-yyy";
            this.dateDtp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateDtp.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateDtp.Location = new System.Drawing.Point(923, 372);
            this.dateDtp.Name = "dateDtp";
            this.dateDtp.Size = new System.Drawing.Size(228, 31);
            this.dateDtp.TabIndex = 45;
            this.dateDtp.ValueChanged += new System.EventHandler(this.dateDtp_ValueChanged);
            // 
            // durationLbl
            // 
            this.durationLbl.AutoSize = true;
            this.durationLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.durationLbl.Location = new System.Drawing.Point(918, 415);
            this.durationLbl.Name = "durationLbl";
            this.durationLbl.Size = new System.Drawing.Size(99, 25);
            this.durationLbl.TabIndex = 47;
            this.durationLbl.Text = "Duration:";
            // 
            // durationCbx
            // 
            this.durationCbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.durationCbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.durationCbx.FormattingEnabled = true;
            this.durationCbx.Location = new System.Drawing.Point(923, 443);
            this.durationCbx.Name = "durationCbx";
            this.durationCbx.Size = new System.Drawing.Size(228, 33);
            this.durationCbx.TabIndex = 46;
            this.durationCbx.SelectedIndexChanged += new System.EventHandler(this.durationCbx_SelectedIndexChanged);
            // 
            // typeCbx
            // 
            this.typeCbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.typeCbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typeCbx.FormattingEnabled = true;
            this.typeCbx.Location = new System.Drawing.Point(923, 301);
            this.typeCbx.Name = "typeCbx";
            this.typeCbx.Size = new System.Drawing.Size(228, 33);
            this.typeCbx.TabIndex = 50;
            this.typeCbx.SelectedIndexChanged += new System.EventHandler(this.typeCbx_SelectedIndexChanged);
            // 
            // dateEnabler
            // 
            this.dateEnabler.AutoSize = true;
            this.dateEnabler.Location = new System.Drawing.Point(982, 349);
            this.dateEnabler.Name = "dateEnabler";
            this.dateEnabler.Size = new System.Drawing.Size(65, 17);
            this.dateEnabler.TabIndex = 51;
            this.dateEnabler.Text = "Enabled";
            this.dateEnabler.UseVisualStyleBackColor = true;
            this.dateEnabler.CheckedChanged += new System.EventHandler(this.dateEnabler_CheckedChanged);
            // 
            // aedBtn
            // 
            this.aedBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aedBtn.Location = new System.Drawing.Point(948, 508);
            this.aedBtn.Name = "aedBtn";
            this.aedBtn.Size = new System.Drawing.Size(203, 130);
            this.aedBtn.TabIndex = 52;
            this.aedBtn.Text = "Training AED";
            this.aedBtn.UseVisualStyleBackColor = true;
            this.aedBtn.Click += new System.EventHandler(this.aedBtn_Click_1);
            // 
            // tType
            // 
            this.tType.HeaderText = "Training Type";
            this.tType.Name = "tType";
            this.tType.ReadOnly = true;
            this.tType.Width = 167;
            // 
            // mDate
            // 
            dataGridViewCellStyle2.Format = "d";
            dataGridViewCellStyle2.NullValue = null;
            this.mDate.DefaultCellStyle = dataGridViewCellStyle2;
            this.mDate.HeaderText = "Date";
            this.mDate.Name = "mDate";
            this.mDate.ReadOnly = true;
            this.mDate.Width = 167;
            // 
            // mTime
            // 
            dataGridViewCellStyle3.Format = "t";
            dataGridViewCellStyle3.NullValue = null;
            this.mTime.DefaultCellStyle = dataGridViewCellStyle3;
            this.mTime.HeaderText = "Time";
            this.mTime.Name = "mTime";
            this.mTime.ReadOnly = true;
            this.mTime.Width = 168;
            // 
            // mDuration
            // 
            this.mDuration.HeaderText = "Duration";
            this.mDuration.Name = "mDuration";
            this.mDuration.ReadOnly = true;
            this.mDuration.Width = 167;
            // 
            // tStaff
            // 
            this.tStaff.HeaderText = "Staff Members";
            this.tStaff.Name = "tStaff";
            this.tStaff.ReadOnly = true;
            this.tStaff.Width = 167;
            // 
            // TrainingMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.ControlBox = false;
            this.Controls.Add(this.aedBtn);
            this.Controls.Add(this.dateEnabler);
            this.Controls.Add(this.typeCbx);
            this.Controls.Add(this.durationLbl);
            this.Controls.Add(this.durationCbx);
            this.Controls.Add(this.dateDtp);
            this.Controls.Add(this.staffCbx);
            this.Controls.Add(this.reportBtn);
            this.Controls.Add(this.dateLbl);
            this.Controls.Add(this.typeLbl);
            this.Controls.Add(this.staffLbl);
            this.Controls.Add(this.mainMenuBtn);
            this.Controls.Add(this.menuLbl);
            this.Controls.Add(this.trainingDGV);
            this.Controls.Add(this.exitBtn);
            this.Name = "TrainingMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TrainingMenu";
            this.Load += new System.EventHandler(this.TrainingMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trainingDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label dateLbl;
        private System.Windows.Forms.Label typeLbl;
        private System.Windows.Forms.Label staffLbl;
        private System.Windows.Forms.Button mainMenuBtn;
        private System.Windows.Forms.Label menuLbl;
        private System.Windows.Forms.DataGridView trainingDGV;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Button reportBtn;
        private System.Windows.Forms.ComboBox staffCbx;
        private System.Windows.Forms.DateTimePicker dateDtp;
        private System.Windows.Forms.Label durationLbl;
        private System.Windows.Forms.ComboBox durationCbx;
        private System.Windows.Forms.ComboBox typeCbx;
        private System.Windows.Forms.CheckBox dateEnabler;
        private System.Windows.Forms.Button aedBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tType;
        private System.Windows.Forms.DataGridViewTextBoxColumn mDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn mTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn mDuration;
        private System.Windows.Forms.DataGridViewTextBoxColumn tStaff;
    }
}