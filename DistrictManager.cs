namespace Mammoth_Cave_Quick_Trippin_;

public class DistrictManager : Employee //, IPromote_Fire_Hire
{
    //promote/demote other employees' titles
    //fire employee (delete)
    public DateTime HiredDate { get; set; } = DateTime.Now.Date;
    public DateTime FiredDate { get; set; } = DateTime.Now.Date;
    public string Promote { get; set; }

    public void Hire(DateTime hiredDate)
    {
        Console.WriteLine("Hire");
    }
    public void Fire(Employee employee)
    {
        employee.Employees.Clear();
    }
    public void promotion(Employee employee)
    {

    }
}
