using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsAbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            IEnemyFactory aquaticFactory = new AquaticEnemyFactory();
            IEnemyFactory flyingFactory = new FlyingEnemyFactory();
            IBasicEnemy enemy1 = aquaticFactory.CreateBasicEnemy();
            IBasicEnemy enemy2 = flyingFactory.CreateBasicEnemy();
            IAdvancedEnemy enemy3 = aquaticFactory.CreateAdvancedEnemy();
            IAdvancedEnemy enemy4 = aquaticFactory.CreateAdvancedEnemy();
            DisplayBasicEnemy(enemy1);
            DisplayBasicEnemy(enemy2);
            DisplayAdvancedEnemy(enemy3);
            DisplayAdvancedEnemy(enemy4);
            Console.ReadKey();
        }
        private static void DisplayBasicEnemy(IBasicEnemy enemy)
        {
            Console.WriteLine(enemy.Name());
            Console.WriteLine(enemy.Attack());
        }
        private static void DisplayAdvancedEnemy(IAdvancedEnemy enemy)
        {
            Console.WriteLine(enemy.Description());
            Console.WriteLine(enemy.SuperAttack());
        }
    }
}
