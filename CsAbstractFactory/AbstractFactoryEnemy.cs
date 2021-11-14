using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsAbstractFactory
{
    public abstract class AbstractFactoryEnemy
    {
        public abstract IBasicEnemy CreateBasicEnemy();
        public abstract IAdvancedEnemy CreateAdvancedEnemy();
        public static AbstractFactoryEnemy getFactory(Factories type)
        {
            switch (type)
            {
                case Factories.FLYING:
                    return new FlyingEnemyFactory();
                case Factories.AQUATIC:
                    return new AquaticEnemyFactory();
                default:
                    return null;
            }
        }
    }
}
