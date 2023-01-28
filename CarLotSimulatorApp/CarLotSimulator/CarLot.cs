using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLotSimulator
{
    public class CarLot
    {
        // added duirng static exercise
        public static int numberOfCars = 1;

        public List<Car> CarList { get; set; } = new List<Car>();   
    }
}
