using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fawry_Quantum_Internship_Challenge
{
    public class Car
    {
        private IEngine engine;
        private int speed = 0;
        public Car(IEngine engine)
        {
            this.engine = engine;
        }
        public void Start()
        { 
            engine.Start();
        }
        public void Stop() { 
            engine.Stop();
        }
        public void Accelerate()
        {
            if (speed <= 180)
            {
                speed += 20;
                engine.OnChangingSpeed(speed);
            }
            else
            {
                Console.WriteLine("The speed must be less than or equal 180 to Accelerate");
            }
            
        }
            
        public void Brake()
        {
            if (speed >= 20)
            {
                speed -= 20;
                engine.OnChangingSpeed(speed);
            }
            else
            {
                Console.WriteLine("The speed must be greate than or equal 20 to Brake");
            }
            
           
        }
        public void ChangeEngine(IEngine engine)
        {
            this.engine=engine;
        }
    }
}
