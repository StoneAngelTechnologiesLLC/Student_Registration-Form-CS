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
    public partial class ScheduleForm : Form
    {
        List<Schedule> newSchedules;
        List<PrerequisiteCourse> prerequsiteCourses;
        List<Course> courses;
        List<Student> students;
        internal ScheduleForm(List<Schedule> schedules,List<Student> students, List<PrerequisiteCourse> prerequsiteCourses, List<Course> courses)
        {
            InitializeComponent();
            newSchedules = schedules;
            this.prerequsiteCourses = prerequsiteCourses;
            this.courses = courses;
            this.students = students;
            //RegistrationStartApp.SetChildForm(this);
            foreach (var course in courses)
            {
                studentAddCourseLstBx.Items.Add(course);
            }
            foreach (var student in students)
            {
                studentIDCmbBx.Items.Add(student.StudentID +"  "+student.StudentLastName+", " + student.StudentFirstName);
            }
            MainScreen();
        }

        private void mainMenuBtn_Click(object sender, EventArgs e)
        {
            
            Form myParentForm = RegistrationStartApp.GetParentForm();
            myParentForm.Show();
            this.Close();
        }
        
        private void StudentAddCourseLstBx_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            MainScreen();
        }

        private void addCourseBtn_Click(object sender, EventArgs e)
        {
            operationScreen();
            this.BackColor = Color.LightGreen;
            AddCourseLbl.Visible = true;
            addCourseBtn.Visible = true;
            editCourseBtn.Visible = false;
            removeCourseLbl.Visible = false;
            
        }
        public void MainScreen()
        {
            this.resetBtn.Visible = false;
            this.studentIDLbl.Visible = false;
            this.studentIDCmbBx.Visible = false;
            this.curStartListLbl.Visible = false;
            this.totalCreditsTxBx.Visible = false;
            this.curUnitListLbl.Visible = false;
            this.totalCreditsLbl.Visible = false;
            this.curTitleListLbl.Visible = false;
            this.studentAddCourseLstBx.Visible = false;
            this.StudentAddCourse2LstBx.Visible = false;
            this.AddCourseLbl.Visible = false;
            this.sublbl.Visible = false;
            this.courseNumlbl.Visible = false;
            this.titleLbl.Visible = false;
            this.seatsLbl.Visible = false;
            this.daysLbl.Visible = false;
            this.stratTimeLbl.Visible = false;
            this.unitsLbl.Visible = false;
            this.removeCourseLbl.Visible = false;
            this.curSeatsListLbl.Visible = false;
            this.editCourseBtn.Visible = true;
            this.curDaysListLbl.Visible = false;
            this.currentCourseLbl.Visible = false;
            this.curSubjectListLbl.Visible = false;
            this.curCourseNumListLbl.Visible = false;
            this.addCourseBtn.Visible = true;
        }
        public void operationScreen()
        {
            this.resetBtn.Visible = true ;
            this.studentIDLbl.Visible = true;
            this.studentIDCmbBx.Visible = true;
            this.curStartListLbl.Visible = true;
            this.totalCreditsTxBx.Visible = true;
            this.curUnitListLbl.Visible = true;
            this.totalCreditsLbl.Visible = true;
            this.curTitleListLbl.Visible = true;
            this.studentAddCourseLstBx.Visible = true;
            this.StudentAddCourse2LstBx.Visible = true;
            this.AddCourseLbl.Visible = true;
            this.sublbl.Visible = true;
            this.courseNumlbl.Visible = true;
            this.titleLbl.Visible = true;
            this.seatsLbl.Visible = true;
            this.daysLbl.Visible = true;
            this.stratTimeLbl.Visible = true;
            this.unitsLbl.Visible = true;
            this.curSeatsListLbl.Visible = true;
            this.resetBtn.Visible = true;
            this.curDaysListLbl.Visible = true;
            this.currentCourseLbl.Visible = true;
            this.curSubjectListLbl.Visible = true;
            this.curCourseNumListLbl.Visible = true;
        }

        private void editCourseBtn_Click(object sender, EventArgs e)
        {
            operationScreen();
            this.removeCourseLbl.Visible = true;
            this.editCourseBtn.Visible = true;
            this.addCourseBtn.Visible = false;
            this.AddCourseLbl.Visible = false;
            this.BackColor = Color.Yellow;
        }
    }
}
