using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ECS.Legacy;

namespace ECS.legacy.Test.Unit
{
    
    class FakeHeater : IHeater
    {
        private bool _heaterIsOn = false;
        public bool HeaterIsOn { get => _heaterIsOn; private set => _heaterIsOn = value; }

        public void TurnOn()
        {
            HeaterIsOn = true;
        }

        public void TurnOff()
        {
            HeaterIsOn = false;
        }

        public bool RunSelfTest()
        {
            return true;
        }
    }
}
