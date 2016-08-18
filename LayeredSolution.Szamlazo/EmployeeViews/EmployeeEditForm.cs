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
    public partial class EmployeeEditForm : Form
    {
        private readonly EmployeeEditViewModel _employeeEditViewModel;
        public EmployeeEditForm(EmployeeEditViewModel employeeEditViewModel)
        {
            _employeeEditViewModel = employeeEditViewModel;
            InitializeComponent();
        }

        public void EditModel(EmployeeModel employeeModel)
        {
            _employeeEditViewModel.EditEmployee(employeeModel);
            employeeModelBindingSource.DataSource = _employeeEditViewModel.Employee;
        }

        private void EmployeeEditForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(DialogResult == DialogResult.OK)
            {
                _employeeEditViewModel.SaveEmployee();
            }
        }
    }
}
