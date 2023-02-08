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
    public string DistrictManager { get; set; }

    public string DistrictName { get; set; }

    public int DistrictSales { get; set; }

    //Constructor Method//
    public District(string districtName, string districtManager, int districtSales)
    {
        DistrictName = districtName;
        DistrictManager = districtManager;
        DistrictSales = districtSales;
    }

    //For Lists Of Districts//
    static List<District> _districts = new List<District>();

    public List<District> GetDistricts()
    {
        throw new NotImplementedException();
    }


    // For Saving New Districts
    public void SaveNewDistrict(District district)
    {
        throw new NotImplementedException();
    }

    //For List Of Stores//
    public List<Store> GetStores()
    {
        return new List<Store>();
    }

}





