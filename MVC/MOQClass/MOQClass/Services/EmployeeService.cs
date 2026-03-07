using MOQClass.Models;
using System;
using System.Collections.Generic;
using System.Text;
using MOQClass.Repositories;
using System.Linq;

namespace MOQClass.Services
{
    public sealed class EmployeeService
    {
        private readonly IEmployeeRepository _repo;

        public EmployeeService(IEmployeeRepository repo)
        {
            _repo = repo;
        }

        public Employee GetEmployeeOrThrow(int id)
        {
            if (id <= 0)
            {
                throw new ArgumentException("Id must be greater than zero.");
            }

            var employee = _repo.GetById(id);

            if (employee == null)
            {
                throw new InvalidOperationException($"Employee with id {id} not found.");
            }

            return employee;
        }

        public IReadOnlyList<Employee> GetActiveEmployees()
        {
            return _repo.GetAll()
                        .Where(e => e.IsActive)
                        .ToList();
        }

        public void Add(Employee employee)
        {
            if (employee == null)
            {
                throw new ArgumentNullException(nameof(employee));
            }

            _repo.Add(employee);
        }

        public void Update(Employee employee)
        {
            if (employee == null)
            {
                throw new ArgumentNullException(nameof(employee));
            }

            _repo.Update(employee);
        }

        public void Delete(int id)
        {
            if (id <= 0)
            {
                throw new ArgumentException("Id must be greater than zero.");
            }

            _repo.Delete(id);
        }
    }
}