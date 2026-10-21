
namespace Movers
{
    partial class ItemAED
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
            this.aedTabs = new System.Windows.Forms.TabControl();
            this.addTab = new System.Windows.Forms.TabPage();
            this.addQuantTxt = new System.Windows.Forms.TextBox();
            this.addBtn = new System.Windows.Forms.Button();
            this.addQuantLbl = new System.Windows.Forms.Label();
            this.addPriceTxt = new System.Windows.Forms.TextBox();
            this.addPriceLbl = new System.Windows.Forms.Label();
            this.addSNameTxt = new System.Windows.Forms.TextBox();
            this.addSNameLbl = new System.Windows.Forms.Label();
            this.editTab = new System.Windows.Forms.TabPage();
            this.editQuantTxt = new System.Windows.Forms.TextBox();
            this.editQuantLbl = new System.Windows.Forms.Label();
            this.editPriceTxt = new System.Windows.Forms.TextBox();
            this.editPriceLbl = new System.Windows.Forms.Label();
            this.editSNameTxt = new System.Windows.Forms.TextBox();
            this.editSNameLbl = new System.Windows.Forms.Label();
            this.editIdCbx = new System.Windows.Forms.ComboBox();
            this.editIdLbl = new System.Windows.Forms.Label();
            this.editBtn = new System.Windows.Forms.Button();
            this.deleteTab = new System.Windows.Forms.TabPage();
            this.deleteQuantTxt = new System.Windows.Forms.TextBox();
            this.deleteQuantLbl = new System.Windows.Forms.Label();
            this.deletePriceTxt = new System.Windows.Forms.TextBox();
            this.deletePriceLbl = new System.Windows.Forms.Label();
            this.deleteSNameTxt = new System.Windows.Forms.TextBox();
            this.deleteSNameLbl = new System.Windows.Forms.Label();
            this.deleteIdCbx = new System.Windows.Forms.ComboBox();
            this.deleteIdLbl = new System.Windows.Forms.Label();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.menuBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.aedTabs.SuspendLayout();
            this.addTab.SuspendLayout();
            this.editTab.SuspendLayout();
            this.deleteTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // aedTabs
            // 
            this.aedTabs.Controls.Add(this.addTab);
            this.aedTabs.Controls.Add(this.editTab);
            this.aedTabs.Controls.Add(this.deleteTab);
            this.aedTabs.Location = new System.Drawing.Point(23, 106);
            this.aedTabs.Name = "aedTabs";
            this.aedTabs.SelectedIndex = 0;
            this.aedTabs.Size = new System.Drawing.Size(1139, 543);
            this.aedTabs.TabIndex = 22;
            // 
            // addTab
            // 
            this.addTab.Controls.Add(this.addQuantTxt);
            this.addTab.Controls.Add(this.addBtn);
            this.addTab.Controls.Add(this.addQuantLbl);
            this.addTab.Controls.Add(this.addPriceTxt);
            this.addTab.Controls.Add(this.addPriceLbl);
            this.addTab.Controls.Add(this.addSNameTxt);
            this.addTab.Controls.Add(this.addSNameLbl);
            this.addTab.Location = new System.Drawing.Point(4, 22);
            this.addTab.Name = "addTab";
            this.addTab.Padding = new System.Windows.Forms.Padding(3);
            this.addTab.Size = new System.Drawing.Size(1131, 517);
            this.addTab.TabIndex = 0;
            this.addTab.Text = "Add";
            this.addTab.UseVisualStyleBackColor = true;
            // 
            // addQuantTxt
            // 
            this.addQuantTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addQuantTxt.Location = new System.Drawing.Point(552, 266);
            this.addQuantTxt.Name = "addQuantTxt";
            this.addQuantTxt.Size = new System.Drawing.Size(324, 40);
            this.addQuantTxt.TabIndex = 11;
            // 
            // addBtn
            // 
            this.addBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBtn.Location = new System.Drawing.Point(943, 397);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(155, 97);
            this.addBtn.TabIndex = 10;
            this.addBtn.Text = "Add Stock";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // addQuantLbl
            // 
            this.addQuantLbl.AutoSize = true;
            this.addQuantLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addQuantLbl.Location = new System.Drawing.Point(266, 266);
            this.addQuantLbl.Name = "addQuantLbl";
            this.addQuantLbl.Size = new System.Drawing.Size(244, 33);
            this.addQuantLbl.TabIndex = 4;
            this.addQuantLbl.Text = "Quantity in Stock:";
            // 
            // addPriceTxt
            // 
            this.addPriceTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPriceTxt.Location = new System.Drawing.Point(552, 202);
            this.addPriceTxt.Name = "addPriceTxt";
            this.addPriceTxt.Size = new System.Drawing.Size(324, 40);
            this.addPriceTxt.TabIndex = 3;
            // 
            // addPriceLbl
            // 
            this.addPriceLbl.AutoSize = true;
            this.addPriceLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPriceLbl.Location = new System.Drawing.Point(266, 205);
            this.addPriceLbl.Name = "addPriceLbl";
            this.addPriceLbl.Size = new System.Drawing.Size(90, 33);
            this.addPriceLbl.TabIndex = 2;
            this.addPriceLbl.Text = "Price:";
            // 
            // addSNameTxt
            // 
            this.addSNameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addSNameTxt.Location = new System.Drawing.Point(552, 138);
            this.addSNameTxt.Name = "addSNameTxt";
            this.addSNameTxt.Size = new System.Drawing.Size(324, 40);
            this.addSNameTxt.TabIndex = 1;
            // 
            // addSNameLbl
            // 
            this.addSNameLbl.AutoSize = true;
            this.addSNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addSNameLbl.Location = new System.Drawing.Point(266, 141);
            this.addSNameLbl.Name = "addSNameLbl";
            this.addSNameLbl.Size = new System.Drawing.Size(182, 33);
            this.addSNameLbl.TabIndex = 0;
            this.addSNameLbl.Text = "Stock Name:";
            // 
            // editTab
            // 
            this.editTab.Controls.Add(this.editQuantTxt);
            this.editTab.Controls.Add(this.editQuantLbl);
            this.editTab.Controls.Add(this.editPriceTxt);
            this.editTab.Controls.Add(this.editPriceLbl);
            this.editTab.Controls.Add(this.editSNameTxt);
            this.editTab.Controls.Add(this.editSNameLbl);
            this.editTab.Controls.Add(this.editIdCbx);
            this.editTab.Controls.Add(this.editIdLbl);
            this.editTab.Controls.Add(this.editBtn);
            this.editTab.Location = new System.Drawing.Point(4, 22);
            this.editTab.Name = "editTab";
            this.editTab.Padding = new System.Windows.Forms.Padding(3);
            this.editTab.Size = new System.Drawing.Size(1131, 517);
            this.editTab.TabIndex = 1;
            this.editTab.Text = "Edit";
            this.editTab.UseVisualStyleBackColor = true;
            // 
            // editQuantTxt
            // 
            this.editQuantTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editQuantTxt.Location = new System.Drawing.Point(545, 275);
            this.editQuantTxt.Name = "editQuantTxt";
            this.editQuantTxt.Size = new System.Drawing.Size(324, 40);
            this.editQuantTxt.TabIndex = 27;
            // 
            // editQuantLbl
            // 
            this.editQuantLbl.AutoSize = true;
            this.editQuantLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editQuantLbl.Location = new System.Drawing.Point(259, 275);
            this.editQuantLbl.Name = "editQuantLbl";
            this.editQuantLbl.Size = new System.Drawing.Size(244, 33);
            this.editQuantLbl.TabIndex = 26;
            this.editQuantLbl.Text = "Quantity in Stock:";
            // 
            // editPriceTxt
            // 
            this.editPriceTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editPriceTxt.Location = new System.Drawing.Point(545, 211);
            this.editPriceTxt.Name = "editPriceTxt";
            this.editPriceTxt.Size = new System.Drawing.Size(324, 40);
            this.editPriceTxt.TabIndex = 25;
            // 
            // editPriceLbl
            // 
            this.editPriceLbl.AutoSize = true;
            this.editPriceLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editPriceLbl.Location = new System.Drawing.Point(259, 214);
            this.editPriceLbl.Name = "editPriceLbl";
            this.editPriceLbl.Size = new System.Drawing.Size(90, 33);
            this.editPriceLbl.TabIndex = 24;
            this.editPriceLbl.Text = "Price:";
            // 
            // editSNameTxt
            // 
            this.editSNameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editSNameTxt.Location = new System.Drawing.Point(545, 147);
            this.editSNameTxt.Name = "editSNameTxt";
            this.editSNameTxt.Size = new System.Drawing.Size(324, 40);
            this.editSNameTxt.TabIndex = 23;
            // 
            // editSNameLbl
            // 
            this.editSNameLbl.AutoSize = true;
            this.editSNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editSNameLbl.Location = new System.Drawing.Point(259, 150);
            this.editSNameLbl.Name = "editSNameLbl";
            this.editSNameLbl.Size = new System.Drawing.Size(182, 33);
            this.editSNameLbl.TabIndex = 22;
            this.editSNameLbl.Text = "Stock Name:";
            // 
            // editIdCbx
            // 
            this.editIdCbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.editIdCbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editIdCbx.FormattingEnabled = true;
            this.editIdCbx.Location = new System.Drawing.Point(545, 84);
            this.editIdCbx.Name = "editIdCbx";
            this.editIdCbx.Size = new System.Drawing.Size(324, 41);
            this.editIdCbx.TabIndex = 21;
            this.editIdCbx.SelectedIndexChanged += new System.EventHandler(this.editIdCbx_SelectedIndexChanged);
            // 
            // editIdLbl
            // 
            this.editIdLbl.AutoSize = true;
            this.editIdLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editIdLbl.Location = new System.Drawing.Point(259, 92);
            this.editIdLbl.Name = "editIdLbl";
            this.editIdLbl.Size = new System.Drawing.Size(125, 33);
            this.editIdLbl.TabIndex = 20;
            this.editIdLbl.Text = "Stock ID";
            // 
            // editBtn
            // 
            this.editBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editBtn.Location = new System.Drawing.Point(946, 391);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(155, 97);
            this.editBtn.TabIndex = 19;
            this.editBtn.Text = "Edit Stock";
            this.editBtn.UseVisualStyleBackColor = true;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // deleteTab
            // 
            this.deleteTab.Controls.Add(this.deleteQuantTxt);
            this.deleteTab.Controls.Add(this.deleteQuantLbl);
            this.deleteTab.Controls.Add(this.deletePriceTxt);
            this.deleteTab.Controls.Add(this.deletePriceLbl);
            this.deleteTab.Controls.Add(this.deleteSNameTxt);
            this.deleteTab.Controls.Add(this.deleteSNameLbl);
            this.deleteTab.Controls.Add(this.deleteIdCbx);
            this.deleteTab.Controls.Add(this.deleteIdLbl);
            this.deleteTab.Controls.Add(this.deleteBtn);
            this.deleteTab.Location = new System.Drawing.Point(4, 22);
            this.deleteTab.Name = "deleteTab";
            this.deleteTab.Padding = new System.Windows.Forms.Padding(3);
            this.deleteTab.Size = new System.Drawing.Size(1131, 517);
            this.deleteTab.TabIndex = 2;
            this.deleteTab.Text = "Delete";
            this.deleteTab.UseVisualStyleBackColor = true;
            // 
            // deleteQuantTxt
            // 
            this.deleteQuantTxt.Enabled = false;
            this.deleteQuantTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteQuantTxt.Location = new System.Drawing.Point(543, 278);
            this.deleteQuantTxt.Name = "deleteQuantTxt";
            this.deleteQuantTxt.Size = new System.Drawing.Size(324, 40);
            this.deleteQuantTxt.TabIndex = 38;
            // 
            // deleteQuantLbl
            // 
            this.deleteQuantLbl.AutoSize = true;
            this.deleteQuantLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteQuantLbl.Location = new System.Drawing.Point(257, 278);
            this.deleteQuantLbl.Name = "deleteQuantLbl";
            this.deleteQuantLbl.Size = new System.Drawing.Size(244, 33);
            this.deleteQuantLbl.TabIndex = 37;
            this.deleteQuantLbl.Text = "Quantity in Stock:";
            // 
            // deletePriceTxt
            // 
            this.deletePriceTxt.Enabled = false;
            this.deletePriceTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletePriceTxt.Location = new System.Drawing.Point(543, 214);
            this.deletePriceTxt.Name = "deletePriceTxt";
            this.deletePriceTxt.Size = new System.Drawing.Size(324, 40);
            this.deletePriceTxt.TabIndex = 36;
            // 
            // deletePriceLbl
            // 
            this.deletePriceLbl.AutoSize = true;
            this.deletePriceLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletePriceLbl.Location = new System.Drawing.Point(257, 217);
            this.deletePriceLbl.Name = "deletePriceLbl";
            this.deletePriceLbl.Size = new System.Drawing.Size(90, 33);
            this.deletePriceLbl.TabIndex = 35;
            this.deletePriceLbl.Text = "Price:";
            // 
            // deleteSNameTxt
            // 
            this.deleteSNameTxt.Enabled = false;
            this.deleteSNameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteSNameTxt.Location = new System.Drawing.Point(543, 150);
            this.deleteSNameTxt.Name = "deleteSNameTxt";
            this.deleteSNameTxt.Size = new System.Drawing.Size(324, 40);
            this.deleteSNameTxt.TabIndex = 34;
            // 
            // deleteSNameLbl
            // 
            this.deleteSNameLbl.AutoSize = true;
            this.deleteSNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteSNameLbl.Location = new System.Drawing.Point(257, 153);
            this.deleteSNameLbl.Name = "deleteSNameLbl";
            this.deleteSNameLbl.Size = new System.Drawing.Size(182, 33);
            this.deleteSNameLbl.TabIndex = 33;
            this.deleteSNameLbl.Text = "Stock Name:";
            // 
            // deleteIdCbx
            // 
            this.deleteIdCbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.deleteIdCbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteIdCbx.FormattingEnabled = true;
            this.deleteIdCbx.Location = new System.Drawing.Point(543, 87);
            this.deleteIdCbx.Name = "deleteIdCbx";
            this.deleteIdCbx.Size = new System.Drawing.Size(324, 41);
            this.deleteIdCbx.TabIndex = 32;
            this.deleteIdCbx.SelectedIndexChanged += new System.EventHandler(this.deleteIdCbx_SelectedIndexChanged);
            // 
            // deleteIdLbl
            // 
            this.deleteIdLbl.AutoSize = true;
            this.deleteIdLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteIdLbl.Location = new System.Drawing.Point(257, 95);
            this.deleteIdLbl.Name = "deleteIdLbl";
            this.deleteIdLbl.Size = new System.Drawing.Size(125, 33);
            this.deleteIdLbl.TabIndex = 31;
            this.deleteIdLbl.Text = "Stock ID";
            // 
            // deleteBtn
            // 
            this.deleteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteBtn.Location = new System.Drawing.Point(941, 390);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(155, 97);
            this.deleteBtn.TabIndex = 30;
            this.deleteBtn.Text = "Delete Stock";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // menuBtn
            // 
            this.menuBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuBtn.Location = new System.Drawing.Point(1012, 12);
            this.menuBtn.Name = "menuBtn";
            this.menuBtn.Size = new System.Drawing.Size(150, 77);
            this.menuBtn.TabIndex = 21;
            this.menuBtn.Text = "Return to Stock Menu";
            this.menuBtn.UseVisualStyleBackColor = true;
            this.menuBtn.Click += new System.EventHandler(this.mainMenuBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBtn.Location = new System.Drawing.Point(23, 34);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(110, 55);
            this.exitBtn.TabIndex = 20;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // ItemAED
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.ControlBox = false;
            this.Controls.Add(this.aedTabs);
            this.Controls.Add(this.menuBtn);
            this.Controls.Add(this.exitBtn);
            this.Name = "ItemAED";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ItemAED";
            this.aedTabs.ResumeLayout(false);
            this.addTab.ResumeLayout(false);
            this.addTab.PerformLayout();
            this.editTab.ResumeLayout(false);
            this.editTab.PerformLayout();
            this.deleteTab.ResumeLayout(false);
            this.deleteTab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl aedTabs;
        private System.Windows.Forms.TabPage addTab;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Label addQuantLbl;
        private System.Windows.Forms.TextBox addPriceTxt;
        private System.Windows.Forms.Label addPriceLbl;
        private System.Windows.Forms.TextBox addSNameTxt;
        private System.Windows.Forms.Label addSNameLbl;
        private System.Windows.Forms.TabPage editTab;
        private System.Windows.Forms.ComboBox editIdCbx;
        private System.Windows.Forms.Label editIdLbl;
        private System.Windows.Forms.Button editBtn;
        private System.Windows.Forms.TabPage deleteTab;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button menuBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.TextBox addQuantTxt;
        private System.Windows.Forms.TextBox editQuantTxt;
        private System.Windows.Forms.Label editQuantLbl;
        private System.Windows.Forms.TextBox editPriceTxt;
        private System.Windows.Forms.Label editPriceLbl;
        private System.Windows.Forms.TextBox editSNameTxt;
        private System.Windows.Forms.Label editSNameLbl;
        private System.Windows.Forms.TextBox deleteQuantTxt;
        private System.Windows.Forms.Label deleteQuantLbl;
        private System.Windows.Forms.TextBox deletePriceTxt;
        private System.Windows.Forms.Label deletePriceLbl;
        private System.Windows.Forms.TextBox deleteSNameTxt;
        private System.Windows.Forms.Label deleteSNameLbl;
        private System.Windows.Forms.ComboBox deleteIdCbx;
        private System.Windows.Forms.Label deleteIdLbl;
    }
}