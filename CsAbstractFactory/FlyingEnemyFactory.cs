using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsAbstractFactory
{
    public class FlyingEnemyFactory : IEnemyFactory
    {
        public IAdvancedEnemy CreateAdvancedEnemy()
        {
            return new AdvancedFlyingEnemy();
        }

        public IBasicEnemy CreateBasicEnemy()
        {
            return new BasicFlyingEnemy();
        }
    }
}
