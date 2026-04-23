using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fawry_Quantum_Internship_Challenge
{
    public class CarFactory
    {
        public Car CreateCar(string type)
        {
            if (type.ToLower() == "gas")
                return new Car(new GasEngine());
            else if(type.ToLower() =="electric")
                return new Car(new ElectricEngine());
            else if(type.ToLower() =="hyprid")
                return new Car(new HybridEngine());
            else
            {
                throw new Exception("Wrong Type");
            }
        }
        public void ChangeEngine(Car car, IEngine NewEngine)
        {
            car.ChangeEngine(NewEngine);
        }
    }
}
