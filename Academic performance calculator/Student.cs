using System;
using System.Collections.Generic;
using System.Text;

namespace Academic_performance_calculator
{
    class Student
    {
        public string FirstName;
        public string LastName;
        public int Attendance = 0;
        public int Exam = 0;
        public int Coursework = 0;

        public void setAttendance(int A) 
        {
            if (Attendance > 100) Attendance = A;
        }

        public void setExam(int E)
        {
            if (Exam > 100) Exam = E;
        }

        public void setCoursework(int C)
        {
            if (Coursework > 100) Coursework = C;
        }


    }
}
