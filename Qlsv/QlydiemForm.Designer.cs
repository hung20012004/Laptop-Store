namespace Qlsv
{
    partial class QlydiemForm
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
            tableSV = new DataGridView();
            colID = new DataGridViewTextBoxColumn();
            colName = new DataGridViewTextBoxColumn();
            colGender = new DataGridViewTextBoxColumn();
            colKhoa = new DataGridViewTextBoxColumn();
            colClass = new DataGridViewTextBoxColumn();
            lbID = new Label();
            lbName = new Label();
            Gender = new Label();
            tbID = new TextBox();
            tbName = new TextBox();
            tbClass = new TextBox();
            lbKhoa = new Label();
            lbClass = new Label();
            cbKhoa = new ComboBox();
            cbGender = new ComboBox();
            Add = new Button();
            Update = new Button();
            Delete = new Button();
            btnInsert = new Button();
            ((System.ComponentModel.ISupportInitialize)tableSV).BeginInit();
            SuspendLayout();
            // 
            // tableSV
            // 
            tableSV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tableSV.Columns.AddRange(new DataGridViewColumn[] { colID, colName, colGender, colKhoa, colClass });
            tableSV.Location = new Point(35, 298);
            tableSV.Name = "tableSV";
            tableSV.RowHeadersWidth = 62;
            tableSV.RowTemplate.Height = 33;
            tableSV.Size = new Size(1235, 553);
            tableSV.TabIndex = 0;
            // 
            // colID
            // 
            colID.HeaderText = "Mã sinh viên";
            colID.MinimumWidth = 8;
            colID.Name = "colID";
            colID.Width = 300;
            // 
            // colName
            // 
            colName.HeaderText = "Tên";
            colName.MinimumWidth = 8;
            colName.Name = "colName";
            colName.Width = 300;
            // 
            // colGender
            // 
            colGender.HeaderText = "Giới tính";
            colGender.MinimumWidth = 8;
            colGender.Name = "colGender";
            colGender.Width = 170;
            // 
            // colKhoa
            // 
            colKhoa.HeaderText = "Khoa";
            colKhoa.MinimumWidth = 8;
            colKhoa.Name = "colKhoa";
            colKhoa.Width = 200;
            // 
            // colClass
            // 
            colClass.HeaderText = "Lớp";
            colClass.MinimumWidth = 8;
            colClass.Name = "colClass";
            colClass.Width = 200;
            // 
            // lbID
            // 
            lbID.AutoSize = true;
            lbID.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lbID.Location = new Point(44, 42);
            lbID.Name = "lbID";
            lbID.Size = new Size(121, 28);
            lbID.TabIndex = 1;
            lbID.Text = "Mã sinh viên";
            // 
            // lbName
            // 
            lbName.AutoSize = true;
            lbName.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lbName.Location = new Point(44, 98);
            lbName.Name = "lbName";
            lbName.Size = new Size(41, 28);
            lbName.TabIndex = 2;
            lbName.Text = "Tên";
            // 
            // Gender
            // 
            Gender.AutoSize = true;
            Gender.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            Gender.Location = new Point(558, 42);
            Gender.Name = "Gender";
            Gender.Size = new Size(87, 28);
            Gender.TabIndex = 3;
            Gender.Text = "Giới tính";
            // 
            // tbID
            // 
            tbID.Enabled = false;
            tbID.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            tbID.Location = new Point(187, 42);
            tbID.Name = "tbID";
            tbID.Size = new Size(321, 34);
            tbID.TabIndex = 4;
            // 
            // tbName
            // 
            tbName.Enabled = false;
            tbName.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            tbName.Location = new Point(187, 98);
            tbName.Name = "tbName";
            tbName.Size = new Size(321, 34);
            tbName.TabIndex = 5;
            // 
            // tbClass
            // 
            tbClass.Enabled = false;
            tbClass.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            tbClass.Location = new Point(187, 154);
            tbClass.Name = "tbClass";
            tbClass.Size = new Size(321, 34);
            tbClass.TabIndex = 6;
            // 
            // lbKhoa
            // 
            lbKhoa.AutoSize = true;
            lbKhoa.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lbKhoa.Location = new Point(44, 210);
            lbKhoa.Name = "lbKhoa";
            lbKhoa.Size = new Size(57, 28);
            lbKhoa.TabIndex = 8;
            lbKhoa.Text = "Khoa";
            // 
            // lbClass
            // 
            lbClass.AutoSize = true;
            lbClass.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lbClass.Location = new Point(44, 154);
            lbClass.Name = "lbClass";
            lbClass.Size = new Size(45, 28);
            lbClass.TabIndex = 9;
            lbClass.Text = "Lớp";
            // 
            // cbKhoa
            // 
            cbKhoa.Enabled = false;
            cbKhoa.FormattingEnabled = true;
            cbKhoa.Location = new Point(187, 210);
            cbKhoa.Name = "cbKhoa";
            cbKhoa.Size = new Size(200, 36);
            cbKhoa.TabIndex = 10;
            // 
            // cbGender
            // 
            cbGender.Enabled = false;
            cbGender.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            cbGender.FormattingEnabled = true;
            cbGender.Location = new Point(680, 42);
            cbGender.Name = "cbGender";
            cbGender.Size = new Size(200, 36);
            cbGender.TabIndex = 11;
            // 
            // Add
            // 
            Add.Location = new Point(973, 38);
            Add.Name = "Add";
            Add.Size = new Size(112, 45);
            Add.TabIndex = 12;
            Add.Text = "Thêm";
            Add.UseVisualStyleBackColor = true;
            Add.Click += Add_Click;
            // 
            // Update
            // 
            Update.Location = new Point(973, 111);
            Update.Name = "Update";
            Update.Size = new Size(112, 39);
            Update.TabIndex = 13;
            Update.Text = "Sửa";
            Update.UseVisualStyleBackColor = true;
            Update.Click += Update_Click;
            // 
            // Delete
            // 
            Delete.Location = new Point(973, 182);
            Delete.Name = "Delete";
            Delete.Size = new Size(112, 40);
            Delete.TabIndex = 14;
            Delete.Text = "Xóa";
            Delete.UseVisualStyleBackColor = true;
            // 
            // btnInsert
            // 
            btnInsert.Location = new Point(680, 93);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(129, 89);
            btnInsert.TabIndex = 15;
            btnInsert.Text = "Ghi dữ liệu";
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += btnInsert_Click;
            // 
            // QlydiemForm
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1312, 860);
            Controls.Add(btnInsert);
            Controls.Add(Delete);
            Controls.Add(Update);
            Controls.Add(Add);
            Controls.Add(cbGender);
            Controls.Add(cbKhoa);
            Controls.Add(lbClass);
            Controls.Add(lbKhoa);
            Controls.Add(tbClass);
            Controls.Add(tbName);
            Controls.Add(tbID);
            Controls.Add(Gender);
            Controls.Add(lbName);
            Controls.Add(lbID);
            Controls.Add(tableSV);
            Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "QlydiemForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "QlydiemForm";
            WindowState = FormWindowState.Maximized;
            Load += QlydiemForm_Load;
            ((System.ComponentModel.ISupportInitialize)tableSV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView tableSV;
        private Label lbID;
        private Label lbName;
        private Label Gender;
        private TextBox tbID;
        private TextBox tbName;
        private TextBox tbClass;
        private Label lbKhoa;
        private Label lbClass;
        private ComboBox cbKhoa;
        private ComboBox cbGender;
        private Button Add;
        private Button Update;
        private Button Delete;
        private DataGridViewTextBoxColumn colID;
        private DataGridViewTextBoxColumn colName;
        private DataGridViewTextBoxColumn colGender;
        private DataGridViewTextBoxColumn colKhoa;
        private DataGridViewTextBoxColumn colClass;
        private Button btnInsert;
    }
}