using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LayeredSolution.BusinessLayer;
using LayeredSolution.Szamlazo.OrderViews;
using Autofac;

namespace LayeredSolution.Szamlazo
{
    public partial class OrdersForm : Form
    {
        private readonly IOrderService _service; 

        public OrdersForm(IOrderService orderService)
        {
            InitializeComponent();
            _service = orderService;
        }
        
        private void OrdersForm_Load(object sender, EventArgs e)
        {
            orderBindingSource.DataSource = _service.GetOrders();
        }

        private void újRendelésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var lifetimeScope = Program.Container.BeginLifetimeScope();
            var form = lifetimeScope.Resolve<NewOrderForm>();
            form.MdiParent = MdiParent;
            form.WindowState = FormWindowState.Maximized;
            form.Show();
            form.Closed += delegate
            {
                lifetimeScope.Dispose();
                OrdersForm_Load(this, new EventArgs());
            };
        }
    }
}
