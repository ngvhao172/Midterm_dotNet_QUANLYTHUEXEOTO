namespace dotNet_GK_QUANLYTHUEXEOTO
{
    partial class Homepage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Homepage));
            panel1 = new Panel();
            btn_Logout = new Button();
            txtName = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            btnInvoices = new Button();
            btnSchedule = new Button();
            btnReportAndStatistic = new Button();
            btnCustomerManagement = new Button();
            btnCarManagement = new Button();
            btnCarOrders = new Button();
            btnRentCar = new Button();
            btnHomepage = new Button();
            panelContainer = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.RosyBrown;
            panel1.Controls.Add(btn_Logout);
            panel1.Controls.Add(txtName);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1605, 107);
            panel1.TabIndex = 0;
            // 
            // btn_Logout
            // 
            btn_Logout.BackColor = Color.DarkRed;
            btn_Logout.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Logout.ForeColor = Color.Snow;
            btn_Logout.Location = new Point(1429, 32);
            btn_Logout.Name = "btn_Logout";
            btn_Logout.Size = new Size(130, 44);
            btn_Logout.TabIndex = 6;
            btn_Logout.Text = "Đăng xuất";
            btn_Logout.UseVisualStyleBackColor = false;
            btn_Logout.Click += btn_Logout_Click_1;
            // 
            // txtName
            // 
            txtName.AutoSize = true;
            txtName.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtName.Location = new Point(1165, 37);
            txtName.Name = "txtName";
            txtName.Size = new Size(182, 30);
            txtName.TabIndex = 2;
            txtName.Text = "Xin chào Hào!";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(163, 28);
            label1.Name = "label1";
            label1.Size = new Size(189, 40);
            label1.TabIndex = 1;
            label1.Text = "AUTO CAR";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(32, 16);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(114, 67);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnInvoices);
            panel2.Controls.Add(btnSchedule);
            panel2.Controls.Add(btnReportAndStatistic);
            panel2.Controls.Add(btnCustomerManagement);
            panel2.Controls.Add(btnCarManagement);
            panel2.Controls.Add(btnCarOrders);
            panel2.Controls.Add(btnRentCar);
            panel2.Controls.Add(btnHomepage);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 107);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(1605, 67);
            panel2.TabIndex = 1;
            // 
            // btnInvoices
            // 
            btnInvoices.BackColor = Color.White;
            btnInvoices.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnInvoices.Location = new Point(803, 0);
            btnInvoices.Margin = new Padding(3, 4, 3, 4);
            btnInvoices.Name = "btnInvoices";
            btnInvoices.Size = new Size(135, 67);
            btnInvoices.TabIndex = 7;
            btnInvoices.Text = "Danh sách hóa đơn";
            btnInvoices.UseVisualStyleBackColor = false;
            btnInvoices.Click += btnInvoices_Click;
            // 
            // btnSchedule
            // 
            btnSchedule.BackColor = Color.White;
            btnSchedule.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnSchedule.Location = new Point(267, 0);
            btnSchedule.Margin = new Padding(3, 4, 3, 4);
            btnSchedule.Name = "btnSchedule";
            btnSchedule.Size = new Size(135, 67);
            btnSchedule.TabIndex = 6;
            btnSchedule.Text = "Quản lý lịch trình";
            btnSchedule.UseVisualStyleBackColor = false;
            btnSchedule.Click += btnSchedule_Click;
            // 
            // btnReportAndStatistic
            // 
            btnReportAndStatistic.BackColor = Color.White;
            btnReportAndStatistic.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnReportAndStatistic.Location = new Point(937, 0);
            btnReportAndStatistic.Margin = new Padding(3, 4, 3, 4);
            btnReportAndStatistic.Name = "btnReportAndStatistic";
            btnReportAndStatistic.Size = new Size(135, 67);
            btnReportAndStatistic.TabIndex = 5;
            btnReportAndStatistic.Text = "Báo cáo";
            btnReportAndStatistic.UseVisualStyleBackColor = false;
            btnReportAndStatistic.Click += btnReportAndStatistic_Click;
            // 
            // btnCustomerManagement
            // 
            btnCustomerManagement.BackColor = Color.White;
            btnCustomerManagement.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnCustomerManagement.Location = new Point(669, 0);
            btnCustomerManagement.Margin = new Padding(3, 4, 3, 4);
            btnCustomerManagement.Name = "btnCustomerManagement";
            btnCustomerManagement.Size = new Size(135, 67);
            btnCustomerManagement.TabIndex = 4;
            btnCustomerManagement.Text = "Quản lý khách hàng";
            btnCustomerManagement.UseVisualStyleBackColor = false;
            btnCustomerManagement.Click += btnCustomerManagement_Click;
            // 
            // btnCarManagement
            // 
            btnCarManagement.BackColor = Color.White;
            btnCarManagement.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnCarManagement.Location = new Point(535, 0);
            btnCarManagement.Margin = new Padding(3, 4, 3, 4);
            btnCarManagement.Name = "btnCarManagement";
            btnCarManagement.Size = new Size(135, 67);
            btnCarManagement.TabIndex = 3;
            btnCarManagement.Text = "Quản lý ô tô";
            btnCarManagement.UseVisualStyleBackColor = false;
            btnCarManagement.Click += btnCarManagement_Click;
            // 
            // btnCarOrders
            // 
            btnCarOrders.BackColor = Color.White;
            btnCarOrders.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnCarOrders.Location = new Point(401, 0);
            btnCarOrders.Margin = new Padding(3, 4, 3, 4);
            btnCarOrders.Name = "btnCarOrders";
            btnCarOrders.Size = new Size(135, 67);
            btnCarOrders.TabIndex = 2;
            btnCarOrders.Text = "Quản lý đơn đặt";
            btnCarOrders.UseVisualStyleBackColor = false;
            btnCarOrders.Click += btnCarOrders_Click;
            // 
            // btnRentCar
            // 
            btnRentCar.BackColor = Color.White;
            btnRentCar.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnRentCar.Location = new Point(134, 0);
            btnRentCar.Margin = new Padding(3, 4, 3, 4);
            btnRentCar.Name = "btnRentCar";
            btnRentCar.Size = new Size(135, 67);
            btnRentCar.TabIndex = 1;
            btnRentCar.Text = "Thuê xe";
            btnRentCar.UseVisualStyleBackColor = false;
            btnRentCar.Click += btnRentCar_Click;
            // 
            // btnHomepage
            // 
            btnHomepage.BackColor = Color.White;
            btnHomepage.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnHomepage.Location = new Point(0, 0);
            btnHomepage.Margin = new Padding(3, 4, 3, 4);
            btnHomepage.Name = "btnHomepage";
            btnHomepage.Size = new Size(135, 67);
            btnHomepage.TabIndex = 0;
            btnHomepage.Text = "Trang chủ";
            btnHomepage.UseVisualStyleBackColor = false;
            btnHomepage.Click += btnHomepage_Click;
            // 
            // panelContainer
            // 
            panelContainer.Dock = DockStyle.Fill;
            panelContainer.Location = new Point(0, 174);
            panelContainer.Margin = new Padding(3, 4, 3, 4);
            panelContainer.Name = "panelContainer";
            panelContainer.Size = new Size(1605, 819);
            panelContainer.TabIndex = 2;
            // 
            // Homepage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1605, 993);
            Controls.Add(panelContainer);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Homepage";
            Text = "Auto Car";
            Load += Homepage_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label txtName;
        private Label label1;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Button btnHomepage;
        private Button btnRentCar;
        private Button btnSchedule;
        private Button btnReportAndStatistic;
        private Button btnCustomerManagement;
        private Button btnCarManagement;
        private Button btnCarOrders;
        private Panel panelContainer;
        private Button btn_Logout;
        private Button button1;
        private Button btnInvoices;
    }
}