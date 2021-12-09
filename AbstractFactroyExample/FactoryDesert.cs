using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactroyExample
{
    public class FactoryDesert : IAbstractFactoryBiom
    {
        public IAnimal createAnimal()
        {
            return new Camel();
        }

        public IFloor createFloor()
        {
            return new Sand();
        }

        public IPlant createPlant()
        {
            return new Cactus(); 
        }
    }
}
