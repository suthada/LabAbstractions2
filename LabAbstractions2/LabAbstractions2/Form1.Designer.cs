namespace LabAbstractions2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonCheckOut = new System.Windows.Forms.Button();
            this.buttonCheckIn = new System.Windows.Forms.Button();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxUserorId = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelUserorID = new System.Windows.Forms.Label();
            this.groupBoxMember = new System.Windows.Forms.GroupBox();
            this.comboBoxMajor = new System.Windows.Forms.ComboBox();
            this.buttonRegister = new System.Windows.Forms.Button();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxPassword2 = new System.Windows.Forms.TextBox();
            this.textBoxSSID = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.labelPassword2 = new System.Windows.Forms.Label();
            this.labelSSID = new System.Windows.Forms.Label();
            this.labelMajor = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColumnMajor1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSSID1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnName1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPassword1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.ColumnMajor2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSSID2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPassword = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBoxMember.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonCheckOut);
            this.groupBox1.Controls.Add(this.buttonCheckIn);
            this.groupBox1.Controls.Add(this.textBoxPassword);
            this.groupBox1.Controls.Add(this.textBoxUserorId);
            this.groupBox1.Controls.Add(this.labelPassword);
            this.groupBox1.Controls.Add(this.labelUserorID);
            this.groupBox1.Location = new System.Drawing.Point(23, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(317, 177);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Login";
            // 
            // buttonCheckOut
            // 
            this.buttonCheckOut.Location = new System.Drawing.Point(174, 132);
            this.buttonCheckOut.Name = "buttonCheckOut";
            this.buttonCheckOut.Size = new System.Drawing.Size(125, 29);
            this.buttonCheckOut.TabIndex = 5;
            this.buttonCheckOut.Text = "CheckOut";
            this.buttonCheckOut.UseVisualStyleBackColor = true;
            this.buttonCheckOut.Click += new System.EventHandler(this.buttonCheckOut_Click);
            // 
            // buttonCheckIn
            // 
            this.buttonCheckIn.Location = new System.Drawing.Point(174, 97);
            this.buttonCheckIn.Name = "buttonCheckIn";
            this.buttonCheckIn.Size = new System.Drawing.Size(125, 29);
            this.buttonCheckIn.TabIndex = 4;
            this.buttonCheckIn.Text = "CheckIn";
            this.buttonCheckIn.UseVisualStyleBackColor = true;
            this.buttonCheckIn.Click += new System.EventHandler(this.buttonCheckIn_Click);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(174, 64);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(125, 27);
            this.textBoxPassword.TabIndex = 3;
            // 
            // textBoxUserorId
            // 
            this.textBoxUserorId.Location = new System.Drawing.Point(174, 31);
            this.textBoxUserorId.Name = "textBoxUserorId";
            this.textBoxUserorId.Size = new System.Drawing.Size(125, 27);
            this.textBoxUserorId.TabIndex = 2;
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(16, 67);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(70, 20);
            this.labelPassword.TabIndex = 1;
            this.labelPassword.Text = "Password";
            // 
            // labelUserorID
            // 
            this.labelUserorID.AutoSize = true;
            this.labelUserorID.Location = new System.Drawing.Point(16, 34);
            this.labelUserorID.Name = "labelUserorID";
            this.labelUserorID.Size = new System.Drawing.Size(75, 20);
            this.labelUserorID.TabIndex = 0;
            this.labelUserorID.Text = "User or ID";
            // 
            // groupBoxMember
            // 
            this.groupBoxMember.Controls.Add(this.comboBoxMajor);
            this.groupBoxMember.Controls.Add(this.buttonRegister);
            this.groupBoxMember.Controls.Add(this.textBoxName);
            this.groupBoxMember.Controls.Add(this.textBoxPassword2);
            this.groupBoxMember.Controls.Add(this.textBoxSSID);
            this.groupBoxMember.Controls.Add(this.labelName);
            this.groupBoxMember.Controls.Add(this.labelPassword2);
            this.groupBoxMember.Controls.Add(this.labelSSID);
            this.groupBoxMember.Controls.Add(this.labelMajor);
            this.groupBoxMember.Location = new System.Drawing.Point(23, 232);
            this.groupBoxMember.Name = "groupBoxMember";
            this.groupBoxMember.Size = new System.Drawing.Size(317, 221);
            this.groupBoxMember.TabIndex = 1;
            this.groupBoxMember.TabStop = false;
            this.groupBoxMember.Text = "Member";
            // 
            // comboBoxMajor
            // 
            this.comboBoxMajor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMajor.FormattingEnabled = true;
            this.comboBoxMajor.Items.AddRange(new object[] {
            "Staff",
            "Teacher",
            "Student"});
            this.comboBoxMajor.Location = new System.Drawing.Point(174, 37);
            this.comboBoxMajor.Name = "comboBoxMajor";
            this.comboBoxMajor.Size = new System.Drawing.Size(125, 28);
            this.comboBoxMajor.TabIndex = 10;
            // 
            // buttonRegister
            // 
            this.buttonRegister.Location = new System.Drawing.Point(174, 172);
            this.buttonRegister.Name = "buttonRegister";
            this.buttonRegister.Size = new System.Drawing.Size(125, 29);
            this.buttonRegister.TabIndex = 9;
            this.buttonRegister.Text = "Register";
            this.buttonRegister.UseVisualStyleBackColor = true;
            this.buttonRegister.Click += new System.EventHandler(this.buttonRegister_Click);
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(174, 104);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(125, 27);
            this.textBoxName.TabIndex = 8;
            // 
            // textBoxPassword2
            // 
            this.textBoxPassword2.Location = new System.Drawing.Point(174, 136);
            this.textBoxPassword2.Name = "textBoxPassword2";
            this.textBoxPassword2.Size = new System.Drawing.Size(125, 27);
            this.textBoxPassword2.TabIndex = 7;
            // 
            // textBoxSSID
            // 
            this.textBoxSSID.Location = new System.Drawing.Point(174, 71);
            this.textBoxSSID.Name = "textBoxSSID";
            this.textBoxSSID.Size = new System.Drawing.Size(125, 27);
            this.textBoxSSID.TabIndex = 6;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(16, 111);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(49, 20);
            this.labelName.TabIndex = 5;
            this.labelName.Text = "Name";
            // 
            // labelPassword2
            // 
            this.labelPassword2.AutoSize = true;
            this.labelPassword2.Location = new System.Drawing.Point(16, 143);
            this.labelPassword2.Name = "labelPassword2";
            this.labelPassword2.Size = new System.Drawing.Size(70, 20);
            this.labelPassword2.TabIndex = 4;
            this.labelPassword2.Text = "Password";
            // 
            // labelSSID
            // 
            this.labelSSID.AutoSize = true;
            this.labelSSID.Location = new System.Drawing.Point(16, 79);
            this.labelSSID.Name = "labelSSID";
            this.labelSSID.Size = new System.Drawing.Size(40, 20);
            this.labelSSID.TabIndex = 3;
            this.labelSSID.Text = "SSID";
            // 
            // labelMajor
            // 
            this.labelMajor.AutoSize = true;
            this.labelMajor.Location = new System.Drawing.Point(16, 45);
            this.labelMajor.Name = "labelMajor";
            this.labelMajor.Size = new System.Drawing.Size(48, 20);
            this.labelMajor.TabIndex = 2;
            this.labelMajor.Text = "Major";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(957, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(128, 26);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(128, 26);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click_1);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnMajor1,
            this.ColumnSSID1,
            this.ColumnName1,
            this.ColumnPassword1});
            this.dataGridView1.Location = new System.Drawing.Point(357, 57);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(551, 177);
            this.dataGridView1.TabIndex = 3;
            // 
            // ColumnMajor1
            // 
            this.ColumnMajor1.HeaderText = "Major";
            this.ColumnMajor1.MinimumWidth = 6;
            this.ColumnMajor1.Name = "ColumnMajor1";
            this.ColumnMajor1.Width = 125;
            // 
            // ColumnSSID1
            // 
            this.ColumnSSID1.HeaderText = "SSID";
            this.ColumnSSID1.MinimumWidth = 6;
            this.ColumnSSID1.Name = "ColumnSSID1";
            this.ColumnSSID1.Width = 125;
            // 
            // ColumnName1
            // 
            this.ColumnName1.HeaderText = "Name";
            this.ColumnName1.MinimumWidth = 6;
            this.ColumnName1.Name = "ColumnName1";
            this.ColumnName1.Width = 125;
            // 
            // ColumnPassword1
            // 
            this.ColumnPassword1.HeaderText = "Password";
            this.ColumnPassword1.MinimumWidth = 6;
            this.ColumnPassword1.Name = "ColumnPassword1";
            this.ColumnPassword1.Width = 125;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnMajor2,
            this.ColumnSSID2,
            this.ColumnName,
            this.ColumnPassword});
            this.dataGridView2.Location = new System.Drawing.Point(357, 256);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 29;
            this.dataGridView2.Size = new System.Drawing.Size(551, 177);
            this.dataGridView2.TabIndex = 4;
            // 
            // ColumnMajor2
            // 
            this.ColumnMajor2.HeaderText = "Major";
            this.ColumnMajor2.MinimumWidth = 6;
            this.ColumnMajor2.Name = "ColumnMajor2";
            this.ColumnMajor2.Width = 125;
            // 
            // ColumnSSID2
            // 
            this.ColumnSSID2.HeaderText = "SSID";
            this.ColumnSSID2.MinimumWidth = 6;
            this.ColumnSSID2.Name = "ColumnSSID2";
            this.ColumnSSID2.Width = 125;
            // 
            // ColumnName
            // 
            this.ColumnName.HeaderText = "Name";
            this.ColumnName.MinimumWidth = 6;
            this.ColumnName.Name = "ColumnName";
            this.ColumnName.Width = 125;
            // 
            // ColumnPassword
            // 
            this.ColumnPassword.HeaderText = "Password";
            this.ColumnPassword.MinimumWidth = 6;
            this.ColumnPassword.Name = "ColumnPassword";
            this.ColumnPassword.Width = 125;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 492);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBoxMember);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBoxMember.ResumeLayout(false);
            this.groupBoxMember.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox groupBox1;
        private Button buttonCheckOut;
        private Button buttonCheckIn;
        private TextBox textBoxPassword;
        private TextBox textBoxUserorId;
        private Label labelPassword;
        private Label labelUserorID;
        private GroupBox groupBoxMember;
        private Button buttonRegister;
        private TextBox textBoxName;
        private TextBox textBoxPassword2;
        private TextBox textBoxSSID;
        private Label labelName;
        private Label labelPassword2;
        private Label labelSSID;
        private Label labelMajor;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private DataGridView dataGridView1;
        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn ColumnMajor1;
        private DataGridViewTextBoxColumn ColumnSSID1;
        private DataGridViewTextBoxColumn ColumnName1;
        private DataGridViewTextBoxColumn ColumnPassword1;
        private DataGridViewTextBoxColumn ColumnMajor2;
        private DataGridViewTextBoxColumn ColumnSSID2;
        private DataGridViewTextBoxColumn ColumnName;
        private DataGridViewTextBoxColumn ColumnPassword;
        private ComboBox comboBoxMajor;
    }
}