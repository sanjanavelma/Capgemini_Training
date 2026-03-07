
using MOQClass.Models;
using MOQClass.Repositories;
using MOQClass.Services;
using Moq;
using NUnit.Framework;

namespace EmployeeApp.Tests;

public class EmployeeServiceTests
{
    public sealed class EmployeeServiceTests
    {
        private Mock<IEmployeeRepository> _mockRepo;
        private EmployeeService _employeeService = default!;
        [SetUp]
        public void Setup()
        {
            _mockRepo = new Mock<IEmployeeRepository>();
            _employeeService = new EmployeeService(_mockRepo.Object);
        }
        [Test]
        public void GetEmployeeOrThrow_ValidId_ReturnsEmployee()
        {
            // Arrange
            var employee = new Employee(1, "John Doe", true);
            _mockRepo.Setup(repo => repo.GetById(1)).Returns
}


