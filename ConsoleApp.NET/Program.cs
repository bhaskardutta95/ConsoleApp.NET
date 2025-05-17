using ConsoleApp.NET.Service;

var empService = new EmployeeService();
MenuService menuService = new MenuService(empService);
menuService.Execute();
