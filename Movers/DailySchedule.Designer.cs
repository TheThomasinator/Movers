
namespace Movers
{
    partial class DailySchedule
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
            this.mainMenuBtn = new System.Windows.Forms.Button();
            this.menuLbl = new System.Windows.Forms.Label();
            this.exitBtn = new System.Windows.Forms.Button();
            this.jobDgv = new System.Windows.Forms.DataGridView();
            this.maintenanceDgv = new System.Windows.Forms.DataGridView();
            this.trainingDgv = new System.Windows.Forms.DataGridView();
            this.dayLbl = new System.Windows.Forms.Label();
            this.reportBtn = new System.Windows.Forms.Button();
            this.dateDtp = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.jobDgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maintenanceDgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainingDgv)).BeginInit();
            this.SuspendLayout();
            // 
            // mainMenuBtn
            // 
            this.mainMenuBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainMenuBtn.Location = new System.Drawing.Point(969, 12);
            this.mainMenuBtn.Name = "mainMenuBtn";
            this.mainMenuBtn.Size = new System.Drawing.Size(203, 130);
            this.mainMenuBtn.TabIndex = 27;
            this.mainMenuBtn.Text = "Return to Main Menu";
            this.mainMenuBtn.UseVisualStyleBackColor = true;
            this.mainMenuBtn.Click += new System.EventHandler(this.mainMenuBtn_Click);
            // 
            // menuLbl
            // 
            this.menuLbl.AutoSize = true;
            this.menuLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuLbl.Location = new System.Drawing.Point(435, 44);
            this.menuLbl.Name = "menuLbl";
            this.menuLbl.Size = new System.Drawing.Size(344, 55);
            this.menuLbl.TabIndex = 26;
            this.menuLbl.Text = "Daily Schedule";
            // 
            // exitBtn
            // 
            this.exitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBtn.Location = new System.Drawing.Point(12, 12);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(110, 55);
            this.exitBtn.TabIndex = 25;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // jobDgv
            // 
            this.jobDgv.AllowUserToAddRows = false;
            this.jobDgv.AllowUserToDeleteRows = false;
            this.jobDgv.AllowUserToResizeColumns = false;
            this.jobDgv.AllowUserToResizeRows = false;
            this.jobDgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.jobDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.jobDgv.Location = new System.Drawing.Point(665, 181);
            this.jobDgv.Name = "jobDgv";
            this.jobDgv.ReadOnly = true;
            this.jobDgv.Size = new System.Drawing.Size(304, 456);
            this.jobDgv.TabIndex = 29;
            // 
            // maintenanceDgv
            // 
            this.maintenanceDgv.AllowUserToAddRows = false;
            this.maintenanceDgv.AllowUserToDeleteRows = false;
            this.maintenanceDgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.maintenanceDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.maintenanceDgv.Location = new System.Drawing.Point(355, 181);
            this.maintenanceDgv.Name = "maintenanceDgv";
            this.maintenanceDgv.ReadOnly = true;
            this.maintenanceDgv.Size = new System.Drawing.Size(304, 456);
            this.maintenanceDgv.TabIndex = 31;
            // 
            // trainingDgv
            // 
            this.trainingDgv.AllowUserToAddRows = false;
            this.trainingDgv.AllowUserToDeleteRows = false;
            this.trainingDgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.trainingDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.trainingDgv.Location = new System.Drawing.Point(45, 181);
            this.trainingDgv.Name = "trainingDgv";
            this.trainingDgv.ReadOnly = true;
            this.trainingDgv.Size = new System.Drawing.Size(304, 456);
            this.trainingDgv.TabIndex = 32;
            // 
            // dayLbl
            // 
            this.dayLbl.AutoSize = true;
            this.dayLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dayLbl.Location = new System.Drawing.Point(975, 181);
            this.dayLbl.Name = "dayLbl";
            this.dayLbl.Size = new System.Drawing.Size(126, 24);
            this.dayLbl.TabIndex = 33;
            this.dayLbl.Text = "Selected Day:";
            // 
            // reportBtn
            // 
            this.reportBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportBtn.Location = new System.Drawing.Point(975, 507);
            this.reportBtn.Name = "reportBtn";
            this.reportBtn.Size = new System.Drawing.Size(203, 130);
            this.reportBtn.TabIndex = 34;
            this.reportBtn.Text = "Create Report";
            this.reportBtn.UseVisualStyleBackColor = true;
            this.reportBtn.Click += new System.EventHandler(this.reportBtn_Click);
            // 
            // dateDtp
            // 
            this.dateDtp.CustomFormat = "dd-MM-yyyy";
            this.dateDtp.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateDtp.Location = new System.Drawing.Point(978, 208);
            this.dateDtp.Name = "dateDtp";
            this.dateDtp.Size = new System.Drawing.Size(200, 20);
            this.dateDtp.TabIndex = 35;
            this.dateDtp.ValueChanged += new System.EventHandler(this.dateDtp_ValueChanged);
            // 
            // DailySchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.ControlBox = false;
            this.Controls.Add(this.dateDtp);
            this.Controls.Add(this.reportBtn);
            this.Controls.Add(this.dayLbl);
            this.Controls.Add(this.trainingDgv);
            this.Controls.Add(this.maintenanceDgv);
            this.Controls.Add(this.jobDgv);
            this.Controls.Add(this.mainMenuBtn);
            this.Controls.Add(this.menuLbl);
            this.Controls.Add(this.exitBtn);
            this.Name = "DailySchedule";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DailySchedule";
            ((System.ComponentModel.ISupportInitialize)(this.jobDgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maintenanceDgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainingDgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button mainMenuBtn;
        private System.Windows.Forms.Label menuLbl;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.DataGridView jobDgv;
        private System.Windows.Forms.DataGridView maintenanceDgv;
        private System.Windows.Forms.DataGridView trainingDgv;
        private System.Windows.Forms.Label dayLbl;
        private System.Windows.Forms.Button reportBtn;
        private System.Windows.Forms.DateTimePicker dateDtp;
    }
}