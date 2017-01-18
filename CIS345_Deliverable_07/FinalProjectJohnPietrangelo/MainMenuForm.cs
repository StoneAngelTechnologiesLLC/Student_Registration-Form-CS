//John Pietrangelo CIS345 Tues/Thurs 9am
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace FinalProjectJohnPietrangelo
{
    public partial class MainMenuForm : Form
    {
        private List<Student> students = new List<Student>();
        private List<PrerequisiteCourse> prePrerequisiteCoursesNull = new List<PrerequisiteCourse>();
        private List<PrerequisiteCourse> prerequisiteCourses = new List<PrerequisiteCourse>();
        private List<Course> courses = new List<Course>();
        private List<Schedule> schedules = new List<Schedule>();
        
        public MainMenuForm()
        {
           
            InitializeComponent();
            List<PrerequisiteCourse> s1CourseHistory = new List<PrerequisiteCourse>();
            List<PrerequisiteCourse> s2CourseHistory = new List<PrerequisiteCourse>();
            List<PrerequisiteCourse> s3CourseHistory = new List<PrerequisiteCourse>();
            List<PrerequisiteCourse> s4CourseHistory = new List<PrerequisiteCourse>();
            List<PrerequisiteCourse> s5CourseHistory = new List<PrerequisiteCourse>();
            List<PrerequisiteCourse> s6CourseHistory = new List<PrerequisiteCourse>();
            List<PrerequisiteCourse> busPre = new List<PrerequisiteCourse>();
            List<PrerequisiteCourse> cisPre = new List<PrerequisiteCourse>();
            List<PrerequisiteCourse> scmPre = new List<PrerequisiteCourse>();
            List<PrerequisiteCourse> cisPre2 = new List<PrerequisiteCourse>();
            
            
            List<PrerequisiteCourse> sosPre = new List<PrerequisiteCourse>();
            PrerequisiteCourse cis340PreReq = new PrerequisiteCourse("CIS", 340, "Bus_Info_Systems_Devlopment_I", 3, busPre);
            cisPre.Add(cis340PreReq);
            PrerequisiteCourse cis345PreReq = new PrerequisiteCourse("CIS", 345, "Bus_Info_Systems_Devlopment_II", 3, cisPre);
            cisPre2.Add(cis345PreReq);
            PrerequisiteCourse scm300PreReq = new PrerequisiteCourse("SCM", 300, "Global_Supply_Operations", 3, busPre);
            scmPre.Add(scm300PreReq);
            PrerequisiteCourse bus300PreReq = new PrerequisiteCourse("BUS", 300, "Introduction_To_Business", 3, prePrerequisiteCoursesNull);
            busPre.Add(bus300PreReq);
            PrerequisiteCourse sos320PreReq = new PrerequisiteCourse("SOS", 320, "Society_and_Sustainability", 3, busPre);
            sosPre.Add(sos320PreReq);
            PrerequisiteCourse s1C1 = new PrerequisiteCourse("SCM", 300, "Global_Supply_Operations", 3, busPre);
            s1CourseHistory.Add(s1C1);
            PrerequisiteCourse s1C2 = new PrerequisiteCourse("MKT", 425, "Global_Marketing_Management", 3, busPre);
            s1CourseHistory.Add(s1C2);
            PrerequisiteCourse s1C3 = new PrerequisiteCourse("PUP", 190, "Sustainable_Cities_In_the_US", 3, busPre);
            s1CourseHistory.Add(s1C3);
            PrerequisiteCourse s1C4 = new PrerequisiteCourse("SOS", 101, "Sustainable_World_views", 3, busPre);
            s1CourseHistory.Add(s1C4);
            PrerequisiteCourse s1C5 = new PrerequisiteCourse("ACC", 444, "Enterprise_Proc_Analys_&_Desgn", 3, busPre);
            s1CourseHistory.Add(s1C5);
            PrerequisiteCourse s1C6 = new PrerequisiteCourse("CIS", 340, "Bus_Info_Systems_Devlopment_I", 3, busPre);
            s1CourseHistory.Add(s1C6);
            PrerequisiteCourse s1C7 = new PrerequisiteCourse("SCM", 300, "Global_Supply_Operations", 3, busPre);
            s1CourseHistory.Add(s1C7);
            PrerequisiteCourse s1C8 = new PrerequisiteCourse("SOS", 101, "Sustainable_World_Views", 3, busPre);
            s1CourseHistory.Add(s1C8);
            PrerequisiteCourse s1C9 = new PrerequisiteCourse("SOS", 320, "Society_and_Sustainability", 3, busPre);
            s1CourseHistory.Add(s1C9);
           
           
            
            PrerequisiteCourse s2C1 = new PrerequisiteCourse("ACC", 444, "Enterprise_Proc_Analys_&_Desgn", 3, busPre);
            s2CourseHistory.Add(s2C1);
            PrerequisiteCourse s2C2 = new PrerequisiteCourse("CIS", 340, "Bus_Info_Systems_Devlopment_I", 3, busPre);
            s2CourseHistory.Add(s2C2);
            PrerequisiteCourse s2C3 = new PrerequisiteCourse("MKT", 425, "Global_Marketing_Management", 3, busPre);
            s2CourseHistory.Add(s2C3);
            PrerequisiteCourse s2C4 = new PrerequisiteCourse("PUP", 190, "Sustainable_Cities_In_The_US", 3, busPre);
            s2CourseHistory.Add(s2C4);
            






            Student student1 = new Student(9000000001, "John", "Pietrangelo", 2.0, s1CourseHistory,schedules, "false");
            students.Add(student1);
            Student student2 = new Student(9000000002, "Anne", "Roundtree", 3.0, s2CourseHistory, schedules, "false");
            students.Add(student2);
            Student student3 = new Student(9000000003, "Mike", "Smithphield", 4.0, s3CourseHistory, schedules, "false");
            students.Add(student3);
            GraduateStudent student4 = new GraduateStudent(9000000004, "Sara", "Wutangclan", 2.5, s4CourseHistory, schedules, "true", 800);
            students.Add(student4);
            GraduateStudent student5 = new GraduateStudent(9000000005, "Jake", "Johnsonloc", 4.0, s4CourseHistory, schedules, "true", 500);
            students.Add(student5);
            GraduateStudent student6 = new GraduateStudent(9000000006, "Mary", "Leonardelle", 3.5, s4CourseHistory, schedules, "true", 750);
            students.Add(student6);
            //-------------------------------------------------------------------------------------------------------------------
            PrerequisiteCourse prerequisiteCourse1 = new PrerequisiteCourse("ACC", 444, "Enterprise_Proc_Analys_&_Desgn", 3, busPre);
            prerequisiteCourses.Add(prerequisiteCourse1);
            PrerequisiteCourse prerequisiteCourse2 = new PrerequisiteCourse("CIS", 340, "Bus_Info_Systems_Devlopment_I", 3, busPre);
            prerequisiteCourses.Add(prerequisiteCourse2);
            PrerequisiteCourse prerequisiteCourse3 = new PrerequisiteCourse("CIS", 345, "Bus_Info_Systems_Devlopment_II", 3, cisPre);
            prerequisiteCourses.Add(prerequisiteCourse3);
            PrerequisiteCourse prerequisiteCourse4 = new PrerequisiteCourse("CIS", 365, "Business_Database_Systems", 3, cisPre);
            prerequisiteCourses.Add(prerequisiteCourse4);
            PrerequisiteCourse prerequisiteCourse5 = new PrerequisiteCourse("CIS", 425, "ElectronicCommerce_Strategy", 3, cisPre2);
            prerequisiteCourses.Add(prerequisiteCourse5);
            PrerequisiteCourse prerequisiteCourse6 = new PrerequisiteCourse("CIS", 430, "Networks/Distributed_Systems", 3, cisPre2);
            prerequisiteCourses.Add(prerequisiteCourse6);
            PrerequisiteCourse prerequisiteCourse7 = new PrerequisiteCourse("CIS", 440, "Systems_Design/Electronic_Comm", 3, cisPre2);
            prerequisiteCourses.Add(prerequisiteCourse7);
            PrerequisiteCourse prerequisiteCourse8 = new PrerequisiteCourse("MKT", 425, "Global_Marketing_Management", 3, busPre);
            prerequisiteCourses.Add(prerequisiteCourse8);
            PrerequisiteCourse prerequisiteCourse9 = new PrerequisiteCourse("PUP", 190, "Sustainable_Cities_In_The_US", 3, busPre);
            prerequisiteCourses.Add(prerequisiteCourse9);
            PrerequisiteCourse prerequisiteCourse10 = new PrerequisiteCourse("SCM", 300, "Global_Supply_Operations", 3, busPre);
            prerequisiteCourses.Add(prerequisiteCourse10);
            PrerequisiteCourse prerequisiteCourse11 = new PrerequisiteCourse("SCM", 385, "Business_&_Sustainability_I", 3, scmPre);
            prerequisiteCourses.Add(prerequisiteCourse11);
            PrerequisiteCourse prerequisiteCourse12 = new PrerequisiteCourse("SCM", 485, "Business and Sustainability II", 3, scmPre);
            prerequisiteCourses.Add(prerequisiteCourse12);
            PrerequisiteCourse prerequisiteCourse13 = new PrerequisiteCourse("SOS", 101, "Sustainable_World_Views", 3, busPre);
            prerequisiteCourses.Add(prerequisiteCourse13);
            PrerequisiteCourse prerequisiteCourse14 = new PrerequisiteCourse("SOS", 320, "Society_and_Sustainability", 3, busPre);
            prerequisiteCourses.Add(prerequisiteCourse14);
            PrerequisiteCourse prerequisiteCourse15 = new PrerequisiteCourse("SOS", 325, "Economics of Sustainability", 3, sosPre);
            prerequisiteCourses.Add(prerequisiteCourse15);
            

            //--------------------------------------------------------------------------------------------------------------------------------------------------------
            Course course1 = new Course("ACC", 444, "Enterprise_Proc_Analys_&_Desgn", 3, busPre, "12:00_P.M.", "T_TH", 10);
            courses.Add(course1);
            Course course2 = new Course("CIS", 340, "Bus_Info_Systems_Devlopment_I", 3, busPre, "10:00_A.M.", "M_W", 15);
            courses.Add(course2);
            Course course3 = new Course("CIS", 345, "Bus_Info_Systems_Devlopment_II", 3, cisPre, "12:00_P.M.", "T_TH", 9);
            courses.Add(course3);
            Course course4 = new Course("CIS", 365, "Business_Database_Systems", 3, cisPre, "2:00_P.M.", "M_W", 0);
            courses.Add(course4);
            Course course5 = new Course("CIS", 425, "Electronic_Commerce_Strategy", 3, cisPre2, "10:00_A.M.", "M_W", 22);
            courses.Add(course5);
            Course course6 = new Course("CIS", 430, "Networks/Distributed_Systems", 3, cisPre2, "4:00_P.M.", "T_TH", 15);
            courses.Add(course6);  
            Course course7 = new Course("CIS", 440, "Systems_Design/Electronic_Comm", 3, cisPre2, "8:00_A.M.", "M_W", 15);
            courses.Add(course7);
            Course course8 = new Course("MKT", 425, "Global_Marketing_Management", 3, busPre,"2:00_P.M.", "T_TH", 20);
            courses.Add(course8);
            Course course9 = new Course("PUP", 190, "Sustainable_Cities_In_The_US", 3, busPre, "4:00_P.M.", "M_W", 18);
            courses.Add(course9);
            Course course10 = new Course("SCM", 300, "Global_Supply_Operations", 3, busPre, "2:00_P.M.", "M_W", 15);
            courses.Add(course10);
            Course course11 = new Course("SCM", 385, "Business_&_Sustainability_I", 3, scmPre, "10:00_A.M.", "M_W", 0);
            courses.Add(course11);
            Course course12 = new Course("SCM", 485, "Business and Sustainability II", 3, scmPre, "4:00_P.M.", "T_TH", 11);
            courses.Add(course12);
            Course course13 = new Course("SOS", 101, "Sustainable_World_Views", 3, busPre, "8:00_A.M.", "M_W", 13);
            courses.Add(course13);
            Course course14 = new Course("SOS", 320, "Society_and_Sustainability", 3, busPre, "2:00_P.M.", "T_TH", 10);
            courses.Add(course14);
            Course course15 = new Course("SOS", 325, "Economics of Sustainability", 3, sosPre,"4:00_P.M.", "M_W", 20);
            courses.Add(course15);
            Course course16 = new Course("CIS", 540, "MASTER_PROGRAM", 3, prePrerequisiteCoursesNull, "8:00_A.M.", "M_W", 1);
            courses.Add(course16);

            // To set the "Parent" form for this app.
            RegistrationStartApp.SetParentForm(this);
           
           // RegistrationStartApp.SetChildForm(ScheduleForm);
        }
        private void studentsBtn_Click(object sender, EventArgs e)
        {
            Form myStudenInformationForm = new StudentInformationForm(students, prerequisiteCourses,schedules
                );
            myStudenInformationForm.Show();
            this.Hide();
        }
        private void coursesBtn_Click(object sender, EventArgs e)
        {
           
            Form myCourseForm = new AddCourseForm(prerequisiteCourses,courses);
            myCourseForm.Show();
            this.Hide();
        }
        private void schedulesBtn_Click(object sender, EventArgs e)
        {
            Form myScheduleForm = new ScheduleForm(schedules,students,prerequisiteCourses,courses);
            myScheduleForm.Show();
            this.Hide();
        }
        private void exitBtn_Click(object sender, EventArgs e)
        {
            
            Environment.Exit(0);
        }
    }
}
