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
    public partial class StudentInformationForm : Form 
    { 
        //To create a List to store Student Objects.
        List<Student> newStudents;
        List<Schedule> studentSchedule;
        List<PrerequisiteCourse> preCourseHistory;
        List<PrerequisiteCourse> courseHistory;
        List<PrerequisiteCourse> prerequisiteCourses;
        /* To Construct this.Form using a Student List-Object 
        as the Argument for the Constructor's OverLoaded Parameter*/
        internal StudentInformationForm(List<Student> students,List<PrerequisiteCourse>prerequisitecourses, List<Schedule>schedules)
        { 
            //To initialize StudentInfo Form
            InitializeComponent();
            //To initialize newStudents List-Objects as Constructor 
            //Argument's students List-Objects
            newStudents = students;
            this.prerequisiteCourses = prerequisitecourses;
            this.studentSchedule = schedules;
            courseHistory = new List<PrerequisiteCourse>();
            preCourseHistory = new List<PrerequisiteCourse>();
            //To Initilize StudentInfo Form's format.
            this.MainScreen();
        }
        //To declare Form varibles
        private static Int64 studentId;
        private static string studentFirstName;
        private static string studentLastName;
        private static double studentGPA;
        private static int studentGMAT;
        private static string isGradStudent;
        private static bool secondClick = false;
        // EventHandler to navigate back to Main Menu
    
//----------------------------Beginning of Add Student----------------------------------------------------
        private void addStudentBtn_Click(object sender, EventArgs e)
        {
            studentIDTxBx.Focus();
            if (secondClick == true)
            {
                try
                {
                    ValidateGPA();
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message.ToString() + " Please Enter A GPA Value Between '0' and '4'");
                }
                finally
                {
                    // Giving CPU work-break.
                    System.Threading.Thread.Sleep(50);
                }
                try
                {
                    ValidateGMAT();
                }
                catch (Exception error2)
                {
                    MessageBox.Show(error2.Message.ToString() + " Please Enter A GMAT Value Between '200' and '800'");
                }
                finally
                {
                    // Giving CPU work-break.
                    System.Threading.Thread.Sleep(50);
                }
            }
            if (studentIDTxBx.Text.Length < 10 && secondClick == true)
            {
                MessageBox.Show("ID Must Be A 10 Digit Number");
                studentIDTxBx.Clear();
                secondClick = false;
            }
            AddStudentScreen();
            addStudentBtn.Enabled = false;
            PopulateAvailableCourseListBox();
            if (!studentIsGradCkBx.Checked && secondClick == true)
            {
                try
                {
                    studentId = Convert.ToInt64(studentIDTxBx.Text);
                    studentFirstName = studentFirstNameTxBx.Text;
                    studentLastName = studentLastNameTxBx.Text;
                    studentGPA = Convert.ToDouble(studentGPATxBx.Text);
                    isGradStudent = Convert.ToString(studentIsGradCkBx.Checked);
                    Student student = new Student(studentId, studentFirstName, studentLastName, studentGPA,courseHistory,studentSchedule,isGradStudent);
                    newStudents.Add(student);
                  }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message + "Error: ID Must Be A 10 Digit Number!\n Please Re-Enter Data in the correct format and I'll give it another try.");
                }
                finally
                {
                    courseHistory.Clear();
                    availableStudentsCoursesLstBx.Items.Clear();
                    secondClick = false;
                    this.Clear();
                    PopulateAvailableCourseListBox();
                }
            }
            else if(studentIsGradCkBx.Checked && secondClick == true)
            {
                try
                {
                    studentId = Convert.ToInt64(studentIDTxBx.Text);
                    studentFirstName = studentFirstNameTxBx.Text;
                    studentLastName = studentLastNameTxBx.Text;
                    studentGPA = Convert.ToDouble(studentGPATxBx.Text);
                    isGradStudent = Convert.ToString(studentIsGradCkBx.Checked);
                    studentGMAT = Convert.ToInt32(studentGMATTxBx.Text);
                    GraduateStudent graduateStudent = new GraduateStudent(studentId, studentFirstName, studentLastName, studentGPA, courseHistory,studentSchedule,isGradStudent, studentGMAT);
                    newStudents.Add(graduateStudent);
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message + "Error: ID Must Be A 10 Digit Number!\n Please Re-Enter Data in the correct format and I'll give it another try.");
                }
                finally
                {
                    availableStudentsCoursesLstBx.Items.Clear();
                    courseHistory.Clear();
                    secondClick = false;
                    this.Clear();
                    PopulateAvailableCourseListBox();
                }
            }
            else
            {
                secondClick = true;
            }
        }
        private void availableCoursesLstBx_SelectedIndexChanged(object sender, EventArgs e)
        {
            char[] charSeparators = new char[] { ' ' };
            string selectedCourse = availableStudentsCoursesLstBx.SelectedItem.ToString();
            string[] selectedCourseAttributes = selectedCourse.Split(charSeparators, StringSplitOptions.RemoveEmptyEntries);
            string subject = selectedCourseAttributes[0];
            int courseNum = Convert.ToInt32(selectedCourseAttributes[1]);
            string description = selectedCourseAttributes[3];
            int units = Convert.ToInt32(selectedCourseAttributes[2]);
            //how do I attach to new student and create a new studentCourse History for next student entered
            PrerequisiteCourse studentCourseHistory = new PrerequisiteCourse(subject, courseNum, description, units, preCourseHistory);
            courseHistory.Add(studentCourseHistory);
            studentEditDeleteLstBx.Items.Clear();
            foreach (PrerequisiteCourse course in courseHistory)
            {
                studentEditDeleteLstBx.Items.Add(course);
            }
        }
        private void studentIsGradCkBx_CheckedChanged(object sender, EventArgs e)
        {
            GradStudentCheck();
            addStudentBtn.Enabled = false;
            if (studentIsGradCkBx.Checked == false)
            {
               studentGMATTxBx.Clear();
            }
        }
        private void studentIDTxBx_TextChanged(object sender, EventArgs e)
        {
            secondClick = FormComplete();
            if (studentIDTxBx.Text.Length == 10 && secondClick == true)
            {
                try
                {
                    foreach (var student in newStudents)
                    {
                        if (Convert.ToInt64(studentIDTxBx.Text) == student.StudentID && Convert.ToInt64(editStudentLstBx.Items.IndexOf(editStudentLstBx.SelectedIndex)) != Convert.ToInt64(newStudents.IndexOf(student)))
                        {
                            MessageBox.Show("This ID Number is already in use.\n Please re-enter a different 10 digit ID Number.");
                            studentIDTxBx.Clear();
                            break;
                        }
                    }
                }
                catch (FormatException alpha)
                {
                    MessageBox.Show(alpha.Message + " ID Must Be A 10 Digit Number.");
                    studentIDTxBx.Clear();
                }
                 finally
                {
                    secondClick = true;
                }           
            }
            if (studentIDTxBx.Text.Length == 11)
            {
                MessageBox.Show("Error: ID Must Be a 10 Digit Number.");
                studentIDTxBx.Clear();
            }
        }
        private void studentFirstNameTxBx_TextChanged(object sender, EventArgs e)
        {
            secondClick = FormComplete();         
        }
        private void studentLastNameTxBx_TextChanged(object sender, EventArgs e)
        {
            secondClick = FormComplete();
        }
        private void studentGPATxBx_TextChanged(object sender, EventArgs e)
        {
            secondClick = FormComplete();
        }
        private void studentGMATTxBx_TextChanged(object sender, EventArgs e)
        {
            secondClick = FormComplete();
        }
