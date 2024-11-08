using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP_Demo
{
    public class MaintenanceService
    {
        public void MaintainCar(Car car)
        {
            car.PerformCarMaintenance();
        }

        public void MaintainBike(Bike bike)
        {
            bike.PerformBikeMaintenance();
        }
    }
}

