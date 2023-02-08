using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mammoth_Cave_Quick_Trippin_
{
    public interface IPromote_Fire_Hire
    {
    public DateTime HiredDate { get; set; } 
    public DateTime FiredDate { get; set; }
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
}
