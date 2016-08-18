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
    public class LoginViewModel : BaseModel
    {
        private readonly IMessageService _messageService;
        private readonly IEmployeeService _employeeService;
        private readonly ILoggedInEmployeeService _loggedInEmployeeService;
        private string _userName;
        private string _password;

        public LoginViewModel(IMessageService messageService, 
                              ILoggedInEmployeeService loggedInEmployeeService, 
                              IEmployeeService employeeService)
        {
            _messageService = messageService;
            _employeeService = employeeService;
            _loggedInEmployeeService = loggedInEmployeeService;
        }

        public string UserName
        {
            get
            {
                return _userName;
            }
            set
            {
                OnPropertyChanged(ref _userName, value);
            }
        }

        public string Password
        {
            get
            {
                return _password;
            }
            set
            {
                OnPropertyChanged(ref _password, value);
            }
        }

        public void Login(CancelEventArgs args)
        {
            EmployeeModel employeeModel = _employeeService.Login(UserName, Password);
            if(employeeModel != null)
            {
                _loggedInEmployeeService.LoggedInEmployee = employeeModel;
            }
            else
            {
                _messageService.ShowErrorMessage("Wrong username or password");
                args.Cancel = true;
            }
        }
    }
}
