using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsAbstractFactory
{
    public class AquaticEnemyFactory : AbstractFactoryEnemy
    {
        public override IAdvancedEnemy CreateAdvancedEnemy()
        {
            return new AdvancedAquaticEnemy();
        }

        public override IBasicEnemy CreateBasicEnemy()
        {
            return new BasicAquaticEnemy();
        }
    }
}
