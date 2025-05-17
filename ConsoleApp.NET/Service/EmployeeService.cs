using ConsoleApp.NET.Model;
using System.Text.Json;

namespace ConsoleApp.NET.Service
{
    public class EmployeeService
    {
        private List<EmpData> _empDataList;
        public EmployeeService() 
        {
            _empDataList =
            [
                new EmpData()
                {
                    Empid = 1,
                    EmpName = "Mike",
                    Domain = "DEV",
                    Salary = 100000
                },
                new EmpData()
                {
                    Empid = 2,
                    EmpName = "Brad",
                    Domain = "TESTING",
                    Salary = 100000
                },
                new EmpData()
                {
                    Empid = 3,
                    EmpName = "Chester",
                    Domain = "BA",
                    Salary = 100000
                }
            ];
        }

        public void GetAllEmpData()
        {
            Console.WriteLine(JsonSerializer.Serialize(_empDataList));
        }

        public void GetEmpDataById()
        {
            Console.Write("EmpId: ");
            var id = Console.ReadLine() ?? "";
            var empRecord = _empDataList
                .Where(x => x.Empid == Convert.ToInt32(id))
                .Select(x => new EmpData() 
            {
                Empid = x.Empid,
                EmpName = x.EmpName,
                Domain = x.Domain,
                Salary = x.Salary,
            }).ToList();

            Console.WriteLine(JsonSerializer.Serialize(empRecord));
        }

        public void AddEmp()
        {
            Console.Write("EmpId: ");
            var id = Console.ReadLine() ?? "";

            Console.Write("Name: ");
            var name = Console.ReadLine() ?? "";

            Console.Write("Domain: ");
            var domain = Console.ReadLine() ?? "";

            Console.Write("Salary: ");
            var sal = Console.ReadLine();

            var employee = new EmpData
            {
                Empid = Convert.ToInt32(id),
                EmpName = name,
                Domain = domain,
                Salary = Convert.ToDecimal(sal)
            };

            _empDataList.Add(employee);
            Console.WriteLine("Employee added successfully.");
        }
    }
}
