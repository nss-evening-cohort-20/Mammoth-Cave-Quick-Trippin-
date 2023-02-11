using Mammoth_Cave_Quick_Trippin_;
using System.Security.Cryptography.X509Certificates;
using static System.Formats.Asn1.AsnWriter;

class EmployeeRepository
{
    static List<Employee> _employees = new List<Employee>()
    {
        new Employee(1) { FirstName = "Mason", LastName = "Brad", Title = "Store Manager", Sales = 1015.01, StoreNumber = 1 },
        new Employee(2) { FirstName = "Kyle", LastName = "Brad", Title = "Store Manager", Sales = 1055.30, StoreNumber = 2 },
        new Employee(3) { FirstName = "Mariana", LastName = "Brad", Title = "Store Manager", Sales = 1200.60, StoreNumber = 3 },
        new Employee(4) { FirstName = "Cristi", LastName = "Brad", Title = "Store Manager", Sales = 1621.36, StoreNumber = 4 },
        new Employee(5) { FirstName = "aaaaa", LastName = "Brad", Title = "Store Manager", Sales = 3650.02, StoreNumber = 5 },
        new Employee(6) { FirstName = "Jerry", LastName = "Brad", Title = "Store Manager", Sales = 6055.22, StoreNumber = 6 },
        new Employee(7) { FirstName = "Bob", LastName = "Brad", Title = "Assistant Manager", Sales = 1411.22, StoreNumber = 1 },
        new Employee(8) { FirstName = "Brad", LastName = "Brad", Title = "Assistant Manager", Sales = 998.36, StoreNumber = 2 },
        new Employee(9) { FirstName = "Diane", LastName = "Brad", Title = "Assistant Manager", Sales = 456.32, StoreNumber = 3 },
        new Employee(10) { FirstName = "Sam", LastName = "Brad", Title = "Assistant Manager", Sales = 141.32, StoreNumber = 4 },
        new Employee(11) { FirstName = "Candy", LastName = "Brad", Title = "Assistant Manager", Sales = 559.65, StoreNumber = 5 },
        new Employee(12) { FirstName = "Brian", LastName = "Brad", Title = "Assistant Manager", Sales = 446.25, StoreNumber = 6 },
        new Employee(13) { FirstName = "Jasmine", LastName = "Brad", Title = "Associate", Sales = 448.67, StoreNumber = 1 },
        new Employee(14) { FirstName = "Derek", LastName = "Brad", Title = "Associate", Sales = 225.32, StoreNumber = 2 },
        new Employee(15) { FirstName = "Hal", LastName = "Brad", Title = "Associate", Sales = 114.32, StoreNumber = 3 },
        new Employee(16) { FirstName = "Stewart", LastName = "Brad", Title = "Associate", Sales = 441.32, StoreNumber = 4 },
        new Employee(17) { FirstName = "Thomas", LastName = "Brad", Title = "Associate", Sales = 441.25, StoreNumber = 5 },
        new Employee(18) { FirstName = "Charles", LastName = "Brad", Title = "Associate", Sales = 10.01, StoreNumber = 6 },
        new Employee(19) { FirstName = "Lukas", LastName = "Brad", Title = "District Manager" },
        new Employee(20) { FirstName = "Sarah", LastName = "Brad", Title = "District Manager" },
        new Employee(21) { FirstName = "Eleven", LastName = "Brad", Title = "District Manager" }
};

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

        Employee newEmployee = new Employee(0, "", "", "", 0);
        /*---------------//Employee validation--------------------*/

        Console.Write("Employee Id: ");
        //newEmployee.Id = int.Parse(Console.ReadLine());
        string input1 = Console.ReadLine();
        newEmployee.Id = newEmployee.NumberValidation(input1);
        /*-----------------------------------*/

        Console.Write("Employee FirstName: ");
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
        newEmployee.StoreNumber =newEmployee.NumberValidation(input4);
        /*-----------------------------------*/

        //Console.Write("Employee District: ");
        //newEmployee.District = Console.ReadLine();
        //_employees.Add(newEmployee);

        Console.Clear();
        Console.WriteLine(@$"Employee {newEmployee.FirstName} {newEmployee.LastName} added to database!
Title: {newEmployee.Title}
Store Number: {newEmployee.StoreNumber}");

        Console.Write("Press enter to exit.");
        Console.ReadLine();
    }
    /*---------------//Edit an employee--------------------*/

    public void UpdateEmployee()
    {
        throw new NotImplementedException();
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
