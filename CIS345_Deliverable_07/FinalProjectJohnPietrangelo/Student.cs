//John Pietrangelo CIS345 Tues/Thurs 9am
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectJohnPietrangelo
{
    class Student
    {
        private Int64 studentID;
        private string studentFirstName;
        private string studentLastName;
        private double studentGPA;
        private List<PrerequisiteCourse> courseHistory;
        private List<Schedule> studentSchedule;
        private string isGradStudent;


        public Student(Int64 studentID, string studentFirstName, string studentLastName, double studentGPA, List<PrerequisiteCourse> courseHistory,List<Schedule>studentSchedule, string isGradStudent )
        {
            this.StudentID = studentID;
            this.StudentFirstName = studentFirstName;
            this.StudentLastName = studentLastName;
            this.StudentGPA = studentGPA;
            this.courseHistory = courseHistory;
            this.studentSchedule = studentSchedule;
            this.IsGradStudent = isGradStudent;
        }
        public Int64 StudentID
        {
            get
            {
                return studentID;
            }
            set
            {

                studentID = value;
            }
        }

        public string StudentFirstName
        {
            get
            {
                return studentFirstName;
            }
            set
            {
                studentFirstName = value;
            }
        }
        public string StudentLastName
        {
            get
            {
                return studentLastName;
            }
            set
            {
                studentLastName = value;
            }
        }
        public double StudentGPA
        {
            get
            {
                return studentGPA;
            }
            set
            {
                studentGPA = value;
            }
        }
        public string IsGradStudent
        {
            get
            {
                return isGradStudent;
            }
            set
            {
                isGradStudent = value;
            }
        }
        public override string ToString()
        {
            return string.Format("{0}     {1}     {2}       {3:0.00}         {4}", studentID,studentFirstName, studentLastName, studentGPA,isGradStudent);
        }
    }
}

