using EmployeeApp.Services.Implementation;
using EmployeeApp.Services.Interfaces;

IEmployeeService employeeService = new EmployeeService();

Console.WriteLine("0.Close");
Console.WriteLine("1.Employee Create");
Console.WriteLine("2.Employee Update");
Console.WriteLine("3.Employee Delete");
Console.WriteLine("4.Employee ShowAll");
Console.WriteLine("5.Employee ShowById");

string Request = Console.ReadLine();

while (Request != "0")
{
    switch (Request)
    {
        case "1":
            Console.Clear();
            employeeService.Create();
            break;
        case "2":
            Console.Clear();

            employeeService.Update();
            break;
        case "3":
            Console.Clear();

            employeeService.Delete();

            break;
        case "4":
            Console.Clear();

            employeeService.ShowAll();

            break;
        case "5":
            Console.Clear();

            employeeService.ShowById();
            break;
        default:
            Console.Clear();
            Console.WriteLine("select valid option");
            break;
    }

    Console.WriteLine("0.Close");
    Console.WriteLine("1.Employee Create");
    Console.WriteLine("2.Employee Update");
    Console.WriteLine("3.Employee Delete");
    Console.WriteLine("4.Employee ShowAll");
    Console.WriteLine("5.Employee ShowById");

    Request = Console.ReadLine();
}
