using LayeredSolution.BusinessLayer.Common;
using LayeredSolution.DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LayeredSolution.BusinessLayer.EmployeeModels
{
    public class EmployeeService : IEmployeeService
    {
        private readonly ISampleContext _sampleContext;

        public EmployeeService(ISampleContext sampleContext)
        {
            _sampleContext = sampleContext;
        }

        public List<EmployeeModel> GetEmployees()
        {
            return _sampleContext.Employees.Select(i => new EmployeeModel()
            {
                Id = i.Id, Name = i.Name, UserName = i.UserName, Role = i.Role, Password = null, Position = i.Position
            }).ToList();
        }

        public bool IsInRole(EmployeeModel user, string role)
        {
            return user.Role == role;
        }

        public EmployeeModel Login(string userName, string password)
        {
            var employeeModel = _sampleContext.Employees.Where(e => e.UserName == userName).Select(e => new EmployeeModel
            {
                Id = e.Id,
                Name = e.Name,
                Password = e.Password,
                UserName = e.UserName,
                Role = e.Role,
                Position = e.Position
            }).FirstOrDefault();
            if (employeeModel == null) return null;
            if(PasswordHelper.CheckPassword(password, employeeModel.Password))
            {
                return employeeModel;
            }
            return null;
        }

        public void SaveEmployee(EmployeeModel employee)
        {
            EmployeeEntity employeeEntity;
            if(employee.Id > 0)
            {
                employeeEntity = _sampleContext.Employees.FirstOrDefault(e => e.Id == employee.Id);
            }
            else
            {
                employeeEntity = new EmployeeEntity();
                _sampleContext.Employees.Add(employeeEntity);
            }
            if (employeeEntity != null)
            {
                employeeEntity.Name = employee.Name;
                employeeEntity.Position = employee.Position;
                employeeEntity.Role = employee.Role;
                employeeEntity.UserName = employee.UserName;
                if (!string.IsNullOrEmpty(employee.Password))
                {
                    employeeEntity.Password = PasswordHelper.EncryptPassword(employee.Password);
                }
            }
            _sampleContext.SaveChanges();
        }
    }
}
