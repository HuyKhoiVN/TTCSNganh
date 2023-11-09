namespace CustomerManager
{
    partial class RecordCusInfor
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
            dgvRecordCusInf = new DataGridView();
            btnFix = new Button();
            lblRecordCusInfor = new Label();
            btnDele = new Button();
            lblFixCusInf = new Label();
            lblCusInf = new Label();
            dgvCusInf = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            lblName = new Label();
            lblNumber = new Label();
            lblEmail = new Label();
            lblRequire = new Label();
            lblStatus = new Label();
            lblTime = new Label();
            colCusName = new DataGridViewTextBoxColumn();
            colCusNumber = new DataGridViewTextBoxColumn();
            colCusEmail = new DataGridViewTextBoxColumn();
            colCusRequire = new DataGridViewTextBoxColumn();
            colStatus = new DataGridViewTextBoxColumn();
            colTime = new DataGridViewTextBoxColumn();
            txtName = new TextBox();
            txtEmail = new TextBox();
            txtNumber = new TextBox();
            txtTime = new TextBox();
            txtStatus = new TextBox();
            txtRequire = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvRecordCusInf).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvCusInf).BeginInit();
            SuspendLayout();
            // 
            // dgvRecordCusInf
            // 
            dgvRecordCusInf.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRecordCusInf.Columns.AddRange(new DataGridViewColumn[] { colCusName, colCusNumber, colCusEmail, colCusRequire, colStatus, colTime });
            dgvRecordCusInf.Location = new Point(101, 83);
            dgvRecordCusInf.Name = "dgvRecordCusInf";
            dgvRecordCusInf.RowTemplate.Height = 25;
            dgvRecordCusInf.Size = new Size(783, 50);
            dgvRecordCusInf.TabIndex = 1;
            dgvRecordCusInf.CellContentClick += dataGridView1_CellContentClick;
            // 
            // btnFix
            // 
            btnFix.Location = new Point(722, 157);
            btnFix.Name = "btnFix";
            btnFix.Size = new Size(75, 23);
            btnFix.TabIndex = 2;
            btnFix.Text = "Sửa";
            btnFix.UseVisualStyleBackColor = true;
            btnFix.Click += button1_Click;
            // 
            // lblRecordCusInfor
            // 
            lblRecordCusInfor.AutoSize = true;
            lblRecordCusInfor.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lblRecordCusInfor.Location = new Point(364, 28);
            lblRecordCusInfor.Name = "lblRecordCusInfor";
            lblRecordCusInfor.Size = new Size(286, 28);
            lblRecordCusInfor.TabIndex = 3;
            lblRecordCusInfor.Text = "Ghi  nhận thông tin khách hàng";
            lblRecordCusInfor.Click += label1_Click_1;
            // 
            // btnDele
            // 
            btnDele.Location = new Point(809, 157);
            btnDele.Name = "btnDele";
            btnDele.Size = new Size(75, 23);
            btnDele.TabIndex = 4;
            btnDele.Text = "Xoá";
            btnDele.UseVisualStyleBackColor = true;
            // 
            // lblFixCusInf
            // 
            lblFixCusInf.AutoSize = true;
            lblFixCusInf.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            lblFixCusInf.Location = new Point(101, 210);
            lblFixCusInf.Name = "lblFixCusInf";
            lblFixCusInf.Size = new Size(216, 25);
            lblFixCusInf.TabIndex = 5;
            lblFixCusInf.Text = "Sửa thông tin khách hàng";
            // 
            // lblCusInf
            // 
            lblCusInf.AutoSize = true;
            lblCusInf.Font = new Font("Segoe UI", 9F, FontStyle.Underline, GraphicsUnit.Point);
            lblCusInf.Location = new Point(101, 248);
            lblCusInf.Name = "lblCusInf";
            lblCusInf.Size = new Size(123, 15);
            lblCusInf.TabIndex = 6;
            lblCusInf.Text = "Thông tin khách hàng";
            // 
            // dgvCusInf
            // 
            dgvCusInf.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCusInf.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5, dataGridViewTextBoxColumn6 });
            dgvCusInf.Location = new Point(101, 281);
            dgvCusInf.Name = "dgvCusInf";
            dgvCusInf.RowTemplate.Height = 25;
            dgvCusInf.Size = new Size(662, 60);
            dgvCusInf.TabIndex = 7;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn1.HeaderText = "Tên khách hàng";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn2.HeaderText = "Số điện thoại";
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.HeaderText = "Email";
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn4.HeaderText = "Nội dung yêu cầu";
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn5.HeaderText = "Trạng thái xử lí";
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            dataGridViewTextBoxColumn6.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn6.HeaderText = "Thời gian yêu cầu";
            dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(101, 385);
            lblName.Name = "lblName";
            lblName.Size = new Size(90, 15);
            lblName.TabIndex = 8;
            lblName.Text = "Tên khách hàng";
            // 
            // lblNumber
            // 
            lblNumber.AutoSize = true;
            lblNumber.Location = new Point(101, 427);
            lblNumber.Name = "lblNumber";
            lblNumber.Size = new Size(76, 15);
            lblNumber.TabIndex = 9;
            lblNumber.Text = "Số điện thoại";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(110, 480);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(36, 15);
            lblEmail.TabIndex = 10;
            lblEmail.Text = "Email";
            // 
            // lblRequire
            // 
            lblRequire.AutoSize = true;
            lblRequire.Location = new Point(592, 385);
            lblRequire.Name = "lblRequire";
            lblRequire.Size = new Size(101, 15);
            lblRequire.TabIndex = 11;
            lblRequire.Text = "Nội dung yêu cầu";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(592, 427);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(59, 15);
            lblStatus.TabIndex = 12;
            lblStatus.Text = "Trạng thái";
            lblStatus.Click += label5_Click;
            // 
            // lblTime
            // 
            lblTime.AutoSize = true;
            lblTime.Location = new Point(593, 480);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(100, 15);
            lblTime.TabIndex = 13;
            lblTime.Text = "Thời gian yêu cầu";
            // 
            // colCusName
            // 
            colCusName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colCusName.HeaderText = "Tên khách hàng";
            colCusName.Name = "colCusName";
            // 
            // colCusNumber
            // 
            colCusNumber.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colCusNumber.HeaderText = "Số điện thoại";
            colCusNumber.Name = "colCusNumber";
            // 
            // colCusEmail
            // 
            colCusEmail.HeaderText = "Email";
            colCusEmail.Name = "colCusEmail";
            // 
            // colCusRequire
            // 
            colCusRequire.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colCusRequire.HeaderText = "Nội dung yêu cầu";
            colCusRequire.Name = "colCusRequire";
            // 
            // colStatus
            // 
            colStatus.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colStatus.HeaderText = "Trạng thái xử lí";
            colStatus.Name = "colStatus";
            // 
            // colTime
            // 
            colTime.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colTime.HeaderText = "Thời gian yêu cầu";
            colTime.Name = "colTime";
            // 
            // txtName
            // 
            txtName.Location = new Point(239, 385);
            txtName.Name = "txtName";
            txtName.Size = new Size(222, 23);
            txtName.TabIndex = 14;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(239, 472);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(222, 23);
            txtEmail.TabIndex = 17;
            // 
            // txtNumber
            // 
            txtNumber.Location = new Point(239, 427);
            txtNumber.Name = "txtNumber";
            txtNumber.Size = new Size(222, 23);
            txtNumber.TabIndex = 18;
            // 
            // txtTime
            // 
            txtTime.Location = new Point(722, 472);
            txtTime.Name = "txtTime";
            txtTime.Size = new Size(222, 23);
            txtTime.TabIndex = 20;
            // 
            // txtStatus
            // 
            txtStatus.Location = new Point(722, 427);
            txtStatus.Name = "txtStatus";
            txtStatus.Size = new Size(222, 23);
            txtStatus.TabIndex = 21;
            // 
            // txtRequire
            // 
            txtRequire.Location = new Point(722, 377);
            txtRequire.Name = "txtRequire";
            txtRequire.Size = new Size(222, 23);
            txtRequire.TabIndex = 22;
            txtRequire.TextChanged += textBox7_TextChanged;
            // 
            // RecordCusInfor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1197, 623);
            Controls.Add(txtRequire);
            Controls.Add(txtStatus);
            Controls.Add(txtTime);
            Controls.Add(txtNumber);
            Controls.Add(txtEmail);
            Controls.Add(txtName);
            Controls.Add(lblTime);
            Controls.Add(lblStatus);
            Controls.Add(lblRequire);
            Controls.Add(lblEmail);
            Controls.Add(lblNumber);
            Controls.Add(lblName);
            Controls.Add(dgvCusInf);
            Controls.Add(lblCusInf);
            Controls.Add(lblFixCusInf);
            Controls.Add(btnDele);
            Controls.Add(lblRecordCusInfor);
            Controls.Add(btnFix);
            Controls.Add(dgvRecordCusInf);
            Name = "RecordCusInfor";
            Text = "RecordCusInfor";
            Load += RecordCusInfor_Load;
            ((System.ComponentModel.ISupportInitialize)dgvRecordCusInf).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvCusInf).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dgvRecordCusInf;
        private Button btnFix;
        private Label lblRecordCusInfor;
        private Button btnDele;
        private Label lblFixCusInf;
        private Label lblCusInf;
        private DataGridView dgvCusInf;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private Label lblName;
        private Label lblNumber;
        private Label lblEmail;
        private Label lblRequire;
        private Label lblStatus;
        private Label lblTime;
        private DataGridViewTextBoxColumn colCusName;
        private DataGridViewTextBoxColumn colCusNumber;
        private DataGridViewTextBoxColumn colCusEmail;
        private DataGridViewTextBoxColumn colCusRequire;
        private DataGridViewTextBoxColumn colStatus;
        private DataGridViewTextBoxColumn colTime;
        private TextBox txtName;
        private TextBox txtEmail;
        private TextBox txtNumber;
        private TextBox txtTime;
        private TextBox txtStatus;
        private TextBox txtRequire;
    }
}