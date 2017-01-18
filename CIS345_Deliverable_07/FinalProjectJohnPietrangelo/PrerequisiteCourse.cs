//John Pietrangelo CIS345 Tues/Thurs 9am
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectJohnPietrangelo
{
    class PrerequisiteCourse
    {
        private string courseSubject;
        private int courseNumber;
        private string courseDiscription;
        private int courseUnits;
        List<PrerequisiteCourse> preCourses;
        

        public PrerequisiteCourse(string courseSubject, int courseNumber, string courseDiscription, int courseUnits, List<PrerequisiteCourse> preCourses)
        {
            CourseSubject = courseSubject;
            CourseNumber = courseNumber;
            CourseDiscription = courseDiscription;
            CourseUnits = courseUnits;
            this.preCourses = preCourses;
            


        }
        public string CourseSubject
        {
            get
            {
                return courseSubject;
            }
            set
            {
                this.courseSubject = value;
            }
        }
        public int CourseNumber
        {
            get
            {
                return courseNumber;
            }
            set
            {
                this.courseNumber = value;
            }
        }
        public string CourseDiscription
        {
            get
            {
                return courseDiscription;
            }
            set
            {
                this.courseDiscription = value;
            }
        }
        public int CourseUnits
        {
            get
            {
                return courseUnits;
            }
            set
            {
                this.courseUnits = value;
            }
        }
       public List<PrerequisiteCourse> PreCourses
        {
            get
            {
                return preCourses;
            }
            set
            {
                this.preCourses = value;
            }
        }
        public override string ToString()
        {
            return string.Format("{0,6} {1,23} {3,10}   {2,35}", courseSubject,courseNumber,courseDiscription,courseUnits);
        }
    }
}
