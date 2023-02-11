using Mammoth_Cave_Quick_Trippin_;

class DistrictRepository
{
    // we're using a static list here instead of a proper database
    // but the general idea still holds up once we cover databases
    // it's just another piece of code to replace and refactor nbd
    static List<District> _districts = new List<District>()
    {
        new District ("District1","Mason",10000),
        new District ("District2","Mariana",20000),
        new District ("District3","Cristi",30000),
        new District ("District4","Kyle",40000),
    };

    public List<District> GetDistricts()//????
    {
        return _districts;
    }

    public void SaveNewDistrict()
    {
        Console.Clear();

        District newDistrict = new District("", "", 0);

        Console.Write("District Name: ");
        newDistrict.Name = Console.ReadLine();

        Console.Write("District Manager: ");
        newDistrict.Manager = Console.ReadLine();

        Console.Write("District Sales: ");
        newDistrict.Sales = int.Parse(Console.ReadLine());

        _districts.Add(newDistrict);

        Console.WriteLine(@$"District {newDistrict.Name} added to database!
Manager: {newDistrict.Manager}
Sales: {newDistrict.Sales}");

        Console.Write("Press enter to exit.");
        Console.ReadLine();
    }

    public void UpdateDistrictSales()
    {
        Console.Clear();

        Console.Write("What District would you like to update? ");

        string district = Console.ReadLine();

        District foundDistrict = _districts.Find(d => d.Name == district);

        _districts.Remove(foundDistrict);
        Console.WriteLine($"{foundDistrict.Name} sales: {foundDistrict.Sales}");


        Console.Write("Enter your updated sales: ");


        foundDistrict.Sales = double.Parse(Console.ReadLine());

        _districts.Add(foundDistrict);

        Console.WriteLine($"{foundDistrict.Name} sales has been updated");

        Console.Write("Press enter to exit.");
        Console.ReadLine();

    }

    public void RemoveDistrict()
    {
        Console.Write("Enter district name to remove: ");

        string name = Console.ReadLine().ToLower();
        District foundDistrict = _districts.FirstOrDefault(d => d.Name.ToLower() == name);
        _districts.Remove(foundDistrict);

        Console.WriteLine($"District {name.ToUpper()} was removed from database.");

        Console.Write("Press enter to exit.");
        Console.ReadLine();
    }

    public void GetDistrictReport()
    {
        Console.Clear();
        Console.Write("Enter the name of the district you want a report on: ");

        string district = Console.ReadLine();
        District foundDistrict = _districts.Find(d => d.Name == district);

        Console.WriteLine(@$"
Name: {foundDistrict.Name}
Manager: {foundDistrict.Manager}
Sales: ${foundDistrict.Sales}
");

        Console.Write("Press enter to exit.");
        Console.ReadLine();
    }
}
