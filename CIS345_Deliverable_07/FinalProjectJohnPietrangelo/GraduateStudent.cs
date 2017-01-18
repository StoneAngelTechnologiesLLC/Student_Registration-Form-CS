using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectJohnPietrangelo
{
    class GraduateStudent:Student
    {
        private int studentGMAT;
        public int StudentGMAT
        {
            get
            {
                return studentGMAT;
            }
            set
            {
                this.studentGMAT = value;
            }
        }

        public GraduateStudent(Int64 studentID, string studentFirstName, string studentLastName, double studentGPA, List<PrerequisiteCourse> courseHistory,List<Schedule> studentSchedule, string isGradStudent, int studentGMAT):base (studentID,studentFirstName,studentLastName,studentGPA,courseHistory,studentSchedule, isGradStudent)
        {

            this.studentGMAT = studentGMAT;
        }
        public override string ToString()
        {
            return string.Format("{0}        {1}",base.ToString(),studentGMAT);
        }
    }
}
