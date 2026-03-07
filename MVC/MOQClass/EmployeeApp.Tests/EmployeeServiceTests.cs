using MOQClass.Models;
using MOQClass.Repositories;
using MOQClass.Services;
using Moq;
using NUnit.Framework;

namespace EmployeeApp.Tests;

public sealed class EmployeeServiceTests
{
    private Mock<IEmployeeRepository> _mockRepo;
    private EmployeeService _employeeService;

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
        _mockRepo.Setup(repo => repo.GetById(1)).Returns(employee);

        // Act
        var result = _employeeService.GetEmployeeOrThrow(1);

        // Assert
        Assert.That(result, Is.EqualTo(employee));
        _mockRepo.Verify(repo => repo.GetById(1), Times.Once);
    }

    [Test]
    public void GetEmployeeOrThrow_InvalidId_ThrowsArgumentException()
    {
        // Act & Assert
        Assert.Throws<ArgumentException>(() =>
            _employeeService.GetEmployeeOrThrow(0));
    }

    [Test]
    public void GetEmployeeOrThrow_EmployeeNotFound_ThrowsInvalidOperationException()
    {
        // Arrange
        _mockRepo.Setup(repo => repo.GetById(1)).Returns((Employee)null);

        // Act & Assert
        Assert.Throws<InvalidOperationException>(() =>
            _employeeService.GetEmployeeOrThrow(1));
    }
    [Test]
    public void Add_ValidEmployee_CallsRepositoryAdd()
    {
        // Arrange
        var employee = new Employee(2, "Alice", true);

        // Act
        _employeeService.Add(employee);

        // Assert
        _mockRepo.Verify(repo => repo.Add(employee), Times.Once);
    }
}