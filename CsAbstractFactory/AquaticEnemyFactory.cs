using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsAbstractFactory
{
    public class AquaticEnemyFactory : IEnemyFactory
    {
        public IAdvancedEnemy CreateAdvancedEnemy()
        {
            return new AdvancedAquaticEnemy();
        }

        public IBasicEnemy CreateBasicEnemy()
        {
            return new BasicAquaticEnemy();
        }
    }
}
