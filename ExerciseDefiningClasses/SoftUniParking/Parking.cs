using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SoftUniParking
{
    public class Parking
    {

        private int capacity;
        private List<Car> cars = new List<Car>();
        private int count = 0;

        public int Count
        {
            get { return Cars.Count; } 
        }




        public List<Car> Cars
        {
            get { return cars; }
            set { cars = value; }
        }

        public Parking(int cap)
        {
            this.capacity = cap;
        }
        public string AddCar(Car car)
        {
            if ((Cars.Any(c => c.RegistrationNumber == car.RegistrationNumber)))
            {
                return "Car with that registration number, already exists!";
            }
            else if (Cars.Count >= capacity)
            {
                return "Parking is full!";
            }
            else
            {
                Cars.Add(car);
                return  $"Successfully added new car {car.Make} {car.RegistrationNumber}";
               
            }
        }
        public string RemoveCar(string regNum)
        {
            bool isRemoved = false;
            foreach (var item in Cars)
            {
                if (item.RegistrationNumber == regNum)
                {
                    Cars.Remove(item);
                    isRemoved = true;
                    
                    return $"Successfully removed {regNum}";
                    
                    
                }
            }
            if (!isRemoved)
            {
                return "Car with that registration number, doesn't exist!";
            }
            return "";
        }

        public string GetCar(string regNum)
        {
            foreach (var item in Cars)
            {
                if (item.RegistrationNumber == regNum)
                {
                   return item.ToString();
                }
                else
                {
                    
                }
            }
            return "";
        }
        public void RemoveSetOfRegistrationNumber(List<string> RegistrationNumbers)
        {
            foreach (var item in RegistrationNumbers)
            {
                foreach (var item1 in Cars)
                {
                    if (item == item1.RegistrationNumber)
                    {
                        Cars.Remove(item1);
                    }
                }
            }
        }
    }
}
