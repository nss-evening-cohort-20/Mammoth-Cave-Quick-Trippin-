using System.Collections.Generic;
using System.Text;

namespace Mammoth_Cave_Quick_Trippin_;

public class Menu
{
    private DistrictRepository _districtRepository = new DistrictRepository();
    private EmployeeRepository _employeeRepository = new EmployeeRepository();

    private enum MenuOption
    {
        ShowDistricts = 1,
        GenerateDistrictReport,
        AddDistrict,
        RemoveDistrict,
        UpdateDistrictSales,
        ShowEmployees,
        AddEmployee,
        RemoveEmployee,
        EditEmployee,
        AddStore,
        Exit
    }

    private bool _running;

    public void Show()
    {
        _running = true;
        while (_running)
        {
            Console.Clear();
            string menuText = GetMenuAsText();
            Console.Write(menuText);

            string input = Console.ReadLine();
            MenuOption chooseOption = (MenuOption)int.Parse(input);

            switch (chooseOption)
            {
                case MenuOption.ShowDistricts:
                    ShowDistricts();
                    break;

                case MenuOption.GenerateDistrictReport:
                    _districtRepository.GetDistrictReport();
                    break;

                case MenuOption.AddDistrict:
                    _districtRepository.SaveNewDistrict();
                    break;

                case MenuOption.RemoveDistrict:
                    _districtRepository.RemoveDistrict();
                    break;

                case MenuOption.UpdateDistrictSales:
                    _districtRepository.UpdateDistrictSales();
                    break;

                case MenuOption.ShowEmployees:
                    ShowEmployees();
                    break;

                case MenuOption.AddEmployee:
                    _employeeRepository.SaveNewEmployee();
                    break;

                case MenuOption.RemoveEmployee:
                    _employeeRepository.RemoveEmployee();
                    break;

                case MenuOption.EditEmployee:
                    _employeeRepository.UpdateEmployee();
                    break;

                case MenuOption.AddStore:
                    AddStore();
                    break;

                case MenuOption.Exit:
                    Exit();
                    _running = false;
                    break;

                default:
                    break;

            }
        }
    }

    public void ShowDistricts()
    {
        List<District> districts = _districtRepository.GetDistricts();
        districts.ForEach(district => Console.WriteLine(district.Name));

        Console.Write("Press enter to exit;");
        Console.ReadLine();
    }

    public void ShowEmployees()
    {
        List<Employee> employees = _employeeRepository.GetEmployees();
        foreach (var employee in employees)
        {
            Console.WriteLine(employee.FirstName +" "+ employee.LastName);
        }

        Console.Write("Press enter to exit;");
        Console.ReadLine();
    }
    private string GetMenuAsText()
    {
        StringBuilder bldr = new StringBuilder();

        List<string> menuOptions = Enum.GetNames<MenuOption>().ToList();

        for (int i = 0; i < menuOptions.Count; i++) //start at 1, don't print the 0 option
        {
            bldr.AppendLine($"{i+1}. {menuOptions[i]}");
        }

        bldr.AppendLine();
        bldr.Append("Please select a menu option: ");
        return bldr.ToString();
    }

    public void Exit()
    {
        Console.WriteLine("Exiting...");
    }
    private void AddStore()
    {
        Console.WriteLine("Add a Store/District");
        Console.ReadLine();
    }


}