using Autofac;
using LayeredSolution.BusinessLayer.EmployeeModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LayeredSolution.Szamlazo.EmployeeViews
{
    public partial class EmployeeListForm : Form
    {
        private readonly EmployeeListViewModel _employeeListViewModel;

        public EmployeeListForm(EmployeeListViewModel employeeListViewModel)
        {
            _employeeListViewModel = employeeListViewModel;
            InitializeComponent();
        }

        private void EmployeeListForm_Load(object sender, EventArgs e)
        {
            _employeeListViewModel.LoadEmployees();
            viewModelBindingSource.DataSource = _employeeListViewModel;
            employeeModelBindingSource.DataSource = _employeeListViewModel.Employees;
        }

        private void újToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenEditForm(null);
        }

        private void szerkesztToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var current = employeeModelBindingSource.Current as EmployeeModel;
            if (current == null) return;
            OpenEditForm(current);
        }

        private void OpenEditForm(EmployeeModel employeeModel)
        {
            using (var lifetimeScope = Program.Container.BeginLifetimeScope())
            {
                var form = lifetimeScope.Resolve<EmployeeEditForm>();
                form.EditModel(employeeModel);
                form.ShowDialog();
                _employeeListViewModel.LoadEmployees();
            }
        }
    }
}
