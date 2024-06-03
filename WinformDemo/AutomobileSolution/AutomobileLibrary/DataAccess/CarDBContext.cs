using AutomobileLibrary.BussinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace AutomobileLibrary.DataAccess
{
    public class CarDBContext
    {
        // private car list
        private static List<Car> CarList = new List<Car>()
        {
            new Car() {CarID = 1, CarName = "CRV", Manufacturer = "Honda", Price = 30000, ReleaseYear = 2001},
            new Car() {CarID = 2, CarName = "Ford Focus", Manufacturer = "Ford", Price = 15000, ReleaseYear = 2010}
        };

        //--------------------------------------------------
        //Using singleton pattern
        private CarDBContext() { }
        private static CarDBContext instance = null;
        private static readonly object instantLock = new object();
        public static CarDBContext Instance
        {
            get
            {
                lock(instantLock)
                {
                    if (instance == null)
                    {
                        instance = new CarDBContext();
                    }
                    return instance;
                }
            }
        }
        //--------------------------------------------------

        public List<Car> GetCarList() => CarList;

        public Car GetCarByID(int carID)
        {
            return CarList.SingleOrDefault(car => car.CarID == carID);
        }

        public void AddNew(Car car)
        {
            Car temp = GetCarByID(car.CarID);
            if(temp != null)
            {
                throw new Exception("Car is already exists.");
            }

            CarList.Add(car);
        }

        public void Update(Car car)
        {
            Car temp = GetCarByID(car.CarID);
            
            if (temp == null) {
                throw new Exception("Car does not already exists.");
            }

            var index = CarList.IndexOf(temp);
            CarList[index] = car;
        }

        public void Remove(int carID)
        {
            Car temp = GetCarByID(carID);
            if (temp == null)
            {
                throw new Exception("Car does not already exists.");
            }

            CarList.Remove(temp);
        }
    }
}
