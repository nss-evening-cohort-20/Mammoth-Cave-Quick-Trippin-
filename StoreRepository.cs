using Mammoth_Cave_Quick_Trippin_;

class StoreRepository
{
    EmployeeRepository _employeeRepository = new EmployeeRepository();

    private List<Employee> _employees { set => _employeeRepository.GetEmployees(); }

    static List<Store> _stores = new List<Store>()
    {
        new Store(1) {GasYearly = 9865.35, GasCurrentQuarter = 1352.25, RetailYearly = 80522.21, RetailCurrentQuarter = 325.15},
        new Store(2) {GasYearly = 6452.52, GasCurrentQuarter = 1352.25, RetailYearly = 900000.25, RetailCurrentQuarter = 325.15},
        new Store(3) {GasYearly = 8484.25, GasCurrentQuarter = 1352.25, RetailYearly = 416415.25, RetailCurrentQuarter = 325.15},
        new Store(4) {GasYearly = 94564.24, GasCurrentQuarter = 1352.25, RetailYearly = 41645.01, RetailCurrentQuarter = 325.15},
        new Store(5) {GasYearly = 12434.24, GasCurrentQuarter = 1352.25, RetailYearly = 800004.24, RetailCurrentQuarter = 325.15},
        new Store(6) {GasYearly = 41241.00, GasCurrentQuarter = 1352.25, RetailYearly = 419415.02, RetailCurrentQuarter = 325.15}
    };

    public List<Store> GetStores()
    {
        return _stores;
    }

    public void SaveNewStore(Store store)
    {
        throw new NotImplementedException();
    }
}