//John Pietrangelo CIS345 Tues/Thurs 9am
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProjectJohnPietrangelo
{
    static class RegistrationStartApp
    {// To create a class variable to hold "parent Form's memory address.
        private static Form myParentForm = null;
       // private static Form myChildForm = null; 
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainMenuForm());
        }
        // To set "Parent" form address
        public static void SetParentForm(Form parentForm)
        {
            myParentForm = parentForm;
        }
        // To get "Parent" form address
        public static Form GetParentForm()
        {
            return myParentForm;
        }
        //// To set "Child" form address
        //public static void SetChildForm(Form childForm)
        //{
        //    myChildForm = childForm;
        //}
        //// To get "Child" form address
        //public static Form GetChildForm()
        //{
        //    return myChildForm;
        //}
    }
}
