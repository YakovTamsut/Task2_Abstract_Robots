using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots_inc
{
    public class OperationalWorker : Worker
    {
        protected int hoursWorked;
        protected double MpH;

        public OperationalWorker(string name, string id, DateTime bDate, string pass, int hoursWorked, double MpH)
            : base(name, id, bDate, pass)
        {
            this.MpH = MpH;
            this.hoursWorked = hoursWorked;
        }

        public override double CalculateSalery()
        {
           return MpH * hoursWorked;
        }


    }
}
