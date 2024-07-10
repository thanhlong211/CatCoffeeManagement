namespace CatCoffee
{
    partial class ShopManagement
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private DataGridView dataGridViewShops;
        private Label lblShopName;
        private TextBox txtShopName;
        private Label lblAddress;
        private TextBox txtAddress;
        private Button btnCreate;
        private Button btnUpdate;
        private Button btnActivate;
        private Button btnDeactivate;
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
        private void InitializeComponent()
        {
            dataGridViewShops = new DataGridView();
            lblShopName = new Label();
            txtShopName = new TextBox();
            lblAddress = new Label();
            txtAddress = new TextBox();
            btnCreate = new Button();
            btnUpdate = new Button();
            btnActivate = new Button();
            btnDeactivate = new Button();
            label1 = new Label();
            label2 = new Label();
            txtEmail = new TextBox();
            txtPhone = new MaskedTextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewShops).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewShops
            // 
            dataGridViewShops.AllowUserToAddRows = false;
            dataGridViewShops.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewShops.Location = new Point(20, 49);
            dataGridViewShops.Margin = new Padding(4, 5, 4, 5);
            dataGridViewShops.MultiSelect = false;
            dataGridViewShops.Name = "dataGridViewShops";
            dataGridViewShops.RowHeadersWidth = 51;
            dataGridViewShops.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewShops.Size = new Size(839, 349);
            dataGridViewShops.TabIndex = 0;
            dataGridViewShops.CellClick += dataGridViewShops_CellClick;
            dataGridViewShops.CellContentClick += dataGridViewShops_CellContentClick;
            // 
            // lblShopName
            // 
            lblShopName.AutoSize = true;
            lblShopName.Location = new Point(16, 431);
            lblShopName.Margin = new Padding(4, 0, 4, 0);
            lblShopName.Name = "lblShopName";
            lblShopName.Size = new Size(90, 20);
            lblShopName.TabIndex = 1;
            lblShopName.Text = "Shop Name:";
            // 
            // txtShopName
            // 
            txtShopName.Location = new Point(113, 426);
            txtShopName.Margin = new Padding(4, 5, 4, 5);
            txtShopName.Name = "txtShopName";
            txtShopName.Size = new Size(265, 27);
            txtShopName.TabIndex = 2;
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Location = new Point(486, 431);
            lblAddress.Margin = new Padding(4, 0, 4, 0);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(65, 20);
            lblAddress.TabIndex = 3;
            lblAddress.Text = "Address:";
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(594, 424);
            txtAddress.Margin = new Padding(4, 5, 4, 5);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(265, 27);
            txtAddress.TabIndex = 4;
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(34, 605);
            btnCreate.Margin = new Padding(4, 5, 4, 5);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(100, 35);
            btnCreate.TabIndex = 5;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(278, 605);
            btnUpdate.Margin = new Padding(4, 5, 4, 5);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(100, 35);
            btnUpdate.TabIndex = 6;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnActivate
            // 
            btnActivate.Location = new Point(501, 605);
            btnActivate.Margin = new Padding(4, 5, 4, 5);
            btnActivate.Name = "btnActivate";
            btnActivate.Size = new Size(100, 35);
            btnActivate.TabIndex = 8;
            btnActivate.Text = "Activate";
            btnActivate.UseVisualStyleBackColor = true;
            btnActivate.Click += btnActivate_Click;
            // 
            // btnDeactivate
            // 
            btnDeactivate.Location = new Point(759, 605);
            btnDeactivate.Margin = new Padding(4, 5, 4, 5);
            btnDeactivate.Name = "btnDeactivate";
            btnDeactivate.Size = new Size(100, 35);
            btnDeactivate.TabIndex = 9;
            btnDeactivate.Text = "Deactivate";
            btnDeactivate.UseVisualStyleBackColor = true;
            btnDeactivate.Click += btnDeactivate_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(486, 507);
            label1.Name = "label1";
            label1.Size = new Size(46, 20);
            label1.TabIndex = 10;
            label1.Text = "email";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 514);
            label2.Name = "label2";
            label2.Size = new Size(51, 20);
            label2.TabIndex = 11;
            label2.Text = "phone";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(594, 487);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(265, 27);
            txtEmail.TabIndex = 12;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(113, 507);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(265, 27);
            txtPhone.TabIndex = 13;
            // 
            // button1
            // 
            button1.Location = new Point(911, 12);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 14;
            button1.Text = "logout";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(911, 107);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 15;
            button2.Text = "Area";
            button2.UseVisualStyleBackColor = true;
            button2.Click += BtnManageAreas_Click;
            // 
            // button3
            // 
            button3.Location = new Point(911, 185);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 16;
            button3.Text = "item";
            button3.UseVisualStyleBackColor = true;
            button3.Click += BtnManageMenus_Click;
            // 
            // button4
            // 
            button4.Location = new Point(20, 12);
            button4.Name = "button4";
            button4.Size = new Size(94, 29);
            button4.TabIndex = 17;
            button4.Text = "logout";
            button4.UseVisualStyleBackColor = true;
            button4.Click += this.btnLogout_Click;
            // 
            // ShopManagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1067, 692);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txtPhone);
            Controls.Add(txtEmail);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnDeactivate);
            Controls.Add(btnActivate);
            Controls.Add(btnUpdate);
            Controls.Add(btnCreate);
            Controls.Add(txtAddress);
            Controls.Add(lblAddress);
            Controls.Add(txtShopName);
            Controls.Add(lblShopName);
            Controls.Add(dataGridViewShops);
            Margin = new Padding(4, 5, 4, 5);
            Name = "ShopManagement";
            Text = "ShopManagement";
            Load += ShopManagement_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewShops).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion
        private Label label1;
        private Label label2;
        private TextBox txtEmail;
        private MaskedTextBox txtPhone;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}