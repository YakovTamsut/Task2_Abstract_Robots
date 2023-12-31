﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots_inc
{
	public abstract class RobotSpy
	{
		private string model;
		private DateTime creationDate;
		private double batteryStatus; 

		public RobotSpy(string model)
		{
			this.model = model;
			creationDate=DateTime.Now;
			batteryStatus = 100;
        }
		public string GetModel() { 	return this.model; }
        public string Model { get { return model; } }
        public DateTime CreationDate { get { return creationDate; } set { creationDate = value; } }
        public double BatteryStatus { get { return batteryStatus; } set { batteryStatus = value; } }

        public abstract void MoveForward();
		public abstract void MoveBackward();
		public abstract void TurnLeft();
		public abstract void TurnRight();

		public void TakePicture() 
		{
			
			batteryStatus -= 5;
            if (batteryStatus < 5)
            {
				batteryStatus = 0;
				throw new Exception("Battery too low");
            }
        } 
		public void ChargeBattery() 
		{ 
			batteryStatus = 100;
		} 
	}
}
