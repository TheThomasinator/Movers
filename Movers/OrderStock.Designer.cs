
namespace Movers
{
    partial class OrderStock
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
            this.menuBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.manageTab = new System.Windows.Forms.TabPage();
            this.reportBtn = new System.Windows.Forms.Button();
            this.costTxt = new System.Windows.Forms.TextBox();
            this.dateTxt = new System.Windows.Forms.TextBox();
            this.costLbl = new System.Windows.Forms.Label();
            this.dateLbl = new System.Windows.Forms.Label();
            this.discTxt = new System.Windows.Forms.TextBox();
            this.discLbl = new System.Windows.Forms.Label();
            this.confirmBtn = new System.Windows.Forms.Button();
            this.idCbx = new System.Windows.Forms.ComboBox();
            this.idLbl = new System.Windows.Forms.Label();
            this.orderManageDgv = new System.Windows.Forms.DataGridView();
            this.addTab = new System.Windows.Forms.TabPage();
            this.stockCbx = new System.Windows.Forms.ComboBox();
            this.amountLbl = new System.Windows.Forms.Label();
            this.amountTxt = new System.Windows.Forms.TextBox();
            this.stockLbl = new System.Windows.Forms.Label();
            this.setStockbtn = new System.Windows.Forms.Button();
            this.titleLbl = new System.Windows.Forms.Label();
            this.orderDgv = new System.Windows.Forms.DataGridView();
            this.addBtn = new System.Windows.Forms.Button();
            this.aedTabs = new System.Windows.Forms.TabControl();
            this.totalCostLbl = new System.Windows.Forms.Label();
            this.manageTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderManageDgv)).BeginInit();
            this.addTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderDgv)).BeginInit();
            this.aedTabs.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuBtn
            // 
            this.menuBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuBtn.Location = new System.Drawing.Point(1012, 12);
            this.menuBtn.Name = "menuBtn";
            this.menuBtn.Size = new System.Drawing.Size(150, 77);
            this.menuBtn.TabIndex = 24;
            this.menuBtn.Text = "Return to Stock Menu";
            this.menuBtn.UseVisualStyleBackColor = true;
            this.menuBtn.Click += new System.EventHandler(this.menuBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBtn.Location = new System.Drawing.Point(23, 34);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(110, 55);
            this.exitBtn.TabIndex = 23;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // manageTab
            // 
            this.manageTab.Controls.Add(this.reportBtn);
            this.manageTab.Controls.Add(this.costTxt);
            this.manageTab.Controls.Add(this.dateTxt);
            this.manageTab.Controls.Add(this.costLbl);
            this.manageTab.Controls.Add(this.dateLbl);
            this.manageTab.Controls.Add(this.discTxt);
            this.manageTab.Controls.Add(this.discLbl);
            this.manageTab.Controls.Add(this.confirmBtn);
            this.manageTab.Controls.Add(this.idCbx);
            this.manageTab.Controls.Add(this.idLbl);
            this.manageTab.Controls.Add(this.orderManageDgv);
            this.manageTab.Location = new System.Drawing.Point(4, 22);
            this.manageTab.Name = "manageTab";
            this.manageTab.Padding = new System.Windows.Forms.Padding(3);
            this.manageTab.Size = new System.Drawing.Size(1131, 528);
            this.manageTab.TabIndex = 1;
            this.manageTab.Text = "Manage";
            this.manageTab.UseVisualStyleBackColor = true;
            // 
            // reportBtn
            // 
            this.reportBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportBtn.Location = new System.Drawing.Point(655, 365);
            this.reportBtn.Name = "reportBtn";
            this.reportBtn.Size = new System.Drawing.Size(203, 130);
            this.reportBtn.TabIndex = 60;
            this.reportBtn.Text = "Create Report";
            this.reportBtn.UseVisualStyleBackColor = true;
            this.reportBtn.Click += new System.EventHandler(this.reportBtn_Click);
            // 
            // costTxt
            // 
            this.costTxt.Enabled = false;
            this.costTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.costTxt.Location = new System.Drawing.Point(655, 273);
            this.costTxt.Name = "costTxt";
            this.costTxt.Size = new System.Drawing.Size(203, 40);
            this.costTxt.TabIndex = 59;
            // 
            // dateTxt
            // 
            this.dateTxt.Enabled = false;
            this.dateTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTxt.Location = new System.Drawing.Point(655, 164);
            this.dateTxt.Name = "dateTxt";
            this.dateTxt.Size = new System.Drawing.Size(203, 40);
            this.dateTxt.TabIndex = 57;
            // 
            // costLbl
            // 
            this.costLbl.AutoSize = true;
            this.costLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.costLbl.Location = new System.Drawing.Point(649, 236);
            this.costLbl.Name = "costLbl";
            this.costLbl.Size = new System.Drawing.Size(156, 33);
            this.costLbl.TabIndex = 58;
            this.costLbl.Text = "Total Cost:";
            // 
            // dateLbl
            // 
            this.dateLbl.AutoSize = true;
            this.dateLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLbl.Location = new System.Drawing.Point(649, 127);
            this.dateLbl.Name = "dateLbl";
            this.dateLbl.Size = new System.Drawing.Size(199, 33);
            this.dateLbl.TabIndex = 56;
            this.dateLbl.Text = "Date Ordered:";
            // 
            // discTxt
            // 
            this.discTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.discTxt.Location = new System.Drawing.Point(905, 55);
            this.discTxt.Multiline = true;
            this.discTxt.Name = "discTxt";
            this.discTxt.Size = new System.Drawing.Size(203, 258);
            this.discTxt.TabIndex = 55;
            // 
            // discLbl
            // 
            this.discLbl.AutoSize = true;
            this.discLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.discLbl.Location = new System.Drawing.Point(899, 19);
            this.discLbl.Name = "discLbl";
            this.discLbl.Size = new System.Drawing.Size(208, 33);
            this.discLbl.TabIndex = 54;
            this.discLbl.Text = "Discrepancies:";
            // 
            // confirmBtn
            // 
            this.confirmBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmBtn.Location = new System.Drawing.Point(905, 365);
            this.confirmBtn.Name = "confirmBtn";
            this.confirmBtn.Size = new System.Drawing.Size(203, 130);
            this.confirmBtn.TabIndex = 53;
            this.confirmBtn.Text = "Confirm Order Arrived";
            this.confirmBtn.UseVisualStyleBackColor = true;
            this.confirmBtn.Click += new System.EventHandler(this.confirmBtn_Click);
            // 
            // idCbx
            // 
            this.idCbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.idCbx.DropDownWidth = 300;
            this.idCbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idCbx.FormattingEnabled = true;
            this.idCbx.Location = new System.Drawing.Point(655, 54);
            this.idCbx.Name = "idCbx";
            this.idCbx.Size = new System.Drawing.Size(203, 41);
            this.idCbx.TabIndex = 52;
            this.idCbx.SelectedIndexChanged += new System.EventHandler(this.idCbx_SelectedIndexChanged);
            // 
            // idLbl
            // 
            this.idLbl.AutoSize = true;
            this.idLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idLbl.Location = new System.Drawing.Point(649, 18);
            this.idLbl.Name = "idLbl";
            this.idLbl.Size = new System.Drawing.Size(98, 33);
            this.idLbl.TabIndex = 51;
            this.idLbl.Text = "Order:";
            // 
            // orderManageDgv
            // 
            this.orderManageDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orderManageDgv.Location = new System.Drawing.Point(19, 19);
            this.orderManageDgv.Name = "orderManageDgv";
            this.orderManageDgv.ReadOnly = true;
            this.orderManageDgv.Size = new System.Drawing.Size(613, 503);
            this.orderManageDgv.TabIndex = 12;
            // 
            // addTab
            // 
            this.addTab.Controls.Add(this.totalCostLbl);
            this.addTab.Controls.Add(this.stockCbx);
            this.addTab.Controls.Add(this.amountLbl);
            this.addTab.Controls.Add(this.amountTxt);
            this.addTab.Controls.Add(this.stockLbl);
            this.addTab.Controls.Add(this.setStockbtn);
            this.addTab.Controls.Add(this.titleLbl);
            this.addTab.Controls.Add(this.orderDgv);
            this.addTab.Controls.Add(this.addBtn);
            this.addTab.Location = new System.Drawing.Point(4, 22);
            this.addTab.Name = "addTab";
            this.addTab.Padding = new System.Windows.Forms.Padding(3);
            this.addTab.Size = new System.Drawing.Size(1131, 528);
            this.addTab.TabIndex = 0;
            this.addTab.Text = "Add";
            this.addTab.UseVisualStyleBackColor = true;
            // 
            // stockCbx
            // 
            this.stockCbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.stockCbx.DropDownWidth = 450;
            this.stockCbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stockCbx.FormattingEnabled = true;
            this.stockCbx.Location = new System.Drawing.Point(886, 175);
            this.stockCbx.Name = "stockCbx";
            this.stockCbx.Size = new System.Drawing.Size(220, 41);
            this.stockCbx.TabIndex = 53;
            // 
            // amountLbl
            // 
            this.amountLbl.AutoSize = true;
            this.amountLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amountLbl.Location = new System.Drawing.Point(880, 233);
            this.amountLbl.Name = "amountLbl";
            this.amountLbl.Size = new System.Drawing.Size(115, 31);
            this.amountLbl.TabIndex = 34;
            this.amountLbl.Text = "Amount:";
            // 
            // amountTxt
            // 
            this.amountTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amountTxt.Location = new System.Drawing.Point(886, 267);
            this.amountTxt.Name = "amountTxt";
            this.amountTxt.Size = new System.Drawing.Size(220, 38);
            this.amountTxt.TabIndex = 33;
            // 
            // stockLbl
            // 
            this.stockLbl.AutoSize = true;
            this.stockLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stockLbl.Location = new System.Drawing.Point(880, 141);
            this.stockLbl.Name = "stockLbl";
            this.stockLbl.Size = new System.Drawing.Size(91, 31);
            this.stockLbl.TabIndex = 32;
            this.stockLbl.Text = "Stock:";
            // 
            // setStockbtn
            // 
            this.setStockbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setStockbtn.Location = new System.Drawing.Point(886, 428);
            this.setStockbtn.Name = "setStockbtn";
            this.setStockbtn.Size = new System.Drawing.Size(223, 82);
            this.setStockbtn.TabIndex = 30;
            this.setStockbtn.Text = "Set Stock";
            this.setStockbtn.UseVisualStyleBackColor = true;
            this.setStockbtn.Click += new System.EventHandler(this.addStockbtn_Click);
            // 
            // titleLbl
            // 
            this.titleLbl.AutoSize = true;
            this.titleLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLbl.Location = new System.Drawing.Point(467, 30);
            this.titleLbl.Name = "titleLbl";
            this.titleLbl.Size = new System.Drawing.Size(257, 55);
            this.titleLbl.TabIndex = 28;
            this.titleLbl.Text = "New Order";
            // 
            // orderDgv
            // 
            this.orderDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orderDgv.Location = new System.Drawing.Point(28, 97);
            this.orderDgv.Name = "orderDgv";
            this.orderDgv.ReadOnly = true;
            this.orderDgv.Size = new System.Drawing.Size(820, 413);
            this.orderDgv.TabIndex = 12;
            // 
            // addBtn
            // 
            this.addBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBtn.Location = new System.Drawing.Point(985, 22);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(124, 82);
            this.addBtn.TabIndex = 10;
            this.addBtn.Text = "Add Order";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // aedTabs
            // 
            this.aedTabs.Controls.Add(this.addTab);
            this.aedTabs.Controls.Add(this.manageTab);
            this.aedTabs.Location = new System.Drawing.Point(23, 95);
            this.aedTabs.Name = "aedTabs";
            this.aedTabs.SelectedIndex = 0;
            this.aedTabs.Size = new System.Drawing.Size(1139, 554);
            this.aedTabs.TabIndex = 25;
            // 
            // totalCostLbl
            // 
            this.totalCostLbl.AutoSize = true;
            this.totalCostLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalCostLbl.Location = new System.Drawing.Point(880, 341);
            this.totalCostLbl.Name = "totalCostLbl";
            this.totalCostLbl.Size = new System.Drawing.Size(154, 62);
            this.totalCostLbl.TabIndex = 54;
            this.totalCostLbl.Text = "Total Cost: \r\n£";
            // 
            // OrderStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.aedTabs);
            this.Controls.Add(this.menuBtn);
            this.Controls.Add(this.exitBtn);
            this.Name = "OrderStock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OrderStock";
            this.manageTab.ResumeLayout(false);
            this.manageTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderManageDgv)).EndInit();
            this.addTab.ResumeLayout(false);
            this.addTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderDgv)).EndInit();
            this.aedTabs.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button menuBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.TabPage manageTab;
        private System.Windows.Forms.TabPage addTab;
        private System.Windows.Forms.DataGridView orderDgv;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.TabControl aedTabs;
        private System.Windows.Forms.DataGridView orderManageDgv;
        private System.Windows.Forms.Label titleLbl;
        private System.Windows.Forms.ComboBox idCbx;
        private System.Windows.Forms.Label idLbl;
        private System.Windows.Forms.TextBox discTxt;
        private System.Windows.Forms.Label discLbl;
        private System.Windows.Forms.Button confirmBtn;
        private System.Windows.Forms.Label amountLbl;
        private System.Windows.Forms.TextBox amountTxt;
        private System.Windows.Forms.Label stockLbl;
        private System.Windows.Forms.Button setStockbtn;
        private System.Windows.Forms.ComboBox stockCbx;
        private System.Windows.Forms.Label dateLbl;
        private System.Windows.Forms.TextBox costTxt;
        private System.Windows.Forms.TextBox dateTxt;
        private System.Windows.Forms.Label costLbl;
        private System.Windows.Forms.Button reportBtn;
        private System.Windows.Forms.Label totalCostLbl;
    }
}