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
        private ECS _uut;

        [SetUp]
        public void Setup()
        {
            _uut = new ECS();
        }
    }
}
