using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DIP_Demo;

namespace DIPDemo
{
    
    //Testing the Dependency Inversion Principle 
    public class Program
    {
        public static void Main()
        {
            var car = new Car();
            var bike = new Bike(); 

            var maintenanceService = new MaintenanceService();
            maintenanceService.MaintainCar(car);
            maintenanceService.MaintainBike(bike);

            Console.ReadKey();
        }
    }
}
