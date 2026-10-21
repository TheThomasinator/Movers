
namespace Movers
{
    partial class StaffAED
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
            this.aedTabs = new System.Windows.Forms.TabControl();
            this.addTab = new System.Windows.Forms.TabPage();
            this.addBtn = new System.Windows.Forms.Button();
            this.addPorFCbx = new System.Windows.Forms.ComboBox();
            this.addTitleCbx = new System.Windows.Forms.ComboBox();
            this.addPorFLbl = new System.Windows.Forms.Label();
            this.addTitleLbl = new System.Windows.Forms.Label();
            this.addSNameTxt = new System.Windows.Forms.TextBox();
            this.addSNameLbl = new System.Windows.Forms.Label();
            this.addFNameTxt = new System.Windows.Forms.TextBox();
            this.addFNameLbl = new System.Windows.Forms.Label();
            this.editTab = new System.Windows.Forms.TabPage();
            this.editIdCbx = new System.Windows.Forms.ComboBox();
            this.editIdLbl = new System.Windows.Forms.Label();
            this.editBtn = new System.Windows.Forms.Button();
            this.editPorFCbx = new System.Windows.Forms.ComboBox();
            this.editTitleCbx = new System.Windows.Forms.ComboBox();
            this.editPorFLbl = new System.Windows.Forms.Label();
            this.editTitleLbl = new System.Windows.Forms.Label();
            this.editSNameTxt = new System.Windows.Forms.TextBox();
            this.editSNameLbl = new System.Windows.Forms.Label();
            this.editFNameTxt = new System.Windows.Forms.TextBox();
            this.editFNameLbl = new System.Windows.Forms.Label();
            this.deleteTab = new System.Windows.Forms.TabPage();
            this.deletePorFTxt = new System.Windows.Forms.TextBox();
            this.deleteTitleTxt = new System.Windows.Forms.TextBox();
            this.deleteIdCbx = new System.Windows.Forms.ComboBox();
            this.deleteIdLbl = new System.Windows.Forms.Label();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.deletePorFLbl = new System.Windows.Forms.Label();
            this.deleteTitleLbl = new System.Windows.Forms.Label();
            this.deleteSNameTxt = new System.Windows.Forms.TextBox();
            this.deleteSNameLbl = new System.Windows.Forms.Label();
            this.deleteFNameTxt = new System.Windows.Forms.TextBox();
            this.deleteFNameLbl = new System.Windows.Forms.Label();
            this.aedTabs.SuspendLayout();
            this.addTab.SuspendLayout();
            this.editTab.SuspendLayout();
            this.deleteTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuBtn
            // 
            this.menuBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuBtn.Location = new System.Drawing.Point(1022, 12);
            this.menuBtn.Name = "menuBtn";
            this.menuBtn.Size = new System.Drawing.Size(150, 77);
            this.menuBtn.TabIndex = 18;
            this.menuBtn.Text = "Return to Staff Menu";
            this.menuBtn.UseVisualStyleBackColor = true;
            this.menuBtn.Click += new System.EventHandler(this.mainMenuBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBtn.Location = new System.Drawing.Point(33, 34);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(110, 55);
            this.exitBtn.TabIndex = 17;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // aedTabs
            // 
            this.aedTabs.Controls.Add(this.addTab);
            this.aedTabs.Controls.Add(this.editTab);
            this.aedTabs.Controls.Add(this.deleteTab);
            this.aedTabs.Location = new System.Drawing.Point(33, 106);
            this.aedTabs.Name = "aedTabs";
            this.aedTabs.SelectedIndex = 0;
            this.aedTabs.Size = new System.Drawing.Size(1139, 543);
            this.aedTabs.TabIndex = 19;
            // 
            // addTab
            // 
            this.addTab.Controls.Add(this.addBtn);
            this.addTab.Controls.Add(this.addPorFCbx);
            this.addTab.Controls.Add(this.addTitleCbx);
            this.addTab.Controls.Add(this.addPorFLbl);
            this.addTab.Controls.Add(this.addTitleLbl);
            this.addTab.Controls.Add(this.addSNameTxt);
            this.addTab.Controls.Add(this.addSNameLbl);
            this.addTab.Controls.Add(this.addFNameTxt);
            this.addTab.Controls.Add(this.addFNameLbl);
            this.addTab.Location = new System.Drawing.Point(4, 22);
            this.addTab.Name = "addTab";
            this.addTab.Padding = new System.Windows.Forms.Padding(3);
            this.addTab.Size = new System.Drawing.Size(1131, 517);
            this.addTab.TabIndex = 0;
            this.addTab.Text = "Add";
            this.addTab.UseVisualStyleBackColor = true;
            // 
            // addBtn
            // 
            this.addBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBtn.Location = new System.Drawing.Point(943, 397);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(155, 97);
            this.addBtn.TabIndex = 10;
            this.addBtn.Text = "Add Staff Member";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // addPorFCbx
            // 
            this.addPorFCbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.addPorFCbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPorFCbx.FormattingEnabled = true;
            this.addPorFCbx.Location = new System.Drawing.Point(552, 331);
            this.addPorFCbx.Name = "addPorFCbx";
            this.addPorFCbx.Size = new System.Drawing.Size(324, 41);
            this.addPorFCbx.TabIndex = 9;
            // 
            // addTitleCbx
            // 
            this.addTitleCbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.addTitleCbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addTitleCbx.FormattingEnabled = true;
            this.addTitleCbx.Location = new System.Drawing.Point(552, 269);
            this.addTitleCbx.Name = "addTitleCbx";
            this.addTitleCbx.Size = new System.Drawing.Size(324, 41);
            this.addTitleCbx.TabIndex = 8;
            // 
            // addPorFLbl
            // 
            this.addPorFLbl.AutoSize = true;
            this.addPorFLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPorFLbl.Location = new System.Drawing.Point(266, 331);
            this.addPorFLbl.Name = "addPorFLbl";
            this.addPorFLbl.Size = new System.Drawing.Size(240, 33);
            this.addPorFLbl.TabIndex = 6;
            this.addPorFLbl.Text = "Part or Full Time:";
            // 
            // addTitleLbl
            // 
            this.addTitleLbl.AutoSize = true;
            this.addTitleLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addTitleLbl.Location = new System.Drawing.Point(266, 269);
            this.addTitleLbl.Name = "addTitleLbl";
            this.addTitleLbl.Size = new System.Drawing.Size(134, 33);
            this.addTitleLbl.TabIndex = 4;
            this.addTitleLbl.Text = "Job Title:";
            // 
            // addSNameTxt
            // 
            this.addSNameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addSNameTxt.Location = new System.Drawing.Point(552, 202);
            this.addSNameTxt.Name = "addSNameTxt";
            this.addSNameTxt.Size = new System.Drawing.Size(324, 40);
            this.addSNameTxt.TabIndex = 3;
            // 
            // addSNameLbl
            // 
            this.addSNameLbl.AutoSize = true;
            this.addSNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addSNameLbl.Location = new System.Drawing.Point(266, 205);
            this.addSNameLbl.Name = "addSNameLbl";
            this.addSNameLbl.Size = new System.Drawing.Size(207, 33);
            this.addSNameLbl.TabIndex = 2;
            this.addSNameLbl.Text = "Second Name:";
            // 
            // addFNameTxt
            // 
            this.addFNameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addFNameTxt.Location = new System.Drawing.Point(552, 138);
            this.addFNameTxt.Name = "addFNameTxt";
            this.addFNameTxt.Size = new System.Drawing.Size(324, 40);
            this.addFNameTxt.TabIndex = 1;
            // 
            // addFNameLbl
            // 
            this.addFNameLbl.AutoSize = true;
            this.addFNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addFNameLbl.Location = new System.Drawing.Point(266, 141);
            this.addFNameLbl.Name = "addFNameLbl";
            this.addFNameLbl.Size = new System.Drawing.Size(167, 33);
            this.addFNameLbl.TabIndex = 0;
            this.addFNameLbl.Text = "First Name:";
            // 
            // editTab
            // 
            this.editTab.Controls.Add(this.editIdCbx);
            this.editTab.Controls.Add(this.editIdLbl);
            this.editTab.Controls.Add(this.editBtn);
            this.editTab.Controls.Add(this.editPorFCbx);
            this.editTab.Controls.Add(this.editTitleCbx);
            this.editTab.Controls.Add(this.editPorFLbl);
            this.editTab.Controls.Add(this.editTitleLbl);
            this.editTab.Controls.Add(this.editSNameTxt);
            this.editTab.Controls.Add(this.editSNameLbl);
            this.editTab.Controls.Add(this.editFNameTxt);
            this.editTab.Controls.Add(this.editFNameLbl);
            this.editTab.Location = new System.Drawing.Point(4, 22);
            this.editTab.Name = "editTab";
            this.editTab.Padding = new System.Windows.Forms.Padding(3);
            this.editTab.Size = new System.Drawing.Size(1131, 517);
            this.editTab.TabIndex = 1;
            this.editTab.Text = "Edit";
            this.editTab.UseVisualStyleBackColor = true;
            // 
            // editIdCbx
            // 
            this.editIdCbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.editIdCbx.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.editIdCbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editIdCbx.FormattingEnabled = true;
            this.editIdCbx.Location = new System.Drawing.Point(555, 68);
            this.editIdCbx.Name = "editIdCbx";
            this.editIdCbx.Size = new System.Drawing.Size(324, 41);
            this.editIdCbx.TabIndex = 21;
            this.editIdCbx.SelectedIndexChanged += new System.EventHandler(this.editIdCbx_SelectedIndexChanged);
            // 
            // editIdLbl
            // 
            this.editIdLbl.AutoSize = true;
            this.editIdLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editIdLbl.Location = new System.Drawing.Point(269, 76);
            this.editIdLbl.Name = "editIdLbl";
            this.editIdLbl.Size = new System.Drawing.Size(119, 33);
            this.editIdLbl.TabIndex = 20;
            this.editIdLbl.Text = "Staff ID:";
            // 
            // editBtn
            // 
            this.editBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editBtn.Location = new System.Drawing.Point(946, 391);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(155, 97);
            this.editBtn.TabIndex = 19;
            this.editBtn.Text = "Edit Staff Member";
            this.editBtn.UseVisualStyleBackColor = true;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // editPorFCbx
            // 
            this.editPorFCbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.editPorFCbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editPorFCbx.FormattingEnabled = true;
            this.editPorFCbx.Location = new System.Drawing.Point(555, 325);
            this.editPorFCbx.Name = "editPorFCbx";
            this.editPorFCbx.Size = new System.Drawing.Size(324, 41);
            this.editPorFCbx.TabIndex = 18;
            // 
            // editTitleCbx
            // 
            this.editTitleCbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.editTitleCbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editTitleCbx.FormattingEnabled = true;
            this.editTitleCbx.Location = new System.Drawing.Point(555, 263);
            this.editTitleCbx.Name = "editTitleCbx";
            this.editTitleCbx.Size = new System.Drawing.Size(324, 41);
            this.editTitleCbx.TabIndex = 17;
            // 
            // editPorFLbl
            // 
            this.editPorFLbl.AutoSize = true;
            this.editPorFLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editPorFLbl.Location = new System.Drawing.Point(269, 325);
            this.editPorFLbl.Name = "editPorFLbl";
            this.editPorFLbl.Size = new System.Drawing.Size(240, 33);
            this.editPorFLbl.TabIndex = 16;
            this.editPorFLbl.Text = "Part or Full Time:";
            // 
            // editTitleLbl
            // 
            this.editTitleLbl.AutoSize = true;
            this.editTitleLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editTitleLbl.Location = new System.Drawing.Point(269, 263);
            this.editTitleLbl.Name = "editTitleLbl";
            this.editTitleLbl.Size = new System.Drawing.Size(134, 33);
            this.editTitleLbl.TabIndex = 15;
            this.editTitleLbl.Text = "Job Title:";
            // 
            // editSNameTxt
            // 
            this.editSNameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editSNameTxt.Location = new System.Drawing.Point(555, 196);
            this.editSNameTxt.Name = "editSNameTxt";
            this.editSNameTxt.Size = new System.Drawing.Size(324, 40);
            this.editSNameTxt.TabIndex = 14;
            // 
            // editSNameLbl
            // 
            this.editSNameLbl.AutoSize = true;
            this.editSNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editSNameLbl.Location = new System.Drawing.Point(269, 199);
            this.editSNameLbl.Name = "editSNameLbl";
            this.editSNameLbl.Size = new System.Drawing.Size(207, 33);
            this.editSNameLbl.TabIndex = 13;
            this.editSNameLbl.Text = "Second Name:";
            // 
            // editFNameTxt
            // 
            this.editFNameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editFNameTxt.Location = new System.Drawing.Point(555, 132);
            this.editFNameTxt.Name = "editFNameTxt";
            this.editFNameTxt.Size = new System.Drawing.Size(324, 40);
            this.editFNameTxt.TabIndex = 12;
            // 
            // editFNameLbl
            // 
            this.editFNameLbl.AutoSize = true;
            this.editFNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editFNameLbl.Location = new System.Drawing.Point(269, 135);
            this.editFNameLbl.Name = "editFNameLbl";
            this.editFNameLbl.Size = new System.Drawing.Size(167, 33);
            this.editFNameLbl.TabIndex = 11;
            this.editFNameLbl.Text = "First Name:";
            // 
            // deleteTab
            // 
            this.deleteTab.Controls.Add(this.deletePorFTxt);
            this.deleteTab.Controls.Add(this.deleteTitleTxt);
            this.deleteTab.Controls.Add(this.deleteIdCbx);
            this.deleteTab.Controls.Add(this.deleteIdLbl);
            this.deleteTab.Controls.Add(this.deleteBtn);
            this.deleteTab.Controls.Add(this.deletePorFLbl);
            this.deleteTab.Controls.Add(this.deleteTitleLbl);
            this.deleteTab.Controls.Add(this.deleteSNameTxt);
            this.deleteTab.Controls.Add(this.deleteSNameLbl);
            this.deleteTab.Controls.Add(this.deleteFNameTxt);
            this.deleteTab.Controls.Add(this.deleteFNameLbl);
            this.deleteTab.Location = new System.Drawing.Point(4, 22);
            this.deleteTab.Name = "deleteTab";
            this.deleteTab.Padding = new System.Windows.Forms.Padding(3);
            this.deleteTab.Size = new System.Drawing.Size(1131, 517);
            this.deleteTab.TabIndex = 2;
            this.deleteTab.Text = "Delete";
            this.deleteTab.UseVisualStyleBackColor = true;
            // 
            // deletePorFTxt
            // 
            this.deletePorFTxt.Enabled = false;
            this.deletePorFTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletePorFTxt.Location = new System.Drawing.Point(550, 324);
            this.deletePorFTxt.Name = "deletePorFTxt";
            this.deletePorFTxt.Size = new System.Drawing.Size(324, 40);
            this.deletePorFTxt.TabIndex = 34;
            // 
            // deleteTitleTxt
            // 
            this.deleteTitleTxt.Enabled = false;
            this.deleteTitleTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteTitleTxt.Location = new System.Drawing.Point(550, 262);
            this.deleteTitleTxt.Name = "deleteTitleTxt";
            this.deleteTitleTxt.Size = new System.Drawing.Size(324, 40);
            this.deleteTitleTxt.TabIndex = 33;
            // 
            // deleteIdCbx
            // 
            this.deleteIdCbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.deleteIdCbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteIdCbx.FormattingEnabled = true;
            this.deleteIdCbx.Location = new System.Drawing.Point(550, 70);
            this.deleteIdCbx.Name = "deleteIdCbx";
            this.deleteIdCbx.Size = new System.Drawing.Size(324, 41);
            this.deleteIdCbx.TabIndex = 32;
            this.deleteIdCbx.SelectedIndexChanged += new System.EventHandler(this.deleteIdCbx_SelectedIndexChanged);
            // 
            // deleteIdLbl
            // 
            this.deleteIdLbl.AutoSize = true;
            this.deleteIdLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteIdLbl.Location = new System.Drawing.Point(264, 78);
            this.deleteIdLbl.Name = "deleteIdLbl";
            this.deleteIdLbl.Size = new System.Drawing.Size(119, 33);
            this.deleteIdLbl.TabIndex = 31;
            this.deleteIdLbl.Text = "Staff ID:";
            // 
            // deleteBtn
            // 
            this.deleteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteBtn.Location = new System.Drawing.Point(941, 393);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(155, 97);
            this.deleteBtn.TabIndex = 30;
            this.deleteBtn.Text = "Delete Staff Member";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // deletePorFLbl
            // 
            this.deletePorFLbl.AutoSize = true;
            this.deletePorFLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletePorFLbl.Location = new System.Drawing.Point(264, 327);
            this.deletePorFLbl.Name = "deletePorFLbl";
            this.deletePorFLbl.Size = new System.Drawing.Size(240, 33);
            this.deletePorFLbl.TabIndex = 27;
            this.deletePorFLbl.Text = "Part or Full Time:";
            // 
            // deleteTitleLbl
            // 
            this.deleteTitleLbl.AutoSize = true;
            this.deleteTitleLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteTitleLbl.Location = new System.Drawing.Point(264, 265);
            this.deleteTitleLbl.Name = "deleteTitleLbl";
            this.deleteTitleLbl.Size = new System.Drawing.Size(134, 33);
            this.deleteTitleLbl.TabIndex = 26;
            this.deleteTitleLbl.Text = "Job Title:";
            // 
            // deleteSNameTxt
            // 
            this.deleteSNameTxt.Enabled = false;
            this.deleteSNameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteSNameTxt.Location = new System.Drawing.Point(550, 198);
            this.deleteSNameTxt.Name = "deleteSNameTxt";
            this.deleteSNameTxt.Size = new System.Drawing.Size(324, 40);
            this.deleteSNameTxt.TabIndex = 25;
            // 
            // deleteSNameLbl
            // 
            this.deleteSNameLbl.AutoSize = true;
            this.deleteSNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteSNameLbl.Location = new System.Drawing.Point(264, 201);
            this.deleteSNameLbl.Name = "deleteSNameLbl";
            this.deleteSNameLbl.Size = new System.Drawing.Size(207, 33);
            this.deleteSNameLbl.TabIndex = 24;
            this.deleteSNameLbl.Text = "Second Name:";
            // 
            // deleteFNameTxt
            // 
            this.deleteFNameTxt.Enabled = false;
            this.deleteFNameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteFNameTxt.Location = new System.Drawing.Point(550, 134);
            this.deleteFNameTxt.Name = "deleteFNameTxt";
            this.deleteFNameTxt.Size = new System.Drawing.Size(324, 40);
            this.deleteFNameTxt.TabIndex = 23;
            // 
            // deleteFNameLbl
            // 
            this.deleteFNameLbl.AutoSize = true;
            this.deleteFNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteFNameLbl.Location = new System.Drawing.Point(264, 137);
            this.deleteFNameLbl.Name = "deleteFNameLbl";
            this.deleteFNameLbl.Size = new System.Drawing.Size(167, 33);
            this.deleteFNameLbl.TabIndex = 22;
            this.deleteFNameLbl.Text = "First Name:";
            // 
            // StaffAED
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.ControlBox = false;
            this.Controls.Add(this.aedTabs);
            this.Controls.Add(this.menuBtn);
            this.Controls.Add(this.exitBtn);
            this.Name = "StaffAED";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StaffAED";
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

        private System.Windows.Forms.Button menuBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.TabControl aedTabs;
        private System.Windows.Forms.TabPage addTab;
        private System.Windows.Forms.TextBox addFNameTxt;
        private System.Windows.Forms.Label addFNameLbl;
        private System.Windows.Forms.TabPage editTab;
        private System.Windows.Forms.TabPage deleteTab;
        private System.Windows.Forms.Label addPorFLbl;
        private System.Windows.Forms.Label addTitleLbl;
        private System.Windows.Forms.TextBox addSNameTxt;
        private System.Windows.Forms.Label addSNameLbl;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.ComboBox editIdCbx;
        private System.Windows.Forms.Label editIdLbl;
        private System.Windows.Forms.Button editBtn;
        private System.Windows.Forms.ComboBox editPorFCbx;
        private System.Windows.Forms.ComboBox editTitleCbx;
        private System.Windows.Forms.Label editPorFLbl;
        private System.Windows.Forms.Label editTitleLbl;
        private System.Windows.Forms.TextBox editSNameTxt;
        private System.Windows.Forms.Label editSNameLbl;
        private System.Windows.Forms.TextBox editFNameTxt;
        private System.Windows.Forms.Label editFNameLbl;
        private System.Windows.Forms.ComboBox deleteIdCbx;
        private System.Windows.Forms.Label deleteIdLbl;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Label deletePorFLbl;
        private System.Windows.Forms.Label deleteTitleLbl;
        private System.Windows.Forms.TextBox deleteSNameTxt;
        private System.Windows.Forms.Label deleteSNameLbl;
        private System.Windows.Forms.TextBox deleteFNameTxt;
        private System.Windows.Forms.Label deleteFNameLbl;
        private System.Windows.Forms.ComboBox addPorFCbx;
        private System.Windows.Forms.ComboBox addTitleCbx;
        private System.Windows.Forms.TextBox deletePorFTxt;
        private System.Windows.Forms.TextBox deleteTitleTxt;
    }
}