namespace EnterpriseManagementSystem
{
    partial class ManagerForm
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
            this.components = new System.ComponentModel.Container();
            this.PersonDataGirdView = new System.Windows.Forms.DataGridView();
            this.PersonId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PersonSex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PersonName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PersonAge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Department = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhoneNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsDel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.删除ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.Search = new System.Windows.Forms.TextBox();
            this.SearchName = new System.Windows.Forms.Button();
            this.SearchDepartment = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.新增员工ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.修改信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cobSex = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.AddStaff = new System.Windows.Forms.Button();
            this.cobDepartment = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbAge = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbAdress = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbPhoneNum = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.AddPanel = new System.Windows.Forms.Panel();
            this.RevisePanel = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cobReviseSex = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnRevise = new System.Windows.Forms.Button();
            this.cobReviseDepartment = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbReviseAge = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbReviseAdress = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tbRevisePhone = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tbReviseName = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PersonDataGirdView)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.AddPanel.SuspendLayout();
            this.RevisePanel.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // PersonDataGirdView
            // 
            this.PersonDataGirdView.AllowUserToDeleteRows = false;
            this.PersonDataGirdView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.PersonDataGirdView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PersonDataGirdView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PersonId,
            this.PersonSex,
            this.PersonName,
            this.PersonAge,
            this.Department,
            this.PhoneNum,
            this.Address,
            this.IsDel});
            this.PersonDataGirdView.ContextMenuStrip = this.contextMenuStrip1;
            this.PersonDataGirdView.Location = new System.Drawing.Point(-2, 100);
            this.PersonDataGirdView.MultiSelect = false;
            this.PersonDataGirdView.Name = "PersonDataGirdView";
            this.PersonDataGirdView.ReadOnly = true;
            this.PersonDataGirdView.RowTemplate.Height = 23;
            this.PersonDataGirdView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.PersonDataGirdView.Size = new System.Drawing.Size(740, 363);
            this.PersonDataGirdView.TabIndex = 0;
            // 
            // PersonId
            // 
            this.PersonId.DataPropertyName = "PersonId";
            this.PersonId.HeaderText = "Id";
            this.PersonId.Name = "PersonId";
            this.PersonId.ReadOnly = true;
            // 
            // PersonSex
            // 
            this.PersonSex.DataPropertyName = "PersonSex";
            this.PersonSex.HeaderText = "性别";
            this.PersonSex.Name = "PersonSex";
            this.PersonSex.ReadOnly = true;
            // 
            // PersonName
            // 
            this.PersonName.DataPropertyName = "PersonName";
            this.PersonName.HeaderText = "名字";
            this.PersonName.Name = "PersonName";
            this.PersonName.ReadOnly = true;
            // 
            // PersonAge
            // 
            this.PersonAge.DataPropertyName = "PersonAge";
            this.PersonAge.HeaderText = "年龄";
            this.PersonAge.Name = "PersonAge";
            this.PersonAge.ReadOnly = true;
            // 
            // Department
            // 
            this.Department.DataPropertyName = "Department";
            this.Department.HeaderText = "部门";
            this.Department.Name = "Department";
            this.Department.ReadOnly = true;
            // 
            // PhoneNum
            // 
            this.PhoneNum.DataPropertyName = "PhoneNum";
            this.PhoneNum.HeaderText = "电话";
            this.PhoneNum.Name = "PhoneNum";
            this.PhoneNum.ReadOnly = true;
            // 
            // Address
            // 
            this.Address.DataPropertyName = "Address";
            this.Address.HeaderText = "地址";
            this.Address.Name = "Address";
            this.Address.ReadOnly = true;
            // 
            // IsDel
            // 
            this.IsDel.DataPropertyName = "IsDel";
            this.IsDel.HeaderText = "是否在职";
            this.IsDel.Name = "IsDel";
            this.IsDel.ReadOnly = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.删除ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(101, 26);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // 删除ToolStripMenuItem
            // 
            this.删除ToolStripMenuItem.Name = "删除ToolStripMenuItem";
            this.删除ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.删除ToolStripMenuItem.Text = "删除";
            this.删除ToolStripMenuItem.Click += new System.EventHandler(this.删除ToolStripMenuItem_Click);
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // Search
            // 
            this.Search.Location = new System.Drawing.Point(468, 64);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(100, 21);
            this.Search.TabIndex = 1;
            // 
            // SearchName
            // 
            this.SearchName.Location = new System.Drawing.Point(574, 64);
            this.SearchName.Name = "SearchName";
            this.SearchName.Size = new System.Drawing.Size(75, 23);
            this.SearchName.TabIndex = 2;
            this.SearchName.Text = "按名字搜索";
            this.SearchName.UseVisualStyleBackColor = true;
            this.SearchName.Click += new System.EventHandler(this.SearchName_Click);
            // 
            // SearchDepartment
            // 
            this.SearchDepartment.Location = new System.Drawing.Point(655, 64);
            this.SearchDepartment.Name = "SearchDepartment";
            this.SearchDepartment.Size = new System.Drawing.Size(75, 23);
            this.SearchDepartment.TabIndex = 3;
            this.SearchDepartment.Text = "按部门搜索";
            this.SearchDepartment.UseVisualStyleBackColor = true;
            this.SearchDepartment.Click += new System.EventHandler(this.SearchDepartment_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.AllowMerge = false;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.新增员工ToolStripMenuItem,
            this.修改信息ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(738, 25);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 新增员工ToolStripMenuItem
            // 
            this.新增员工ToolStripMenuItem.Name = "新增员工ToolStripMenuItem";
            this.新增员工ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.新增员工ToolStripMenuItem.Text = "新增员工";
            this.新增员工ToolStripMenuItem.Click += new System.EventHandler(this.新增员工ToolStripMenuItem_Click);
            // 
            // 修改信息ToolStripMenuItem
            // 
            this.修改信息ToolStripMenuItem.Name = "修改信息ToolStripMenuItem";
            this.修改信息ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.修改信息ToolStripMenuItem.Text = "修改信息";
            this.修改信息ToolStripMenuItem.Click += new System.EventHandler(this.修改信息ToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cobSex);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.AddStaff);
            this.groupBox1.Controls.Add(this.cobDepartment);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.tbAge);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.tbAdress);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tbPhoneNum);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tbName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(3, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(413, 172);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // cobSex
            // 
            this.cobSex.FormattingEnabled = true;
            this.cobSex.Location = new System.Drawing.Point(315, 23);
            this.cobSex.Name = "cobSex";
            this.cobSex.Size = new System.Drawing.Size(67, 20);
            this.cobSex.TabIndex = 26;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("宋体", 10F);
            this.label7.Location = new System.Drawing.Point(279, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 14);
            this.label7.TabIndex = 25;
            this.label7.Text = "性别";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(245, 128);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 24;
            this.button2.Text = "取消";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // AddStaff
            // 
            this.AddStaff.Location = new System.Drawing.Point(84, 128);
            this.AddStaff.Name = "AddStaff";
            this.AddStaff.Size = new System.Drawing.Size(75, 23);
            this.AddStaff.TabIndex = 23;
            this.AddStaff.Text = "添加";
            this.AddStaff.UseVisualStyleBackColor = true;
            this.AddStaff.Click += new System.EventHandler(this.AddStaff_Click);
            // 
            // cobDepartment
            // 
            this.cobDepartment.FormattingEnabled = true;
            this.cobDepartment.Location = new System.Drawing.Point(282, 53);
            this.cobDepartment.Name = "cobDepartment";
            this.cobDepartment.Size = new System.Drawing.Size(100, 20);
            this.cobDepartment.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 10F);
            this.label6.Location = new System.Drawing.Point(241, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 14);
            this.label6.TabIndex = 21;
            this.label6.Text = "部门";
            // 
            // tbAge
            // 
            this.tbAge.Font = new System.Drawing.Font("宋体", 10F);
            this.tbAge.Location = new System.Drawing.Point(210, 22);
            this.tbAge.Name = "tbAge";
            this.tbAge.Size = new System.Drawing.Size(46, 23);
            this.tbAge.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 10F);
            this.label5.Location = new System.Drawing.Point(178, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 14);
            this.label5.TabIndex = 19;
            this.label5.Text = "年龄";
            // 
            // tbAdress
            // 
            this.tbAdress.Font = new System.Drawing.Font("宋体", 10F);
            this.tbAdress.Location = new System.Drawing.Point(69, 84);
            this.tbAdress.Name = "tbAdress";
            this.tbAdress.Size = new System.Drawing.Size(313, 23);
            this.tbAdress.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 10F);
            this.label4.Location = new System.Drawing.Point(28, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 14);
            this.label4.TabIndex = 17;
            this.label4.Text = "地址";
            // 
            // tbPhoneNum
            // 
            this.tbPhoneNum.Font = new System.Drawing.Font("宋体", 10F);
            this.tbPhoneNum.Location = new System.Drawing.Point(69, 53);
            this.tbPhoneNum.Name = "tbPhoneNum";
            this.tbPhoneNum.Size = new System.Drawing.Size(135, 23);
            this.tbPhoneNum.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 10F);
            this.label3.Location = new System.Drawing.Point(28, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 14);
            this.label3.TabIndex = 15;
            this.label3.Text = "电话";
            // 
            // tbName
            // 
            this.tbName.Font = new System.Drawing.Font("宋体", 10F);
            this.tbName.Location = new System.Drawing.Point(69, 22);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(90, 23);
            this.tbName.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 10F);
            this.label2.Location = new System.Drawing.Point(28, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 14);
            this.label2.TabIndex = 13;
            this.label2.Text = "姓名";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F);
            this.label1.Location = new System.Drawing.Point(3, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "新增员工";
            // 
            // AddPanel
            // 
            this.AddPanel.Controls.Add(this.groupBox1);
            this.AddPanel.Controls.Add(this.label1);
            this.AddPanel.Location = new System.Drawing.Point(138, 82);
            this.AddPanel.Name = "AddPanel";
            this.AddPanel.Size = new System.Drawing.Size(419, 207);
            this.AddPanel.TabIndex = 7;
            this.AddPanel.Visible = false;
            // 
            // RevisePanel
            // 
            this.RevisePanel.Controls.Add(this.groupBox2);
            this.RevisePanel.Controls.Add(this.label14);
            this.RevisePanel.Location = new System.Drawing.Point(138, 82);
            this.RevisePanel.Name = "RevisePanel";
            this.RevisePanel.Size = new System.Drawing.Size(419, 207);
            this.RevisePanel.TabIndex = 8;
            this.RevisePanel.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cobReviseSex);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.btnCancel);
            this.groupBox2.Controls.Add(this.btnRevise);
            this.groupBox2.Controls.Add(this.cobReviseDepartment);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.tbReviseAge);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.tbReviseAdress);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.tbRevisePhone);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.tbReviseName);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Location = new System.Drawing.Point(3, 23);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(413, 172);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // cobReviseSex
            // 
            this.cobReviseSex.FormattingEnabled = true;
            this.cobReviseSex.Location = new System.Drawing.Point(315, 23);
            this.cobReviseSex.Name = "cobReviseSex";
            this.cobReviseSex.Size = new System.Drawing.Size(67, 20);
            this.cobReviseSex.TabIndex = 26;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("宋体", 10F);
            this.label8.Location = new System.Drawing.Point(279, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 14);
            this.label8.TabIndex = 25;
            this.label8.Text = "性别";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(245, 128);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 24;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnRevise
            // 
            this.btnRevise.Location = new System.Drawing.Point(84, 128);
            this.btnRevise.Name = "btnRevise";
            this.btnRevise.Size = new System.Drawing.Size(75, 23);
            this.btnRevise.TabIndex = 23;
            this.btnRevise.Text = "修改";
            this.btnRevise.UseVisualStyleBackColor = true;
            this.btnRevise.Click += new System.EventHandler(this.btnRevise_Click);
            // 
            // cobReviseDepartment
            // 
            this.cobReviseDepartment.FormattingEnabled = true;
            this.cobReviseDepartment.Location = new System.Drawing.Point(282, 53);
            this.cobReviseDepartment.Name = "cobReviseDepartment";
            this.cobReviseDepartment.Size = new System.Drawing.Size(100, 20);
            this.cobReviseDepartment.TabIndex = 22;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("宋体", 10F);
            this.label9.Location = new System.Drawing.Point(241, 56);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 14);
            this.label9.TabIndex = 21;
            this.label9.Text = "部门";
            // 
            // tbReviseAge
            // 
            this.tbReviseAge.Font = new System.Drawing.Font("宋体", 10F);
            this.tbReviseAge.Location = new System.Drawing.Point(210, 22);
            this.tbReviseAge.Name = "tbReviseAge";
            this.tbReviseAge.Size = new System.Drawing.Size(46, 23);
            this.tbReviseAge.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("宋体", 10F);
            this.label10.Location = new System.Drawing.Point(178, 25);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 14);
            this.label10.TabIndex = 19;
            this.label10.Text = "年龄";
            // 
            // tbReviseAdress
            // 
            this.tbReviseAdress.Font = new System.Drawing.Font("宋体", 10F);
            this.tbReviseAdress.Location = new System.Drawing.Point(69, 84);
            this.tbReviseAdress.Name = "tbReviseAdress";
            this.tbReviseAdress.Size = new System.Drawing.Size(313, 23);
            this.tbReviseAdress.TabIndex = 18;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("宋体", 10F);
            this.label11.Location = new System.Drawing.Point(28, 87);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(35, 14);
            this.label11.TabIndex = 17;
            this.label11.Text = "地址";
            // 
            // tbRevisePhone
            // 
            this.tbRevisePhone.Font = new System.Drawing.Font("宋体", 10F);
            this.tbRevisePhone.Location = new System.Drawing.Point(69, 53);
            this.tbRevisePhone.Name = "tbRevisePhone";
            this.tbRevisePhone.Size = new System.Drawing.Size(135, 23);
            this.tbRevisePhone.TabIndex = 16;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("宋体", 10F);
            this.label12.Location = new System.Drawing.Point(28, 56);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(35, 14);
            this.label12.TabIndex = 15;
            this.label12.Text = "电话";
            // 
            // tbReviseName
            // 
            this.tbReviseName.Font = new System.Drawing.Font("宋体", 10F);
            this.tbReviseName.Location = new System.Drawing.Point(69, 22);
            this.tbReviseName.Name = "tbReviseName";
            this.tbReviseName.Size = new System.Drawing.Size(90, 23);
            this.tbReviseName.TabIndex = 14;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("宋体", 10F);
            this.label13.Location = new System.Drawing.Point(28, 25);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(35, 14);
            this.label13.TabIndex = 13;
            this.label13.Text = "姓名";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("宋体", 12F);
            this.label14.Location = new System.Drawing.Point(3, 4);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(72, 16);
            this.label14.TabIndex = 0;
            this.label14.Text = "修改信息";
            // 
            // ManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 462);
            this.Controls.Add(this.RevisePanel);
            this.Controls.Add(this.AddPanel);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.SearchDepartment);
            this.Controls.Add(this.SearchName);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.PersonDataGirdView);
            this.Name = "ManagerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "员工管理";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ManagerForm_FormClosing);
            this.Load += new System.EventHandler(this.ManagerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PersonDataGirdView)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.AddPanel.ResumeLayout(false);
            this.AddPanel.PerformLayout();
            this.RevisePanel.ResumeLayout(false);
            this.RevisePanel.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView PersonDataGirdView;
        private System.DirectoryServices.DirectorySearcher directorySearcher1;
        private System.Windows.Forms.TextBox Search;
        private System.Windows.Forms.Button SearchName;
        private System.Windows.Forms.Button SearchDepartment;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 删除ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 新增员工ToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button AddStaff;
        private System.Windows.Forms.ComboBox cobDepartment;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbAge;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbAdress;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbPhoneNum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel AddPanel;
        private System.Windows.Forms.ComboBox cobSex;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ToolStripMenuItem 修改信息ToolStripMenuItem;
        private System.Windows.Forms.Panel RevisePanel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cobReviseSex;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnRevise;
        private System.Windows.Forms.ComboBox cobReviseDepartment;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbReviseAge;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbReviseAdress;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbRevisePhone;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tbReviseName;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DataGridViewTextBoxColumn PersonId;
        private System.Windows.Forms.DataGridViewTextBoxColumn PersonSex;
        private System.Windows.Forms.DataGridViewTextBoxColumn PersonName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PersonAge;
        private System.Windows.Forms.DataGridViewTextBoxColumn Department;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhoneNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn IsDel;
    }
}