//----------------------------End of Add Student----------------------------------------------------
     
//----------------------------Beginning of Edit Student---------------------------------------------
        private void editStudentBtn_Click(object sender, EventArgs e)
        {
            EditScreen();
            studentEditDeleteLstBx.Items.Clear();
            if (secondClick == true)
            {
                try
                {
                    ValidateGPA();
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message.ToString() + " Please Enter A GPA Value Between '0' and '4'");
                }
                finally
                {
                    // Giving CPU work-break.
                    System.Threading.Thread.Sleep(50);
                }

                try
                {
                    ValidateGMAT();
                }
                catch (Exception error2)
                {
                    MessageBox.Show(error2.Message.ToString() + " Please Enter A GMAT Value Between '200' and '800'");
                }
                finally
                {
                    // Giving CPU work-break.
                    System.Threading.Thread.Sleep(50);
                }
            }
            if (studentIDTxBx.Text.Length < 10 && secondClick == true)
            {
                MessageBox.Show("ID Must Be A 10 Digit Number");
                studentIDTxBx.Clear();
                secondClick = false;
            }
            editStudentBtn.Enabled = false;
           
            if (!studentIsGradCkBx.Checked && secondClick == true)
            {
                for (int i = 0; i < newStudents.Count; i++)
                {
                    if (editStudentLstBx.SelectedItem.ToString() == newStudents[i].ToString())
                    {
                        newStudents.Remove(newStudents[i]);
                    }
                }
                try
                {
                    studentId = Convert.ToInt64(studentIDTxBx.Text);
                    studentFirstName = studentFirstNameTxBx.Text;
                    studentLastName = studentLastNameTxBx.Text;
                    studentGPA = Convert.ToDouble(studentGPATxBx.Text);
                    isGradStudent = Convert.ToString(studentIsGradCkBx.Checked);
                    Student student = new Student(studentId, studentFirstName, studentLastName, studentGPA, courseHistory,studentSchedule, isGradStudent);
                    newStudents.Add(student);
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message + "Error: What The Heck Did You Just Do?! Please Re-Enter Data, I'll give it another try.");
                }
                finally
                {
                    editStudentLstBx.Items.Clear();
                    secondClick = false;
                    this.Clear();
                }
            }
            else if (studentIsGradCkBx.Checked && secondClick == true)
            {
                for (int i = 0; i < newStudents.Count; i++)
                {
                    if (editStudentLstBx.SelectedItem.ToString() == newStudents[i].ToString())
                    {
                        newStudents.Remove(newStudents[i]);
                    }
                }
                try
                {
                    studentId = Convert.ToInt64(studentIDTxBx.Text);
                    studentFirstName = studentFirstNameTxBx.Text;
                    studentLastName = studentLastNameTxBx.Text;
                    studentGPA = Convert.ToDouble(studentGPATxBx.Text);
                    isGradStudent = Convert.ToString(studentIsGradCkBx.Checked);
                    studentGMAT = Convert.ToInt32(studentGMATTxBx.Text);
                    GraduateStudent graduateStudent = new GraduateStudent(studentId, studentFirstName, studentLastName, studentGPA, courseHistory,studentSchedule, isGradStudent, studentGMAT);
                    newStudents.Add(graduateStudent);
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message + "Error: What The Heck Did You Just Do?! Please Re-Enter Data, I'll give it another try.");
                }
                finally
                {
                    editStudentLstBx.Items.Clear();
                    secondClick = false;
                    this.Clear();
                }
            }
            else
            {
                secondClick = true;
            }
            PopulateEditStudentListBox();
        }
        private void editStudentLstBx_SelectedIndexChanged(object sender, EventArgs e)
        {
            editStudentBtn.Enabled = false;
            studentIDTxBx.ReadOnly = false;
            studentFirstNameTxBx.ReadOnly = false;
            studentLastNameTxBx.ReadOnly = false;
            studentGPATxBx.ReadOnly = false;
            studentIsGradCkBx.Enabled = true;
            studentGMATTxBx.ReadOnly = false;
            studentIDTxBx.Focus();
            char[] charSeparators = new char[] { ' ' };
            string selectedStudent = editStudentLstBx.SelectedItem.ToString();
            string[] selectedStudentAttributes = selectedStudent.Split(charSeparators, StringSplitOptions.RemoveEmptyEntries);
            Int64 studentID = Convert.ToInt64(selectedStudentAttributes[0]);
            string studentFirstName = selectedStudentAttributes[1];
            string studentLastName = selectedStudentAttributes[2];
            double studentGPA = Convert.ToDouble(selectedStudentAttributes[3]);
            string isStudentGrad = selectedStudentAttributes[4];
            int studentGMAT = 0;
            if (selectedStudentAttributes.Length == 6)
            {
                studentGMAT = Convert.ToInt32(selectedStudentAttributes[5]);
            }
            studentGMATTxBx.Text = studentGMAT.ToString();
            studentIDTxBx.Text = studentID.ToString();
            studentFirstNameTxBx.Text = studentFirstName;
            studentLastNameTxBx.Text = studentLastName;
            studentGPATxBx.Text = studentGPA.ToString("0.00");
            if (isStudentGrad == "true")
            {
                studentIsGradCkBx.Checked = true;
            }
            else
            {
                studentIsGradCkBx.Checked = false;
            }
        }
