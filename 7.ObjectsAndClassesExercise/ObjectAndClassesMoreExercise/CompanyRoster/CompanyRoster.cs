using System;
using System.Collections.Generic;
using System.Linq;


class CompanyRoster
{
    static void Main()
    {
        var employeesDict = new Dictionary<string, List<Employee>>();
        int employesToAdd = int.Parse(Console.ReadLine());
        for (int i = 0; i < employesToAdd; i++)
        {
            string employeeInfo = Console.ReadLine();
            AddEmployee(employeesDict, employeeInfo);
        }

        var highestPaidDepartmentName = GetHighestPaidDepartmentName(employeesDict);

        PrintDepartment(employeesDict, highestPaidDepartmentName);
    }

    private static void PrintDepartment(Dictionary<string, List<Employee>> employeesDict, string highestPaidDepartmentName)
    {
        Console.WriteLine($"Highest Average Salary: {highestPaidDepartmentName}");
        employeesDict = OrderEmployeesBySalary(employeesDict);
        foreach (var employee in employeesDict[highestPaidDepartmentName])
        {
            Console.WriteLine($"{employee.Name} {employee.Salary:f2}");
        }
    }

    private static Dictionary<string, List<Employee>> OrderEmployeesBySalary(Dictionary<string, List<Employee>> employeesDict)
    {
        var orderedDict = new Dictionary< string, List< Employee >> ();
        foreach (var department in employeesDict)
        {
            orderedDict[department.Key] = department.Value.OrderByDescending(x => x.Salary).ToList();
        }

        return orderedDict;
    }

    private static string GetHighestPaidDepartmentName(Dictionary<string, List<Employee>> employeesDict)
    {
        var avarageSalaryPerDepartment = new Dictionary<string, decimal>();
        foreach (var department in employeesDict)
        {
            avarageSalaryPerDepartment[department.Key] = department.Value.Average(e => e.Salary);
        }

        var maxAvarageSalary = avarageSalaryPerDepartment
            .Max(x => x.Value);
        string maxPaidDepartmentName = avarageSalaryPerDepartment
            .FirstOrDefault(x => x.Value == maxAvarageSalary)
            .Key;
        return maxPaidDepartmentName;
    }

    private static void AddEmployee(Dictionary<string, List<Employee>> employeesDict, string employeeInfo)
    {
        string[] data = employeeInfo
            .Split();
        string name = data[0];
        string salary = data[1];
        string department = data[2];
        Employee employee = new Employee(name,salary,department);

        if (employeesDict.ContainsKey(department) == false)
        {
            employeesDict[department] = new List<Employee>();
        }

        employeesDict[department].Add(employee);
    }
}

class Employee
{
    public Employee(string name, string salary, string department)
    {
        Name = name;
        Salary = decimal.Parse(salary);
        Department = department;
    }

    public string Name { get; set; }
    public decimal Salary { get; set; }
    public string Department { get; set; }
}

