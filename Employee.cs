using System.ComponentModel.Design;
using System.Net;

namespace Mammoth_Cave_Quick_Trippin_;

public class Employee
{
    

    public Employee() { }
    public Employee(int id) { }
    public Employee(int id ,string fristName, string lastName, string title) 
    {
        Id= id;
        FristName = fristName;
        LastName = lastName;
        Title = title;
        Store = Store;
        District= District;
    }

    public int Id { get; set; }
    public string FristName { get; set; }
    public string LastName { get; set; }
    public string Title { get; set; }

    public int Store { get; set; }
    public int District { get; set; }

    public List<Employee> Employees { get; set;}//= new List<Employee>();
    //public void AddEmployee(Employee employee)
    //{
    //    Employees.Add(employee);
    //}

    public void PrintEmployeesToConsol()
    {
        string output = $@"
Employee:{FristName} {LastName} Title:{Title}";
        Console.WriteLine(output);
    }
}
