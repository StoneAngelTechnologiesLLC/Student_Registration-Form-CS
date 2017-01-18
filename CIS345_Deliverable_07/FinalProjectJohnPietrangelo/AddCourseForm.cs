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
    public partial class AddCourseForm : Form
    {
        List<PrerequisiteCourse> coursePreReqs = new List<PrerequisiteCourse>();
        List<PrerequisiteCourse> prerequsiteCoursesNull = new List<PrerequisiteCourse>();
        List<PrerequisiteCourse> prerequsiteCourses;
        List<Course> courses;
        bool secondClick = false;
        
        internal AddCourseForm(List<PrerequisiteCourse> prerequisteCourses, List<Course> courses)
        {
            InitializeComponent();
            this.courses = courses;
            this.prerequsiteCourses = prerequisteCourses;
            this.MainScreen();
        }
        private void mainMenuBtn_Click(object sender, EventArgs e)
        {
            Form myParentForm = RegistrationStartApp.GetParentForm();
            myParentForm.Show();
            this.Close();
        }
        private void resetBtn_Click(object sender, EventArgs e)
        {
            this.MainScreen();
            this.ClearFormInputComponents();
            displayAllCoursesLstBx.Items.Clear();
        }
        private void disply1Btn_Click(object sender, EventArgs e)
        {

        }
        private void addCourseBtn_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.LightGreen;
            editCourseBtn.Visible = false;
            if (secondClick == true)
            {
                try
                {
                    Course courseAdd = new Course(subjectTxBx.Text, Convert.ToInt32(courseNumTxBx.Text), titleTxBx.Text, Convert.ToInt32(unitsTxBx.Text), prerequsiteCoursesNull, startTimeTxBx.Text, daysTxBx.Text, Convert.ToInt32(unitsTxBx.Text));
                    courses.Add(courseAdd);
                    displayAllCoursesLstBx.Items.Clear();
                    ClearFormInputComponents();
                    secondClick = false;
                }
                catch (Exception Bad)
                {

                    MessageBox.Show(Bad.Message + "Try Again");
                }
                finally
                {
                    ClearFormInputComponents();
                    secondClick = false;

                }
            }
            AddScreen();
        }
        private void editCourseBtn_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Yellow;
            addCourseBtn.Visible = false;
            EditScreen();
            ReadOnlyTextBoxesEngaged();
            PopulateDisplayScreen();
            if (secondClick == true)
            {
                try
                {
                    PrerequisiteCourse preReq = new PrerequisiteCourse(p1SubjectTxBx.Text, Convert.ToInt32(p1CourseNumTxBx.Text), p1TitleTxBx.Text, Convert.ToInt32(p1UnitsTxBx.Text), prerequsiteCoursesNull);
                coursePreReqs.Add(preReq);
                Course courseAdd = new Course(subjectTxBx.Text, Convert.ToInt32(courseNumTxBx.Text), titleTxBx.Text, Convert.ToInt32(unitsTxBx.Text), coursePreReqs, startTimeTxBx.Text, daysTxBx.Text, Convert.ToInt32(unitsTxBx.Text));
                courses.Add(courseAdd);
                for (int i = 0; i < courses.Count; i++)
                {
                    if (displayAllCoursesLstBx.SelectedItem.ToString() == courses[i].ToString())
                    {
                        courses.Remove(courses[i]);
                    }
                   
                }

                    
                }
                catch (Exception DontKnow)
                {
                    MessageBox.Show(DontKnow.Message + "Try Again");
                    ClearFormInputComponents();
                }
                finally
                {
                    displayAllCoursesLstBx.Items.Clear();
                    ClearFormInputComponents();
                    PopulateDisplayScreen();
                    secondClick = false;
                }
            }
         }
        private void displayAllCoursesLstBx_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            ClearFormInputComponents();
            ReadOnlyTextBoxesDisengaged();
            char[] charSeparators = new char[] { ' ' };
            string selectedCourse = displayAllCoursesLstBx.SelectedItem.ToString();
            string[] selectedCourseAttributes = selectedCourse.Split(charSeparators, StringSplitOptions.RemoveEmptyEntries);
            subjectTxBx.Text = selectedCourseAttributes[0];
            courseNumTxBx.Text = selectedCourseAttributes[1];
            titleTxBx.Text = selectedCourseAttributes[3];
            unitsTxBx.Text = selectedCourseAttributes[2];
            startTimeTxBx.Text = selectedCourseAttributes[4];
            daysTxBx.Text = selectedCourseAttributes[5];
            seatsTxBx.Text = selectedCourseAttributes[6];
            for (int i = 0; i < prerequsiteCourses.Count; i++)
            {
                try
                {
                    if (titleTxBx.Text == prerequsiteCourses[i].CourseDiscription)
                    {
                        p1SubjectTxBx.Text = prerequsiteCourses[i].PreCourses[0].CourseSubject;
                        p1CourseNumTxBx.Text = Convert.ToString(prerequsiteCourses[i].PreCourses[0].CourseNumber);
                        p1UnitsTxBx.Text = Convert.ToString(prerequsiteCourses[i].PreCourses[0].CourseUnits);
                        p1TitleTxBx.Text = prerequsiteCourses[i].PreCourses[0].CourseDiscription;
                    }
                }
                catch (Exception Error)
                {
                    MessageBox.Show(Error.Message + "\nInternal Upgrade Currently Taking Place.\nPlease try again.");
                }
                finally
                {
                    secondClick = true;
                    // Giving CPU work-break.
                    System.Threading.Thread.Sleep(50);
                }
            }

        }
        public void MainScreen()
        {
            secondClick = false;
            courseListLbl.Visible = false;
            preReqHeaderLbl.Visible = false;
            displayAllCoursesLstBx.Visible = false;
            preReqHeaderLbl.Visible = false;
            subjectListLbl.Visible = false;
            subjectLbl.Visible = false;
            courseNumlbl.Visible = false;
            titleLbl.Visible = false;
            unitsLbl.Visible = false;
            startTimelbl.Visible = false;
            daysLbl.Visible = false;
            seatsLbl.Visible = false;
            subjectTxBx.Visible = false;
            courseNumTxBx.Visible = false;
            titleTxBx.Visible = false;
            unitsTxBx.Visible = false;
            startTimeTxBx.Visible = false;
            daysTxBx.Visible = false;
            seatsTxBx.Visible = false;
            resetBtn.Visible = false;
            p1CourseNumLbl.Visible = false;
            p1CourseNumTxBx.Visible = false;
            p1TitleLbl.Visible = false;
            p1TitleTxBx.Visible = false;
            p1SubjectLbl.Visible = false;
            p1SubjectTxBx.Visible = false;
            p1UnitsLbl.Visible = false;
            p1UnitsTxBx.Visible = false;
            courseNumListLbl.Visible = false;
            titleListLbl.Visible = false;
            unitListLbl.Visible = false;
            startTimeListLbl.Visible = false;
            daysListLbl.Visible = false;
            avalSeatListLbl.Visible = false;
            addCourseBtn.Visible = true;
            editCourseBtn.Visible = true;
            aCourseNumFormatLbl.Visible = false;
            aDayFormatLbl.Visible = false;
            aFormatLbl.Visible = false;
            aPreFormatLbl.Visible = false;
            aSeatFormatLbl.Visible = false;
            aStartTimeFormatLbl.Visible = false;
            aSubjectFormatLbl.Visible = false;
            aTitleFormatLbl.Visible = false;
            aUnitsFormatLbl.Visible = false;


        }
        public void EditScreen()
        {
            
            courseListLbl.Visible = true;
            preReqHeaderLbl.Visible = true;
            displayAllCoursesLstBx.Visible = true;
            preReqHeaderLbl.Visible = true;
            subjectListLbl.Visible = true;
            subjectLbl.Visible = true;
            courseNumlbl.Visible = true;
            titleLbl.Visible = true;
            unitsLbl.Visible = true;
            startTimelbl.Visible = true;
            daysLbl.Visible = true;
            seatsLbl.Visible = true;
            subjectTxBx.Visible = true;
            courseNumTxBx.Visible = true;
            titleTxBx.Visible = true;
            unitsTxBx.Visible = true;
            startTimeTxBx.Visible = true;
            daysTxBx.Visible = true;
            seatsTxBx.Visible = true;
            resetBtn.Visible = true;
            p1CourseNumLbl.Visible = true;
            p1CourseNumTxBx.Visible = true;
            p1TitleLbl.Visible = true;
            p1TitleTxBx.Visible = true;
            p1SubjectLbl.Visible = true;
            p1SubjectTxBx.Visible = true;
            p1UnitsLbl.Visible = true;
            p1UnitsTxBx.Visible = true;
            courseNumListLbl.Visible = true;
            titleListLbl.Visible = true;
            unitListLbl.Visible = true;
            startTimeListLbl.Visible = true;
            daysListLbl.Visible = true;
            avalSeatListLbl.Visible = true;
            subjectListLbl.Visible = true;
            aCourseNumFormatLbl.Visible = false;
            aDayFormatLbl.Visible = false;
            aFormatLbl.Visible = false;
            aPreFormatLbl.Visible = false;
            aSeatFormatLbl.Visible = false;
            aStartTimeFormatLbl.Visible = false;
            aSubjectFormatLbl.Visible = false;
            aTitleFormatLbl.Visible = false;
            aUnitsFormatLbl.Visible = false;
        }
        public void AddScreen()
        {
            courseListLbl.Visible = false;
            preReqHeaderLbl.Visible = true;
            displayAllCoursesLstBx.Visible = false;
            preReqHeaderLbl.Visible = true;
            subjectListLbl.Visible = true;
            subjectLbl.Visible = true;
            courseNumlbl.Visible = true;
            titleLbl.Visible = true;
            unitsLbl.Visible = true;
            startTimelbl.Visible = true;
            daysLbl.Visible = true;
            seatsLbl.Visible = true;
            subjectTxBx.Visible = true;
            courseNumTxBx.Visible = true;
            titleTxBx.Visible = true;
            unitsTxBx.Visible = true;
            startTimeTxBx.Visible = true;
            daysTxBx.Visible = true;
            seatsTxBx.Visible = true;
            resetBtn.Visible = true;
            p1CourseNumLbl.Visible = true;
            p1CourseNumTxBx.Visible = true;
            p1TitleLbl.Visible = true;
            p1TitleTxBx.Visible = true;
            p1SubjectLbl.Visible = true;
            p1SubjectTxBx.Visible = true;
            p1UnitsLbl.Visible = true;
            p1UnitsTxBx.Visible = true;
            courseNumListLbl.Visible = false;
            titleListLbl.Visible = false;
            unitListLbl.Visible = false;
            startTimeListLbl.Visible = false;
            daysListLbl.Visible = false;
            avalSeatListLbl.Visible = false;
            subjectListLbl.Visible = false;
            aCourseNumFormatLbl.Visible = true;
            aDayFormatLbl.Visible = true;
            aFormatLbl.Visible = true;
            aPreFormatLbl.Visible = true;
            aSeatFormatLbl.Visible = true;
            aStartTimeFormatLbl.Visible = true;
            aSubjectFormatLbl.Visible = true;
            aTitleFormatLbl.Visible = true;
            aUnitsFormatLbl.Visible = true;
        }
        public void ReadOnlyTextBoxesEngaged()
        {
            subjectTxBx.ReadOnly = true;
            courseNumTxBx.ReadOnly = true;
            titleTxBx.ReadOnly = true;
            unitsTxBx.ReadOnly = true;
            startTimeTxBx.ReadOnly = true;
            daysTxBx.ReadOnly = true;
            seatsTxBx.ReadOnly = true;
            p1SubjectTxBx.ReadOnly = true;
            p1CourseNumTxBx.ReadOnly = true;
            p1TitleTxBx.ReadOnly = true;
            p1UnitsTxBx.ReadOnly = true;
        }
        public void ReadOnlyTextBoxesDisengaged()
        {
            subjectTxBx.ReadOnly = false;
            courseNumTxBx.ReadOnly = false;
            titleTxBx.ReadOnly = false;
            unitsTxBx.ReadOnly = false;
            startTimeTxBx.ReadOnly = false;
            daysTxBx.ReadOnly = false;
            seatsTxBx.ReadOnly = false;
            p1SubjectTxBx.ReadOnly = false;
            p1CourseNumTxBx.ReadOnly = false;
            p1TitleTxBx.ReadOnly = false;
            p1UnitsTxBx.ReadOnly = false;
        }
        public void ClearFormInputComponents()
        {

            subjectTxBx.Clear();
            courseNumTxBx.Clear();
            titleTxBx.Clear();
            unitsTxBx.Clear();
            startTimeTxBx.Clear();
            daysTxBx.Clear();
            seatsTxBx.Clear();
            p1SubjectTxBx.Clear();
            p1CourseNumTxBx.Clear();
            p1TitleTxBx.Clear();
            p1UnitsTxBx.Clear();
        }
        public void PopulateDisplayScreen()
        {
            foreach (Course course in courses)
            {
                displayAllCoursesLstBx.Items.Add(course.ToString());
            }
        }
        private void subjectTxBx_TextChanged(object sender, EventArgs e)
        {
            string isNumber = "";
            try
            {
                isNumber = subjectTxBx.Text; 
            }
            catch (FormatException Format)
            {

                MessageBox.Show(Format.Message + "Numbers Not Permitted In Subject Acronym");
                subjectTxBx.Clear();
            }
            finally
            {
                // Giving CPU work-break.
                System.Threading.Thread.Sleep(50);
            }
            if (subjectTxBx.Text.Length > 3)
            {
                MessageBox.Show("Error Entry must A 3 Letter Acronym");
                subjectTxBx.Clear();
            }
            //if (secondClick == true && subjectTxBx.Text.Length != 3)
            //{
            //    MessageBox.Show("Error Entry must A 3 Letter Acronym");
            //    subjectTxBx.Clear();
            //}
        }
        private void titleTxBx_Enter(object sender, EventArgs e)
        {
            secondClick = true;
        }
    }
}
