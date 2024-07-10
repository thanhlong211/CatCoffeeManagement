using System;
using System.Windows.Forms;
using Entities;
using Repositories.Auth;
using Repositories;
using Microsoft.EntityFrameworkCore;

namespace CatCoffee
{
    public partial class RegisterForm : Form
    {
        private readonly IRegisterRepository _registerRepository;
        private readonly CoffeeCatContext _catContext;
        public RegisterForm(IRegisterRepository registerRepository, CoffeeCatContext catContext)
        {
            InitializeComponent();
            _registerRepository = registerRepository;
            _catContext = catContext;
        }

        private async void btnRegister_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();
            string phone = txtPhone.Text.Trim();
            string userName = txtUserName.Text.Trim();
            string password = txtPassword.Text.Trim();
            string confirmPassword = txtConfirmPassword.Text.Trim();

            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(confirmPassword))
            {
                MessageBox.Show("All fields are required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (password != confirmPassword)
            {
                MessageBox.Show("Passwords do not match.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var user = new User
            {
                CustomerEmail = email,
                CustomerTelephone = phone,
                CustomerName = userName,
                CustomerEnabled = true,
                CustomerPassword = password
                // Add other properties if needed
            };

            try
            {
                await _registerRepository.RegisterAsync(user);
                MessageBox.Show("Registration successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Chuyển hướng qua trang login
                LoginForm loginForm = new LoginForm(new SignInRepository(_catContext), new CoffeeCatContext());
                loginForm.Show();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error during registration: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {

        }
    }
}
