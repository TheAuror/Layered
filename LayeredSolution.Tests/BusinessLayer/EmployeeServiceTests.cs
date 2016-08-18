using FluentAssertions;
using LayeredSolution.BusinessLayer.Common;
using LayeredSolution.BusinessLayer.EmployeeModels;
using LayeredSolution.DataLayer;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LayeredSolution.Tests.BusinessLayer
{
    [TestFixture]
    public class EmployeeServiceTests
    {
        private EmployeeService _employeeService;
        private Mock<ISampleContext> _sampleContext;
        private Mock<DbSet<EmployeeEntity>> _employeeDbSetMock;
        List<EmployeeEntity> employees;
        [SetUp]
        public void SetUp()
        {
            _sampleContext = new Mock<ISampleContext>();
            _employeeDbSetMock = new Mock<DbSet<EmployeeEntity>>();
            _sampleContext.SetupGet(context => context.Employees).Returns(_employeeDbSetMock.Object);
            employees = new List<EmployeeEntity>();
            employees.Add(new EmployeeEntity()
            {
                Id = 1,
                UserName = "Correct",
                Role = "admin",
                Password = PasswordHelper.EncryptPassword("correct password")
            });
            employees.Add(new EmployeeEntity()
            {
                Id = 2,
                UserName = "Correct2",
                Role = "user",
                Password = PasswordHelper.EncryptPassword("correct password2")
            });
            _employeeDbSetMock.SetDataSource(employees);
            _employeeService = new EmployeeService(_sampleContext.Object);
            
        }

        [Test]
        public void Login_OnCorrectUserAndPassword_ShouldReturnEmployeeModel()
        {
            //Arrange
            //Act
            var result = _employeeService.Login("Correct", "correct password");
            //Assert
            result.Should().NotBeNull();
            result.Id.Should().Be(1);
        }

        [Test]
        public void GetEmployees_EmployeesInDatabase_ShouldReturnAllElement()
        {
            _employeeService.GetEmployees().Count.Should().NotBe(null);
            _employeeService.GetEmployees().Count.Should().Be(_employeeDbSetMock.Object.Count());
            var list = _employeeService.GetEmployees();
            list.Should().OnlyContain(e => e.Password == null);
        }

        [Test]
        public void SameEmployee_OnNewEmployee_SaveNewEmployee()
        {
            var newEmployee = new EmployeeModel
            {
                Id = 0,
                Name = "Asd",
                Password = "asd",
                Role = "user",
                Position = "senki",
                UserName = "asd"
            };
            _employeeService.SaveEmployee(newEmployee);

            _employeeDbSetMock.Verify(set => set.Add(It.IsAny<EmployeeEntity>()), Times.Once);
            _sampleContext.Verify(context => context.SaveChanges(), Times.Once);
        }

        [Test]
        public void SaveEmployee_OnExistingEmployee_UpdateEmployee()
        {
            EmployeeModel existingEmployee = new EmployeeModel
            {
                Id = 1,
                Name = "AsdUpdated",
                Password = "asd",
                Role = "user",
                Position = "senki",
                UserName = "asd"
            };

            _employeeService.SaveEmployee(existingEmployee);

            _sampleContext.Verify(context => context.SaveChanges(), Times.Once);
            var employeeEntity = employees.Find(e => e.Id == existingEmployee.Id);
            employeeEntity.Name.Should().Be(existingEmployee.Name);
            PasswordHelper.CheckPassword(existingEmployee.Password, employeeEntity.Password).Should().BeTrue();    
        }

        [Test]
        public void SaveEmployee_OnEmptyPassword_DontUpdatePassword()
        {
            EmployeeModel existingEmployee = new EmployeeModel
            {
                Id = 1,
                Name = "AsdUpdated",
                Password = "",
                Role = "user",
                UserName = "asd",
                Position = "user"
            };

            var employeeEntity = employees.Find(e => e.Id == existingEmployee.Id);

            var oldPasswordHash = employeeEntity.Password;

            _employeeService.SaveEmployee(existingEmployee);

            _sampleContext.Verify(context => context.SaveChanges(), Times.Once);
            employeeEntity.Name.Should().Be(existingEmployee.Name);
            employeeEntity.Password.Should().Be(oldPasswordHash);
        }
    }
}
