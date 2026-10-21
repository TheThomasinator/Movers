
namespace Movers
{
    partial class BookingsNeeded
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bookingTabs = new System.Windows.Forms.TabControl();
            this.staffTab = new System.Windows.Forms.TabPage();
            this.staffCbx = new System.Windows.Forms.ComboBox();
            this.staffLbl = new System.Windows.Forms.Label();
            this.staffReportBtn = new System.Windows.Forms.Button();
            this.staffDgv = new System.Windows.Forms.DataGridView();
            this.vanTab = new System.Windows.Forms.TabPage();
            this.vanCbx = new System.Windows.Forms.ComboBox();
            this.vanLbl = new System.Windows.Forms.Label();
            this.vanReportBtn = new System.Windows.Forms.Button();
            this.vanDgv = new System.Windows.Forms.DataGridView();
            this.menuBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.position = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vanID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vanReg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookingTabs.SuspendLayout();
            this.staffTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.staffDgv)).BeginInit();
            this.vanTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vanDgv)).BeginInit();
            this.SuspendLayout();
            // 
            // bookingTabs
            // 
            this.bookingTabs.Controls.Add(this.staffTab);
            this.bookingTabs.Controls.Add(this.vanTab);
            this.bookingTabs.Location = new System.Drawing.Point(23, 95);
            this.bookingTabs.Name = "bookingTabs";
            this.bookingTabs.SelectedIndex = 0;
            this.bookingTabs.Size = new System.Drawing.Size(1139, 554);
            this.bookingTabs.TabIndex = 28;
            // 
            // staffTab
            // 
            this.staffTab.Controls.Add(this.staffCbx);
            this.staffTab.Controls.Add(this.staffLbl);
            this.staffTab.Controls.Add(this.staffReportBtn);
            this.staffTab.Controls.Add(this.staffDgv);
            this.staffTab.Location = new System.Drawing.Point(4, 22);
            this.staffTab.Name = "staffTab";
            this.staffTab.Padding = new System.Windows.Forms.Padding(3);
            this.staffTab.Size = new System.Drawing.Size(1131, 528);
            this.staffTab.TabIndex = 0;
            this.staffTab.Text = "Staff";
            this.staffTab.UseVisualStyleBackColor = true;
            // 
            // staffCbx
            // 
            this.staffCbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.staffCbx.DropDownWidth = 450;
            this.staffCbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staffCbx.FormattingEnabled = true;
            this.staffCbx.Location = new System.Drawing.Point(937, 122);
            this.staffCbx.Name = "staffCbx";
            this.staffCbx.Size = new System.Drawing.Size(172, 41);
            this.staffCbx.TabIndex = 53;
            this.staffCbx.SelectedIndexChanged += new System.EventHandler(this.staffCbx_SelectedIndexChanged);
            // 
            // staffLbl
            // 
            this.staffLbl.AutoSize = true;
            this.staffLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staffLbl.Location = new System.Drawing.Point(931, 88);
            this.staffLbl.Name = "staffLbl";
            this.staffLbl.Size = new System.Drawing.Size(79, 31);
            this.staffLbl.TabIndex = 32;
            this.staffLbl.Text = "Staff:";
            // 
            // staffReportBtn
            // 
            this.staffReportBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staffReportBtn.Location = new System.Drawing.Point(937, 410);
            this.staffReportBtn.Name = "staffReportBtn";
            this.staffReportBtn.Size = new System.Drawing.Size(172, 100);
            this.staffReportBtn.TabIndex = 30;
            this.staffReportBtn.Text = "Create Report";
            this.staffReportBtn.UseVisualStyleBackColor = true;
            this.staffReportBtn.Click += new System.EventHandler(this.staffReportBtn_Click);
            // 
            // staffDgv
            // 
            this.staffDgv.AllowUserToAddRows = false;
            this.staffDgv.AllowUserToDeleteRows = false;
            this.staffDgv.AllowUserToResizeColumns = false;
            this.staffDgv.AllowUserToResizeRows = false;
            this.staffDgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.staffDgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.staffDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.staffDgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name,
            this.position,
            this.sType,
            this.sDate,
            this.lastDate});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.staffDgv.DefaultCellStyle = dataGridViewCellStyle2;
            this.staffDgv.Location = new System.Drawing.Point(27, 27);
            this.staffDgv.Name = "staffDgv";
            this.staffDgv.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.staffDgv.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.staffDgv.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.staffDgv.Size = new System.Drawing.Size(888, 495);
            this.staffDgv.TabIndex = 12;
            // 
            // vanTab
            // 
            this.vanTab.Controls.Add(this.vanCbx);
            this.vanTab.Controls.Add(this.vanLbl);
            this.vanTab.Controls.Add(this.vanReportBtn);
            this.vanTab.Controls.Add(this.vanDgv);
            this.vanTab.Location = new System.Drawing.Point(4, 22);
            this.vanTab.Name = "vanTab";
            this.vanTab.Padding = new System.Windows.Forms.Padding(3);
            this.vanTab.Size = new System.Drawing.Size(1131, 528);
            this.vanTab.TabIndex = 1;
            this.vanTab.Text = "Van";
            this.vanTab.UseVisualStyleBackColor = true;
            // 
            // vanCbx
            // 
            this.vanCbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.vanCbx.DropDownWidth = 450;
            this.vanCbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vanCbx.FormattingEnabled = true;
            this.vanCbx.Location = new System.Drawing.Point(943, 122);
            this.vanCbx.Name = "vanCbx";
            this.vanCbx.Size = new System.Drawing.Size(172, 41);
            this.vanCbx.TabIndex = 58;
            this.vanCbx.SelectedIndexChanged += new System.EventHandler(this.vanCbx_SelectedIndexChanged);
            // 
            // vanLbl
            // 
            this.vanLbl.AutoSize = true;
            this.vanLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vanLbl.Location = new System.Drawing.Point(937, 88);
            this.vanLbl.Name = "vanLbl";
            this.vanLbl.Size = new System.Drawing.Size(70, 31);
            this.vanLbl.TabIndex = 56;
            this.vanLbl.Text = "Van:";
            // 
            // vanReportBtn
            // 
            this.vanReportBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vanReportBtn.Location = new System.Drawing.Point(943, 410);
            this.vanReportBtn.Name = "vanReportBtn";
            this.vanReportBtn.Size = new System.Drawing.Size(172, 100);
            this.vanReportBtn.TabIndex = 55;
            this.vanReportBtn.Text = "Create Report";
            this.vanReportBtn.UseVisualStyleBackColor = true;
            this.vanReportBtn.Click += new System.EventHandler(this.vanReportBtn_Click);
            // 
            // vanDgv
            // 
            this.vanDgv.AllowUserToAddRows = false;
            this.vanDgv.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.vanDgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.vanDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vanDgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.vanID,
            this.vanReg,
            this.type,
            this.date,
            this.lastM});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.vanDgv.DefaultCellStyle = dataGridViewCellStyle6;
            this.vanDgv.Location = new System.Drawing.Point(27, 28);
            this.vanDgv.Name = "vanDgv";
            this.vanDgv.ReadOnly = true;
            this.vanDgv.Size = new System.Drawing.Size(890, 494);
            this.vanDgv.TabIndex = 12;
            // 
            // menuBtn
            // 
            this.menuBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuBtn.Location = new System.Drawing.Point(1012, 12);
            this.menuBtn.Name = "menuBtn";
            this.menuBtn.Size = new System.Drawing.Size(150, 77);
            this.menuBtn.TabIndex = 27;
            this.menuBtn.Text = "Return to Main Menu";
            this.menuBtn.UseVisualStyleBackColor = true;
            this.menuBtn.Click += new System.EventHandler(this.menuBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBtn.Location = new System.Drawing.Point(23, 34);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(110, 55);
            this.exitBtn.TabIndex = 26;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // id
            // 
            this.id.HeaderText = "Staff Id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // name
            // 
            this.name.HeaderText = "Staff Name";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // position
            // 
            this.position.HeaderText = "Staff Position ";
            this.position.Name = "position";
            this.position.ReadOnly = true;
            // 
            // sType
            // 
            this.sType.HeaderText = "Type Needed";
            this.sType.Name = "sType";
            this.sType.ReadOnly = true;
            // 
            // sDate
            // 
            this.sDate.HeaderText = "Date Needed";
            this.sDate.Name = "sDate";
            this.sDate.ReadOnly = true;
            // 
            // lastDate
            // 
            this.lastDate.HeaderText = "Last Training";
            this.lastDate.Name = "lastDate";
            this.lastDate.ReadOnly = true;
            // 
            // vanID
            // 
            this.vanID.HeaderText = "Van Id";
            this.vanID.Name = "vanID";
            this.vanID.ReadOnly = true;
            this.vanID.Width = 169;
            // 
            // vanReg
            // 
            this.vanReg.HeaderText = "Van Registration";
            this.vanReg.Name = "vanReg";
            this.vanReg.ReadOnly = true;
            this.vanReg.Width = 170;
            // 
            // type
            // 
            this.type.HeaderText = "Type Needed";
            this.type.Name = "type";
            this.type.ReadOnly = true;
            this.type.Width = 169;
            // 
            // date
            // 
            dataGridViewCellStyle5.Format = "d";
            dataGridViewCellStyle5.NullValue = null;
            this.date.DefaultCellStyle = dataGridViewCellStyle5;
            this.date.HeaderText = "Date Needed";
            this.date.Name = "date";
            this.date.ReadOnly = true;
            this.date.Width = 170;
            // 
            // lastM
            // 
            this.lastM.HeaderText = "Last Maintenance";
            this.lastM.Name = "lastM";
            this.lastM.ReadOnly = true;
            this.lastM.Width = 169;
            // 
            // BookingsNeeded
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.ControlBox = false;
            this.Controls.Add(this.bookingTabs);
            this.Controls.Add(this.menuBtn);
            this.Controls.Add(this.exitBtn);
            this.Name = "BookingsNeeded";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BookingsNeeded";
            this.bookingTabs.ResumeLayout(false);
            this.staffTab.ResumeLayout(false);
            this.staffTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.staffDgv)).EndInit();
            this.vanTab.ResumeLayout(false);
            this.vanTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vanDgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl bookingTabs;
        private System.Windows.Forms.TabPage staffTab;
        private System.Windows.Forms.ComboBox staffCbx;
        private System.Windows.Forms.Label staffLbl;
        private System.Windows.Forms.Button staffReportBtn;
        private System.Windows.Forms.DataGridView staffDgv;
        private System.Windows.Forms.TabPage vanTab;
        private System.Windows.Forms.ComboBox vanCbx;
        private System.Windows.Forms.Label vanLbl;
        private System.Windows.Forms.Button vanReportBtn;
        private System.Windows.Forms.DataGridView vanDgv;
        private System.Windows.Forms.Button menuBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn position;
        private System.Windows.Forms.DataGridViewTextBoxColumn sType;
        private System.Windows.Forms.DataGridViewTextBoxColumn sDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn vanID;
        private System.Windows.Forms.DataGridViewTextBoxColumn vanReg;
        private System.Windows.Forms.DataGridViewTextBoxColumn type;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastM;
    }
}