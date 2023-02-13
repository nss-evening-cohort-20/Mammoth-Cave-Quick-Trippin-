
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

            Menu menu = new Menu();
            menu.Show();

            //Store store = new Store(1);
            //store.ShowEmployees();
            //store.ShowSales();

            Console.ReadLine();



        }
    }
}

