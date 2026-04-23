using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fawry_Quantum_Internship_Challenge
{
    public class HybridEngine :IEngine
    {
        private ElectricEngine electricEngine;
        private GasEngine gasEngine;
        private IEngine operatingEngine;
        public HybridEngine()
        {
            this.electricEngine = new ElectricEngine();
            this.gasEngine = new  GasEngine();
            operatingEngine = electricEngine;
        }
        public void Start()
        {
            operatingEngine.Start();
        }

        public void Stop()
        {
            operatingEngine.Stop();
        }
        public void DecreaseSpeed(int speed)
        {
            if (speed > 0)
            {
                speed--;
                Console.WriteLine($"The Hybrid Engine Speed has been decreased by 1");            
                OnChangingSpeed(speed);
            }
            else
                Console.WriteLine("Can not decrease the speed beacause it is Minimum");
        }

        public void IncreaseSpeed(int speed)
        {
            if (speed < 50 )
            {
                speed++;
                Console.WriteLine($"The Hybrid Engine Speed has been increased by 1");               
                OnChangingSpeed(speed);
            }
            else
                Console.WriteLine("Can not increase the speed beacause it is Maximum");
        }

        public void OnChangingSpeed(int speed)
        {
            if (speed >50)
            {
                if (operatingEngine is ElectricEngine)
                {
                    electricEngine.Stop();
                    operatingEngine = gasEngine;
                    gasEngine.Start();
                }
                gasEngine.OnChangingSpeed(speed);
            }
            else
            {
                if (operatingEngine is GasEngine)
                {
                    gasEngine.Stop();
                    operatingEngine=electricEngine;
                    electricEngine.Start();
                }
                electricEngine.OnChangingSpeed(speed);
            }
        }
    }
}
