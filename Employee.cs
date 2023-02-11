using System.ComponentModel.Design;
using System.Net;

namespace Mammoth_Cave_Quick_Trippin_;

public class Employee
{
    //private int _store;
    //private bool ValidStoreInput(int input)
    //{

    //    return input <= 1;
    //}
    //private int _employees;
    static List<Employee> _employees = new List<Employee>();

    public Employee() { }
    public Employee(int id)
    { 
        Id = id;
    }
    public Employee(int id, string firstName, string lastName, string title, int store)
    {
        Id = id;
        FirstName = firstName;
        LastName = lastName;
        Title = title;
        StoreNumber = store;
    }

    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Title { get; set; }
    public double Sales { get; set; }

    public int StoreNumber { get; set; }

    public string District { get; set; }
    //public int Store
    //{
    //    get => _store;
    //    set
    //    {
    //        if (ValidStoreInput(value))
    //        {
    //            _store = value;
    //        }
    //        else
    //        {
    //            throw new Exception("The store must be a positive number.");
    //        }
    //    }
    //}


    public List<Employee> Employees { get; set; }
    
    
    //= new List<Employee>();
    //public void AddEmployee(Employee employee)
    //{
    //    Employees.Add(employee);
    //}

    //    public void PrintEmployeesToConsol()
    //    {
    //        string output = $@"
    //Employee:{FristName} {LastName} Title:{Title}";
    //        Console.WriteLine(output);
    //    }



    public int NumberValidation(string input)
    {

        int ValidNumber = 0;
        //string input = Console.ReadLine();
        bool isInvalid, isOutOfRange;
        isOutOfRange = true;
        do
        {
            isInvalid = !int.TryParse(input, out ValidNumber);
            if (!isInvalid)
            {
                isOutOfRange = (ValidNumber < 1 || ValidNumber > 1000);
            }
            if (isInvalid)
            {
                Console.Write("Please enter a valid Number value: #");
                input = Console.ReadLine();

            }
            else if (isOutOfRange)
            {
                Console.Write("Please enter value between 1 and 1000: #");
                input = Console.ReadLine();
            }

        } while (isInvalid || isOutOfRange);

        return ValidNumber;
        //newEmployee.Store = ValidNumber;
    }

    /*---------------//valid Name--------------------*/

    public string StringValidation(string input)
    {
        while (string.IsNullOrWhiteSpace(input))
        {
            Console.Write("Name cannot be blank: ");
            input = Console.ReadLine();
        }
        //ValidString.
        return input;
    }
    /*---------------//remove an employee--------------------*/

    public void RemoveEmployee(int input)
    {
        //Employee _employees;
        Console.Write("Enter Employee Id to remove: ");

        input = int.Parse(Console.ReadLine());
        Employee foundEmployeet = _employees.FirstOrDefault(d => d.Id == input);
        _employees.Remove(foundEmployeet);

        Console.WriteLine($"Employee #{input} was removed from database.");

        Console.Write("Press enter to exit.");
        Console.ReadLine();
    }
}

/*---------------//valid Name--------------------*/

//public string StringValidation(string input)
//{
//    string ValidString = " ";
//    while (true)
//    {

//        if (string.IsNullOrWhiteSpace(input))
//        {
//            Console.Write("Name cannot be blank: ");
//            input = Console.ReadLine();
//        }
//        //if (int.Parse(input)>=0)
//        //{
//        //    Console.Write("Enter valid value: ");
//        //    input = Console.ReadLine();
//    //}
//        else
//    {
//        continue;
//    }

//}
//    return ValidString;
//}