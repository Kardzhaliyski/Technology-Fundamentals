using System;
using System.Linq;
using System.Collections.Generic;

namespace CompanyUsers
{
    class CompanyUsers
    {
        static void Main(string[] args)
        {
            var companyEmployees = new Dictionary<string, List<string>>();

            while (true)
            {
                string[] tokens = Console.ReadLine()
                    .Split(" -> ");
                if (tokens[0] == "End")
                {
                    break;
                }

                string company = tokens[0];
                string employeeId = tokens[1];

                AddEmployee(companyEmployees, company, employeeId);
            }

            companyEmployees = companyEmployees
                .OrderBy(x => x.Key)
                .ToDictionary(x => x.Key, x => x.Value);
            PrintEmployees(companyEmployees);

        }

        private static void PrintEmployees(Dictionary<string, List<string>> companyEmployees)
        {
            foreach (var company in companyEmployees)
            {
                Console.WriteLine(company.Key);

                foreach (var employee in company.Value)
                {
                    Console.WriteLine($"-- {employee}");
                }
            }
        }

        private static void AddEmployee(Dictionary<string, List<string>> companyEmployees, string company, string employeeId)
        {
            if (companyEmployees.ContainsKey(company) == false)
            {
                companyEmployees[company] = new List<string>();
            }

            if (companyEmployees[company].Contains(employeeId) == false)
            {
                companyEmployees[company].Add(employeeId);
            }
        }
    }
}
