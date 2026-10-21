
namespace Movers
{
    partial class StockMenu
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
            this.aedBtn = new System.Windows.Forms.Button();
            this.mainMenuBtn = new System.Windows.Forms.Button();
            this.reportBtn = new System.Windows.Forms.Button();
            this.menuLbl = new System.Windows.Forms.Label();
            this.stockDGV = new System.Windows.Forms.DataGridView();
            this.exitBtn = new System.Windows.Forms.Button();
            this.reOrderBtn = new System.Windows.Forms.Button();
            this.nameTxt = new System.Windows.Forms.TextBox();
            this.priceLbl = new System.Windows.Forms.Label();
            this.priceTxt = new System.Windows.Forms.TextBox();
            this.quantTxt = new System.Windows.Forms.TextBox();
            this.quantLbl = new System.Windows.Forms.Label();
            this.nameLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.stockDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // aedBtn
            // 
            this.aedBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aedBtn.Location = new System.Drawing.Point(948, 497);
            this.aedBtn.Name = "aedBtn";
            this.aedBtn.Size = new System.Drawing.Size(203, 130);
            this.aedBtn.TabIndex = 23;
            this.aedBtn.Text = "Item AED";
            this.aedBtn.UseVisualStyleBackColor = true;
            this.aedBtn.Click += new System.EventHandler(this.aedBtn_Click);
            // 
            // mainMenuBtn
            // 
            this.mainMenuBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainMenuBtn.Location = new System.Drawing.Point(948, 34);
            this.mainMenuBtn.Name = "mainMenuBtn";
            this.mainMenuBtn.Size = new System.Drawing.Size(203, 121);
            this.mainMenuBtn.TabIndex = 22;
            this.mainMenuBtn.Text = "Return to Main Menu";
            this.mainMenuBtn.UseVisualStyleBackColor = true;
            this.mainMenuBtn.Click += new System.EventHandler(this.mainMenuBtn_Click);
            // 
            // reportBtn
            // 
            this.reportBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportBtn.Location = new System.Drawing.Point(948, 171);
            this.reportBtn.Name = "reportBtn";
            this.reportBtn.Size = new System.Drawing.Size(203, 130);
            this.reportBtn.TabIndex = 21;
            this.reportBtn.Text = "Create Report";
            this.reportBtn.UseVisualStyleBackColor = true;
            this.reportBtn.Click += new System.EventHandler(this.reportBtn_Click);
            // 
            // menuLbl
            // 
            this.menuLbl.AutoSize = true;
            this.menuLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuLbl.Location = new System.Drawing.Point(414, 57);
            this.menuLbl.Name = "menuLbl";
            this.menuLbl.Size = new System.Drawing.Size(278, 55);
            this.menuLbl.TabIndex = 20;
            this.menuLbl.Text = "Stock Menu";
            // 
            // stockDGV
            // 
            this.stockDGV.AllowUserToAddRows = false;
            this.stockDGV.AllowUserToDeleteRows = false;
            this.stockDGV.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.stockDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.stockDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.stockDGV.DefaultCellStyle = dataGridViewCellStyle2;
            this.stockDGV.Location = new System.Drawing.Point(76, 171);
            this.stockDGV.Name = "stockDGV";
            this.stockDGV.ReadOnly = true;
            this.stockDGV.Size = new System.Drawing.Size(853, 456);
            this.stockDGV.TabIndex = 19;
            // 
            // exitBtn
            // 
            this.exitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBtn.Location = new System.Drawing.Point(33, 34);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(110, 55);
            this.exitBtn.TabIndex = 18;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // reOrderBtn
            // 
            this.reOrderBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reOrderBtn.Location = new System.Drawing.Point(726, 34);
            this.reOrderBtn.Name = "reOrderBtn";
            this.reOrderBtn.Size = new System.Drawing.Size(203, 121);
            this.reOrderBtn.TabIndex = 24;
            this.reOrderBtn.Text = "Re-Order Stock";
            this.reOrderBtn.UseVisualStyleBackColor = true;
            this.reOrderBtn.Click += new System.EventHandler(this.reOrderBtn_Click);
            // 
            // nameTxt
            // 
            this.nameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTxt.Location = new System.Drawing.Point(948, 345);
            this.nameTxt.Name = "nameTxt";
            this.nameTxt.Size = new System.Drawing.Size(203, 29);
            this.nameTxt.TabIndex = 25;
            // 
            // priceLbl
            // 
            this.priceLbl.AutoSize = true;
            this.priceLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceLbl.Location = new System.Drawing.Point(944, 377);
            this.priceLbl.Name = "priceLbl";
            this.priceLbl.Size = new System.Drawing.Size(53, 24);
            this.priceLbl.TabIndex = 28;
            this.priceLbl.Text = "Price";
            // 
            // priceTxt
            // 
            this.priceTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceTxt.Location = new System.Drawing.Point(948, 404);
            this.priceTxt.Name = "priceTxt";
            this.priceTxt.Size = new System.Drawing.Size(203, 29);
            this.priceTxt.TabIndex = 29;
            // 
            // quantTxt
            // 
            this.quantTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantTxt.Location = new System.Drawing.Point(948, 462);
            this.quantTxt.Name = "quantTxt";
            this.quantTxt.Size = new System.Drawing.Size(203, 29);
            this.quantTxt.TabIndex = 30;
            // 
            // quantLbl
            // 
            this.quantLbl.AutoSize = true;
            this.quantLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantLbl.Location = new System.Drawing.Point(944, 436);
            this.quantLbl.Name = "quantLbl";
            this.quantLbl.Size = new System.Drawing.Size(139, 24);
            this.quantLbl.TabIndex = 31;
            this.quantLbl.Text = "QuantityInStock";
            // 
            // nameLbl
            // 
            this.nameLbl.AutoSize = true;
            this.nameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLbl.Location = new System.Drawing.Point(944, 318);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(112, 24);
            this.nameLbl.TabIndex = 32;
            this.nameLbl.Text = "Stock Name";
            // 
            // StockMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.ControlBox = false;
            this.Controls.Add(this.nameLbl);
            this.Controls.Add(this.quantLbl);
            this.Controls.Add(this.quantTxt);
            this.Controls.Add(this.priceTxt);
            this.Controls.Add(this.priceLbl);
            this.Controls.Add(this.nameTxt);
            this.Controls.Add(this.reOrderBtn);
            this.Controls.Add(this.aedBtn);
            this.Controls.Add(this.mainMenuBtn);
            this.Controls.Add(this.reportBtn);
            this.Controls.Add(this.menuLbl);
            this.Controls.Add(this.stockDGV);
            this.Controls.Add(this.exitBtn);
            this.Name = "StockMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StockMenu";
            ((System.ComponentModel.ISupportInitialize)(this.stockDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button aedBtn;
        private System.Windows.Forms.Button mainMenuBtn;
        private System.Windows.Forms.Button reportBtn;
        private System.Windows.Forms.Label menuLbl;
        private System.Windows.Forms.DataGridView stockDGV;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Button reOrderBtn;
        private System.Windows.Forms.TextBox nameTxt;
        private System.Windows.Forms.Label priceLbl;
        private System.Windows.Forms.TextBox priceTxt;
        private System.Windows.Forms.TextBox quantTxt;
        private System.Windows.Forms.Label quantLbl;
        private System.Windows.Forms.Label nameLbl;
    }
}