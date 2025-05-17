using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.NET.Service
{
    public class MenuService
    {
        private EmployeeService _employeeService;
        public MenuService(EmployeeService employeeService) 
        {
             _employeeService = employeeService;
        }

        public void Execute()
        {
            while (true)
            {
                Console.WriteLine("\n--- Employee Management System ---");
                Console.WriteLine("1. Add Employee");
                Console.WriteLine("2. List Employees");
                Console.WriteLine("3. Get Employee By Id");
                Console.WriteLine("0. Exit");
                Console.Write("Choose an option: ");

                var choice = Console.ReadLine();
                switch (choice)
                {
                    case "1": _employeeService.AddEmp(); break;
                    case "2": _employeeService.GetAllEmpData(); break;
                    case "3": _employeeService.GetEmpDataById(); break;
                    case "0": return;
                    default: Console.WriteLine("Invalid option."); break;
                }
            }
        }
    }
}
