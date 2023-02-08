
//Classes
//Menu -- enums
//District
//list of stores
//district manager
//inherit from employee (override retail sales)
//district name
//district sales -- totals store sales
//Store
//storeid (store number)
//gas yearly
//gas current quarter
//retail yearly
//retail current quarter
//store manager
//assistant manager
//list of associates
//store sales
//Employee -- base class for all types of employees.
//id
//name
//retail sales
//Store Manager -- inherit from employee
//title
//promote/demote other employees' titles
//fire employee (delete)
//Assistant Manager -- inherit from employee
//title
//Associate -- inherit from employee
//title
//quite job
//District Manager -- inherit from employee
//title
//id
//name

using Mammoth_Cave_Quick_Trippin_;

namespace Namespace
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Employee> Employees = new List<Employee>();

            Employees.Add(new Employee(1) { Id = 1, FristName = "Mason", LastName = "Brad", Title = "District Manager" });
            Employees.Add(new Employee(2) { Id = 2, FristName = "Kyle", LastName = "Malone", Title = "Manager" });
            Employees.Add(new Employee(3) { Id = 3, FristName = "Seven", LastName = "Thomas", Title = "Assistant Manager" });
            Employees.Add(new Employee(4) { Id = 4, FristName = "Cristi", LastName = "Hares", Title = "Associate" });
            Employees.Add(new Employee(5) { Id = 5, FristName = "Mariana", LastName = "Mena", Title = "Associate" });
            Employees.Add(new Employee(6) { Id = 6, FristName = "John", LastName = "White", Title = "Associate" });
            Employees.Add(new Employee(7) { Id = 7, FristName = "Markos", LastName = "Hales", Title = "Associate" });
            Employees.Add(new Employee(8) { Id = 8, FristName = "Gorge", LastName = "Barker", Title = "Associate" });
            Employees.Add(new Employee(9) { Id = 9, FristName = "Andrew", LastName = "Hares", Title = "Associate" });

            Employee employee1= new Employee(1) { Id = 1, FristName = "Mason", LastName = "Brad", Title = "District Manager" };
            //Employee employeesGroup= new Employee();
            //employeesGroup.AddEmployee(employee1);
            //foreach (var employee in employeesGroup.Employees)
            //{
            //    employee.PrintEmployeesToConsol();
            //}

            /*--------------display employees-------------*/
            foreach (var employee in Employees)
            {
                employee.PrintEmployeesToConsol();
            }


            /*--------------find employee by id-------------*/
            var findEmployeeId = Employees.FirstOrDefault(u => u.Id == 1);
            //Console.WriteLine($"Employee {findEmployeeId.Id} {findEmployeeId.FristName} {findEmployeeId.LastName}{findEmployeeId.Title}");

            //Console.WriteLine(employee1.LastName);
            //Menu menu = new Menu();
            //menu.Show();

            Console.ReadLine();



        }
    }
}

