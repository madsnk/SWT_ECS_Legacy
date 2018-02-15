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

        [SetUp]
        public void Setup()
        {

            _uut = new Legacy.ECS(17, new FakeTempSensor(), new FakeHeater());
        }

        public void tempOverThresh_hearterOn(int a, int b, int result)
        {

        }
        public void tempUnderThresh_hearterOn(int a, int b, int result)
        {

        }

    }
}
