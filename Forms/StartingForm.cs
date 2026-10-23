using E_Commerce_Cart_API_UI.Dto;
using E_Commerce_Cart_API_UI.Services;
using E_Commerce_Cart_API_UI.Validators;
using FluentValidation;
using FluentValidation.Results;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace E_Commerce_Cart_API_UI
{
    public partial class StartingForm : Form
    {
        private readonly AuthService _authService;
        private IServiceProvider _serviceProvider;
        public StartingForm(AuthService authService, IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _authService = authService;
            _serviceProvider = serviceProvider;
        }

        private async void registerButton_Click(object sender, EventArgs e)
        {
            RegisterRequest registerRequest = new RegisterRequest(
                firstNameTB.Text,
                lastNameTB.Text,
                registerEmailTB.Text,
                registerPasswordTB.Text
                );

            var validator = new RegisterRequestValidator();
            ValidationResult result = validator.Validate(registerRequest);

            if (!result.IsValid)
            {
                string errorMessages = string.Join("\n", result.Errors.Select(e => e.ErrorMessage));
                MessageBox.Show(this, $"{errorMessages}", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Result<RegisterResponse> response = await _authService.RegisterAsync(registerRequest);

            if (response.isSuccess)
            {
                MessageBox.Show(this, "You have registered successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                firstNameTB.Clear();
                lastNameTB.Clear();
                registerEmailTB.Clear();
                registerPasswordTB.Clear();
            }
            else
                MessageBox.Show(this, $"Occurs an error: {response.errorMessage}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            
        }

        private async void loginButton_Click(object sender, EventArgs e)
        {
            LoginRequest loginRequest = new LoginRequest(
                loginEmailTB.Text,
                loginPasswordTB.Text
                );

            var validator = new LoginRequestValidator();
            ValidationResult result = validator.Validate(loginRequest);

            if (!result.IsValid)
            {
                string errorMessages = string.Join("\n", result.Errors.Select(e => e.ErrorMessage));
                MessageBox.Show(this, $"{errorMessages}", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Result<LoginResponse> response = await _authService.LoginAsync(loginRequest);

            if (response.isSuccess)
            {
                this.Hide();
                MessageBox.Show(this, "You have loged in successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Result<UserResponse> userResponse = await _authService.GetMe();

                MainForm mainForm = _serviceProvider.GetRequiredService<MainForm>();
                mainForm.Show();
            }
            else
                MessageBox.Show(this, $"Email or password unmatched!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}