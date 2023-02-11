namespace Mammoth_Cave_Quick_Trippin_;

public class Store
{
    EmployeeRepository _employeeRepository = new EmployeeRepository();
    private List<Employee> _employees;
    public List<Employee> Employees
    { 
        get { return _employees; }
        set
        {
            List<Employee> allEmployees = _employeeRepository.GetEmployees();
            foreach (Employee employee in allEmployees)
            {
                if (employee.StoreNumber == StoreNumber)
                {
                    _employees.Add(employee);
                }
            }
        }
    }

    public int StoreNumber { get; set; } //have this public read-only maybe?
    //stretch goal: have method in District class that can set the id for a new store since it already contains a list of all the stores? unsure how complex this would be
    public Employee StoreManager { get; set; }
    public Employee AssistantManager { get; set; }
    public List<Employee> Associates = new List<Employee>();
    public double GasYearly { get; set; }
    public double GasCurrentQuarter { get; set; }
    public double RetailYearly { get; set; }
    public double RetailCurrentQuarter { get; set; }

    public Store(int id)
    {
        StoreNumber = id;
    }

    public void DisplayEmployees()
    {
        _employees.ForEach(employee => Console.WriteLine(employee.FirstName));
        Console.WriteLine("Done.");
    }

//    public void GenerateSalesReport()
//    {
//        Console.WriteLine($@"Store #{_id}
//-----------------------------
//1. Store Manager
//{StoreManager}
//Retail Sales: ${StoreManager.RetailSales}

//2. Assistant Manager
//{AssistantManager}
//Retail Sales: ${AssistantManager.RetailSales}
//");
//        GenerateAssociateSales();
//        Console.WriteLine($@"Gas Yearly: ${GasYearly}
//Gas Current quarter: ${GasCurrentQuarter}
//Retail Yearly: ${RetailYearly}
//Retail Current quarter: ${RetailCurrentQuarter}
//");
//    }

//    public void GenerateAssociateSales()
//    {
//        Associates.ForEach(associate =>
//        {
//            int num = 3;
//            Console.WriteLine($@"{num}. Associate
//{associate.Name}
//Retail Sales: ${associate.RetailSales}
//");
//            num++;
//        });
//    }
}