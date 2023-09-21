using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots_inc
{
    public abstract class Worker
    {
        private string fullName;
        private string idNumber;
        private DateTime birthDate;
        private string password;


        public Worker(string name, string id, DateTime bDate, string pass)
        {
            fullName = name;
            idNumber = id;
            birthDate = bDate;
            password = pass;
            //משימה 1
            //השלימו את הבנאי המקבל הפרמטרים הנחוצים ליצירת עובד חדש
        }
        public string FullName { get { return fullName; }  set { fullName = value; } }
        //משימה 2
        //get כתבו פעולות מאחזרות 
        public string GetFullName() {return fullName;}
        public string GetIdNumber() {return idNumber;}
        public string GetPassword() {return password;}
        public DateTime GetBirthDate() {return birthDate;}

        //משימה 3
        //רק לתכונות שניתן לשנות - set כתבו פעולות מעדכנות

        //משימה 4
        // כתבו חתימה פעולה אבסטרקטית לחישוב שכר
        public abstract double CalculateSalery();

        public override string ToString()
        {
            string str = "";
            if(birthDate.Equals(DateTime.Today))
                str=" - HappyBirthDay";
            return fullName + " ID." + idNumber + str;

        }
    }
}
