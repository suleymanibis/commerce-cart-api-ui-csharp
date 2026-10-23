namespace E_Commerce_Cart_API_UI
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            productsTable = new DataGridView();
            addProductButton = new Button();
            productNameTB = new TextBox();
            productDescTB = new TextBox();
            productPriceTB = new TextBox();
            logOutButton = new Button();
            userInfoGB = new GroupBox();
            displayCartButton = new Button();
            refreshButton = new Button();
            userRoleLabel = new Label();
            userEmailLabel = new Label();
            userLastNameLabel = new Label();
            userFirstNameLabel = new Label();
            userIdLabel = new Label();
            producManagementGB = new GroupBox();
            label3 = new Label();
            productStockTB = new TextBox();
            deleteProductButton = new Button();
            label2 = new Label();
            label1 = new Label();
            label5 = new Label();
            statusLabel = new Label();
            purchasementFieldGB = new GroupBox();
            quantityNUD = new NumericUpDown();
            label4 = new Label();
            label6 = new Label();
            addProductToCartButton = new Button();
            displayOrderHistory = new Button();
            ((System.ComponentModel.ISupportInitialize)productsTable).BeginInit();
            userInfoGB.SuspendLayout();
            producManagementGB.SuspendLayout();
            purchasementFieldGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)quantityNUD).BeginInit();
            SuspendLayout();
            // 
            // productsTable
            // 
            productsTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            productsTable.Location = new Point(616, 12);
            productsTable.Name = "productsTable";
            productsTable.Size = new Size(634, 364);
            productsTable.TabIndex = 0;
            // 
            // addProductButton
            // 
            addProductButton.Location = new Point(6, 147);
            addProductButton.Name = "addProductButton";
            addProductButton.Size = new Size(287, 38);
            addProductButton.TabIndex = 1;
            addProductButton.Text = "Add Product";
            addProductButton.UseVisualStyleBackColor = true;
            addProductButton.Click += addProductButton_Click;
            // 
            // productNameTB
            // 
            productNameTB.Location = new Point(103, 31);
            productNameTB.Name = "productNameTB";
            productNameTB.Size = new Size(190, 23);
            productNameTB.TabIndex = 2;
            // 
            // productDescTB
            // 
            productDescTB.Location = new Point(103, 60);
            productDescTB.Name = "productDescTB";
            productDescTB.Size = new Size(190, 23);
            productDescTB.TabIndex = 3;
            // 
            // productPriceTB
            // 
            productPriceTB.Location = new Point(103, 89);
            productPriceTB.Name = "productPriceTB";
            productPriceTB.Size = new Size(190, 23);
            productPriceTB.TabIndex = 4;
            // 
            // logOutButton
            // 
            logOutButton.Location = new Point(6, 312);
            logOutButton.Name = "logOutButton";
            logOutButton.Size = new Size(113, 41);
            logOutButton.TabIndex = 5;
            logOutButton.Text = "Log Out";
            logOutButton.UseVisualStyleBackColor = true;
            logOutButton.Click += logOutButton_Click;
            // 
            // userInfoGB
            // 
            userInfoGB.Controls.Add(displayOrderHistory);
            userInfoGB.Controls.Add(displayCartButton);
            userInfoGB.Controls.Add(refreshButton);
            userInfoGB.Controls.Add(userRoleLabel);
            userInfoGB.Controls.Add(userEmailLabel);
            userInfoGB.Controls.Add(logOutButton);
            userInfoGB.Controls.Add(userLastNameLabel);
            userInfoGB.Controls.Add(userFirstNameLabel);
            userInfoGB.Controls.Add(userIdLabel);
            userInfoGB.Location = new Point(12, 12);
            userInfoGB.Name = "userInfoGB";
            userInfoGB.Size = new Size(286, 364);
            userInfoGB.TabIndex = 6;
            userInfoGB.TabStop = false;
            userInfoGB.Text = "User Information";
            // 
            // displayCartButton
            // 
            displayCartButton.Location = new Point(6, 265);
            displayCartButton.Name = "displayCartButton";
            displayCartButton.Size = new Size(113, 41);
            displayCartButton.TabIndex = 7;
            displayCartButton.Text = "Display Cart";
            displayCartButton.UseVisualStyleBackColor = true;
            displayCartButton.Click += displayCartButton_Click;
            // 
            // refreshButton
            // 
            refreshButton.Location = new Point(167, 312);
            refreshButton.Name = "refreshButton";
            refreshButton.Size = new Size(113, 41);
            refreshButton.TabIndex = 6;
            refreshButton.Text = "Refresh";
            refreshButton.UseVisualStyleBackColor = true;
            refreshButton.Click += refreshButton_Click;
            // 
            // userRoleLabel
            // 
            userRoleLabel.AutoSize = true;
            userRoleLabel.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            userRoleLabel.Location = new Point(6, 112);
            userRoleLabel.Name = "userRoleLabel";
            userRoleLabel.Size = new Size(28, 20);
            userRoleLabel.TabIndex = 4;
            userRoleLabel.Text = "ID:";
            // 
            // userEmailLabel
            // 
            userEmailLabel.AutoSize = true;
            userEmailLabel.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            userEmailLabel.Location = new Point(6, 92);
            userEmailLabel.Name = "userEmailLabel";
            userEmailLabel.Size = new Size(28, 20);
            userEmailLabel.TabIndex = 3;
            userEmailLabel.Text = "ID:";
            // 
            // userLastNameLabel
            // 
            userLastNameLabel.AutoSize = true;
            userLastNameLabel.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            userLastNameLabel.Location = new Point(6, 72);
            userLastNameLabel.Name = "userLastNameLabel";
            userLastNameLabel.Size = new Size(28, 20);
            userLastNameLabel.TabIndex = 2;
            userLastNameLabel.Text = "ID:";
            // 
            // userFirstNameLabel
            // 
            userFirstNameLabel.AutoSize = true;
            userFirstNameLabel.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            userFirstNameLabel.Location = new Point(6, 52);
            userFirstNameLabel.Name = "userFirstNameLabel";
            userFirstNameLabel.Size = new Size(28, 20);
            userFirstNameLabel.TabIndex = 1;
            userFirstNameLabel.Text = "ID:";
            // 
            // userIdLabel
            // 
            userIdLabel.AutoSize = true;
            userIdLabel.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            userIdLabel.Location = new Point(6, 32);
            userIdLabel.Name = "userIdLabel";
            userIdLabel.Size = new Size(28, 20);
            userIdLabel.TabIndex = 0;
            userIdLabel.Text = "ID:";
            // 
            // producManagementGB
            // 
            producManagementGB.Controls.Add(label3);
            producManagementGB.Controls.Add(productStockTB);
            producManagementGB.Controls.Add(deleteProductButton);
            producManagementGB.Controls.Add(label2);
            producManagementGB.Controls.Add(label1);
            producManagementGB.Controls.Add(productPriceTB);
            producManagementGB.Controls.Add(productDescTB);
            producManagementGB.Controls.Add(label5);
            producManagementGB.Controls.Add(productNameTB);
            producManagementGB.Controls.Add(addProductButton);
            producManagementGB.Location = new Point(310, 12);
            producManagementGB.Name = "producManagementGB";
            producManagementGB.Size = new Size(300, 239);
            producManagementGB.TabIndex = 7;
            producManagementGB.TabStop = false;
            producManagementGB.Text = "Product Management";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label3.Location = new Point(6, 119);
            label3.Name = "label3";
            label3.Size = new Size(91, 17);
            label3.TabIndex = 9;
            label3.Text = "Stock Quantity";
            // 
            // productStockTB
            // 
            productStockTB.Location = new Point(103, 118);
            productStockTB.Name = "productStockTB";
            productStockTB.Size = new Size(190, 23);
            productStockTB.TabIndex = 8;
            // 
            // deleteProductButton
            // 
            deleteProductButton.Location = new Point(6, 191);
            deleteProductButton.Name = "deleteProductButton";
            deleteProductButton.Size = new Size(287, 38);
            deleteProductButton.TabIndex = 7;
            deleteProductButton.Text = "Delete Product";
            deleteProductButton.UseVisualStyleBackColor = true;
            deleteProductButton.Click += deleteProductButton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label2.Location = new Point(6, 61);
            label2.Name = "label2";
            label2.Size = new Size(74, 17);
            label2.TabIndex = 6;
            label2.Text = "Description";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label1.Location = new Point(6, 90);
            label1.Name = "label1";
            label1.Size = new Size(36, 17);
            label1.TabIndex = 5;
            label1.Text = "Price";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label5.Location = new Point(6, 32);
            label5.Name = "label5";
            label5.Size = new Size(43, 17);
            label5.TabIndex = 0;
            label5.Text = "Name";
            // 
            // statusLabel
            // 
            statusLabel.AutoSize = true;
            statusLabel.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            statusLabel.ForeColor = Color.ForestGreen;
            statusLabel.Location = new Point(12, 379);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new Size(50, 20);
            statusLabel.TabIndex = 10;
            statusLabel.Text = "Status";
            // 
            // purchasementFieldGB
            // 
            purchasementFieldGB.Controls.Add(quantityNUD);
            purchasementFieldGB.Controls.Add(label4);
            purchasementFieldGB.Controls.Add(label6);
            purchasementFieldGB.Controls.Add(addProductToCartButton);
            purchasementFieldGB.Location = new Point(310, 257);
            purchasementFieldGB.Name = "purchasementFieldGB";
            purchasementFieldGB.Size = new Size(300, 119);
            purchasementFieldGB.TabIndex = 11;
            purchasementFieldGB.TabStop = false;
            purchasementFieldGB.Text = "Purchasement Field";
            // 
            // quantityNUD
            // 
            quantityNUD.Location = new Point(103, 23);
            quantityNUD.Name = "quantityNUD";
            quantityNUD.Size = new Size(190, 23);
            quantityNUD.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label4.ForeColor = Color.ForestGreen;
            label4.Location = new Point(6, 245);
            label4.Name = "label4";
            label4.Size = new Size(0, 20);
            label4.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label6.Location = new Point(6, 29);
            label6.Name = "label6";
            label6.Size = new Size(56, 17);
            label6.TabIndex = 9;
            label6.Text = "Quantity";
            // 
            // addProductToCartButton
            // 
            addProductToCartButton.Location = new Point(6, 70);
            addProductToCartButton.Name = "addProductToCartButton";
            addProductToCartButton.Size = new Size(287, 38);
            addProductToCartButton.TabIndex = 1;
            addProductToCartButton.Text = "Add Product to Cart";
            addProductToCartButton.UseVisualStyleBackColor = true;
            addProductToCartButton.Click += addProductToCartButton_Click;
            // 
            // displayOrderHistory
            // 
            displayOrderHistory.Location = new Point(167, 265);
            displayOrderHistory.Name = "displayOrderHistory";
            displayOrderHistory.Size = new Size(113, 41);
            displayOrderHistory.TabIndex = 8;
            displayOrderHistory.Text = "Display Order History";
            displayOrderHistory.UseVisualStyleBackColor = true;
            displayOrderHistory.Click += displayOrderHistory_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1263, 403);
            Controls.Add(statusLabel);
            Controls.Add(purchasementFieldGB);
            Controls.Add(producManagementGB);
            Controls.Add(userInfoGB);
            Controls.Add(productsTable);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += MainForm_Load;
            ((System.ComponentModel.ISupportInitialize)productsTable).EndInit();
            userInfoGB.ResumeLayout(false);
            userInfoGB.PerformLayout();
            producManagementGB.ResumeLayout(false);
            producManagementGB.PerformLayout();
            purchasementFieldGB.ResumeLayout(false);
            purchasementFieldGB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)quantityNUD).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView productsTable;
        private Button addProductButton;
        private TextBox productNameTB;
        private TextBox productDescTB;
        private TextBox productPriceTB;
        private Button logOutButton;
        private GroupBox userInfoGB;
        private Label userRoleLabel;
        private Label userEmailLabel;
        private Label userLastNameLabel;
        private Label userFirstNameLabel;
        private Label userIdLabel;
        private GroupBox producManagementGB;
        private Button deleteProductButton;
        private Label label2;
        private Label label1;
        private Label label5;
        private Label label3;
        private TextBox productStockTB;
        private Label statusLabel;
        private Button refreshButton;
        private Button displayCartButton;
        private GroupBox purchasementFieldGB;
        private NumericUpDown quantityNUD;
        private Label label4;
        private Label label6;
        private Button addProductToCartButton;
        private Button displayOrderHistory;
    }
}
