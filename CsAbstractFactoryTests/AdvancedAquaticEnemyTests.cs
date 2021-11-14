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
    public class AdvancedAquaticEnemyTests
    {
        private IAdvancedEnemy enemy;
        [TestInitialize()]
        public void Initialize()
        {
            enemy = new AdvancedAquaticEnemy();
        }
        [TestCleanup()]
        public void Cleanup()
        {
            enemy = null;
        }
        [TestMethod()]
        public void SuperAttackTest()
        {
            Assert.AreEqual("A stream of water attack!", enemy.SuperAttack());
        }

        [TestMethod()]
        public void DescriptionTest()
        {
            Assert.AreEqual("I'm a swiming enemy", enemy.Description());
        }
    }
}