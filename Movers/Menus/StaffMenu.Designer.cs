
namespace Movers
{
    partial class StaffMenu
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
            this.mainMenuBtn = new System.Windows.Forms.Button();
            this.menuLbl = new System.Windows.Forms.Label();
            this.staffDGV = new System.Windows.Forms.DataGridView();
            this.exitBtn = new System.Windows.Forms.Button();
            this.aedBtn = new System.Windows.Forms.Button();
            this.fNameLbl = new System.Windows.Forms.Label();
            this.fNameTxt = new System.Windows.Forms.TextBox();
            this.pOrFCbx = new System.Windows.Forms.ComboBox();
            this.titleCbx = new System.Windows.Forms.ComboBox();
            this.sNameLbl = new System.Windows.Forms.Label();
            this.pOrFLbl = new System.Windows.Forms.Label();
            this.titleLbl = new System.Windows.Forms.Label();
            this.sNameTxt = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.staffDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // mainMenuBtn
            // 
            this.mainMenuBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainMenuBtn.Location = new System.Drawing.Point(948, 12);
            this.mainMenuBtn.Name = "mainMenuBtn";
            this.mainMenuBtn.Size = new System.Drawing.Size(203, 130);
            this.mainMenuBtn.TabIndex = 16;
            this.mainMenuBtn.Text = "Return to Main Menu";
            this.mainMenuBtn.UseVisualStyleBackColor = true;
            this.mainMenuBtn.Click += new System.EventHandler(this.mainMenuBtn_Click);
            // 
            // menuLbl
            // 
            this.menuLbl.AutoSize = true;
            this.menuLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuLbl.Location = new System.Drawing.Point(560, 57);
            this.menuLbl.Name = "menuLbl";
            this.menuLbl.Size = new System.Drawing.Size(256, 55);
            this.menuLbl.TabIndex = 14;
            this.menuLbl.Text = "Staff Menu";
            // 
            // staffDGV
            // 
            this.staffDGV.AllowUserToAddRows = false;
            this.staffDGV.AllowUserToDeleteRows = false;
            this.staffDGV.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.staffDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.staffDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.staffDGV.DefaultCellStyle = dataGridViewCellStyle2;
            this.staffDGV.Location = new System.Drawing.Point(76, 154);
            this.staffDGV.Name = "staffDGV";
            this.staffDGV.ReadOnly = true;
            this.staffDGV.Size = new System.Drawing.Size(800, 473);
            this.staffDGV.TabIndex = 13;
            // 
            // exitBtn
            // 
            this.exitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBtn.Location = new System.Drawing.Point(33, 34);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(110, 55);
            this.exitBtn.TabIndex = 12;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // aedBtn
            // 
            this.aedBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aedBtn.Location = new System.Drawing.Point(948, 497);
            this.aedBtn.Name = "aedBtn";
            this.aedBtn.Size = new System.Drawing.Size(203, 130);
            this.aedBtn.TabIndex = 17;
            this.aedBtn.Text = "Staff AED";
            this.aedBtn.UseVisualStyleBackColor = true;
            this.aedBtn.Click += new System.EventHandler(this.aedBtn_Click);
            // 
            // fNameLbl
            // 
            this.fNameLbl.AutoSize = true;
            this.fNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fNameLbl.Location = new System.Drawing.Point(918, 180);
            this.fNameLbl.Name = "fNameLbl";
            this.fNameLbl.Size = new System.Drawing.Size(122, 25);
            this.fNameLbl.TabIndex = 18;
            this.fNameLbl.Text = "First Name:";
            // 
            // fNameTxt
            // 
            this.fNameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fNameTxt.Location = new System.Drawing.Point(923, 208);
            this.fNameTxt.Name = "fNameTxt";
            this.fNameTxt.Size = new System.Drawing.Size(228, 31);
            this.fNameTxt.TabIndex = 19;
            this.fNameTxt.TextChanged += new System.EventHandler(this.fNameTxt_TextChanged);
            // 
            // pOrFCbx
            // 
            this.pOrFCbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.pOrFCbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pOrFCbx.FormattingEnabled = true;
            this.pOrFCbx.Location = new System.Drawing.Point(923, 366);
            this.pOrFCbx.Name = "pOrFCbx";
            this.pOrFCbx.Size = new System.Drawing.Size(228, 33);
            this.pOrFCbx.TabIndex = 20;
            this.pOrFCbx.SelectedIndexChanged += new System.EventHandler(this.pOrFCbx_SelectedIndexChanged);
            // 
            // titleCbx
            // 
            this.titleCbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.titleCbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleCbx.FormattingEnabled = true;
            this.titleCbx.Location = new System.Drawing.Point(923, 446);
            this.titleCbx.Name = "titleCbx";
            this.titleCbx.Size = new System.Drawing.Size(228, 33);
            this.titleCbx.TabIndex = 25;
            this.titleCbx.SelectedIndexChanged += new System.EventHandler(this.titleCbx_SelectedIndexChanged);
            // 
            // sNameLbl
            // 
            this.sNameLbl.AutoSize = true;
            this.sNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sNameLbl.Location = new System.Drawing.Point(918, 259);
            this.sNameLbl.Name = "sNameLbl";
            this.sNameLbl.Size = new System.Drawing.Size(153, 25);
            this.sNameLbl.TabIndex = 26;
            this.sNameLbl.Text = "Second Name:";
            // 
            // pOrFLbl
            // 
            this.pOrFLbl.AutoSize = true;
            this.pOrFLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pOrFLbl.Location = new System.Drawing.Point(918, 338);
            this.pOrFLbl.Name = "pOrFLbl";
            this.pOrFLbl.Size = new System.Drawing.Size(169, 25);
            this.pOrFLbl.TabIndex = 27;
            this.pOrFLbl.Text = "Part or Full time:";
            // 
            // titleLbl
            // 
            this.titleLbl.AutoSize = true;
            this.titleLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLbl.Location = new System.Drawing.Point(918, 418);
            this.titleLbl.Name = "titleLbl";
            this.titleLbl.Size = new System.Drawing.Size(100, 25);
            this.titleLbl.TabIndex = 28;
            this.titleLbl.Text = "Job Title:";
            // 
            // sNameTxt
            // 
            this.sNameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sNameTxt.Location = new System.Drawing.Point(923, 287);
            this.sNameTxt.Name = "sNameTxt";
            this.sNameTxt.Size = new System.Drawing.Size(228, 31);
            this.sNameTxt.TabIndex = 29;
            this.sNameTxt.TextChanged += new System.EventHandler(this.sNameTxt_TextChanged);
            // 
            // StaffMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.ControlBox = false;
            this.Controls.Add(this.sNameTxt);
            this.Controls.Add(this.titleLbl);
            this.Controls.Add(this.pOrFLbl);
            this.Controls.Add(this.sNameLbl);
            this.Controls.Add(this.titleCbx);
            this.Controls.Add(this.pOrFCbx);
            this.Controls.Add(this.fNameTxt);
            this.Controls.Add(this.fNameLbl);
            this.Controls.Add(this.aedBtn);
            this.Controls.Add(this.mainMenuBtn);
            this.Controls.Add(this.menuLbl);
            this.Controls.Add(this.staffDGV);
            this.Controls.Add(this.exitBtn);
            this.Name = "StaffMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StaffMenu";
            ((System.ComponentModel.ISupportInitialize)(this.staffDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button mainMenuBtn;
        private System.Windows.Forms.Label menuLbl;
        private System.Windows.Forms.DataGridView staffDGV;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Button aedBtn;
        private System.Windows.Forms.Label fNameLbl;
        private System.Windows.Forms.TextBox fNameTxt;
        private System.Windows.Forms.ComboBox pOrFCbx;
        private System.Windows.Forms.ComboBox titleCbx;
        private System.Windows.Forms.Label sNameLbl;
        private System.Windows.Forms.Label pOrFLbl;
        private System.Windows.Forms.Label titleLbl;
        private System.Windows.Forms.TextBox sNameTxt;
    }
}