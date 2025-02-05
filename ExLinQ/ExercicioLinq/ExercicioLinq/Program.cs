using ExercicioLinq.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

internal class Program
{
    private static void Main(string[] args)
    {
        List<Employee> employees = new List<Employee>();
        string path = @"E:\Repositório\C#\ExLinQ\in.txt";

        using (StreamReader sr = new StreamReader(path))
        {
            while (!sr.EndOfStream)
            {
                string line = sr.ReadLine();
                string[] vect = line.Split(',');
                double salary = double.Parse(vect[2]);
                employees.Add(new Employee(vect[0], vect[1], salary));
            }
        }

        Console.Write("Enter Salary: ");
        double salarySlice = double.Parse(Console.ReadLine());

        Console.WriteLine("Email of people whose salary is more than 2000.00: ");
        var emailSalarySlice = employees
            .Where(s => s.Salary > salarySlice)
            .Select(s => s.Email);

        foreach (var email in emailSalarySlice)
        {
            Console.WriteLine(email);
        }

        var salaryM = employees
            .Where(s => s.Name[0] == 'M')
            .Select(s => s.Salary);

        double totalSalaryM = salaryM.Sum();

        Console.WriteLine("Sum of salary of people whose name starts with 'M': " +
                          totalSalaryM.ToString("F2"));
    }
}







