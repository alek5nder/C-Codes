using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UczeSB
{
    internal class Student
    {
        public string name;
        public string major;
        public double gpa;

        public Student(string aName, string aMajor, double aGPA)
        {
            name = aName;  
            major = aMajor;
            gpa = aGPA;
        }

        public bool HasHonors()
        {
            gpa = 10;
            if(gpa >= 4)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
