using FluentAssertions;
using LayeredSolution.BusinessLayer.EmployeeModels;
using LayeredSolution.Szamlazo;
using LayeredSolution.Szamlazo.EmployeeViews;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LayeredSolution.Tests.ViewModels
{
    [TestFixture]
    public class LoginViewModelTests
    {
        private LoginViewModel _viewModel;
        private Mock<IMessageService> messageServiceMock;
        private Mock<ILoggedInEmployeeService> loggedInEmployeeServiceMock;
        private Mock<IEmployeeService> employeeServiceMock;
        [SetUp]
        public void SetUp()
        {
            messageServiceMock = new Mock<IMessageService>();
            loggedInEmployeeServiceMock = new Mock<ILoggedInEmployeeService>();
            employeeServiceMock = new Mock<IEmployeeService>();
            loggedInEmployeeServiceMock.SetupAllProperties();
            _viewModel = new LoginViewModel(messageServiceMock.Object,
                                            loggedInEmployeeServiceMock.Object,
                                            employeeServiceMock.Object);
        }

        [Test]
        public void Login_OnCorrectUserAndPassword_ShouldSetTheLoggedInUser()
        {
            //Arrange
            var correctUser = "correct user";
            var correctPassword = "correct password";
            var cancelEventArgs = new CancelEventArgs();
            var employee = new EmployeeModel();
            employeeServiceMock.Setup(service => service.Login(It.IsAny<string>(), It.IsAny<string>())).Returns(employee);
            //Act
            _viewModel.UserName = correctUser;
            _viewModel.Password = correctPassword;
            _viewModel.Login(cancelEventArgs);
            //Assert
            cancelEventArgs.Cancel.Should().BeFalse("Siker");
            loggedInEmployeeServiceMock.Object.LoggedInEmployee.Should().NotBeNull("a login kitölti");
            employeeServiceMock.Verify(service => service.Login(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        }

        [Test]
        public void Login_OnWrongUserNameAndPassword_ShouldShowErrorAndCancel()
        {
            var wrongUser = "correct user";
            var wrongPassword = "correct password";
            var cancelEventArgs = new CancelEventArgs();

            _viewModel.UserName = wrongUser;
            _viewModel.Password = wrongPassword;
            _viewModel.Login(cancelEventArgs);

            cancelEventArgs.Cancel.Should().BeTrue("Hiba");
            messageServiceMock.Verify(service => service.ShowErrorMessage(It.IsAny<string>()), Times.Once);
        }
    }
}
