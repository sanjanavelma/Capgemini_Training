using System;

namespace MOQClass.Models
{
    public class Employee
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public bool IsActive { get; set; }

        public Employee(int id, string name, bool isActive)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException("Name cannot be empty.");
            }

            Id = id;
            Name = name;
            IsActive = isActive;
        }
    }
}