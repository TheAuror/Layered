using FizzWare.NBuilder;
using FluentAssertions;
using LayeredSolution.BusinessLayer.EmployeeModels;
using LayeredSolution.Szamlazo.EmployeeViews;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LayeredSolution.Tests.ViewModels
{
    [TestFixture]
    class EmployeeListViewModelTests
    {
        private EmployeeListViewModel _employeeListViewModel;
        private Mock<IEmployeeService> _employeeServiceMock;
        private List<EmployeeModel> employees;
        [SetUp]
        public void SetUp()
        {
            _employeeServiceMock = new Mock<IEmployeeService>();
            employees = Builder<EmployeeModel>.CreateListOfSize(10).Build().ToList();
            _employeeServiceMock.Setup(service => service.GetEmployees()).Returns(employees);
            _employeeListViewModel = new EmployeeListViewModel(_employeeServiceMock.Object);
        }

        [Test]
        public void OnLoad_WhemEmployeesInDatabase_ShouldReturnAllElement()
        {
            _employeeListViewModel.LoadEmployees();
            _employeeListViewModel.Employees.Should().NotBeNull();
            _employeeListViewModel.Employees.Should().HaveCount(employees.Count);
            _employeeListViewModel.Employees.Should().HaveCount(10);
        }

        [Test]
        public void SearchText_WhenChanged_ShouldFilterTheEmployeesBindingList()
        {
            _employeeListViewModel.LoadEmployees();
            _employeeListViewModel.SearchText = "Name2";
            _employeeListViewModel.Employees.Count.Should().BeGreaterThan(0);
            _employeeListViewModel.Employees.Should().OnlyContain(model => model.Name.ToLower().Contains(_employeeListViewModel.SearchText.ToLower()));
            _employeeListViewModel.Employees.Should().OnlyHaveUniqueItems();
        }
    }
}
