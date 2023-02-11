using Mammoth_Cave_Quick_Trippin_;
using System.Security.Cryptography.X509Certificates;
using static System.Formats.Asn1.AsnWriter;

class EmployeeRepository
{
    static List<Employee> _employees = new List<Employee>();

    public List<Employee> GetEmployees()
    {
        return _employees;
    }

    //private bool ValidStoreInput(int input)
    //{
    //    return input <= 1;

    //}
    public void SaveNewEmployee()
    {
        Console.Clear();
        Console.WriteLine("Add New Employee");

        Employee newEmployee = new Employee(0, "", "", "", 0, "");
        /*---------------//Employee validation--------------------*/

        Console.Write("Employee Id: ");
        //newEmployee.Id = int.Parse(Console.ReadLine());
        string input1 = Console.ReadLine();
        newEmployee.Id = newEmployee.NumberValidation(input1);
        /*-----------------------------------*/

        Console.Write("Employee FirsttName: ");
        //newEmployee.FirstName = Console.ReadLine();
        string input2 = Console.ReadLine();
        newEmployee.FirstName = newEmployee.StringValidation(input2);

        Console.Write("Employee LastName: ");
        string input3 = Console.ReadLine();
        newEmployee.LastName = newEmployee.StringValidation(input3);

        Console.Write("Employee Title: ");
        newEmployee.Title = Console.ReadLine();

        /*-----------------------------------*/
        Console.Write("Employee Store Number: ");
        string input4 = Console.ReadLine();
       // int storeNumberOut = 0;
   // newEmployee.Store = storeNumberOut;
        newEmployee.Store =newEmployee.NumberValidation(input4);
        /*-----------------------------------*/

        Console.Write("Employee District: ");
        newEmployee.District = Console.ReadLine();
        _employees.Add(newEmployee);

        Console.Clear();
        Console.WriteLine(@$"Employee {newEmployee.FirstName} {newEmployee.LastName} added to database!
Title: {newEmployee.Title}
District: {newEmployee.District}
Store Number: {newEmployee.Store}");

        Console.Write("Press enter to exit.");
        Console.ReadLine();
    }
    /*---------------//Edit an employee--------------------*/

    public void UpdateEmployee()
    {
        Console.Clear();
        Console.WriteLine("Enter Employee Id to update : #");
        int employeeId = int.Parse(Console.ReadLine());
        Employee foundEmployee = _employees.FirstOrDefault(_employees[employeeId]);
    }
    /*---------------//remove an employee--------------------*/
    public void RemoveEmployee()
    {
        Console.Write("Enter Employee Id to remove: ");

        int id = int.Parse(Console.ReadLine());
        Employee foundEmployeet = _employees.FirstOrDefault(d => d.Id == id);
        _employees.Remove(foundEmployeet);

        Console.WriteLine($"Employee #{id} was removed from database.");

        Console.Write("Press enter to exit.");
        Console.ReadLine();
    }

}

/*----------------?????????????????-------------------*/
//store validation
//Console.Write("Employee Store: ");
//int input = newEmployee.Store;
//while (true)
//{
//    if (!int.TryParse(Console.ReadLine(), out input))
//        Console.Write("Please enter a valid store number: #");
//    else if (input < 1 || input > 100)
//        Console.Write("Please enter an amount between 1 and 100: ");
//    else
//        break;
//}
//Console.WriteLine("Store number is: " + input.ToString("n"));
/*-----------------------------------*/
//int storeAsInt;
//Console.Write("Employee Store: ");
//string input = Console.ReadLine();
////|| courageAsDec < 0m || courageAsDec > 2m
//while (!int.TryParse(input, out storeAsInt))
//{
//    Console.Write("Please enter value between 1 and 1000: #");
//    input = Console.ReadLine();
//}
//newEmployee.Store = storeAsInt;
/*-----------------------------------*/

//private void NumberValidation()
//{
//    throw new NotImplementedException();
//}
