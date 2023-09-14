using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots_inc
{
    //כתבו את המחלקה על פי המחלקות הקודמות
    //שימו לב שעליכם להתייחס גם לתעופה
    class RobotFly : RobotSpy
    {
        protected bool isFlying;
        public RobotFly(string model) : base(model)
        {

        }
        public void Fly()
        {
            UseWings();
        }
        public override void MoveBackward()
        {
            MoveLeg(1, -1);
            MoveLeg(2, -1);
            MoveLeg(3, -1);
            MoveLeg(4, -1);
            MoveLeg(5, -1);
            MoveLeg(6, -1);
        }

        public override void MoveForward()
        {
            MoveLeg(1, 1);
            MoveLeg(2, 1);
            MoveLeg(3, 1);
            MoveLeg(4, 1);
            MoveLeg(5, 1);
            MoveLeg(6, 1);
        }

        public override void TurnLeft()
        {
            MoveLeg(1, -1);
            MoveLeg(2, -1);
            MoveLeg(3, -1);
            MoveLeg(4, 1);
            MoveLeg(5, 1);
            MoveLeg(6, 1);
        }

        public override void TurnRight()
        {
            MoveLeg(1, 1);
            MoveLeg(2, 1);
            MoveLeg(3, 1);
            MoveLeg(4, -1);
            MoveLeg(5, -1);
            MoveLeg(6, -1);
        }
        private void MoveLeg(int legId, int dir)
        {
            BatteryStatus -= 2;
        }
        private void UseWings()
        {
            isFlying = !isFlying;
            BatteryStatus -= 1.5;
        }


    }
}
