using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentInfoApplication
{
    public partial class frmStudentInfo : Form
    {
        Dictionary<int, StudentInfo> StudentList = new Dictionary<int, StudentInfo>();

        public frmStudentInfo()
        {
            InitializeComponent();

        }

        private void Submit_Button_Click(object sender, EventArgs e)
        {
            //temp variables
            int _id = 0;
            string _firstName = "";
            string _lastName = "";

            //null value error handling
            if (string.IsNullOrWhiteSpace(ID_Input.Text)) { MessageBox.Show("ID is empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
            if (string.IsNullOrWhiteSpace(First_Name_Input.Text)) { MessageBox.Show("First Name is empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
            if (string.IsNullOrWhiteSpace(Last_Name_Input.Text)) { MessageBox.Show("Last Name is empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }

            //get input from textbox
            try
            {
                _id = Int32.Parse(ID_Input.Text);
                _firstName = First_Name_Input.Text;
                _lastName = Last_Name_Input.Text;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning); return;
            }

            //initialize student class with variables and add to dictionary
            StudentInfo student = new StudentInfo(_id, _firstName, _lastName);
            StudentList.Add(_id, student);

            //append to three list in interface
            StudentIDList.Items.Add(_id);
            StudentFirstNameList.Items.Add(StudentList[_id].StudentFirstName);
            StudentLastNameList.Items.Add(StudentList[_id].StudentLastName);

            //clear the textboxes
            ID_Input.Clear();
            First_Name_Input.Clear();
            Last_Name_Input.Clear();

        }

    }

    public class StudentInfo
    {

        //class variables
        private int StudentIDVar;
        private string StudentFirstNameVar;
        private string StudentLastNameVar;

        //default studentinfo constructor
        public StudentInfo()
        {
            this.StudentIDVar = 012341540;
            this.StudentFirstNameVar = "John";
            this.StudentLastNameVar = "Lenon";
        }

        //parametized studentinfo constructor
        public StudentInfo(int id, string firstname, string lastname)
        {
            this.StudentIDVar = id;
            this.StudentFirstNameVar = firstname;
            this.StudentLastNameVar = lastname;
        }

        //get and set studentid
        public int StudentID
        {
            get { return StudentIDVar; }
            set { this.StudentIDVar = value; }
        }

        //get and set studentfirstname
        public string StudentFirstName
        {
            get { return this.StudentFirstNameVar; }
            set { this.StudentFirstNameVar = value; }
        }

        //get and set studentlastname
        public string StudentLastName
        {
            get { return this.StudentLastNameVar; }
            set { this.StudentLastNameVar = value; }
        }
    }
}
