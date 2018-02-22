using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ECS.Legacy;
using NUnit.Framework;

namespace ECS.legacy.Test.Unit
{
    [TestFixture]
    public class ECSlegacyUnitTest
    {
        private Legacy.ECS _uut;
        private FakeHeater _utFakeHeat;

        [SetUp]
        public void Setup()
        {
            _utFakeHeat = new FakeHeater();
            _uut = new Legacy.ECS(17, new FakeTempSensor(), _utFakeHeat);
        }

        [Test]
        public void Regulate_threshUnderTemp_HeaterOff()
        {
            _uut.SetThreshold(20);
            _uut.Regulate();
            Assert.That(_utFakeHeat.HeaterIsOn, Is.False);
        }

        [Test]
        public void Regulate_threshOverTemp_HeaterOn()
        {
            _uut.SetThreshold(30);
            _uut.Regulate();
            Assert.That(_utFakeHeat.HeaterIsOn, Is.True);
        }

    }
}
