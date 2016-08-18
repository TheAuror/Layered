using LayeredSolution.BusinessLayer.Common;
using LayeredSolution.BusinessLayer.EmployeeModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LayeredSolution.Szamlazo.EmployeeViews
{
    public class EmployeeEditViewModel : BaseModel
    {
        private readonly IEmployeeService _employeeService;

        public EmployeeEditViewModel(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        public EmployeeModel Employee { get; set; }

        public void EditEmployee(EmployeeModel model)
        {
            Employee = model ?? new EmployeeModel();
            OnPropertyChanged(nameof(Employee));
        }

        public void SaveEmployee()
        {
            _employeeService.SaveEmployee(Employee);
        }
    }
}
