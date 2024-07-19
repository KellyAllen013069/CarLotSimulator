using System.Collections.Generic;
using System.Security.AccessControl;

namespace CarLotSimulator;

public class CarLot
{
    public List<Car> CarList { get; set; } = new List<Car>();

    public static int NumberOfCars { get; set; }
}