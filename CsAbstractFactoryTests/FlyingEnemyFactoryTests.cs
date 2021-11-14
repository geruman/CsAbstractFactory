using Microsoft.VisualStudio.TestTools.UnitTesting;
using CsAbstractFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsAbstractFactory.Tests
{
    [TestClass()]
    public class FlyingEnemyFactoryTests
    {
        private IEnemyFactory factory;
        [TestInitialize()]
        public void Initialize()
        {
            factory = new FlyingEnemyFactory();
        }
        [TestCleanup()]
        public void Cleanup()
        {
            factory = null;
        }
        [TestMethod()]
        public void CreateAdvancedEnemyTest()
        {
            IAdvancedEnemy enemy = factory.CreateAdvancedEnemy();
            Assert.IsTrue(enemy is AdvancedFlyingEnemy);
        }

        [TestMethod()]
        public void CreateBasicEnemyTest()
        {
            IBasicEnemy enemy = factory.CreateBasicEnemy();
            Assert.IsTrue(enemy is BasicFlyingEnemy);
        }
    }
}