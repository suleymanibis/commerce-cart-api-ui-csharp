namespace E_Commerce_Cart_API_UI.Forms
{
    partial class OrderHistoryForm
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
            ordersTable = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)ordersTable).BeginInit();
            SuspendLayout();
            // 
            // ordersTable
            // 
            ordersTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ordersTable.Location = new Point(12, 12);
            ordersTable.Name = "ordersTable";
            ordersTable.Size = new Size(572, 283);
            ordersTable.TabIndex = 0;
            // 
            // OrderHistoryForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(602, 307);
            Controls.Add(ordersTable);
            Name = "OrderHistoryForm";
            Text = "OrderHistoryForm";
            Load += OrderHistoryForm_Load;
            ((System.ComponentModel.ISupportInitialize)ordersTable).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView ordersTable;
    }
}