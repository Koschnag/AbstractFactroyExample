namespace AbstractFactroyExample
{
    class ForrestFactory : IAbstractFactoryBiom
    {
        public IAnimal createAnimal()
        {
            return new Deer();
        }

        public IFloor createFloor()
        {
            return new Gras();
        }

        public IPlant createPlant()
        {
            return new Beech();
        }
    }
}
