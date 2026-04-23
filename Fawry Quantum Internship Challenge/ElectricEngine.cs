using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fawry_Quantum_Internship_Challenge
{
    public class ElectricEngine : IEngine
    {
        public void DecreaseSpeed(int speed)
        {
            if (speed > 0)

                Console.WriteLine($"The Hybrid Engine Speed has been decreased by 1");
            else
                Console.WriteLine("Can not decrease the speed beacause it is Minimum");
        }

        public void IncreaseSpeed(int speed)
        {
            if (speed < 200)
                Console.WriteLine($"The Hybrid Engine Speed has been increased by 1");
            else
                Console.WriteLine("Can not increase the speed beacause it is Maximum");
        }

        public void OnChangingSpeed(int speed)
        {
            Console.WriteLine($"The Electric Engine Current Speed = {speed}");
        }

        public void Start()
        {
            Console.WriteLine("The Electric Engine Started");
        }

        public void Stop()
        {
            Console.WriteLine("The Electric Engine Stoped");
        }
    }
}
