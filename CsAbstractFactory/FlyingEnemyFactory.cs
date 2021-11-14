using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsAbstractFactory
{
    public class FlyingEnemyFactory : AbstractFactoryEnemy
    {
        public override IAdvancedEnemy CreateAdvancedEnemy()
        {
            return new AdvancedFlyingEnemy();
        }

        public override IBasicEnemy CreateBasicEnemy()
        {
            return new BasicFlyingEnemy();
        }
    }
}
