namespace E_Commerce_Cart_API_UI.Forms
{
    partial class CartForm
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
            cartTable = new DataGridView();
            increaseQuantity = new Button();
            clearCartButton = new Button();
            totalPrice = new Label();
            removeProductFromCartButton = new Button();
            statusLabel = new Label();
            deliveryAddressTB = new TextBox();
            checkoutButton = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)cartTable).BeginInit();
            SuspendLayout();
            // 
            // cartTable
            // 
            cartTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            cartTable.Location = new Point(12, 12);
            cartTable.Name = "cartTable";
            cartTable.Size = new Size(521, 281);
            cartTable.TabIndex = 0;
            // 
            // increaseQuantity
            // 
            increaseQuantity.Location = new Point(539, 12);
            increaseQuantity.Name = "increaseQuantity";
            increaseQuantity.Size = new Size(279, 36);
            increaseQuantity.TabIndex = 1;
            increaseQuantity.Text = "+1 Increase Quantity";
            increaseQuantity.UseVisualStyleBackColor = true;
            increaseQuantity.Click += increaseQuantity_Click;
            // 
            // clearCartButton
            // 
            clearCartButton.Location = new Point(539, 96);
            clearCartButton.Name = "clearCartButton";
            clearCartButton.Size = new Size(279, 36);
            clearCartButton.TabIndex = 2;
            clearCartButton.Text = "Clear Cart";
            clearCartButton.UseVisualStyleBackColor = true;
            clearCartButton.Click += clearCartButton_Click;
            // 
            // totalPrice
            // 
            totalPrice.AutoSize = true;
            totalPrice.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            totalPrice.ForeColor = Color.ForestGreen;
            totalPrice.Location = new Point(12, 296);
            totalPrice.Name = "totalPrice";
            totalPrice.Size = new Size(115, 20);
            totalPrice.TabIndex = 11;
            totalPrice.Text = "Total Price: 0 TL";
            // 
            // removeProductFromCartButton
            // 
            removeProductFromCartButton.Location = new Point(539, 54);
            removeProductFromCartButton.Name = "removeProductFromCartButton";
            removeProductFromCartButton.Size = new Size(279, 36);
            removeProductFromCartButton.TabIndex = 12;
            removeProductFromCartButton.Text = "Remove Product";
            removeProductFromCartButton.UseVisualStyleBackColor = true;
            removeProductFromCartButton.Click += removeProductFromCartButton_Click;
            // 
            // statusLabel
            // 
            statusLabel.AutoSize = true;
            statusLabel.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            statusLabel.ForeColor = Color.ForestGreen;
            statusLabel.Location = new Point(12, 316);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new Size(50, 20);
            statusLabel.TabIndex = 13;
            statusLabel.Text = "Status";
            // 
            // deliveryAddressTB
            // 
            deliveryAddressTB.Location = new Point(639, 228);
            deliveryAddressTB.Name = "deliveryAddressTB";
            deliveryAddressTB.Size = new Size(179, 23);
            deliveryAddressTB.TabIndex = 14;
            // 
            // checkoutButton
            // 
            checkoutButton.Location = new Point(539, 257);
            checkoutButton.Name = "checkoutButton";
            checkoutButton.Size = new Size(279, 36);
            checkoutButton.TabIndex = 15;
            checkoutButton.Text = "Checkout";
            checkoutButton.UseVisualStyleBackColor = true;
            checkoutButton.Click += checkoutButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(539, 231);
            label1.Name = "label1";
            label1.Size = new Size(94, 15);
            label1.TabIndex = 16;
            label1.Text = "Delivery Address";
            // 
            // CartForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(824, 345);
            Controls.Add(label1);
            Controls.Add(checkoutButton);
            Controls.Add(deliveryAddressTB);
            Controls.Add(statusLabel);
            Controls.Add(removeProductFromCartButton);
            Controls.Add(totalPrice);
            Controls.Add(clearCartButton);
            Controls.Add(increaseQuantity);
            Controls.Add(cartTable);
            Name = "CartForm";
            Text = "CartForm";
            Load += CartForm_Load;
            ((System.ComponentModel.ISupportInitialize)cartTable).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView cartTable;
        private Button increaseQuantity;
        private Button clearCartButton;
        private Label totalPrice;
        private Button removeProductFromCartButton;
        private Label statusLabel;
        private TextBox deliveryAddressTB;
        private Button checkoutButton;
        private Label label1;
    }
}