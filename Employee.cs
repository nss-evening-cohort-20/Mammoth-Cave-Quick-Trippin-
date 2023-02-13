using System.ComponentModel.Design;
using System.Net;
using System.Text.RegularExpressions;

namespace Mammoth_Cave_Quick_Trippin_;

public class Employee
{
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
    //public string District { get; set; }
    public List<Employee> Employees { get; set; }

    /*---------------//valid number--------------------*/
    public int NumberValidation(string input)
    {
        int ValidNumber = 0;
        bool isInvalid, isOutOfRange, IsOnlyDigits;
        isOutOfRange = true;
        IsOnlyDigits = false;
        do
        {
            //foreach (char c in input)
            //{
            //    if (!Char.IsDigit(c))
            //        IsOnlyDigits = true;
            //    Console.Write("Please enter a valid Number value: #");
            //    input = Console.ReadLine();
            //}

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

        } while (isInvalid || isOutOfRange || IsOnlyDigits);

        return ValidNumber;
        //newEmployee.Store = ValidNumber;
    }


    /*---------------//valid string--------------------*/

    public string StringValidation(string input)
    {
        bool isValid = true;

        do
        {
            if (string.IsNullOrEmpty(input))
            {
                isValid = false;
                Console.Write("Name cannot be blank: ");
            }
            else
            {

                //process 1
                isValid = Regex.IsMatch(input, @"^[a-zA-Z]+$");

                //process 2
                foreach (char c in input)
                {
                    if (!Char.IsLetter(c))
                        isValid = false;
                    Console.Write("just contain characters Please enter a valid value: ");
                }

            }
            input = Console.ReadLine();
        } while (!isValid);
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

