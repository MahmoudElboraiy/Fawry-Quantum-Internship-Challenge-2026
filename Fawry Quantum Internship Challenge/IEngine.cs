using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fawry_Quantum_Internship_Challenge
{
    public interface IEngine
    {
        void Start();
        void Stop();
        void IncreaseSpeed(int speed);
        void DecreaseSpeed(int speed);
        void OnChangingSpeed(int speed);
    }
}
