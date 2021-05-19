using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContainerShip
{
    class Container
    {
        public int Weight { get; set; }
        public ContainerType Type { get; set; }

        public Container(int weight, ContainerType type)
        {
            Weight = weight;
            Type = type;
        }
    }
}
