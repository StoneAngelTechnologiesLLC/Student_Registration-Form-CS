using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectJohnPietrangelo
{
    class Course : PrerequisiteCourse
    {
        private string courseStartTime;
        private string courseDays;
        private int courseSeats;


        public Course(string courseSubject, int courseNumber, string courseDiscription, int courseUnits,List<PrerequisiteCourse> preCourses, string courseStartTime, string courseDays, int courseSeats) : base(courseSubject, courseNumber, courseDiscription, courseUnits, preCourses)
        {
            CourseStartTime = courseStartTime;
            CourseDays = courseDays;
            CourseSeats = courseSeats;
        }
        public string CourseStartTime
        {
            get
            {
                return courseStartTime;
            }
            set
            {
                this.courseStartTime = value;
            }
        }
        public string CourseDays
        {
            get
            {
                return courseDays;
            }
            set
            {
                this.courseDays = value;
            }
        }
        public int CourseSeats
        {
            get
            {
                return courseSeats;
            }
            set
            {
                this.courseSeats = value;
            }
        }
        public override string ToString()
        {
            return string.Format("{0}          {1,10}  {2,10}  {3,10}",base.ToString(),courseStartTime, courseDays, courseSeats);
        }
    }
}
