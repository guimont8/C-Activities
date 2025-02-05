using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioListas;

internal class Employee
{
    List<Employee> employeeList = new List<Employee>();
    public int EmployeeId { get; private set; }
    public string Name { get; private set; }
    public int Salary { get; private set; }

    public void EmployeeRegister(int id, string name, int salary)
    {
        employeeList.Add(new Employee { EmployeeId = id, Name = name, Salary = salary });
    }
    public void IncreaseSalary(int id, int percentage)
    {
        var employee = employeeList.FirstOrDefault(x => x.EmployeeId == id);

        if (employee != null)
        {
            employee.Salary += employee.Salary * percentage / 100;
        }
        else
        {
            Console.WriteLine("Employee not found.");
        }
    }

    public void ShowEmployeeList()
    {
        Console.WriteLine("Registered Employees:");
        foreach (var employee in employeeList)
        {
            Console.WriteLine($"ID: {employee.EmployeeId}, Name: {employee.Name}, Salary: {employee.Salary:C}");
        }
    }
}
