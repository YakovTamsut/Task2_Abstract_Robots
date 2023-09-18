using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots_inc
{
    public class OperationManager : Worker
    {
        protected int hoursWorked;
        protected double MpH;
        protected int missionComplete;
        public OperationManager(string name, string id, DateTime bDate, string pass, int hoursWorked, double MpH, int missionComplete)
            : base(name, id, bDate, pass)
        {
            this.hoursWorked = hoursWorked;
            this.missionComplete = missionComplete;

        }

        public override double CalculateSalery()
        {
            return (hoursWorked * MpH) * (1 + 0.03 * missionComplete);
        }
    }
}
