namespace Mammoth_Cave_Quick_Trippin_;

public class District
{
    ////District
    //list of stores
    //district manager
    //inherit from employee (override retail sales)
    //district name
    //district sales -- totals store sales



    //Public Properties//
    public string Manager { get; set; }

    public string Name { get; set; }

    public double Sales { get; set; }

    //Constructor Method//
    public District(string districtName, string districtManager, double districtSales)
    {
        Name = districtName;
        Manager = districtManager;
        Sales = districtSales;
    }

    //For List Of Stores//
    //public List<Store> GetStores()
    //{
    //    return new List<Store>();
    //}
}





