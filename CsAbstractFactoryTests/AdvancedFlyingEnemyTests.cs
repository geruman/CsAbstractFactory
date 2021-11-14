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
    public class AdvancedFlyingEnemyTests
    {
        private IAdvancedEnemy enemy;
        [TestInitialize()]
        public void Initialize()
        {
            enemy = new AdvancedFlyingEnemy();
        }
        [TestCleanup()]
        public void Cleanup()
        {
            enemy = null;
        }
        [TestMethod()]
        public void SuperAttackTest()
        {
            Assert.AreEqual("A ton of airbone damage!",enemy.SuperAttack());
        }

        [TestMethod()]
        public void DescriptionTest()
        {
            Assert.AreEqual("I am a flying enemy!",enemy.Description());
        }
    }
}