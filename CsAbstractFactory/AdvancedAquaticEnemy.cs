using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsAbstractFactory
{
    public class AdvancedAquaticEnemy : IAdvancedEnemy
    {
        public string Description()
        {
            return "I'm a swiming enemy";
        }

        public string SuperAttack()
        {
            return "A stream of water attack!";
        }
    }
}
