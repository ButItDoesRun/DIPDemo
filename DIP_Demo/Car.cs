using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP_Demo
{
    public class Car : IVehicle
    {
        public void PerformMaintenance()
        {
            Console.WriteLine("Performing car maintenance...");
        }
    }
}