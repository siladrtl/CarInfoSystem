using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarInfoSystem
{
    public class Motorcycle : IVehicle
    {
        public string Brand { get; set; }

        public void Start()
        {
            Console.WriteLine($"{Brand} motosiklet çalıştı.");
        }

        public void Stop()
        {
            Console.WriteLine($"{Brand} motosiklet durdu.");
        }
    }
}