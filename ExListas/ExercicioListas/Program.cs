using System;
using System.Globalization;
using ExercicioListas;

Employee employee = new Employee();

Console.Write("How many employees will be registered ? ");
int QtdFuncionarios = int.Parse(Console.ReadLine());

for (int i = 0; i < QtdFuncionarios; i++)
{
    Console.WriteLine($"Employee #{i+1}");
    Console.Write("Employee Id: ");
    int employeeId = int.Parse(Console.ReadLine());
    Console.Write("Name: ");
    string name = Console.ReadLine();
    Console.Write("Salary: ");
    int salary = int.Parse(Console.ReadLine());
    employee.EmployeeRegister(employeeId,name,salary);
}
Console.WriteLine("---------------------------------------------------");
Console.Write("Enter the employee id that will have salary increase: ");
int employeeIdIncreasedSalary = int.Parse(Console.ReadLine());
Console.Write("Enter the percentage: ");
int increasePercentage = int.Parse(Console.ReadLine());
employee.IncreaseSalary(employeeIdIncreasedSalary, increasePercentage);
Console.WriteLine("---------------------------------------------------");

employee.ShowEmployeeList();   

