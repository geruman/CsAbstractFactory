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
    public class BasicFlyingEnemyTests
    {
        private IBasicEnemy basicEnemy;
        [TestInitialize()]
        public void Initialize()
        {
            basicEnemy = new BasicFlyingEnemy();

        }
        [TestCleanup()]
        public void Cleanup()
        {
            basicEnemy = null;
        }
        [TestMethod()]
        public void AttackTest()
        {
            Assert.AreEqual(basicEnemy.Attack(), "Normal attack from the air");
        }

        [TestMethod()]
        public void NameTest()
        {
            Assert.AreEqual(basicEnemy.Name(), "I'm a sparrow");
        }
    }
}