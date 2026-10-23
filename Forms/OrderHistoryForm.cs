using E_Commerce_Cart_API_UI.Dto;
using E_Commerce_Cart_API_UI.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace E_Commerce_Cart_API_UI.Forms
{
    public partial class OrderHistoryForm : Form
    {
        private readonly OrderService _orderService;
        public OrderHistoryForm(OrderService orderService)
        {
            InitializeComponent();
            _orderService = orderService;
        }

        private async void OrderHistoryForm_Load(object sender, EventArgs e)
        {
            Result<List<OrderResponse>> result = await _orderService.GetOrders();

            if (!result.isSuccess)
            {
                MessageBox.Show($"Occurrs an error: {result.errorMessage}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            BindingList<OrderResponse>? orders = new BindingList<OrderResponse>(result.Data);
            ordersTable.DataSource = orders;
        }
    }
}
