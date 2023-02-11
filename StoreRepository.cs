using Mammoth_Cave_Quick_Trippin_;

class StoreRepository
{
    EmployeeRepository _employeeRepository = new EmployeeRepository();

    private List<Employee> _employees { set => _employeeRepository.GetEmployees(); }

    static List<Store> _stores = new List<Store>()
    {
        
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