using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots_inc
{
    public class GeneralManager : Worker
    {
        protected double MonthlySalary;
        protected int robotsActive;

        public GeneralManager(string name, string id, DateTime bDate, string pass, double MonthlySalary, int robotsActive)
            : base(name, id, bDate, pass)
        {
            this.MonthlySalary = MonthlySalary;
            this.robotsActive = robotsActive;
        }

        public override double CalculateSalery()
        {
            if (this.robotsActive > 30)
            {
                return MonthlySalary * 1.15;
            }
            return MonthlySalary;
        }
    }
}
