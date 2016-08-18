using LayeredSolution.BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LayeredSolution.Szamlazo.OrderViews
{
    public partial class NewOrderForm : Form
    {
        private readonly NewOrderViewModel _newOrderViewModel;

        public NewOrderForm(NewOrderViewModel newOrderViewModel)
        {
            _newOrderViewModel = newOrderViewModel;
            InitializeComponent();
            newOrderBindingSource.DataSource = _newOrderViewModel.Order;
            OrderItemModelGridView.RowsAdded += delegate { UpdateSumBoxes(); };
            OrderItemModelGridView.RowsRemoved += delegate { UpdateSumBoxes(); };
        }

        public ProductModel ProductModel { get; set; }

        private void ProductNoTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                ProductModel = _newOrderViewModel.GetProduct(ProductNoTextBox.Text);
                if (ProductModel == null)
                {
                    ProductNoTextBox.Focus();
                    ProductNoTextBox.SelectAll();
                    return;
                }
                ProductNameLabel.Text = ProductModel.Name;
                ProductPriceLabel.Text = ProductModel.Price.ToString();
                ProductQuantityTextBox.Focus();
                ProductQuantityTextBox.SelectAll();
            }
        }

        private void ProductQuantityTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                _newOrderViewModel.Order.OrderItems.Add(new OrderItemModel
                {
                    OrderId = _newOrderViewModel.Order.Id,
                    Order = _newOrderViewModel.Order,
                    ProductId = ProductModel.Id,
                    Quantity = int.Parse(ProductQuantityTextBox.Text),
                    Price = ProductModel.Price,
                    ProductName = ProductModel.Name,
                    ProductNo = ProductModel.ProductNo
                });
            }
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            _newOrderViewModel.CreateOrder();
            Close();
        }

        private void UpdateSumBoxes()
        {
            PriceSumTextBox.Text = _newOrderViewModel.Order.SumPrice.ToString();
            SumQuantityTextBox.Text = _newOrderViewModel.Order.SumQuantity.ToString();
        }
    }
}
