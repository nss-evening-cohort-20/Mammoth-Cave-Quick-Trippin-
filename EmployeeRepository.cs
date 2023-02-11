using Mammoth_Cave_Quick_Trippin_;
using System.Security.Cryptography.X509Certificates;
using static System.Formats.Asn1.AsnWriter;

class EmployeeRepository
{
    static List<Employee> _employees = new List<Employee>()
    {
        new Employee(),
            new Employee(1) { Id = 1, FirstName = "Mason", LastName = "Brad", Title = "District Manager" },
            new Employee(2) { Id = 2, FirstName = "Kyle", LastName = "Malone", Title = "Manager" },
            new Employee(9) { Id = 9, FirstName = "Andrew", LastName = "Hares", Title = "Associate" },
            new Employee(3) { Id = 3, FirstName = "Seven", LastName = "Thomas", Title = "Assistant Manager" },
            new Employee(4) { Id = 4, FirstName = "Cristi", LastName = "Hares", Title = "Associate" },
            new Employee(5) { Id = 5, FirstName = "Mariana", LastName = "Mena", Title = "Associate" },
            new Employee(6) { Id = 6, FirstName = "John", LastName = "White", Title = "Associate" },
            new Employee(7) { Id = 7, FirstName = "Markos", LastName = "Hales", Title = "Associate" },
            new Employee(8) { Id = 8, FirstName = "Gorge", LastName = "Barker", Title = "Associate" },
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
        newEmployee.Store = newEmployee.NumberValidation(input4);
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
