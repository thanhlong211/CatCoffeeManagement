using Entities;
using Repositories.Admin;
using Repositories.Auth;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CatCoffee
{
    public partial class AdminForm : Form
    {
        private readonly IAdminRepository _adminRepository;
        private readonly ISessionRepository _sessionRepository;
        private readonly CoffeeCatContext _dbContext;
        public IEnumerable<User> Users { get; set; }
        public User? LoggedInUser { get; set; }
        

        public AdminForm(IAdminRepository adminRepository, ISessionRepository sessionRepository,CoffeeCatContext coffeeCat)
        {
            _dbContext = coffeeCat;
            _adminRepository = adminRepository;
            _sessionRepository = sessionRepository;
            InitializeComponent();
        }
        private int userId;
        private int? shopId;
        private int role;
      
        private void AdminForm_Load(object sender, EventArgs e)
        {
            Authenticate();
            Authorization();
            SetUserSession();
            userId = (int)Session.Get("userId");
            shopId = (int?)Session.Get("shopId");
            role = (int)Session.Get("role");
            if (LoggedInUser != null)
            {
                lblWelcome.Text = "Hello " + LoggedInUser.CustomerName;
            }
            SetUsers();
        }

        private async void btnBan_Click(object sender, EventArgs e)
        {
            int? customerId = GetSelectedCustomerId();
            if (customerId.HasValue)
            {
                await _adminRepository.Ban(customerId.Value);
                SetUsers();
            }
            else
            {
                MessageBox.Show("Please select a user to ban.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnUnban_Click(object sender, EventArgs e)
        {
            int? customerId = GetSelectedCustomerId();
            if (customerId.HasValue)
            {
                await _adminRepository.Unban(customerId.Value);
                SetUsers();
            }
            else
            {
                MessageBox.Show("Please select a user to unban.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private int? GetSelectedCustomerId()
        {
            if (dataGridViewUsers.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridViewUsers.SelectedRows[0];
                return (int)selectedRow.Cells["CustomerId"].Value;
            }
            return null;
        }

        private void Authenticate()
        {
            userId = (int)Session.Get("userId");
            if (userId == null)
            {
                MessageBox.Show("Please log in first.", "Authentication Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close(); // Close the form or redirect to login form
            }
        }

        private void Authorization()
        {
            role = (int)Session.Get("role");
            if (role != 1)
            {
                MessageBox.Show("You are not authorized to access this page.", "Authorization Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close(); // Close the form or redirect to error form
            }
        }

        private void SetUserSession()
        {
            userId = (int)Session.Get("userId");
            if (userId != null)
            {
                LoggedInUser = _sessionRepository.GetUserById(1);
            }
        }

        private void SetUsers()
        {
            Users = _adminRepository.GetAllAccount();
            dataGridViewUsers.DataSource = Users.ToList();
            dataGridViewUsers.Columns["Bookings"].Visible = false;
            dataGridViewUsers.Columns["CustomerPassword"].Visible = false;
            dataGridViewUsers.Columns["Shop"].Visible = false;
            dataGridViewUsers.Columns["Role"].Visible = false;
            dataGridViewUsers.Columns["ShopId"].Visible = false;// Ẩn cột CustomerId nếu cần
            dataGridViewUsers.AutoResizeColumns();
        }
        private void btnLogout_Click(object sender, EventArgs e)
        {
          

            // Xóa các giá trị session liên quan
            Session.Remove("userId");
            Session.Remove("role");
            Session.Remove("shopId");

            // Đóng form hiện tại
            this.Close();


            LoginForm loginForm = new LoginForm(new SignInRepository(_dbContext), new CoffeeCatContext());
            loginForm.Show();
        }
        private async void btnCreateShopOwner_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy thông tin từ các control nhập liệu trên form
                string shopOwnerName = txtShopOwnerName.Text;
                string shopOwnerEmail = txtShopOwnerEmail.Text;
                string shopOwnerPassword = txtShopOwnerPassword.Text;
                string phoneNumber = txtPhone.Text;

                // Kiểm tra tính hợp lệ của dữ liệu nhập vào (ví dụ: kiểm tra rỗng, độ dài, ...)
                if (string.IsNullOrEmpty(shopOwnerName) || string.IsNullOrEmpty(shopOwnerEmail) || string.IsNullOrEmpty(shopOwnerPassword))
                {
                    MessageBox.Show("Please fill in all required fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Tạo đối tượng User để đại diện cho ShopOwner
                User shopOwner = new User
                {
                    CustomerName = shopOwnerName,
                    CustomerEmail = shopOwnerEmail,
                    CustomerPassword = shopOwnerPassword,
                    CustomerTelephone = phoneNumber,
                    RoleId = 2 ,
                    CustomerEnabled = true,
                };


                await _adminRepository.CreateShopOwner(shopOwner);

                MessageBox.Show("ShopOwner account created successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtShopOwnerName.Text = string.Empty;
                txtShopOwnerEmail.Text = string.Empty;
                txtShopOwnerPassword.Text = string.Empty;
                txtPhone.Text = string.Empty;
                SetUsers();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error creating ShopOwner account: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
