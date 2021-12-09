using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactroyExample
{
    public class FactoryArctic : IAbstractFactoryBiom
    {
        public IAnimal createAnimal()
        {
            return new PolarBear();
        }

        public IFloor createFloor()
        {
            return new Snow();
        }

        public IPlant createPlant()
        {
            return new Lichen();
        }
    }
}
