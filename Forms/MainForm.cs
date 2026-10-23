using E_Commerce_Cart_API_UI.Dto;
using E_Commerce_Cart_API_UI.Enums;
using E_Commerce_Cart_API_UI.Forms;
using E_Commerce_Cart_API_UI.Managers;
using E_Commerce_Cart_API_UI.Services;
using E_Commerce_Cart_API_UI.Utils;
using E_Commerce_Cart_API_UI.Validators;
using FluentValidation;
using FluentValidation.Results;
using Microsoft.Extensions.DependencyInjection;
using System.ComponentModel;

namespace E_Commerce_Cart_API_UI
{
    public partial class MainForm : Form
    {
        private UserRole userRole = UserRole.USER;
        private readonly ProductService _productService;
        private readonly CartService _cartService;
        private readonly FileManager _fileManager;
        BindingList<ProductResponse>? _productsList;
        private readonly IServiceProvider _serviceProvider;
        public MainForm(ProductService productService, IServiceProvider serviceProvider, FileManager fileManager, CartService cartService)
        {
            InitializeComponent();

            _productService = productService;
            _serviceProvider = serviceProvider;
            _fileManager = fileManager;
            _cartService = cartService;
        }

        private async void MainForm_Load(object sender, EventArgs e)
        {
            statusLabel.Text = "";
            UserResponse? user = _fileManager.ReadConfig<UserResponse>();

            if (user != null)
            {
                if (user.role.ToUpper() == "ADMIN")
                {
                    userRole = UserRole.ADMIN;
                }
            }

            if (userRole != UserRole.ADMIN)
            {
                producManagementGB.Visible = false;
            }

            userIdLabel.Text = "ID: " + user?.id.ToString();
            userFirstNameLabel.Text = "First Name: " + user?.firstName.ToString();
            userLastNameLabel.Text = "Last Name: " + user?.lastName.ToString();
            userEmailLabel.Text = "Email: " + user?.email.ToString();
            userRoleLabel.Text = "Role: " + user?.role.ToString();

            Result<BindingList<ProductResponse>> result = await _productService.GetProducts();

            if (!result.isSuccess)
            {
                MessageBox.Show($"Occurrs an error: {result.errorMessage}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _productsList = result.Data;
            productsTable.DataSource = _productsList;
        }

        private void logOutButton_Click(object sender, EventArgs e)
        {


            DialogResult isConfirmed = MessageBox.Show("Do yu want to log out?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (isConfirmed == DialogResult.Yes)
            {
                _fileManager.CleanSession();
                _fileManager.CleanConfig();

                StartingForm startingForm = _serviceProvider.GetRequiredService<StartingForm>();
                startingForm.Show();
                this.Close();
            }
        }

        private async void addProductButton_Click(object sender, EventArgs e)
        {
            decimal productPrice;
            if (!decimal.TryParse(productPriceTB.Text, out productPrice))
            {
                MessageBox.Show("Price must be decimal.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int productStock;
            if (!int.TryParse(productStockTB.Text, out productStock))
            {
                MessageBox.Show("Stock must be integer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            CreateProductRequest createProductRequest = new CreateProductRequest(
                productNameTB.Text,
                productDescTB.Text,
                productPrice,
                productStock
                );

            var validator = new CreateProductRequestValidator();
            ValidationResult result = validator.Validate(createProductRequest);

            if (!result.IsValid)
            {
                string errorMessages = string.Join("\n", result.Errors.Select(e => e.ErrorMessage));
                MessageBox.Show(this, $"{errorMessages}", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Result<ProductResponse>? response = await _productService.CreateProduct(createProductRequest);

            if (!response.isSuccess)
            {
                MessageBox.Show(this, $"Occured an error: {response.errorMessage}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _productsList?.Add(response?.Data);

            statusLabel.Text = $"{productNameTB.Text} was added to the product catalog.";

            productNameTB.Clear();
            productDescTB.Clear();
            productPriceTB.Clear();
            productStockTB.Clear();
        }

        private async void deleteProductButton_Click(object sender, EventArgs e)
        {
            if (productsTable.SelectedRows.Count <= 0)
            {
                statusLabel.ForeColor = Color.Red;
                statusLabel.Text = $"Please select a row to delete a product.";
                return;
            }

            ProductResponse selectedProduct = (ProductResponse)productsTable.SelectedRows[0].DataBoundItem;
            long productId = selectedProduct.id;
            string? productName = selectedProduct.name;

            Result<ProductResponse>? response = await _productService.DeleteProduct(productId);

            if (!response.isSuccess)
            {
                MessageBox.Show(this, $"Occured an error: {response.errorMessage}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _productsList?.Remove(selectedProduct);

            statusLabel.ForeColor = Color.Green;
            statusLabel.Text = $"{productName} was deleted from the product catalog.";
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            this.MainForm_Load(sender, e);
        }

        private async void addProductToCartButton_Click(object sender, EventArgs e)
        {
            if (productsTable.SelectedRows.Count <= 0)
            {
                statusLabel.ForeColor = Color.Red;
                statusLabel.Text = $"Please select a row to add a product to your cart.";
                return;
            }

            ProductResponse selectedProduct = (ProductResponse)productsTable.SelectedRows[0].DataBoundItem;
            long productId = selectedProduct.id;
            string? productName = selectedProduct.name;
            int quantity = (int)quantityNUD.Value;

            if (quantity <= 0)
            {
                statusLabel.ForeColor = Color.Red;
                statusLabel.Text = $"Quantity must be positive.";
                return;
            }

            AddToCartRequest addToCartRequest = new AddToCartRequest(
                productId,
                quantity
                );

            Result<CartResponse>? response = await _cartService.AddToCart(addToCartRequest);

            if (!response.isSuccess)
            {
                MessageBox.Show(this, $"Occured an error: {response.errorMessage}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            statusLabel.ForeColor = Color.Green;
            statusLabel.Text = $"{productName} was added to your cart.";
        }

        private void displayCartButton_Click(object sender, EventArgs e)
        {
            using (CartForm cartForm = _serviceProvider.GetRequiredService<CartForm>())
            {
                cartForm.ShowDialog(this);
            }
        }

        private void displayOrderHistory_Click(object sender, EventArgs e)
        {
            using (OrderHistoryForm orderHistoryForm = _serviceProvider.GetRequiredService<OrderHistoryForm>())
            {
                orderHistoryForm.ShowDialog(this);
            }
        }
    }
}
