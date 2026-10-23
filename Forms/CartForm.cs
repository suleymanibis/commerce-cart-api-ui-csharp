using E_Commerce_Cart_API_UI.Dto;
using E_Commerce_Cart_API_UI.Enums;
using E_Commerce_Cart_API_UI.Managers;
using E_Commerce_Cart_API_UI.Services;
using E_Commerce_Cart_API_UI.Validators;
using FluentValidation;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace E_Commerce_Cart_API_UI.Forms
{
    public partial class CartForm : Form
    {
        private readonly CartService _cartService;
        private readonly OrderService _orderService;
        private BindingList<CartItemResponse>? _cartItems;
        public CartForm(CartService cartService, OrderService orderService)
        {
            InitializeComponent();
            _cartService = cartService;
            _orderService = orderService;
        }

        private async void CartForm_Load(object sender, EventArgs e)
        {
            statusLabel.Text = "";
            Result<CartResponse> result = await _cartService.GetCurrentCart();

            if (!result.isSuccess)
            {
                MessageBox.Show($"Occurrs an error: {result.errorMessage}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            CartResponse? cartResponse = result.Data;

            _cartItems = new BindingList<CartItemResponse>(cartResponse.cartItems);

            cartTable.DataSource = _cartItems;
            totalPrice.Text = $"Total Price: {cartResponse.cartTotalPrice} TL";
        }

        private async void removeProductFromCartButton_Click(object sender, EventArgs e)
        {
            if (cartTable.SelectedRows.Count <= 0)
            {
                statusLabel.ForeColor = Color.Red;
                statusLabel.Text = $"Please select a row to remove a product from your cart.";
                return;
            }

            CartItemResponse selectedProduct = (CartItemResponse)cartTable.SelectedRows[0].DataBoundItem;
            long productId = selectedProduct.productId;
            string? productName = selectedProduct.productName;

            Result<CartResponse>? result = await _cartService.RemoveProduct(productId);

            if (!result.isSuccess)
            {
                MessageBox.Show(this, $"Occured an error: {result.errorMessage}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            CartResponse? cartResponse = result.Data;

            _cartItems = new BindingList<CartItemResponse>(cartResponse.cartItems);

            cartTable.DataSource = _cartItems;
            totalPrice.Text = $"Total Price: {cartResponse.cartTotalPrice} TL";

            statusLabel.ForeColor = Color.Green;
            statusLabel.Text = $"{productName} was removed from your cart.";
        }

        private async void increaseQuantity_Click(object sender, EventArgs e)
        {
            if (cartTable.SelectedRows.Count <= 0)
            {
                statusLabel.ForeColor = Color.Red;
                statusLabel.Text = $"Please select a row to increase quantity of the product in your cart.";
                return;
            }

            CartItemResponse selectedProduct = (CartItemResponse)cartTable.SelectedRows[0].DataBoundItem;
            long productId = selectedProduct.productId;
            string? productName = selectedProduct.productName;
            int quantity = 1;

            AddToCartRequest addToCartRequest = new AddToCartRequest(
                productId,
                quantity
                );

            Result<CartResponse>? result = await _cartService.AddToCart(addToCartRequest);

            if (!result.isSuccess)
            {
                MessageBox.Show(this, $"Occured an error: {result.errorMessage}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            CartResponse? cartResponse = result.Data;

            _cartItems = new BindingList<CartItemResponse>(cartResponse.cartItems);

            cartTable.DataSource = _cartItems;
            totalPrice.Text = $"Total Price: {cartResponse.cartTotalPrice} TL";

            statusLabel.ForeColor = Color.Green;
            statusLabel.Text = $"Quantity of {productName} was increased 1 piece.";
        }

        private async void clearCartButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show(this, "Do you want to clear your cart?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.No)
            {
                return;
            }

            Result<CartResponse> result = await _cartService.ClearCart();

            if (!result.isSuccess)
            {
                MessageBox.Show($"Occurrs an error: {result.errorMessage}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            CartResponse? cartResponse = result.Data;

            _cartItems = new BindingList<CartItemResponse>(cartResponse.cartItems);

            cartTable.DataSource = _cartItems;
            totalPrice.Text = $"Total Price: {cartResponse.cartTotalPrice} TL";

            statusLabel.ForeColor = Color.Green;
            statusLabel.Text = $"Your cart was cleared.";
        }

        private async void checkoutButton_Click(object sender, EventArgs e)
        {
            CreateOrderRequest createOrderRequest = new CreateOrderRequest(
                deliveryAddressTB.Text
                );

            var validator = new CreaterOrderRequestValidator();
            ValidationResult validatorResult = validator.Validate(createOrderRequest);

            if (!validatorResult.IsValid)
            {
                string errorMessages = string.Join("\n", validatorResult.Errors.Select(e => e.ErrorMessage));
                MessageBox.Show(this, $"{errorMessages}", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Result<OrderResponse>? result = await _orderService.CreateOrder(createOrderRequest);

            if (!result.isSuccess)
            {
                MessageBox.Show(this, $"Occured an error: {result.errorMessage}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            
            cartTable.DataSource = null;
            deliveryAddressTB.Clear();

            this.Close();

            MessageBox.Show(this, "Payment completed succesfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
