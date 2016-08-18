namespace LayeredSolution.Szamlazo.OrderViews
{
    partial class NewOrderForm
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
            this.components = new System.ComponentModel.Container();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.AdressLabel = new System.Windows.Forms.Label();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.AdressTextBox = new System.Windows.Forms.TextBox();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.PriceSumTextBox = new System.Windows.Forms.TextBox();
            this.SumQuantityTextBox = new System.Windows.Forms.TextBox();
            this.SumPriceLabel = new System.Windows.Forms.Label();
            this.QuantityLabel = new System.Windows.Forms.Label();
            this.OrderItemModelGridView = new System.Windows.Forms.DataGridView();
            this.orderItemsBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.NewItemLabel = new System.Windows.Forms.Label();
            this.ProductNoTextBox = new System.Windows.Forms.TextBox();
            this.ProductNameLabel = new System.Windows.Forms.Label();
            this.ProductPriceLabel = new System.Windows.Forms.Label();
            this.ProductQuantityTextBox = new System.Windows.Forms.TextBox();
            this.OKButton = new System.Windows.Forms.Button();
            this.newOrderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sumPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.OrderItemModelGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderItemsBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newOrderBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // NameTextBox
            // 
            this.NameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.newOrderBindingSource, "BuyerName", true));
            this.NameTextBox.Location = new System.Drawing.Point(53, 12);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(248, 20);
            this.NameTextBox.TabIndex = 0;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(12, 15);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(30, 13);
            this.NameLabel.TabIndex = 1;
            this.NameLabel.Text = "Név:";
            // 
            // AdressLabel
            // 
            this.AdressLabel.AutoSize = true;
            this.AdressLabel.Location = new System.Drawing.Point(12, 41);
            this.AdressLabel.Name = "AdressLabel";
            this.AdressLabel.Size = new System.Drawing.Size(29, 13);
            this.AdressLabel.TabIndex = 2;
            this.AdressLabel.Text = "Cím:";
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Location = new System.Drawing.Point(12, 67);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(35, 13);
            this.EmailLabel.TabIndex = 3;
            this.EmailLabel.Text = "Email:";
            // 
            // AdressTextBox
            // 
            this.AdressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.newOrderBindingSource, "BuyerAddress", true));
            this.AdressTextBox.Location = new System.Drawing.Point(53, 38);
            this.AdressTextBox.Name = "AdressTextBox";
            this.AdressTextBox.Size = new System.Drawing.Size(248, 20);
            this.AdressTextBox.TabIndex = 4;
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.newOrderBindingSource, "BuyerEmail", true));
            this.EmailTextBox.Location = new System.Drawing.Point(53, 64);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(248, 20);
            this.EmailTextBox.TabIndex = 5;
            // 
            // PriceSumTextBox
            // 
            this.PriceSumTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.newOrderBindingSource, "SumPrice", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.PriceSumTextBox.Location = new System.Drawing.Point(617, 8);
            this.PriceSumTextBox.Name = "PriceSumTextBox";
            this.PriceSumTextBox.ReadOnly = true;
            this.PriceSumTextBox.Size = new System.Drawing.Size(112, 20);
            this.PriceSumTextBox.TabIndex = 20;
            // 
            // SumQuantityTextBox
            // 
            this.SumQuantityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.newOrderBindingSource, "SumQuantity", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.SumQuantityTextBox.Location = new System.Drawing.Point(617, 34);
            this.SumQuantityTextBox.Name = "SumQuantityTextBox";
            this.SumQuantityTextBox.ReadOnly = true;
            this.SumQuantityTextBox.Size = new System.Drawing.Size(112, 20);
            this.SumQuantityTextBox.TabIndex = 19;
            // 
            // SumPriceLabel
            // 
            this.SumPriceLabel.AutoSize = true;
            this.SumPriceLabel.Location = new System.Drawing.Point(493, 11);
            this.SumPriceLabel.Name = "SumPriceLabel";
            this.SumPriceLabel.Size = new System.Drawing.Size(97, 13);
            this.SumPriceLabel.TabIndex = 8;
            this.SumPriceLabel.Text = "Rendelés összege:";
            // 
            // QuantityLabel
            // 
            this.QuantityLabel.AutoSize = true;
            this.QuantityLabel.Location = new System.Drawing.Point(493, 37);
            this.QuantityLabel.Name = "QuantityLabel";
            this.QuantityLabel.Size = new System.Drawing.Size(61, 13);
            this.QuantityLabel.TabIndex = 9;
            this.QuantityLabel.Text = "Tétel szám:";
            // 
            // OrderItemModelGridView
            // 
            this.OrderItemModelGridView.AllowUserToAddRows = false;
            this.OrderItemModelGridView.AutoGenerateColumns = false;
            this.OrderItemModelGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.OrderItemModelGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrderItemModelGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.orderIdDataGridViewTextBoxColumn,
            this.orderDataGridViewTextBoxColumn,
            this.productIdDataGridViewTextBoxColumn,
            this.productNoDataGridViewTextBoxColumn,
            this.productNameDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.sumPriceDataGridViewTextBoxColumn});
            this.OrderItemModelGridView.DataSource = this.orderItemsBindingSource2;
            this.OrderItemModelGridView.Location = new System.Drawing.Point(12, 150);
            this.OrderItemModelGridView.Name = "OrderItemModelGridView";
            this.OrderItemModelGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.OrderItemModelGridView.Size = new System.Drawing.Size(717, 150);
            this.OrderItemModelGridView.TabIndex = 18;
            // 
            // orderItemsBindingSource2
            // 
            this.orderItemsBindingSource2.DataMember = "OrderItems";
            this.orderItemsBindingSource2.DataSource = this.newOrderBindingSource;
            // 
            // NewItemLabel
            // 
            this.NewItemLabel.AutoSize = true;
            this.NewItemLabel.Location = new System.Drawing.Point(12, 96);
            this.NewItemLabel.Name = "NewItemLabel";
            this.NewItemLabel.Size = new System.Drawing.Size(47, 13);
            this.NewItemLabel.TabIndex = 11;
            this.NewItemLabel.Text = "Új Tétel:";
            // 
            // ProductNoTextBox
            // 
            this.ProductNoTextBox.Location = new System.Drawing.Point(12, 124);
            this.ProductNoTextBox.Name = "ProductNoTextBox";
            this.ProductNoTextBox.Size = new System.Drawing.Size(97, 20);
            this.ProductNoTextBox.TabIndex = 12;
            this.ProductNoTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ProductNoTextBox_KeyDown);
            // 
            // ProductNameLabel
            // 
            this.ProductNameLabel.AutoSize = true;
            this.ProductNameLabel.Location = new System.Drawing.Point(115, 127);
            this.ProductNameLabel.Name = "ProductNameLabel";
            this.ProductNameLabel.Size = new System.Drawing.Size(72, 13);
            this.ProductNameLabel.TabIndex = 14;
            this.ProductNameLabel.Text = "Termék Neve";
            // 
            // ProductPriceLabel
            // 
            this.ProductPriceLabel.AutoSize = true;
            this.ProductPriceLabel.Location = new System.Drawing.Point(482, 130);
            this.ProductPriceLabel.Name = "ProductPriceLabel";
            this.ProductPriceLabel.Size = new System.Drawing.Size(17, 13);
            this.ProductPriceLabel.TabIndex = 15;
            this.ProductPriceLabel.Text = "Ár";
            // 
            // ProductQuantityTextBox
            // 
            this.ProductQuantityTextBox.Location = new System.Drawing.Point(629, 124);
            this.ProductQuantityTextBox.Name = "ProductQuantityTextBox";
            this.ProductQuantityTextBox.Size = new System.Drawing.Size(100, 20);
            this.ProductQuantityTextBox.TabIndex = 16;
            this.ProductQuantityTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ProductQuantityTextBox_KeyDown);
            // 
            // OKButton
            // 
            this.OKButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OKButton.Location = new System.Drawing.Point(496, 67);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(233, 42);
            this.OKButton.TabIndex = 17;
            this.OKButton.Text = "Rendelés felvétele";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // newOrderBindingSource
            // 
            this.newOrderBindingSource.DataSource = typeof(LayeredSolution.BusinessLayer.OrderModel);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // orderIdDataGridViewTextBoxColumn
            // 
            this.orderIdDataGridViewTextBoxColumn.DataPropertyName = "OrderId";
            this.orderIdDataGridViewTextBoxColumn.HeaderText = "OrderId";
            this.orderIdDataGridViewTextBoxColumn.Name = "orderIdDataGridViewTextBoxColumn";
            this.orderIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // orderDataGridViewTextBoxColumn
            // 
            this.orderDataGridViewTextBoxColumn.DataPropertyName = "Order";
            this.orderDataGridViewTextBoxColumn.HeaderText = "Order";
            this.orderDataGridViewTextBoxColumn.Name = "orderDataGridViewTextBoxColumn";
            this.orderDataGridViewTextBoxColumn.Visible = false;
            // 
            // productIdDataGridViewTextBoxColumn
            // 
            this.productIdDataGridViewTextBoxColumn.DataPropertyName = "ProductId";
            this.productIdDataGridViewTextBoxColumn.HeaderText = "ProductId";
            this.productIdDataGridViewTextBoxColumn.Name = "productIdDataGridViewTextBoxColumn";
            this.productIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // productNoDataGridViewTextBoxColumn
            // 
            this.productNoDataGridViewTextBoxColumn.DataPropertyName = "ProductNo";
            this.productNoDataGridViewTextBoxColumn.HeaderText = "ProductNo";
            this.productNoDataGridViewTextBoxColumn.Name = "productNoDataGridViewTextBoxColumn";
            // 
            // productNameDataGridViewTextBoxColumn
            // 
            this.productNameDataGridViewTextBoxColumn.DataPropertyName = "ProductName";
            this.productNameDataGridViewTextBoxColumn.HeaderText = "ProductName";
            this.productNameDataGridViewTextBoxColumn.Name = "productNameDataGridViewTextBoxColumn";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            // 
            // sumPriceDataGridViewTextBoxColumn
            // 
            this.sumPriceDataGridViewTextBoxColumn.DataPropertyName = "SumPrice";
            this.sumPriceDataGridViewTextBoxColumn.HeaderText = "SumPrice";
            this.sumPriceDataGridViewTextBoxColumn.Name = "sumPriceDataGridViewTextBoxColumn";
            this.sumPriceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // NewOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 312);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.ProductQuantityTextBox);
            this.Controls.Add(this.ProductPriceLabel);
            this.Controls.Add(this.ProductNameLabel);
            this.Controls.Add(this.ProductNoTextBox);
            this.Controls.Add(this.NewItemLabel);
            this.Controls.Add(this.OrderItemModelGridView);
            this.Controls.Add(this.QuantityLabel);
            this.Controls.Add(this.SumPriceLabel);
            this.Controls.Add(this.SumQuantityTextBox);
            this.Controls.Add(this.PriceSumTextBox);
            this.Controls.Add(this.EmailTextBox);
            this.Controls.Add(this.AdressTextBox);
            this.Controls.Add(this.EmailLabel);
            this.Controls.Add(this.AdressLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.NameTextBox);
            this.Name = "NewOrderForm";
            this.Text = "NewOrderForm";
            ((System.ComponentModel.ISupportInitialize)(this.OrderItemModelGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderItemsBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newOrderBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource newOrderBindingSource;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label AdressLabel;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.TextBox AdressTextBox;
        private System.Windows.Forms.TextBox EmailTextBox;
        private System.Windows.Forms.TextBox PriceSumTextBox;
        private System.Windows.Forms.TextBox SumQuantityTextBox;
        private System.Windows.Forms.Label SumPriceLabel;
        private System.Windows.Forms.Label QuantityLabel;
        private System.Windows.Forms.DataGridView OrderItemModelGridView;
        private System.Windows.Forms.Label NewItemLabel;
        private System.Windows.Forms.TextBox ProductNoTextBox;
        private System.Windows.Forms.Label ProductNameLabel;
        private System.Windows.Forms.Label ProductPriceLabel;
        private System.Windows.Forms.TextBox ProductQuantityTextBox;
        private System.Windows.Forms.BindingSource orderItemsBindingSource2;
        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sumPriceDataGridViewTextBoxColumn;
    }
}