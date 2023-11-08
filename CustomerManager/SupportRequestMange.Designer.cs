namespace CustomerManager
{
    partial class SupportRequestMange
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
            dataGridView1 = new DataGridView();
            lblSupportResquetMange = new Label();
            btnFix = new Button();
            btnRemove = new Button();
            lblFix = new Label();
            dataGridView2 = new DataGridView();
            lblRequesInfo = new Label();
            lblRequestStatus = new Label();
            textBox1 = new TextBox();
            btnCancel = new Button();
            btnUpdate = new Button();
            colCusName = new DataGridViewTextBoxColumn();
            colCusPhone = new DataGridViewTextBoxColumn();
            colCusMail = new DataGridViewTextBoxColumn();
            colCusRequest = new DataGridViewTextBoxColumn();
            colStatus = new DataGridViewTextBoxColumn();
            colTime = new DataGridViewTextBoxColumn();
            colFixName = new DataGridViewTextBoxColumn();
            colFixPhone = new DataGridViewTextBoxColumn();
            colFixMail = new DataGridViewTextBoxColumn();
            colFixCusReques = new DataGridViewTextBoxColumn();
            colFixStatus = new DataGridViewTextBoxColumn();
            colFixTime = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { colCusName, colCusPhone, colCusMail, colCusRequest, colStatus, colTime });
            dataGridView1.Location = new Point(12, 95);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(967, 54);
            dataGridView1.TabIndex = 0;
            // 
            // lblSupportResquetMange
            // 
            lblSupportResquetMange.AutoSize = true;
            lblSupportResquetMange.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lblSupportResquetMange.Location = new Point(332, 38);
            lblSupportResquetMange.Name = "lblSupportResquetMange";
            lblSupportResquetMange.Size = new Size(280, 35);
            lblSupportResquetMange.TabIndex = 1;
            lblSupportResquetMange.Text = "Theo dõi yêu cầu hỗ trợ";
            // 
            // btnFix
            // 
            btnFix.BackColor = Color.LightBlue;
            btnFix.Location = new Point(827, 166);
            btnFix.Name = "btnFix";
            btnFix.Size = new Size(64, 29);
            btnFix.TabIndex = 2;
            btnFix.Text = "Sửa";
            btnFix.UseVisualStyleBackColor = false;
            // 
            // btnRemove
            // 
            btnRemove.BackColor = Color.LightBlue;
            btnRemove.Location = new Point(910, 166);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(69, 29);
            btnRemove.TabIndex = 3;
            btnRemove.Text = "Xoá";
            btnRemove.UseVisualStyleBackColor = false;
            // 
            // lblFix
            // 
            lblFix.AutoSize = true;
            lblFix.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            lblFix.Location = new Point(365, 267);
            lblFix.Name = "lblFix";
            lblFix.Size = new Size(194, 30);
            lblFix.TabIndex = 4;
            lblFix.Text = "Sửa yêu cầu hỗ trợ";
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { colFixName, colFixPhone, colFixMail, colFixCusReques, colFixStatus, colFixTime });
            dataGridView2.Location = new Point(12, 340);
            dataGridView2.Margin = new Padding(3, 4, 3, 4);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.RowTemplate.Height = 25;
            dataGridView2.Size = new Size(967, 50);
            dataGridView2.TabIndex = 5;
            // 
            // lblRequesInfo
            // 
            lblRequesInfo.AutoSize = true;
            lblRequesInfo.Font = new Font("Segoe UI", 9F, FontStyle.Underline, GraphicsUnit.Point);
            lblRequesInfo.Location = new Point(12, 304);
            lblRequesInfo.Name = "lblRequesInfo";
            lblRequesInfo.Size = new Size(126, 20);
            lblRequesInfo.TabIndex = 6;
            lblRequesInfo.Text = "Thông tin yêu cầu";
            // 
            // lblRequestStatus
            // 
            lblRequestStatus.AutoSize = true;
            lblRequestStatus.Location = new Point(12, 420);
            lblRequestStatus.Name = "lblRequestStatus";
            lblRequestStatus.Size = new Size(129, 20);
            lblRequestStatus.TabIndex = 7;
            lblRequestStatus.Text = "Trạng thái yêu cầu";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(153, 420);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(179, 27);
            textBox1.TabIndex = 8;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(772, 411);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 9;
            btnCancel.Text = "Huỷ bỏ";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(885, 411);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 10;
            btnUpdate.Text = "Cập nhật";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // colCusName
            // 
            colCusName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colCusName.FillWeight = 104.946533F;
            colCusName.HeaderText = "Tên khách hàng";
            colCusName.MinimumWidth = 6;
            colCusName.Name = "colCusName";
            // 
            // colCusPhone
            // 
            colCusPhone.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colCusPhone.FillWeight = 104.946533F;
            colCusPhone.HeaderText = "Số điện thoại";
            colCusPhone.MinimumWidth = 6;
            colCusPhone.Name = "colCusPhone";
            // 
            // colCusMail
            // 
            colCusMail.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colCusMail.FillWeight = 80.2139F;
            colCusMail.HeaderText = "Email";
            colCusMail.MinimumWidth = 6;
            colCusMail.Name = "colCusMail";
            // 
            // colCusRequest
            // 
            colCusRequest.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colCusRequest.HeaderText = "Nội dung yêu cầu";
            colCusRequest.MinimumWidth = 6;
            colCusRequest.Name = "colCusRequest";
            // 
            // colStatus
            // 
            colStatus.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colStatus.FillWeight = 104.946533F;
            colStatus.HeaderText = "Trạng thái";
            colStatus.MinimumWidth = 6;
            colStatus.Name = "colStatus";
            // 
            // colTime
            // 
            colTime.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colTime.FillWeight = 104.946533F;
            colTime.HeaderText = "Thời gian yêu cầu";
            colTime.MinimumWidth = 6;
            colTime.Name = "colTime";
            // 
            // colFixName
            // 
            colFixName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colFixName.FillWeight = 104.946533F;
            colFixName.HeaderText = "Tên khách hàng";
            colFixName.MinimumWidth = 6;
            colFixName.Name = "colFixName";
            // 
            // colFixPhone
            // 
            colFixPhone.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colFixPhone.FillWeight = 104.946533F;
            colFixPhone.HeaderText = "Số điện thoại";
            colFixPhone.MinimumWidth = 6;
            colFixPhone.Name = "colFixPhone";
            // 
            // colFixMail
            // 
            colFixMail.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colFixMail.FillWeight = 80.2139F;
            colFixMail.HeaderText = "Email";
            colFixMail.MinimumWidth = 6;
            colFixMail.Name = "colFixMail";
            // 
            // colFixCusReques
            // 
            colFixCusReques.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colFixCusReques.HeaderText = "Nội dung yêu cầu";
            colFixCusReques.MinimumWidth = 6;
            colFixCusReques.Name = "colFixCusReques";
            // 
            // colFixStatus
            // 
            colFixStatus.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colFixStatus.FillWeight = 104.946533F;
            colFixStatus.HeaderText = "Trạng thái";
            colFixStatus.MinimumWidth = 6;
            colFixStatus.Name = "colFixStatus";
            // 
            // colFixTime
            // 
            colFixTime.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colFixTime.FillWeight = 104.946533F;
            colFixTime.HeaderText = "Thời gian yêu cầu";
            colFixTime.MinimumWidth = 6;
            colFixTime.Name = "colFixTime";
            // 
            // SupportRequestMange
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(986, 600);
            Controls.Add(btnUpdate);
            Controls.Add(btnCancel);
            Controls.Add(textBox1);
            Controls.Add(lblRequestStatus);
            Controls.Add(lblRequesInfo);
            Controls.Add(dataGridView2);
            Controls.Add(lblFix);
            Controls.Add(btnRemove);
            Controls.Add(btnFix);
            Controls.Add(lblSupportResquetMange);
            Controls.Add(dataGridView1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "SupportRequestMange";
            Text = "SupportRequestMange";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label lblSupportResquetMange;
        private Button btnFix;
        private Button btnRemove;
        private Label lblFix;
        private DataGridView dataGridView2;
        private Label lblRequesInfo;
        private Label lblRequestStatus;
        private TextBox textBox1;
        private Button btnCancel;
        private Button btnUpdate;
        private DataGridViewTextBoxColumn colCusName;
        private DataGridViewTextBoxColumn colCusPhone;
        private DataGridViewTextBoxColumn colCusMail;
        private DataGridViewTextBoxColumn colCusRequest;
        private DataGridViewTextBoxColumn colStatus;
        private DataGridViewTextBoxColumn colTime;
        private DataGridViewTextBoxColumn colFixName;
        private DataGridViewTextBoxColumn colFixPhone;
        private DataGridViewTextBoxColumn colFixMail;
        private DataGridViewTextBoxColumn colFixCusReques;
        private DataGridViewTextBoxColumn colFixStatus;
        private DataGridViewTextBoxColumn colFixTime;
    }
}