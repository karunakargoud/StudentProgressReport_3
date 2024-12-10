using StudentProgressReport_3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentProgressReport_3.VM
{
    public class StudentVM
    {
        public Student student;
        public int Total;
        public string Result;
        public string Grade;
        public int Average;
        public string ColorName;
        public string TeluguColor;
        public string HindiColor;
        public string EnglishColor;
        public string MathsColor;
        public string ScienceColor;
        public string SocialColor;
        public StudentVM(Student s)
        {
            student = s;
            Total =student.Telugu + student.Hindi + student.English + student.Maths + student.Science + student.Social;
            Result = "Fail";
            if(student.Telugu>=35 && student.Hindi>=35 && student.English>=35 && student.Maths>=35 && student.Science>=35 && student.Social>=35)
            {
                Result = "Pass";
            }
            Grade = "F";
            if (Result == "Pass")
            {
                int p = Total / 6;
                if (p >= 90)
                {
                    Grade = "A+";
                }
                else if (p >= 80)
                {
                    Grade = "A";
                }
                else if (p >= 70)
                {
                    Grade = "B";
                }
                else if (p >= 60)
                {
                    Grade = "C";
                }
                else if (p >= 50)
                {
                    Grade = "D";
                }
                else if (p >= 35)
                {
                    Grade = "E";
                }
            }
            Average = Total / 6;
            if (Result == "Pass")
            {
                ColorName = "green";
            }
            else
            {
                ColorName = "red";
            }
            if (student.Telugu >= 35)
            {
                TeluguColor = "green";
            }
            else
            {
                TeluguColor = "Red";
            }
            if (student.Hindi >= 35)
            {
               HindiColor = "green";
            }
            else
            {
                HindiColor = "Red";
            }
            if (student.English>= 35)
            {
                 EnglishColor = "green";
            }
            else
            {
                EnglishColor = "Red";
            }
            if (student.Maths >= 35)
            {
                MathsColor = "green";
            }
            else
            {
                MathsColor = "Red";
            }
            if (student.Science>= 35)
            {
                ScienceColor = "green";
            }
            else
            {
                ScienceColor = "Red";
            }
            if (student.Social >= 35)
            {
                SocialColor = "green";
            }
            else
            {
                SocialColor = "Red";
            }
        }
    }
}