using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsAbstractFactory
{
    public class BasicFlyingEnemy : IBasicEnemy
    {
        public string Attack()
        {
            return "Normal attack from the air";
        }

        public string Name()
        {
            return "I'm a sparrow";
        }
    }
}
