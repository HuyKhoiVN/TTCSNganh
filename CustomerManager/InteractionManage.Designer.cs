namespace CustomerManager
{
    partial class InteractionManage
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
            lblTitleInteractive = new Label();
            txtTime = new TextBox();
            lblTitleAddInteractive = new Label();
            dgvInteraction = new DataGridView();
            colTime = new DataGridViewTextBoxColumn();
            colPartner = new DataGridViewTextBoxColumn();
            colPurpose = new DataGridViewTextBoxColumn();
            colStatus = new DataGridViewTextBoxColumn();
            btnView = new Button();
            btnAddInteraction = new Button();
            lblTime = new Label();
            lblPartner = new Label();
            txtPartner = new TextBox();
            lblPurpose = new Label();
            txtPurpose = new TextBox();
            lblStatus = new Label();
            txtStatus = new TextBox();
            btnCreate = new Button();
            btnCancel = new Button();
            label1 = new Label();
            lblInfor = new Label();
            lblContent = new Label();
            dataGridView1 = new DataGridView();
            colName = new DataGridViewTextBoxColumn();
            colAge = new DataGridViewTextBoxColumn();
            colAddress = new DataGridViewTextBoxColumn();
            colEmail_PhoneNumber = new DataGridViewTextBoxColumn();
            textBox1 = new TextBox();
            btnCreateCallDetail = new Button();
            btnDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvInteraction).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // lblTitleInteractive
            // 
            lblTitleInteractive.AutoSize = true;
            lblTitleInteractive.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitleInteractive.Location = new Point(297, 22);
            lblTitleInteractive.Name = "lblTitleInteractive";
            lblTitleInteractive.Size = new Size(236, 28);
            lblTitleInteractive.TabIndex = 0;
            lblTitleInteractive.Text = "Quản lý cuộc gọi và email";
            lblTitleInteractive.Click += label1_Click;
            // 
            // txtTime
            // 
            txtTime.Location = new Point(270, 268);
            txtTime.Name = "txtTime";
            txtTime.Size = new Size(138, 23);
            txtTime.TabIndex = 3;
            // 
            // lblTitleAddInteractive
            // 
            lblTitleAddInteractive.AutoSize = true;
            lblTitleAddInteractive.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitleAddInteractive.Location = new Point(178, 220);
            lblTitleAddInteractive.Name = "lblTitleAddInteractive";
            lblTitleAddInteractive.Size = new Size(199, 25);
            lblTitleAddInteractive.TabIndex = 4;
            lblTitleAddInteractive.Text = "Thêm cuộc gọi và email";
            // 
            // dgvInteraction
            // 
            dgvInteraction.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInteraction.Columns.AddRange(new DataGridViewColumn[] { colTime, colPartner, colPurpose, colStatus });
            dgvInteraction.Location = new Point(181, 70);
            dgvInteraction.Margin = new Padding(3, 2, 3, 2);
            dgvInteraction.Name = "dgvInteraction";
            dgvInteraction.RowHeadersWidth = 51;
            dgvInteraction.RowTemplate.Height = 29;
            dgvInteraction.Size = new Size(506, 44);
            dgvInteraction.TabIndex = 5;
            dgvInteraction.CellContentClick += dataGridView1_CellContentClick;
            // 
            // colTime
            // 
            colTime.HeaderText = "Thời gian";
            colTime.MinimumWidth = 6;
            colTime.Name = "colTime";
            colTime.Width = 125;
            // 
            // colPartner
            // 
            colPartner.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colPartner.HeaderText = "Đối tác tham gia";
            colPartner.MinimumWidth = 6;
            colPartner.Name = "colPartner";
            // 
            // colPurpose
            // 
            colPurpose.HeaderText = "Mục đích";
            colPurpose.MinimumWidth = 6;
            colPurpose.Name = "colPurpose";
            colPurpose.Width = 125;
            // 
            // colStatus
            // 
            colStatus.HeaderText = "Trạng thái";
            colStatus.MinimumWidth = 6;
            colStatus.Name = "colStatus";
            colStatus.Width = 125;
            // 
            // btnView
            // 
            btnView.Location = new Point(382, 156);
            btnView.Margin = new Padding(3, 2, 3, 2);
            btnView.Name = "btnView";
            btnView.Size = new Size(82, 22);
            btnView.TabIndex = 6;
            btnView.Text = "Xem";
            btnView.UseVisualStyleBackColor = true;
            btnView.Click += button1_Click;
            // 
            // btnAddInteraction
            // 
            btnAddInteraction.Location = new Point(470, 156);
            btnAddInteraction.Margin = new Padding(3, 2, 3, 2);
            btnAddInteraction.Name = "btnAddInteraction";
            btnAddInteraction.Size = new Size(195, 22);
            btnAddInteraction.TabIndex = 7;
            btnAddInteraction.Text = "Tạo cuộc gọi hoặc email mới";
            btnAddInteraction.UseVisualStyleBackColor = true;
            // 
            // lblTime
            // 
            lblTime.AutoSize = true;
            lblTime.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblTime.Location = new Point(167, 271);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(56, 15);
            lblTime.TabIndex = 8;
            lblTime.Text = "Thời gian";
            // 
            // lblPartner
            // 
            lblPartner.AutoSize = true;
            lblPartner.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblPartner.Location = new Point(167, 308);
            lblPartner.Name = "lblPartner";
            lblPartner.Size = new Size(44, 15);
            lblPartner.TabIndex = 10;
            lblPartner.Text = "Đối tác";
            // 
            // txtPartner
            // 
            txtPartner.Location = new Point(270, 306);
            txtPartner.Name = "txtPartner";
            txtPartner.Size = new Size(138, 23);
            txtPartner.TabIndex = 9;
            // 
            // lblPurpose
            // 
            lblPurpose.AutoSize = true;
            lblPurpose.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblPurpose.Location = new Point(167, 351);
            lblPurpose.Name = "lblPurpose";
            lblPurpose.Size = new Size(57, 15);
            lblPurpose.TabIndex = 12;
            lblPurpose.Text = "Mục đích";
            // 
            // txtPurpose
            // 
            txtPurpose.Location = new Point(270, 349);
            txtPurpose.Name = "txtPurpose";
            txtPurpose.Size = new Size(138, 23);
            txtPurpose.TabIndex = 11;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblStatus.Location = new Point(167, 397);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(59, 15);
            lblStatus.TabIndex = 14;
            lblStatus.Text = "Trạng thái";
            // 
            // txtStatus
            // 
            txtStatus.Location = new Point(270, 394);
            txtStatus.Name = "txtStatus";
            txtStatus.Size = new Size(138, 23);
            txtStatus.TabIndex = 13;
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(240, 431);
            btnCreate.Margin = new Padding(3, 2, 3, 2);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(82, 22);
            btnCreate.TabIndex = 15;
            btnCreate.Text = "Tạo";
            btnCreate.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(327, 431);
            btnCancel.Margin = new Padding(3, 2, 3, 2);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(82, 22);
            btnCancel.TabIndex = 16;
            btnCancel.Text = "Huỷ";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(691, 220);
            label1.Name = "label1";
            label1.Size = new Size(140, 25);
            label1.TabIndex = 17;
            label1.Text = "Chi tiết cuộc gọi";
            label1.Click += label1_Click_1;
            // 
            // lblInfor
            // 
            lblInfor.AutoSize = true;
            lblInfor.Font = new Font("Segoe UI", 13F, FontStyle.Underline, GraphicsUnit.Point);
            lblInfor.Location = new Point(497, 265);
            lblInfor.Name = "lblInfor";
            lblInfor.Size = new Size(147, 25);
            lblInfor.TabIndex = 18;
            lblInfor.Text = "Thông tin đối tác";
            lblInfor.Click += label2_Click;
            // 
            // lblContent
            // 
            lblContent.AutoSize = true;
            lblContent.Font = new Font("Segoe UI", 13F, FontStyle.Underline, GraphicsUnit.Point);
            lblContent.Location = new Point(498, 363);
            lblContent.Name = "lblContent";
            lblContent.Size = new Size(160, 25);
            lblContent.TabIndex = 19;
            lblContent.Text = "Nội dung cuộc gọi";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { colName, colAge, colAddress, colEmail_PhoneNumber });
            dataGridView1.Location = new Point(497, 290);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(474, 60);
            dataGridView1.TabIndex = 20;
            // 
            // colName
            // 
            colName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colName.HeaderText = "Tên";
            colName.MinimumWidth = 6;
            colName.Name = "colName";
            // 
            // colAge
            // 
            colAge.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colAge.HeaderText = "Tuổi";
            colAge.MinimumWidth = 6;
            colAge.Name = "colAge";
            // 
            // colAddress
            // 
            colAddress.HeaderText = "Địa chỉ";
            colAddress.MinimumWidth = 6;
            colAddress.Name = "colAddress";
            colAddress.Width = 125;
            // 
            // colEmail_PhoneNumber
            // 
            colEmail_PhoneNumber.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colEmail_PhoneNumber.HeaderText = "Email/Số điện thoại";
            colEmail_PhoneNumber.MinimumWidth = 6;
            colEmail_PhoneNumber.Name = "colEmail_PhoneNumber";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(497, 397);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(473, 23);
            textBox1.TabIndex = 24;
            // 
            // btnCreateCallDetail
            // 
            btnCreateCallDetail.Location = new Point(498, 433);
            btnCreateCallDetail.Margin = new Padding(3, 2, 3, 2);
            btnCreateCallDetail.Name = "btnCreateCallDetail";
            btnCreateCallDetail.Size = new Size(82, 20);
            btnCreateCallDetail.TabIndex = 22;
            btnCreateCallDetail.Text = "Tạo";
            btnCreateCallDetail.UseVisualStyleBackColor = true;
            btnCreateCallDetail.Click += button1_Click_1;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(595, 431);
            btnDelete.Margin = new Padding(3, 2, 3, 2);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(82, 22);
            btnDelete.TabIndex = 23;
            btnDelete.Text = "Xoá";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // InteractionManage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1057, 558);
            Controls.Add(btnDelete);
            Controls.Add(btnCreateCallDetail);
            Controls.Add(textBox1);
            Controls.Add(dataGridView1);
            Controls.Add(lblContent);
            Controls.Add(lblInfor);
            Controls.Add(label1);
            Controls.Add(btnCancel);
            Controls.Add(btnCreate);
            Controls.Add(lblStatus);
            Controls.Add(txtStatus);
            Controls.Add(lblPurpose);
            Controls.Add(txtPurpose);
            Controls.Add(lblPartner);
            Controls.Add(txtPartner);
            Controls.Add(lblTime);
            Controls.Add(btnAddInteraction);
            Controls.Add(btnView);
            Controls.Add(dgvInteraction);
            Controls.Add(lblTitleAddInteractive);
            Controls.Add(txtTime);
            Controls.Add(lblTitleInteractive);
            Name = "InteractionManage";
            Text = "InteractionManage";
            ((System.ComponentModel.ISupportInitialize)dgvInteraction).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitleInteractive;
        private TextBox txtTime;
        private Label lblTitleAddInteractive;
        private DataGridView dgvInteraction;
        private Button btnView;
        private Button btnAddInteraction;
        private Label lblTime;
        private Label lblPartner;
        private TextBox txtPartner;
        private Label lblPurpose;
        private TextBox txtPurpose;
        private Label lblStatus;
        private TextBox txtStatus;
        private Button btnCreate;
        private Button btnCancel;
        private DataGridViewTextBoxColumn colTime;
        private DataGridViewTextBoxColumn colPartner;
        private DataGridViewTextBoxColumn colPurpose;
        private DataGridViewTextBoxColumn colStatus;
        private Label label1;
        private Label lblInfor;
        private Label lblContent;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn colName;
        private DataGridViewTextBoxColumn colAge;
        private DataGridViewTextBoxColumn colAddress;
        private DataGridViewTextBoxColumn colEmail_PhoneNumber;
        private TextBox textBox1;
        private Button btnCreateCallDetail;
        private Button btnDelete;
    }
}