using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ECS.Legacy;
using System.Threading.Tasks;

namespace ECS.legacy.Test.Unit
{
    class FakeTempSensor : ITempSensor
    {
        public int GetTemp()
        {
            return 25;
        }

        public bool RunSelfTest()
        {
            return true;
        }
    }
}
