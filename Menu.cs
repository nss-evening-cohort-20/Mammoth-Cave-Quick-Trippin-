using System.Text;

namespace Mammoth_Cave_Quick_Trippin_;

public class Menu
{

    private enum MenuOption
    {
        DistrictSales,
        DistrictReport,
        NewEmployee,
        AddStoreDistrict,
        Exit
    }

    private bool _running;

    public void Show()
    {
        _running = true;
        while (_running)
        {
            MenuOption currentOption = MenuOption.DistrictSales;

            Console.Clear();
            string menuText = GetMenuAsText();
            Console.Write(menuText);

            string input = Console.ReadLine();
            MenuOption chooseOption = (MenuOption)int.Parse(input);

            switch (chooseOption)
            {
                case MenuOption.DistrictSales:
                    GetDistrictSales();
                    break;

                case MenuOption.DistrictReport:
                    GetDistrictReport();
                    break;

                case MenuOption.NewEmployee:
                    GetNewEmployee();
                    break;

                case MenuOption.AddStoreDistrict:
                    AddStoreDistrict();
                    break;

                default:
                    break;

            }
        }
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
    private void GetDistrictSales()
    {
        Console.WriteLine("Enter District Sales");

        Console.ReadLine();
    }

    private void GetDistrictReport()
    {
        Console.Write("Generate District Report");
        Console.ReadLine();
    }

    private void GetNewEmployee()
    {
        Console.WriteLine("Add New Employee");
        Console.Write("Press enter to go back...");
        Console.ReadLine();
    }

    private void AddStoreDistrict()
    {
        Console.WriteLine("Add a Store/District");

        Console.ReadLine();
    }


}