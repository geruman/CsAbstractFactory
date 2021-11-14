using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsAbstractFactory
{
    public class AdvancedFlyingEnemy : IAdvancedEnemy
    {
        public string Description()
        {
            return "I am a flying enemy!";
        }

        public string SuperAttack()
        {
            return "A ton of airbone damage!";
        }
    }
}
