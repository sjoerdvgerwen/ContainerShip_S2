using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContainerShip
{
    class Ship
    {
        public int Weight { get; set; }

        public int Length { get; set; }
        
        public int Width { get; set; }

        public Ship(int weight)
        {
            
            Weight = weight;
            
        }

    }
}
