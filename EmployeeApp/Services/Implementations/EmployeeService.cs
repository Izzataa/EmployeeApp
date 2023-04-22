using System;
using EmployeeApp.Services.Interfaces;
using EmployeeApp.Core.Models;
using EmployeeApp.Data.Repositories;

namespace EmployeeApp.Services.Implementation
{
    internal class EmployeeService : IEmployeeService
    {
        private readonly EmployeeRepository _employeeRepository = new EmployeeRepository();

        public void Create()
        {
            Employee employee = new Employee();
            Console.WriteLine("Add name");
            employee.Name = Console.ReadLine();
            Console.WriteLine("Add Surname");
            employee.Surname = Console.ReadLine();
            Console.WriteLine("Add Salary");
            employee.Salary = double.Parse(Console.ReadLine());
            Console.WriteLine("Add Position");
            employee.Position = Console.ReadLine();
            _employeeRepository.Create(employee);


        }

        public void Delete()
        {
            Console.WriteLine("Enter ID");
            int.TryParse(Console.ReadLine(), out int id);

            Employee employee = _employeeRepository.Get(x => x.Id == id);
            if (employee == null)
            {
                Console.WriteLine("Employee not found");
            }
            else
            {
                _employeeRepository.Delete(employee);
                Console.WriteLine("Employee deleted");
            }
        }


        public void ShowAll()
        {
            List<Employee> employee = _employeeRepository.GetAll();
            if (employee == null)
            {
                Console.WriteLine("Employee not found");
            }
            foreach (var item in employee)
            {
                Console.WriteLine(item);
            }
          
        }

        public void Update()
        {
            Console.WriteLine("Enter Id");
            int.TryParse(Console.ReadLine(), out int id);

            Employee employee = _employeeRepository.Get(x => x.Id == id);

            if (employee == null)
            {
                Console.WriteLine("Employee not found");
            }
            else
            {
                Console.WriteLine("Add name");
                employee.Name = Console.ReadLine();

                Console.WriteLine("Add Position");
                employee.Position = Console.ReadLine();


            }
        }

        public void ShowById()
        {
            Console.WriteLine("Enter id:");
            int value = 0;
            if (!int.TryParse(Console.ReadLine(), out value) || value <= 0)
            {
                Console.WriteLine("Invalid input. Please enter a positive integer.");
                return;
            }
        }
        }
    }



