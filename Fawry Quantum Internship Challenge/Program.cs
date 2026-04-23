namespace Fawry_Quantum_Internship_Challenge
{
    internal class Program
    {
        static void Main(string[] args)
        {
           CarFactory carFactory = new CarFactory();
            Car car = carFactory.CreateCar("hyprid");
            car.Start();
            car.Accelerate();
            car.Accelerate();
            car.Accelerate();          
            car.Accelerate();
            car.Brake();
            car.Brake();
            car.Stop();
        }
    }
}