//----------------------------End of Edit Student---------------------------------------------

//----------------------------Beginning of Display Students-----------------------------------
        private void displayBtn_Click(object sender, EventArgs e)
        {
            DisplayScreen();
            foreach (Student student in newStudents)
            {
                displayAllStudentsLstBx.Items.Add(student.ToString());
            }
        }
//----------------------------End of Display Students-----------------------------------

//----------------------------Beginning of Navigation Events----------------------------------

        private void mainMenuBtn_Click(object sender, EventArgs e)
        {
            //To declare Main Menu Form as Parent Form 
            Form myParentForm = RegistrationStartApp.GetParentForm();
            //To show Main Menu (Parent) Form.
            myParentForm.Show();
            // To close StudentInfoForm
            this.Close();
        }
        private void resetBtn_Click(object sender, EventArgs e)
        {
            MainScreen();
        }
//----------------------------Beginning of Navigation Events----------------------------------

//----------------------------Beginning of Delete Students-----------------------------------
        private void deleteStudentBtn_Click(object sender, EventArgs e)
        {
            DeleteScreen();
            deleteStudentBtn.Enabled = false;
            if (displayAllStudentsLstBx.SelectedItem != null)
            {
                
                for (int i = 0; i < newStudents.Count; i++)
                {
                    if (displayAllStudentsLstBx.SelectedItem.ToString() == newStudents[i].ToString())
                    {
                        newStudents.Remove(newStudents[i]);
                    }
                }
                displayAllStudentsLstBx.Items.Clear();
                foreach (Student student in newStudents)
                {
                    displayAllStudentsLstBx.Items.Add(student.ToString());
                }
            }
            secondClick = true;
        }
        private void displayAllStudentsLstBx_SelectedIndexChanged(object sender, EventArgs e)
        {
            deleteStudentBtn.Enabled = true;
        }
        //----------------------------End of Delete Students-----------------------------------

        //----------------------------Beginning of Sub Routines--------------------------------
        public void MainScreen()
        {
            this.BackColor = Color.LemonChiffon;
            studentGMATReqLbl.Visible = false;
            studentGPAReqLbl.Visible = false;
            studentIDReqLbl.Visible = false;
            gradStuLbl.Visible = false;
            gScoreLbl.Visible = false;
            editStudentLstBx.Visible = false;
            gradStatLbl.Visible = false;
            studentIsGradCkBx.Visible = false;
            studentIDLbl.Visible = false;
            studentIDTxBx.Visible = false;
            firstNameLbl.Visible = false;
            lastNameLbl.Visible = false;
            studentLastNameTxBx.Visible = false;
            studentFirstNameTxBx.Visible = false;
            gpaLbl.Visible = false;
            studentGPATxBx.Visible = false;
            displayAllStudentsLbl.Visible = false;
            displayAllStudentsLstBx.Visible = false;
            studentGMATTxBx.Visible = false;
            studentGMATLbl.Visible = false;
            gradHeaderLbl.Visible = false;
            resetBtn.Visible = false;
            didYouMeanLbl.Visible = false;
            studentIsGradCkBx.Focus();
            finishedCourseHeaderLbl.Visible = false;
            studentEditDeleteLstBx.Visible = false;
            finishedSubjectLbl.Visible = false;
            finishedUnitsLbl.Visible = false;
            resetBtn.Visible = false;
            availableStudentsCoursesLstBx.Visible = false;
            finishedCourseLbl.Visible = false;
            finishedTitleLbl.Visible = false;
            selectDeleteLbl.Visible = false;
            selectedDeleteLbl.Visible = false;
            addStudentBtn.Visible = true;
            editStudentBtn.Visible = true;
            deleteStudentBtn.Visible = true;
            displayBtn.Visible = true;
            studentIsGradCkBx.Checked = false;
            addStudentBtn.Enabled = true;
            secondClick = false;
            availableStudentsCoursesLstBx.Items.Clear();
            studentEditDeleteLstBx.Items.Clear();
            displayAllStudentsLstBx.Items.Clear();
            editStudentLstBx.Items.Clear();
            courseHistory.Clear();
            editStudentBtn.Enabled = true;
            Clear();
        }
        public void AddStudentScreen()
        {
           
            finishedUnitsLbl.Text = "Units";
            finishedTitleLbl.Text = "Title";
            studentGMATReqLbl.Visible = false;
            studentGPAReqLbl.Visible = true;
            studentIDReqLbl.Visible = true;
            gradStuLbl.Visible = false;
            gScoreLbl.Visible = false;
            editStudentLstBx.Visible = false;
            gradStatLbl.Visible = true;
            studentIsGradCkBx.Visible = true;
            studentIDLbl.Visible = true;
            studentIDTxBx.Visible = true;
            firstNameLbl.Visible = true;
            lastNameLbl.Visible = true;
            studentLastNameTxBx.Visible = true;
            studentFirstNameTxBx.Visible = true;
            gpaLbl.Visible = true;
            studentGPATxBx.Visible = true;
            studentEditDeleteLstBx.Visible = false;
            finishedCourseLbl.Visible = true;
            finishedCourseLbl.Text = "Course #";
            availableStudentsCoursesLstBx.Visible = true;
            finishedCourseHeaderLbl.Visible = true;
            finishedCourseHeaderLbl.Text = "SELECT COMPLETED COURSES";
            finishedTitleLbl.Visible = true;
            finishedSubjectLbl.Visible = true;
            finishedSubjectLbl.Text = "Subject";
            finishedUnitsLbl.Visible = true;
            studentEditDeleteLstBx.Visible = true;
            this.BackColor = Color.LightGreen;
            editStudentBtn.Visible = false;
            displayBtn.Visible = false;
            deleteStudentBtn.Visible = false;
            didYouMeanLbl.Text = "Student Course History";
            didYouMeanLbl.Visible = true;
            resetBtn.Visible = true;
        }
        public void DeleteScreen()
        {
            this.BackColor = Color.LightSalmon;
            finishedCourseLbl.Visible = true;
            finishedCourseLbl.Text = "First";
            finishedTitleLbl.Visible = true;
            finishedTitleLbl.Text = "G.P.A.";
            finishedUnitsLbl.Visible = true;
            finishedUnitsLbl.Text = "Last";
            finishedSubjectLbl.Visible = true;
            finishedSubjectLbl.Text = "Student ID#";
            gradStuLbl.Visible = true;
            gScoreLbl.Visible = true;
            availableStudentsCoursesLstBx.Visible = false;
            finishedCourseHeaderLbl.Visible = false;
            displayBtn.Visible = false;
            addStudentBtn.Visible = false;
            studentEditDeleteLstBx.Visible = false;
            displayAllStudentsLbl.Visible = true;
            displayAllStudentsLstBx.Visible = true;
            editStudentBtn.Visible = false;
            deleteStudentBtn.Visible = true;
            resetBtn.Visible = true;
            selectDeleteLbl.Visible = true;
            selectedDeleteLbl.Visible = false;
            foreach (Student student in newStudents)
            {
                displayAllStudentsLstBx.Items.Add(student.ToString());
            }
        }
        public void DisplayScreen()
        {
            this.BackColor = Color.LightCyan;
            gradStatLbl.Visible = false;
            studentIsGradCkBx.Visible = false;
            studentIDLbl.Visible = false;
            studentIDTxBx.Visible = false;
            firstNameLbl.Visible = false;
            lastNameLbl.Visible = false;
            studentLastNameTxBx.Visible = false;
            studentFirstNameTxBx.Visible = false;
            gpaLbl.Visible = false;
            studentGPATxBx.Visible = false;
            studentEditDeleteLstBx.Visible = false;
            displayAllStudentsLbl.Visible = true;
            displayAllStudentsLstBx.Visible = true;
            editStudentBtn.Visible = false;
            deleteStudentBtn.Visible = false;
            finishedCourseLbl.Visible = false;
            availableStudentsCoursesLstBx.Visible = false;
            finishedTitleLbl.Visible = false;
            displayBtn.Visible = false;
            resetBtn.Visible = true;
            addStudentBtn.Visible = false;
        }
        public void EditScreen()
        {
            this.BackColor = Color.Yellow;
            gradStuLbl.Visible = true;
            gScoreLbl.Visible = true;
            availableStudentsCoursesLstBx.Visible = false;
            editStudentLstBx.Visible = true;
            gradStatLbl.Visible = true;
            studentIsGradCkBx.Visible = true;
            studentIDLbl.Visible = true;
            studentIDTxBx.Visible = true;
            studentIDReqLbl.Visible = true;
            firstNameLbl.Visible = true;
            lastNameLbl.Visible = true;
            studentLastNameTxBx.Visible = true;
            studentFirstNameTxBx.Visible = true;
            gpaLbl.Visible = true;
            studentGPAReqLbl.Visible = true;
            studentGPATxBx.Visible = true;
            studentGMATTxBx.Visible = false;
            studentGMATLbl.Visible = false;
            gradHeaderLbl.Visible = false;
            studentEditDeleteLstBx.Visible = false;
            finishedCourseLbl.Visible = true;
            finishedCourseLbl.Text = "First";
            finishedCourseHeaderLbl.Visible = true;
            finishedCourseHeaderLbl.Text = "SELECT STUDENT TO EDIT";
            finishedTitleLbl.Visible = true;
            finishedTitleLbl.Text = "G.P.A.";
            finishedUnitsLbl.Visible = true;
            finishedUnitsLbl.Text = "Last";
            finishedSubjectLbl.Visible = true;
            finishedSubjectLbl.Text = "Student ID#";
            editStudentBtn.Visible = true;
            editStudentBtn.Enabled = false;
            displayBtn.Visible = false;
            addStudentBtn.Visible = false;
            deleteStudentBtn.Visible = false;
            didYouMeanLbl.Visible = false;
            didYouMeanLbl.Visible = true;
            resetBtn.Visible = true;
            if (secondClick == false)
            {
                studentIDTxBx.ReadOnly = true;
                studentFirstNameTxBx.ReadOnly = true;
                studentLastNameTxBx.ReadOnly = true;
                studentGPATxBx.ReadOnly = true;
                studentIsGradCkBx.Enabled = false;
                studentGMATTxBx.ReadOnly = true;
            }
        }
        public void Clear()
        {
            studentFirstNameTxBx.Clear();
            studentGMATTxBx.Clear();
            studentGPATxBx.Clear();
            studentIDTxBx.Clear();
            studentIsGradCkBx.Checked = false;
            studentEditDeleteLstBx.Items.Clear();
            studentLastNameTxBx.Clear();
        }
        public void GradStudentCheck()
        {
            if (studentIsGradCkBx.Checked)
            {
                finishedCourseHeaderLbl.Visible = true;
                gradHeaderLbl.Visible = true;
                studentGMATTxBx.Visible = true;
                studentGMATLbl.Visible = true;
                studentGMATReqLbl.Visible = true;
            }
            else
            {
                gradHeaderLbl.Visible = false;
                studentGMATTxBx.Visible = false;
                studentGMATLbl.Visible = false;
                studentGMATReqLbl.Visible = false;
            }
        }
        public bool FormComplete()
        {
                if (!studentIsGradCkBx.Checked && studentIDTxBx.Text != "" && studentFirstNameTxBx.Text != "" && studentLastNameTxBx.Text != "" && studentGPATxBx.Text != "")
                {
                    editStudentBtn.Enabled = true;
                    addStudentBtn.Enabled = true;
                    return true;
                }
                else if (studentIsGradCkBx.Checked && studentIDTxBx.Text != "" && studentFirstNameTxBx.Text != "" && studentLastNameTxBx.Text != "" && studentGPATxBx.Text != "" && studentGMATTxBx.Text != "")
                {
                    editStudentBtn.Enabled = true;
                    addStudentBtn.Enabled = true;
                    return true;
                }
                else
                    return false;
        }
        public void ValidateGPA()
        {
            if ((Convert.ToDouble(studentGPATxBx.Text)) > 4 || (Convert.ToDouble(studentGPATxBx.Text)) < 0 && secondClick == true)
            {
                MessageBox.Show("Error: GPA Value Must Be A Number Between '0' and '4'");
                studentGPATxBx.Clear();
                secondClick = false;
                addStudentBtn.Enabled = true;
            }
        }
        public void ValidateGMAT()
        {
            if ( studentIsGradCkBx.Checked && secondClick == true  )
            {
                int GMAT = Convert.ToInt32(studentGMATTxBx.Text);
                if (GMAT > 800 || GMAT < 200 )
                {
                    MessageBox.Show("Error: GMAT Value Must Be A Number Between '200' and '800'");
                    studentGMATTxBx.Clear();
                    secondClick = false;
                    addStudentBtn.Enabled = true;
                }
            }
        }
        public void PopulateAvailableCourseListBox()
        {
            foreach (PrerequisiteCourse prerequisitecourse in prerequisiteCourses)
            {
                availableStudentsCoursesLstBx.Items.Add(prerequisitecourse.ToString());
            }
        }
        private void studentIsGradCkBx_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (studentIsGradCkBx.Checked == false)
            {
                studentIsGradCkBx.Checked = true;
            }
            else
            {
                studentIsGradCkBx.Checked = false;
            }
        }
        private void PopulateEditStudentListBox()
        {
            foreach (Student student in newStudents)
            {
                editStudentLstBx.Items.Add(student.ToString());
            }
        }

       
        //----------------------------End of Sub Routines--------------------------------
    }
}


