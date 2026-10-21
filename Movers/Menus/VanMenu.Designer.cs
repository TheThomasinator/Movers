
namespace Movers
{
    partial class VanMenu
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.regTxt = new System.Windows.Forms.TextBox();
            this.sizeCbx = new System.Windows.Forms.ComboBox();
            this.aedBtn = new System.Windows.Forms.Button();
            this.mainMenuBtn = new System.Windows.Forms.Button();
            this.menuLbl = new System.Windows.Forms.Label();
            this.vanDGV = new System.Windows.Forms.DataGridView();
            this.exitBtn = new System.Windows.Forms.Button();
            this.regLbl = new System.Windows.Forms.Label();
            this.sizeLbl = new System.Windows.Forms.Label();
            this.pOrFLbl = new System.Windows.Forms.Label();
            this.makeTxt = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.vanDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // regTxt
            // 
            this.regTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regTxt.Location = new System.Drawing.Point(923, 298);
            this.regTxt.Name = "regTxt";
            this.regTxt.Size = new System.Drawing.Size(228, 31);
            this.regTxt.TabIndex = 42;
            this.regTxt.TextChanged += new System.EventHandler(this.regTxt_TextChanged);
            // 
            // sizeCbx
            // 
            this.sizeCbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sizeCbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sizeCbx.FormattingEnabled = true;
            this.sizeCbx.Location = new System.Drawing.Point(923, 219);
            this.sizeCbx.Name = "sizeCbx";
            this.sizeCbx.Size = new System.Drawing.Size(228, 33);
            this.sizeCbx.TabIndex = 38;
            this.sizeCbx.SelectedIndexChanged += new System.EventHandler(this.sizeCbx_SelectedIndexChanged);
            // 
            // aedBtn
            // 
            this.aedBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aedBtn.Location = new System.Drawing.Point(948, 508);
            this.aedBtn.Name = "aedBtn";
            this.aedBtn.Size = new System.Drawing.Size(203, 130);
            this.aedBtn.TabIndex = 34;
            this.aedBtn.Text = "Van AED";
            this.aedBtn.UseVisualStyleBackColor = true;
            this.aedBtn.Click += new System.EventHandler(this.aedBtn_Click);
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
            this.menuLbl.Location = new System.Drawing.Point(560, 68);
            this.menuLbl.Name = "menuLbl";
            this.menuLbl.Size = new System.Drawing.Size(244, 55);
            this.menuLbl.TabIndex = 32;
            this.menuLbl.Text = "Van Menu";
            // 
            // vanDGV
            // 
            this.vanDGV.AllowUserToAddRows = false;
            this.vanDGV.AllowUserToDeleteRows = false;
            this.vanDGV.AllowUserToOrderColumns = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.vanDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.vanDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.vanDGV.DefaultCellStyle = dataGridViewCellStyle4;
            this.vanDGV.Location = new System.Drawing.Point(76, 165);
            this.vanDGV.Name = "vanDGV";
            this.vanDGV.ReadOnly = true;
            this.vanDGV.Size = new System.Drawing.Size(820, 473);
            this.vanDGV.TabIndex = 31;
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
            // regLbl
            // 
            this.regLbl.AutoSize = true;
            this.regLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regLbl.Location = new System.Drawing.Point(918, 270);
            this.regLbl.Name = "regLbl";
            this.regLbl.Size = new System.Drawing.Size(188, 25);
            this.regLbl.TabIndex = 39;
            this.regLbl.Text = "Registration Plate:";
            // 
            // sizeLbl
            // 
            this.sizeLbl.AutoSize = true;
            this.sizeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sizeLbl.Location = new System.Drawing.Point(918, 191);
            this.sizeLbl.Name = "sizeLbl";
            this.sizeLbl.Size = new System.Drawing.Size(60, 25);
            this.sizeLbl.TabIndex = 35;
            this.sizeLbl.Text = "Size:";
            // 
            // pOrFLbl
            // 
            this.pOrFLbl.AutoSize = true;
            this.pOrFLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pOrFLbl.Location = new System.Drawing.Point(918, 349);
            this.pOrFLbl.Name = "pOrFLbl";
            this.pOrFLbl.Size = new System.Drawing.Size(71, 25);
            this.pOrFLbl.TabIndex = 40;
            this.pOrFLbl.Text = "Make:";
            // 
            // makeTxt
            // 
            this.makeTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.makeTxt.Location = new System.Drawing.Point(923, 377);
            this.makeTxt.Name = "makeTxt";
            this.makeTxt.Size = new System.Drawing.Size(228, 31);
            this.makeTxt.TabIndex = 36;
            this.makeTxt.TextChanged += new System.EventHandler(this.makeTxt_TextChanged);
            // 
            // VanMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.ControlBox = false;
            this.Controls.Add(this.regTxt);
            this.Controls.Add(this.pOrFLbl);
            this.Controls.Add(this.regLbl);
            this.Controls.Add(this.sizeCbx);
            this.Controls.Add(this.makeTxt);
            this.Controls.Add(this.sizeLbl);
            this.Controls.Add(this.aedBtn);
            this.Controls.Add(this.mainMenuBtn);
            this.Controls.Add(this.menuLbl);
            this.Controls.Add(this.vanDGV);
            this.Controls.Add(this.exitBtn);
            this.Name = "VanMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VanMenu";
            ((System.ComponentModel.ISupportInitialize)(this.vanDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox regTxt;
        private System.Windows.Forms.ComboBox sizeCbx;
        private System.Windows.Forms.Button aedBtn;
        private System.Windows.Forms.Button mainMenuBtn;
        private System.Windows.Forms.Label menuLbl;
        private System.Windows.Forms.DataGridView vanDGV;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Label regLbl;
        private System.Windows.Forms.Label sizeLbl;
        private System.Windows.Forms.Label pOrFLbl;
        private System.Windows.Forms.TextBox makeTxt;
    }
}