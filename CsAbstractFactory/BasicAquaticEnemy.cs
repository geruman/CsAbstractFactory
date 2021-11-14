using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsAbstractFactory
{
    public class BasicAquaticEnemy : IBasicEnemy
    {
        public string Attack()
        {
            return "have a glass of water";
        }

        public string Name()
        {
            return "I'm a fish!";
        }
    }
}
