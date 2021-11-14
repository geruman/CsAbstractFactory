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
    public class BasicAquaticEnemyTests
    {
        private IBasicEnemy enemy;
        [TestInitialize()]
        public void Initialize()
        {
            enemy = new BasicAquaticEnemy();
        }
        [TestCleanup()]
        public void Cleanup()
        {
            enemy = null;
        }
        [TestMethod()]
        public void NameTest()
        {
            Assert.AreEqual("I'm a fish!",enemy.Name());
        }

        [TestMethod()]
        public void AttackTest()
        {
            Assert.AreEqual("have a glass of water",enemy.Attack());
        }
    }
}