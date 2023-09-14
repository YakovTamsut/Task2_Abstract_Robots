using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots_inc
{
    public class RobotQuad : RobotSpy
    {
        //1. עדכנו את הפעולה הבונה כך שתתאים לפעולת במחלקת העל
        public RobotQuad() : base("Roboquad"){ }

        public override void MoveBackward()
        {
            for (int i = 0; i < 4; i++)
                MoveLeg(i, -1);
        }

        public override void MoveForward()
        {
            for (int i = 0; i < 4; i++)
                MoveLeg(i, 1);
        }

        public override void TurnLeft()
        {
            MoveLeg(1, 1);
            MoveLeg(2, 1);
            MoveLeg(3, -1);
            MoveLeg(4, -1);
        }

        public override void TurnRight()
        {
            MoveLeg(1, -1);
            MoveLeg(2, -1);
            MoveLeg(3, 1);
            MoveLeg(4, 1);
        }

        //2. השלימו את התנועות החסרות מתוך המצגת או על הבנתכם

        private void MoveLeg(int legId, int dir) 
        {
            BatteryStatus -= 3;
        }
    }

}
